using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N (number of random variates):");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of k (number of class intervals):");
            int k = int.Parse(Console.ReadLine());

            // Initialize an array to store the count in each interval
            int[] intervalCounts = new int[k];

            // Generate N uniform random variates and determine the distribution
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                double randomValue = random.NextDouble(); // generates a random value in [0,1)
                int intervalIndex = (int)(randomValue * k); // determine the interval index

                // Increment the count for the corresponding interval
                intervalCounts[intervalIndex]++;
            }

            // Display the results
            Console.WriteLine("\nDistribution of random variates into class intervals:");
            for (int i = 0; i < k; i++)
            {
                double lowerBound = i * 1.0 / k;
                double upperBound = (i + 1) * 1.0 / k;
                Console.WriteLine($"Interval [{lowerBound}, {upperBound}): {intervalCounts[i]} occurrences");
            }
        }
    }
}
