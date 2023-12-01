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
        }
    }
}
