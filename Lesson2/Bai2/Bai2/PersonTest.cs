using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class PersonTest
    {
        public static void Test()
        {
            PersonVietNam personVietNam = new PersonVietNam(2);
            personVietNam[0] = new Person("1234", "Testweqwewqe", 12);
            personVietNam[1] = new Person("1235", "Testweqwewqe", 19);
            personVietNam.DisplayDetails();
        }
    }
}
