using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// klasa stworzona w celu połączenia bazy danych z projektem w środowisku Visual Studio
/// </summary>

namespace Projekt
{
    /// <summary>
    /// Klasa odpowiedzialna za połączenie i funkcjonowanie bazy danych z programem
    /// </summary>
    public class SqlDataAcces
    {
        /// <summary>
        /// metoda wypisania danych z bazy
        /// </summary>
        public static List<WydatkiModel> LoadWydatki()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<WydatkiModel>("select * from Bilans", new DynamicParameters());
                return output.ToList();
            }
        }
        /// <summary>
        /// metoda  zapisania danych do bazy
        /// </summary>
        public static void SaveWydatki(WydatkiModel wydatki)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Bilans (Price, Category, MarketPlace, BuyDate, GwarancyOffDate, Description) " +
                    "values (@Price, @Category, @MarketPlace, @BuyDate, @GwarancyOffDate, @Description)", wydatki);


            }
        }

        public static string LoadConnectionString(string id ="Default" )
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
