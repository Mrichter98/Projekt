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
    /// Klasa odpowiedzialna za znalezienie oraz edycje wybranego elementu 
    /// </summary>
    public partial class EdytujElement : Form
    {
        public EdytujElement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda odpoweidzialan za wymisanie z bazy danych elementu o wcześniej podanym ID przypisana do akcji przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRfrsh2_Click(object sender, EventArgs e)
        {
            //stworzenie obiektu myconnection odpowiedzialnego za połączenie z bazą danych
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=C:\\Users\\Marek\\Desktop\\Win Forms Project\\Projekt\\Projekt\\bin\\Debug\\WydatkiDB.db; Version =3;");
            //otwarcie połączenia z bazą
            myconnection.Open();
            //stworzenie obiektu cmd związanego z komendami wykonywanymi na bazie SQL
            SQLiteCommand cmd = new SQLiteCommand();
            //połączenie obiektu komend do bazy 
            cmd.Connection = myconnection;
            //komendy
            cmd.CommandText = "Select * from Bilans where ID='" + IndexBox2.Text + "'";
            //wykonanie komendy 
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                //tworzenie nowej tablicy z danymi
                DataTable dt = new DataTable();
                //wczytanie danych z warunku do nowej tablicy dt
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                //wypisanie danych w elemencie DataGridView
                grid3.DataSource = dt;


            }
        }
        /// <summary>
        /// Metoda odpoweidzilana za edycję danego elementu przypisana do akcji przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            //stworzenie obiektu wm3 klasy WydatkiModel
            WydatkiModel wm3 = new WydatkiModel();

            //przypisanie danych dla nowego obiektu
            wm3.Price = PriceEdit.Text;
            wm3.MarketPlace = MarketPlaceEdit.Text;
            wm3.BuyDate = BuyDateEdit.Text;
            wm3.GwarancyOffDate = GwarancyOffDateEdit.Text;
            wm3.Category = CategoryEdit.Text;
            wm3.Description = DescriptionEdit.Text;
            //zapisanie danych wm3 w bazie
            SqlDataAcces.SaveWydatki(wm3);



            SQLiteConnection myconnection = new SQLiteConnection("Data Source=C:\\Users\\Marek\\Desktop\\Win Forms Project\\Projekt\\Projekt\\bin\\Debug\\WydatkiDB.db; Version =3;");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            //komenda usunięcia wiersza z bazy danych Bilans o ID podanym w textboxie IndexBox2
            cmd.CommandText = "delete from Bilans where ID='" + IndexBox2.Text + "'";
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                //tworzenie nowej tablicy z danymi
                DataTable dt = new DataTable();
                //datareader w datatable
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                grid3.DataSource = dt;

            }


            //metoda edycji elementu nie jest do końca edycją lecz usunięciem starego elementu i stworzenime nowego


                //tekst informacyjny
                MessageBox.Show("Element został zapisany. Posiada nowe ID");
        }


        /// <summary>
        /// Metoda odpowiedzialna za wpisanie danych do textboxów po przyciśnięciu na wiersz w DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow rowupdate in grid3.SelectedRows)
            {
                PriceEdit.Text = rowupdate.Cells[1].Value.ToString();
                CategoryEdit.Text = rowupdate.Cells[2].Value.ToString();
                MarketPlaceEdit.Text = rowupdate.Cells[3].Value.ToString();
                DescriptionEdit.Text = rowupdate.Cells[6].Value.ToString();
            }
        }
    }
}
