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
using System.Configuration;


namespace Projekt
{
    public partial class DodajWydatki : Form
    {

      
        public DodajWydatki()
        {
            InitializeComponent();

            
        }
        //stworzenie listy wydatki 
        List<WydatkiModel> wydatki = new List<WydatkiModel>();

        public void LoadWydatkiList()
        {
            wydatki = SqlDataAcces.LoadWydatki();

        }

        //metoda stworzona w celu uzyskania/ograniczenia dostępu poprzez checkbox do dataPickera 
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
                GwarancyDateText.Enabled = true;
            if (checkBox1.Checked == false)
                GwarancyDateText.Enabled = false;

        }

        //metoda akcji przycisku
        private void Button1_Click(object sender, EventArgs e)
        {
            //stworzenie obiektu wm klasy WydatkiModel
            WydatkiModel wm = new WydatkiModel();
            
            //przypisanie danych do obiektu wm
            wm.Price = PriceBox.Text;

            //warunek odpowiedzialny za wprowadzenie odpowiednich danych(kategorii) do bazy w zależności od zaznaczonego radioBoxa
            if (fees.Checked == true) wm.Category = "Opłaty";
            else if (meal.Checked == true) wm.Category = "Jedzenie";
            else if (cloathing.Checked == true) wm.Category = "Ubrania";
            else if (other.Checked == true) wm.Category = "Inne";
            else wm.Category = " ";

            wm.MarketPlace = MarketPlaceText.Text;
            wm.BuyDate = MarketDateText.Text;

            if (checkBox1.Checked == true)
            {
                GwarancyDateText.Enabled = true;
                wm.GwarancyOffDate = GwarancyDateText.Text;
            }
            if (checkBox1.Checked == false)
                GwarancyDateText.Enabled = false;

            wm.Description = DescriptionText.Text;

            //zapisanie danych do bazy
            SqlDataAcces.SaveWydatki(wm);

            //okienko informacyjne
            MessageBox.Show("Dane został wprowadzone do bazy!");
           
        }
    }
}
