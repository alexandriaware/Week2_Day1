﻿using System;
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

            //int[] favoriteNumbers = { 1, 2, 3, 4, 5, 6 };

            //string[] studentNames = { "Raz", "Monica", "David", "Brian", "Ali" };

            //Console.WriteLine(studentNames[2]);

            ////Do it!
            //string[] vacationSpots = { "Disney", "Amsterdam", "Paris", "Geneva", "Dublin",
            //    "Vegas", "Denver", "Portland", "Ann Arbor", "Cape Cod" };
            //Console.WriteLine(vacationSpots[0] + " " + vacationSpots[9]);


            //int[] babyWhippersnappers = { 5, 3, 8 };
            //Console.WriteLine(babyWhippersnappers[0]);
            //Console.WriteLine(babyWhippersnappers[1]);
            //Console.WriteLine(babyWhippersnappers[2]);


            //decimal[] gpaScore = { 1.23m, 3.95m, 2.99m, 2.80m, 3.88m, 4.0m, 2.83m, 3.20m };
            //Console.WriteLine(gpaScore[6]);


            //string[] peerNames = { "N", "J", "M", "L" };


            ////back to lecture
            //int[] numbers = new int[4];
            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number");
            //numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine(numbers[3]);


            ////Do it!
            //string[] daysofWeek = new string[7];
            //daysofWeek[0] = "Sunday";
            //daysofWeek[1] = "Monday";
            //daysofWeek[2] = "Tuesday";
            //daysofWeek[3] = "Wednesday";
            //daysofWeek[4] = "Thursday";
            //daysofWeek[5] = "Friday";
            //daysofWeek[6] = "Saturday";


            //int[] studentAge = new int[5];
            //studentAge[0] = 23;
            //studentAge[1] = 30;
            //studentAge[2] = 25;
            //studentAge[3] = 40;

            ////lecture
            //Console.WriteLine(daysofWeek.Length);

            ////Do it!
            //char[] lastName = { 'w', 'a', 'r', 'e' };
            //Console.WriteLine(lastName.Length);



            //string[] sampleStringArray = { "This", "is", "way", "too", "much", "brain", "for", "today." };

            //Console.WriteLine("This is the second to last index " + (sampleStringArray.Length - 2));

            //Console.WriteLine(sampleStringArray[sampleStringArray.Length - 2]);



            //Console.WriteLine("Please enter the size of your array.");

            //int arraySize = int.Parse(Console.ReadLine());
            //int[] newArray = new int[arraySize];

            //Console.WriteLine("The array is of length " + newArray.Length);



            //string[] birthMonths = { "October", "July", "October", "May" };
            //Console.WriteLine(Array.IndexOf(birthMonths, "October"));


            //int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //Console.WriteLine(Array.LastIndexOf(numbers, 4));


            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);


            //Array.Sort(numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[numbers.Length - 1]);



            //Do it!
            //string[] names = { "Joy", "Sadness", "Anger", "Fear", "Disgust" };
            //Console.WriteLine(Array.IndexOf(names, "Fear"));



            //int[] luckyNum = { 3, 8, 3, 14, 8, 1, 14, 7, 1, 13, 7, 14 , 13};
            //Console.WriteLine(Array.LastIndexOf(luckyNum, 7));



            //char[] alphabet = { 'a', 'b', 'c', 'd', 'e' };
            //Console.WriteLine(alphabet [0]);

            //Array.Reverse(alphabet);
            //Console.WriteLine(alphabet[0]);



            //Array.Sort(names);
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[4]);



            double[] faveNum = { 13, 6, 26, 90, 7, 1040, 45, 32, 3.14 };
            Array.Sort(faveNum);
            Console.WriteLine(faveNum[0]);
            Console.WriteLine(faveNum[8]);





        }
    }
}
