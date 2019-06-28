using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektTests.forms
{
    class IMain
    {
 
        /// <summary>
        /// metoda dodawania liczb
        /// </summary>
        /// <returns></returns>
        public double Add_Number(double nr1, double nr2)
        {
            return (nr1 + nr2);
        }

        /// <summary>
        /// metoda odejmowania liczb
        /// </summary>
        /// <returns></returns>
        public double Sub_Number(double nr1, double nr2)
        {
            return (nr1 - nr2);
        }
        /// <summary>
        /// metoda mnożenia liczb
        /// </summary>
        /// <returns></returns>



        public double Mult_Number(double nr1, double nr2)
        {
            return (nr1 * nr2);
        }
    }
}
