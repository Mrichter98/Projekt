using NUnit.Framework;

namespace Projekt

{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void sum_z_dodatnimi()
        {
            Calculator testcalc = new Calculator();


            var result = testcalc.Sum(2, 2);
            var expected = 4;


            Assert.AreEqual(expected, result);
        }
        [Test]
        public void sum_z_ujemnymi()
        {
            Calculator testcalc = new Calculator();


            var result = testcalc.Sum(-2, -2);
            var expected = -4;


            Assert.AreEqual(expected, result);
        }
        [Test]
        public void sum_z_zerami()
        {
            Calculator testcalc = new Calculator();


            var result = testcalc.Sum(0, 0);
            var expected = 0;


            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Ró¿nica_z_ujemnymi()
        {
            Calculator testcalc = new Calculator();


            var result = testcalc.Roz(-2, -2);
            var expected = 0;


            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Ró¿nica_z_dodatnimi()
        {
            Calculator testcalc = new Calculator();


            var result = testcalc.Roz(2, 2);
            var expected = 0;


            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Ró¿nica_z_pierwsz¹_wieksza_od_drugiej()
        {
            Calculator testcalc = new Calculator();


            var result = testcalc.Roz(6, 2);
            var expected = 4;


            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Ró¿nica_z_zermai()
        {
            Calculator testcalc = new Calculator();


            var result = testcalc.Roz(0, 0);
            var expected = 0;


            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Mnoz_z_ujemnymi()
        {
            Calculator testcalc = new Calculator();


            var result = testcalc.Mnoz(-2, -2);
            var expected = 4;


            Assert.AreEqual(expected, result);
        }
        [Test]
        public void mnoz_z_dodatnimi()
        {
            Calculator testcalc = new Calculator();


            var result = testcalc.Mnoz(2, 4);
            var expected = 8;


            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Ró¿nica_z_zerami()
        {
            Calculator testcalc = new Calculator();


            var result = testcalc.Mnoz(0, 0);
            var expected = 0;


            Assert.AreEqual(expected, result);
        }
    }
}