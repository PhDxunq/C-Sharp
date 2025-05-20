using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class TourPackage : ITourPackage
    {

        private int packageId;
        private string destination;
        private int durationDays;
        private float pricePerPerson;
        private int groupSize;


        public int PackageId
        {
            get{
                return packageId;
            }

            set{
                packageId = value;
            }
        }

        public string Destination
        {
            get { return destination; }
            set { 
                if(value.Length < 3 || value.Length > 50)
                {
                    throw new ArgumentException("Destination of the tour (length 3-50 characters).");
                }
                destination = value; 
            }
        }

        public int DurationDays
        {
            get { return durationDays; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of days in the tour (must be > 0).");
                }
                durationDays = value;
            }
        }

        public float PricePerPerson
        {
            get { return pricePerPerson; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price per person for the tour (must be > 0).");
                }
                pricePerPerson = value;
            }
        }

        public int GroupSize
        {
            get { return groupSize; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of people in the tour (must be > 0).");
                }
                groupSize = value;
            }
        }


        public virtual float CalculatePackageCost()
        {
            float totalCost = pricePerPerson* groupSize;
            return totalCost;
        }

        public virtual void DisplayPackageDetails()
        {
            Console.WriteLine($"Tour to {destination} for {durationDays} with a group of {groupSize} people cost a total of ${CalculatePackageCost()} ");
        }
    }
}
