using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] backgroudDegree = {"Computer Science and Engineering","Computer and System Engineering","Computer Science","Computer Science and Engineering","Computer Engineering","Software and Information EngineeringComputer Engineering","Computer Engineering","Computer Science","Computer Science","Computer Science","Computer Science","Computer Engineering","Computer Science","Computer Engineering", "Computer Science","Computer Engineering","Computer Engineering","Computer Science","Computer Science","Computer Science","Computer Science and Engineering","Computer Science","Computer Science","Computer Science","Information Engineering, Computer Science and Statistics","Computer Science","Computer Science","Computer Science","Computer Science","International Relations","Computer Engineering","Computer Science","Cybersecurity","Computer Science","Computer Science","Security of information technologies","Computer Science","Computer Science","Computer Engineering","Computer Science","Computer Science","Computer Science","Computer Engineering","Computer Engineering","Computer Science","Computer Science","Cybersecurity","Computer Science","Conputer Engineering","Cybersecurity","Computer Science","Computer Engineering","Computer Science","Computer Science and Engineering","Computer Science and Engineering","Computer Science and Engineering"};
            int[] age = { 22, 22, 22, 23, 23, 21, 23, 23, 24, 24, 23, 21, 25, 22, 22, 22, 25, 21, 21, 21, 23, 22, 21, 23, 24, 25, 23, 22, 22, 27, 23, 24, 22, 25, 39, 26, 23, 22, 22, 22, 23, 27, 23, 25, 22, 22, 22, 22, 21, 23, 23, 26, 27, 23, 23, 23, 27, 24 };
            int[] hard_Worker = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 4, 5, 5, 5, 4, 5, 5, 5, 5, 5, 4, 4, 4, 5, 4, 4, 2, 4, 4, 5, 4, 4, 4, 4, 3, 4, 4, 5, 4, 5, 4, 5, 4, 4, 4, 4, 4, 5, 4, 3, 4, 4, 4, 5, 3, 4 };


            Dictionary<string, int> degreeCounts = new Dictionary<string, int>();

            // Compute absolute frequency
            foreach (string degree in backgroudDegree)
            {
                if (degreeCounts.ContainsKey(degree))
                    degreeCounts[degree]++;
                else
                    degreeCounts[degree] = 1;
            }

            // Compute relative and percentage frequency
            int totalDegrees = backgroudDegree.Length;
            Dictionary<string, double> relativeFrequency = new Dictionary<string, double>();
            Dictionary<string, double> percentageFrequency = new Dictionary<string, double>();

            foreach (var kvp in degreeCounts)
            {
                relativeFrequency[kvp.Key] = (double)kvp.Value / totalDegrees;
                percentageFrequency[kvp.Key] = relativeFrequency[kvp.Key] * 100;
            }


            Dictionary<int, int> ageCounts = new Dictionary<int, int>();

            // Compute absolute frequency
            foreach (int a in age)
            {
                if (ageCounts.ContainsKey(a))
                    ageCounts[a]++;
                else
                    ageCounts[a] = 1;
            }

            // Compute relative and percentage frequency
            int totalAges = age.Length;
            Dictionary<int, double> relativeAgeFrequency = new Dictionary<int, double>();
            Dictionary<int, double> percentageAgeFrequency = new Dictionary<int, double>();

            foreach (var kvp in ageCounts)
            {
                relativeAgeFrequency[kvp.Key] = (double)kvp.Value / totalAges;
                percentageAgeFrequency[kvp.Key] = relativeAgeFrequency[kvp.Key] * 100;
            }



            int[] classIntervals = { 2, 3, 4, 5 };  

            Dictionary<int, int> workerCounts = new Dictionary<int, int>();

            // Compute absolute frequency
            foreach (int worker in hard_Worker)
            {
                foreach (int interval in classIntervals)
                {
                    if (worker <= interval)
                    {
                        if (workerCounts.ContainsKey(interval))
                            workerCounts[interval]++;
                        else
                            workerCounts[interval] = 1;
                        break;
                    }
                }
            }

            // Compute relative and percentage frequency
            int totalWorkers = hard_Worker.Length;
            Dictionary<int, double> relativeWorkerFrequency = new Dictionary<int, double>();
            Dictionary<int, double> percentageWorkerFrequency = new Dictionary<int, double>();

            foreach (var kvp in workerCounts)
            {
                relativeWorkerFrequency[kvp.Key] = (double)kvp.Value / totalWorkers;
                percentageWorkerFrequency[kvp.Key] = relativeWorkerFrequency[kvp.Key] * 100;
            }


            Dictionary<string, Dictionary<int, int>> jointDistribution = new Dictionary<string, Dictionary<int, int>>();

            for (int i = 0; i < backgroudDegree.Length; i++)
            {
                string degree = backgroudDegree[i];
                int ageValue = age[i];

                if (!jointDistribution.ContainsKey(degree))
                    jointDistribution[degree] = new Dictionary<int, int>();

                if (jointDistribution[degree].ContainsKey(ageValue))
                    jointDistribution[degree][ageValue]++;
                else
                    jointDistribution[degree][ageValue] = 1;
            }

                Console.WriteLine("Degree Frequency Table");
                Console.WriteLine("----------------------");
                Console.WriteLine("| Degree\t| Absolute\t| Relative\t| Percentage\t|");
                Console.WriteLine("----------------------");
                foreach (var kvp in degreeCounts)
                {
                    Console.WriteLine($"| {kvp.Key,-40}\t| {kvp.Value,-10}\t| {relativeFrequency[kvp.Key]:F3}\t\t| {percentageFrequency[kvp.Key]:F2}%\t\t|");
                }
                Console.WriteLine("----------------------");
                Console.WriteLine();

                // Print Age Frequency Table
                Console.WriteLine("Age Frequency Table");
                Console.WriteLine("-------------------");
                Console.WriteLine("| Age\t| Absolute\t| Relative\t| Percentage\t|");
                Console.WriteLine("-------------------");
                foreach (var kvp in ageCounts)
                {
                    Console.WriteLine($"| {kvp.Key,-5}\t| {kvp.Value,-10}\t| {relativeAgeFrequency[kvp.Key]:F3}\t\t| {percentageAgeFrequency[kvp.Key]:F2}%\t\t|");
                }
                Console.WriteLine("-------------------");
                Console.WriteLine();

                // Print Worker Frequency Table
                Console.WriteLine("Worker Frequency Table");
                Console.WriteLine("----------------------");
                Console.WriteLine("| Interval\t| Absolute\t| Relative\t| Percentage\t|");
                Console.WriteLine("----------------------");
                foreach (var kvp in workerCounts)
                {
                    Console.WriteLine($"| {kvp.Key,-10}\t| {kvp.Value,-10}\t| {relativeWorkerFrequency[kvp.Key]:F3}\t\t| {percentageWorkerFrequency[kvp.Key]:F2}%\t\t|");
                }
                Console.WriteLine("----------------------");
                Console.WriteLine();

                // Print Joint Distribution Table
                Console.WriteLine("Joint Distribution Table");
                Console.WriteLine("-------------------------");
                Console.WriteLine("| Degree\t| Age\t| Count\t|");
                Console.WriteLine("-------------------------");
                foreach (var degreeKvp in jointDistribution)
                {
                    foreach (var ageKvp in degreeKvp.Value)
                    {
                        Console.WriteLine($"| {degreeKvp.Key,-40}\t| {ageKvp.Key,-5}\t| {ageKvp.Value,-5}\t|");
                    }
                }
                Console.WriteLine("-------------------------");
            }

    }
}
