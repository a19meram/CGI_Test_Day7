using System;
using System.IO;
using System.Linq;

namespace CrabAlignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adding a path to the input file for positions
            string filePath = "/Users/meronabraham/Downloads/input.txt";

            // Read the puzzle input
            string input = File.ReadAllText(filePath);

            //Converting input to an array of integers
            int[] positions = input.Split(',').Select(int.Parse).ToArray();

            // Start with calculating the madian first
            /*My solution will be based on the median*/
            Array.Sort(positions);//Sorting the "positions" array in ascending order

            // A new variable needed for storing the result of calculations
            double median;

            //Claculating the median for both even and odd for length of array
            if (positions.Length % 2 == 0)
            {
                median = (positions[positions.Length / 2 - 1] + positions[positions.Length / 2]) / 2.0;
            }
            else
            {
                median = positions[positions.Length / 2];
            }

            // Calculate mean (average)
            double mean = positions.Average();

            // Output the calculated median and mean
            Console.WriteLine($"Median: {median}");
            Console.WriteLine($"Mean: {mean}");

            Console.ReadLine();


            // Based on the calulations of the median and mean calculate the fuel spent
            /*Add the calcultions on the next commit*/
        }
    }
}
