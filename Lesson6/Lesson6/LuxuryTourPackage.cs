using System;

namespace Lesson6
{
    internal class LuxuryTourPackage : TourPackage
    {
        private float luxuryTaxRate;

        public float LuxuryTaxRate
        {
            get { return luxuryTaxRate; }
            set
            {
                luxuryTaxRate = 12;
            }
        }

        public override float CalculatePackageCost()
        {
            float baseCost = base.CalculatePackageCost(); 
            float taxAmount = baseCost + (PricePerPerson * luxuryTaxRate / 100);
            return baseCost + taxAmount;
        }

        public override void DisplayPackageDetails()
        {
            Console.WriteLine($"Luxury tour to {Destination} for {DurationDays} days with a group of {GroupSize} people costs a total of ${CalculatePackageCost()}.");

        }
    }
}
