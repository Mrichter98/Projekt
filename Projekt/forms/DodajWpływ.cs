using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class DodajWpływ : Form
    {
        public DodajWpływ()
        {
            InitializeComponent();
        }

        //dodanie akcji dla przycisku
        private void Button1_Click(object sender, EventArgs e)
        {
            //stworzenie obiektu klasy WydatkiModel
            WydatkiModel wm2 = new WydatkiModel();

            //przypisanie danych wprowadzonych z klawiatury przez formularz DodajWpływ do obiektu wm2
            wm2.MarketPlace = IncomeFrome.Text;
            wm2.Price = Income.Text;
            wm2.Description = Description2.Text;
            wm2.Category = "--";
            wm2.BuyDate = IncomeData.Text;
            wm2.GwarancyOffDate = "--";

            //wprowadzenie obiektu wm2 do bazy danych
            SqlDataAcces.SaveWydatki(wm2);

            //okienko informacyjne 
            MessageBox.Show("Dane został wprowadzone do bazy!");
        }
    }
}
