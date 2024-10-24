using Algorithms;
using Algorithms.Models;

namespace Delegats
{

    public delegate void LogDelegate(string arg);

    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<int> intList = new() { 1, 2, 3, 3, 7, 21 };
            var evenElements = CustomAlgorithm.FirstOrDefault(intList, number => number % 2 == 0);
            var oddElements = CustomAlgorithm.FirstOrDefault(intList, number => number % 2 != 0);
            var deideBySeven = CustomAlgorithm.LastOrDefault(intList, number => number % 7 == 0);
            var povitiveNumbers = CustomAlgorithm.Where(intList, number => number > 0);

            var indexOfEl = CustomAlgorithm.IndexOf(intList, number => number == 7);
            var lastIndexOfEl = CustomAlgorithm.LastIndexOf(intList, number => number == 3);

            var maxElFromList = CustomAlgorithm.Max(intList, (a,b) => a > b);
            var minElFromList = CustomAlgorithm.Min(intList, (a, b) => a < b);

            var anyElFromList = CustomAlgorithm.Any(intList, 8, (a, b) => a == b);
            var allElFromList = CustomAlgorithm.All(intList, 7, (a, b) => a == b);



            //var carsData = File.ReadAllLines(@"../../../Files/vehicles.csv");
            //var cars = CustomAlgorithm.Select(carsData, Vehicle.Parse).ToList();


            //var bmws = CustomAlgorithm.Where(cars, vehicle => vehicle.Make.Trim().ToLower() == "BMW".Trim().ToLower()); 
            // var sortedCars = CustomAlgorithm.OrderBy(cars.ToArray(), (Vehicle v1, Vehicle v2) => v1.Combined > v2.Combined);





            /////////////////////////////////////

            // Log("This is a new log message", LogInFile);

        }
        #region logging
        public static void Log(string message, LogDelegate loginConsoleDelegate)
        {
            loginConsoleDelegate(message);
        }

        public static void LogInFile(string message)
        {
            // File.WriteAllText(@"../../../Files/logs.txt", message);
            File.AppendAllText(@"../../../Files/logs.txt", message + Environment.NewLine);

        }

        public static void LogInConsole(string message)
        {
            Console.WriteLine($"Logging to console: {message}");

        }

        #endregion logging
    }

}
