using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class TourManagement
    {
        public List<TourPackage> tourPackages = new List<TourPackage>();
        public void AddTourPackage()
        {
            TourPackage newPackage;
            Console.WriteLine("This is a luxury Tour? (y/n)");
            string choice = Console.ReadLine() ?? "n";
            if (choice == "y")
            {
                newPackage = new LuxuryTourPackage();
                Console.Write("Enter luxury tax: ");
                ((LuxuryTourPackage)newPackage).LuxuryTaxRate = float.Parse(Console.ReadLine() ?? "1");
            } else
            {
                newPackage = new TourPackage();
            }
            Console.Write("Enter PackageId: ");
            newPackage.PackageId = int.Parse(Console.ReadLine() ?? "1");
            Console.Write("Enter Destination: ");
            newPackage.Destination = Console.ReadLine() ?? "";
            Console.Write("Enter DurationDays: ");
            newPackage.DurationDays = int.Parse(Console.ReadLine() ?? "1");
            Console.Write("Enter PricePerPerson: ");
            newPackage.PricePerPerson = float.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter GroupSize: ");
            newPackage.GroupSize = int.Parse(Console.ReadLine() ?? "1");

            tourPackages.Add(newPackage);
            Console.WriteLine("Add success.");
        }
        public void viewTourPackage()
        {
            Console.WriteLine("List tour package");
            foreach(var tourPackage in tourPackages)
            {
                tourPackage.DisplayPackageDetails();    
            }
        }

        public void updateTourPackage()
        {
            int inputPackageID = int.Parse((Console.ReadLine() ?? "0"));
            var package = tourPackages.Find(p => p.PackageId == inputPackageID);
            if (package != null)
            {
                Console.WriteLine("Package not found");
            }
            else
            {
                Console.WriteLine("Update a package’s price per person:");
                package.PricePerPerson = float.Parse(Console.ReadLine() ?? string.Empty);
                Console.WriteLine("Update group size:");
                package.GroupSize = int.Parse (Console.ReadLine() ?? "0");
            }
        }

        public void delTourPackage()
        {
            int inputID = int.Parse((Console.ReadLine() ?? "0"));
            var package = tourPackages.Find(p =>p.PackageId == inputID);
            if (package != null)
            {
                Console.WriteLine("the ID is not found");
            }
            else
            {
                tourPackages.Remove(package);
                Console.WriteLine("Delete success");
            }
        }
    }
}
