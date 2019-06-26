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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //akcja do wyświetlenia okna DodajWydatki
        private void DodajWydatkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajWydatki dwyd = new DodajWydatki();
            dwyd.ShowDialog();
        }

        //akcja do wyświetlenia okna DodajWpływ
        private void DodajWpływToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajWpływ dwp = new DodajWpływ();
            dwp.ShowDialog();
        }

        //akcja do wyświetlenia okienka po przyciśnięciu MenuItema
        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Marek Richter-w58930 IID-P");
        }

        private void HistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historia hist = new Historia();
            hist.ShowDialog();
        }

        private void UsuńElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuńElement ue = new UsuńElement();
            ue.ShowDialog();
        }

        private void EdytujElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdytujElement ee = new EdytujElement();
            ee.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=C:\\Users\\Marek\\Desktop\\Win Forms Project\\Projekt\\Projekt\\bin\\Debug\\WydatkiDB.db; Version =3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select sum(Price) from Bilans  where Price> '" + 0 + "'";
            //sum(Price)
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {

                //tworzenie nowej tablicy z danymi
                DataTable dt = new DataTable();
                //datareader w datatable
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid4.DataSource = dt;


            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=C:\\Users\\Marek\\Desktop\\Win Forms Project\\Projekt\\Projekt\\bin\\Debug\\WydatkiDB.db; Version =3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select sum(Price) from Bilans  where Price< '" + 0 + "'";
            //sum(Price)
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {

                //tworzenie nowej tablicy z danymi
                DataTable dt = new DataTable();
                //datareader w datatable
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid4.DataSource = dt;


            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=C:\\Users\\Marek\\Desktop\\Win Forms Project\\Projekt\\Projekt\\bin\\Debug\\WydatkiDB.db; Version =3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select sum(Price) from Bilans";
            //sum(Price)
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {

                //tworzenie nowej tablicy z danymi
                DataTable dt = new DataTable();
                //datareader w datatable
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid4.DataSource = dt;


            }


        }
    }
}
