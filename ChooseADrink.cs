using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profes = Console.ReadLine();
            var quantities = double.Parse(Console.ReadLine());
            double drink1 = 0.70;
            double drink2 = 1.00;
            double drink3 = 1.70;
            double drink4 = 1.20;

            String profession1 = "Athlete";
            String profession2 = "Businessman";
            String profession3 = "Businesswoman";
            String profession4 = "SoftUni Student";
            

            if (profession == profession1)
            {
                Console.WriteLine($"The Athlete has to pay {((drink1)*(quantities)):f2}.");
            }
            else if (profession == profession2)
            {
                Console.WriteLine($"The Businessman has to pay {((drink2) * (quantities)):f2}.");
            }
            else if (profession == profession3)
            {
                Console.WriteLine($"The Businesswoman has to pay {((drink2) * (quantities)):f2}.");
            }
            else if (profession == profession4)
            {
                Console.WriteLine($"The SoftUni Student has to pay {((drink3) * (quantities)):f2}.");
            }
            else
            {
                Console.WriteLine($"The {profession} has to pay {((drink4) * (quantities)):f2}.");
            }
        }
    }
}
