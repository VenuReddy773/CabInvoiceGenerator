using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        public int totalNumberOfRides { get; set; }
        public double totalFare { get; set; }
        public double averageFarePerRide { get; set; }
        public void CalulateAverageFare()
        {
            averageFarePerRide = totalFare / totalNumberOfRides;
        }
    }
}
