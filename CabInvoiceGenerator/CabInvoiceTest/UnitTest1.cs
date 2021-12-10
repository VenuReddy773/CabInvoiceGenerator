using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceTest
{
    public class Tests
    {
        [Test]

        public void GivenDistanceAndTimeForNormalRide_WhenAnalyzeFare_ShouldReturnTrue()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            double distance = 5.0;
            double time = 10;
            double fare = invoice.CalculateFare(distance, time);
            Assert.AreEqual(fare,60);
        }
    }
}