using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        private double MINIMUM_COST_PER_KM;
        private double COST_PER_TIME;
        private double MINIMUM_FARE;
        public InvoiceGenerator()
        {
            this.MINIMUM_COST_PER_KM = 10;
            this.COST_PER_TIME = 1;
            this.MINIMUM_FARE = 5;     
        }
        public double CalculateTotalFare(double distance, double time)
        {
            if (distance >0 && time >0)
            {
                double totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_TIME;
                return totalFare;
            }
            return MINIMUM_FARE;
        }
        public double CalculateMultipleFare(Ride[] ride)
        {
            double totalFare = 0;
            foreach (var data in ride)
            {
                totalFare += CalculateTotalFare(data.DISTANCE,data.TIME);
            }
            return totalFare;
        }
        public InvoiceSummary CabInvoice(Ride[] ride)
        {
            double totalFare = this.CalculateMultipleFare(ride);
            InvoiceSummary summary = new InvoiceSummary();
            summary.totalFare = totalFare;
            summary.totalNumberOfRides = ride.Count();
            summary.CalculateAverageFare();
            return summary;
        }
    }
}
