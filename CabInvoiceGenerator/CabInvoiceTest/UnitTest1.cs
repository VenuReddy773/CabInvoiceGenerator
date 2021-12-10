using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceTest
{
    public class Tests
    {
        [Test]
        public void GivenDistanceAndTime_WhenAnalyzeFare_ShouldTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            double distance = 5.0;
            double time = 10;
            double fare = invoice.CalculateTotalFare(distance, time);
            Assert.AreEqual(fare,60);
        }
    }
}