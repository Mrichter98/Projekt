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
    /// <summary>
    /// klasa odpoweidzialana za wprowadzenie do bazy danych, danych dotyczących wydatkó
    /// </summary>
    public partial class DodajWpływ : Form
    {
        
        public DodajWpływ()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda zapisania do bazy danych wpisanych przez użytkownika danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            //stworzenie obiektu klasy WydatkiModel
            WydatkiModel wm2 = new WydatkiModel
            {

                //przypisanie danych wprowadzonych z klawiatury przez formularz DodajWpływ do obiektu wm2
                MarketPlace = IncomeFrome.Text,
                Price = Income.Text,
                Description = Description2.Text,
                Category = "--",
                BuyDate = IncomeData.Text,
                GwarancyOffDate = "--"
            };

            //wprowadzenie obiektu wm2 do bazy danych
            SqlDataAcces.SaveWydatki(wm2);

            //okienko informacyjne 
            MessageBox.Show("Dane został wprowadzone do bazy!");
        }
    }
}
