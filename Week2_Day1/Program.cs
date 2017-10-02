using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] favoriteNumbers = { 1, 2, 3, 4, 5, 6 };

            string[] studentNames = { "Raz", "Monica", "David", "Brian", "Ali" };

            Console.WriteLine(studentNames[2]);

            //Do it!
            string[] vacationSpots = { "Disney", "Amsterdam", "Paris", "Geneva", "Dublin",
                "Vegas", "Denver", "Portland", "Ann Arbor", "Cape Cod" };
            Console.WriteLine(vacationSpots[0]);
            Console.WriteLine(vacationSpots[9]);


            int[] babyWhippersnappers = { 5, 3, 8 };
            Console.WriteLine(babyWhippersnappers[0]);
            Console.WriteLine(babyWhippersnappers[1]);
            Console.WriteLine(babyWhippersnappers[2]);
        }
    }
}
