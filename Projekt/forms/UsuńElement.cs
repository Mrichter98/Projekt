using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projekt
{
    /// <summary>
    /// Klasa odpowiedzialna za szukanie oraz usuwanie elementów z bazy danych 
    /// </summary>
    public partial class UsuńElement : Form
    {
        public UsuńElement()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda wypisania elementu o danym ID z bazy, metoda jest przypisana do akcji przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRfrsh_Click(object sender, EventArgs e)
        {
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=C:\\Users\\Marek\\Desktop\\Win Forms Project\\Projekt\\Projekt\\bin\\Debug\\WydatkiDB.db; Version =3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select * from Bilans where ID='"+IndexBox.Text+"'";
            //cmd.CommandText = "Select* from Bilans where Price > '" + 0 + "'";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                //tworzenie nowej tablicy z danymi
                DataTable dt = new DataTable();
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid2.DataSource = dt;


            }
        }
        /// <summary>
        /// Metoda usunięcia elementu o danym ID i bazy, metoda jest przypisana do akcji przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DltButton_Click(object sender, EventArgs e)
        {
            //połączenie z bazą 
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=C:\\Users\\Marek\\Desktop\\Win Forms Project\\Projekt\\Projekt\\bin\\Debug\\WydatkiDB.db; Version =3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            //komenda usunięcia 
            cmd.CommandText = "delete from Bilans where ID='" + IndexBox.Text + "'";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                //tworzenie nowej tablicy z danymi
                DataTable dt = new DataTable();
                //datareader w datatable
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid2.DataSource = dt;


            }
            //okienko informacyjne 
            MessageBox.Show("Element został usunięty");

        }


    }
}
