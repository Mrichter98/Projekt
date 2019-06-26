using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Projekt
{
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
            
        }

        //metoda odpowiedzialna za wczytanie bazy danych do DataGrida
        private void Historia_Load(object sender, EventArgs e)
        {
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=C:\\Users\\Marek\\Desktop\\Win Forms Project\\Projekt\\Projekt\\bin\\Debug\\WydatkiDB.db; Version =3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select * from Bilans";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                //tworzenie nowej tablicy z danymi
                DataTable dt = new DataTable();
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid1.DataSource = dt;
            }
        }
    }
}
