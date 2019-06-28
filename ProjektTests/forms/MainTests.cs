using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projekt.Main
{
    [TestClass()]
    public class MainTests 
    {

        [TestMethod()]
        public void Add_NumberTest()
        {
            double number1 = 10;
            double number2 = 15;
            var calculator = new MainTests();
            double result = calculator.Add_Number();
            Assert.Fail();

        }


        [TestMethod()]
        public void Sub_NumberTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Div_NumberTest()
        {
            Assert.Fail();
        }
    }
}