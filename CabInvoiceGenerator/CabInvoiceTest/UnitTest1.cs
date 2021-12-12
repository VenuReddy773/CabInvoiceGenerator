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
        [Test]
        public void GivenDistanceAndTime_WhenAnalyzeFare_ShouldMultipleTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            Ride[] rides = { new Ride(5, 2), new Ride(7, 1) };
            double expected = invoice.CalculateMultipleFare(rides);
            double result = invoice.CalculateMultipleFare(rides);
            Assert.AreEqual(expected ,result );
        }
        [Test]
        public void GivenSummary_whenCalculate_ShouldReturnAverageFair()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            Ride[] rides = { new Ride(5, 2), new Ride(7,2) };
            InvoiceSummary result = invoice.CabInvoice(rides);
            InvoiceSummary summary = new InvoiceSummary();
            summary.totalFare = 124;
            summary.totalNumberOfRides = 2;
            summary.CalculateAverageFare();
            if (result.totalFare == summary.totalFare && result.totalNumberOfRides == summary.totalNumberOfRides && summary.averageFarePerRide == result.averageFarePerRide)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}