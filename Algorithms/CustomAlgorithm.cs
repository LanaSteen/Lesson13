﻿using Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithms
{
    public delegate bool ComparerDelegateForInts(int arg);
    public delegate bool ComparerDelegateForVehicles(Vehicle vehicle);
    public delegate Vehicle SelectorDelegateForVehicles(string arg);
    public delegate bool ComparerDelegateForVehiclesComparison(Vehicle arg1, Vehicle arg2);
    public delegate bool ComparerDelegateForTwoInts(int a, int b);

    public static class CustomAlgorithm
    {
        public static int FirstOrDefault(int[] collection, ComparerDelegateForInts comparerFunction)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static int FirstOrDefault(int[] collection, int value)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == value)
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static int FirstOrDefault(List<int> collection, int value)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == value)
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static int FirstOrDefault(List<int> collection, ComparerDelegateForInts comparerFunction)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }


        public static int LastOrDefault(List<int> collection, ComparerDelegateForInts comparerFunction)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (comparerFunction(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static int LastOrDefault(List<int> collection, int value)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] == value)
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static int LastOrDefault(int[] collection, int value)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (collection[i] == value)
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static int LastOrDefault(int[] collection, ComparerDelegateForInts comparerFunction)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (comparerFunction(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }




        public static List<int> Where(List<int> collection, int value)
        {
            List<int> result = new();

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == value)
                {
                    result.Add(collection[i]);
                }
            }

            return result;
        }
        public static List<int> Where(List<int> collection, ComparerDelegateForInts comparerFunction)
        {
            List<int> result = new();

            for (int i = 0; i < collection.Count; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }

            return result;
        }


        public static int[] Where(int[] collection, ComparerDelegateForInts comparerFunction)
        {
            List<int> result = new();

            for (int i = 0; i < collection.Length; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }

            return result.ToArray();
        }
        public static int[] Where(int[] collection, int value)
        {
            List<int> result = new();

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == value)
                {
                    result.Add(collection[i]);
                }
            }

            return result.ToArray();
        }

        public static List<Vehicle> Where(List<Vehicle> collection, ComparerDelegateForVehicles comparerFunction)
        {
            List<Vehicle> result = new();

            for (int i = 0; i < collection.Count; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }

            return result;
        }
        public static List<Vehicle> Where(Vehicle[] collection, string make)
        {
            List<Vehicle> result = new();

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i].Make.Trim().ToLower().Contains(make.Trim().ToLower()))
                {
                    result.Add(collection[i]);
                }
            }

            return result;
        }



        public static int IndexOf(int[] collection, ComparerDelegateForInts comparerFunction)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        public static int IndexOf(int[] collection, int value)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int IndexOf(List<int> collection, int value)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int IndexOf(List<int> collection, ComparerDelegateForInts comparerFunction)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }


        public static int LastIndexOf(int[] collection, int value)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (collection[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int LastIndexOf(List<int> collection, int value)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int LastIndexOf(int[] collection, ComparerDelegateForInts comparerFunction)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (comparerFunction(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        public static int LastIndexOf(List<int> collection, ComparerDelegateForInts comparerFunction)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (comparerFunction(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }


        public static int Sum(int[] collection)
        {
            int result = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                result += collection[i];
            }

            return result;
        }
        public static int Sum(List<int> collection)
        {
            int result = 0;

            for (int i = 0; i < collection.Count; i++)
            {
                result += i;
            }

            return result;
        }


        public static Vehicle[] Take(Vehicle[] vehicles)
        {
            Vehicle[] tenMostEconomicCars = new Vehicle[10];
            for (int i = 0; i < tenMostEconomicCars.Length; i++)
            {
                tenMostEconomicCars[i] = vehicles[i];
            }

            return tenMostEconomicCars;
        }
        public static Vehicle[] OrderBy(Vehicle[] vehicles)
        {
            for (int i = 0; i < vehicles.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Length; j++)
                {
                    if (vehicles[j].Combined > vehicles[i].Combined)
                    {
                        Vehicle temp = vehicles[j];
                        vehicles[j] = vehicles[i];
                        vehicles[i] = temp;
                    }
                }
            }

            return vehicles;
        }

        public static Vehicle[] OrderBy(Vehicle[] vehicles, ComparerDelegateForVehiclesComparison comparerFunction)
        {
            for (int i = 0; i < vehicles.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Length; j++)
                {
                    if (comparerFunction(vehicles[j], vehicles[i]))
                    {
                        Vehicle temp = vehicles[j];
                        vehicles[j] = vehicles[i];
                        vehicles[i] = temp;
                    }
                }
            }

            return vehicles;
        }


        public static Vehicle[] Select(string[] stringVehicles)
        {
            Vehicle[] vehicles = new Vehicle[stringVehicles.Length];
            for (int i = 0; i < stringVehicles.Length; i++)
            {
                vehicles[i] = Vehicle.Parse(stringVehicles[i]);
            }

            return vehicles;
        }
        public static Vehicle[] Select(string[] stringVehicles, SelectorDelegateForVehicles transformerFunction)
        {
            Vehicle[] vehicles = new Vehicle[stringVehicles.Length];
            for (int i = 0; i < stringVehicles.Length; i++)
            {
                vehicles[i] = transformerFunction(stringVehicles[i]);
            }

            return vehicles;
        }


        public static int Max(List<int> intList, ComparerDelegateForTwoInts comparerFunction)
        {
            int max = intList[0];

            for (int i = 0; i < intList.Count; i++)
            {
                if (comparerFunction(intList[i], max))
                {
                    max = intList[i];
                }
            }

            return max;
        }
        public static int Max(int[] intAr, ComparerDelegateForTwoInts comparerFunction)
        {
            int max = intAr[0];

            for (int i = 0; i < intAr.Length; i++)
            {
                if (comparerFunction(intAr[i], max))
                {
                    max = intAr[i];
                }
            }

            return max;
        }


        public static int Min(List<int> intList, ComparerDelegateForTwoInts comparerFunction)
        {
            int min = intList[0];

            for (int i = 0; i < intList.Count; i++)
            {
                if (comparerFunction(intList[i], min))
                {
                    min = intList[i];
                }
            }

            return min;
        }
        public static int Min(int[] intAr, ComparerDelegateForTwoInts comparerFunction)
        {
            int min = intAr[0];

            for (int i = 0; i < intAr.Length; i++)
            {
                if (comparerFunction(intAr[i], min))
                {
                    min = intAr[i];
                }
            }

            return min;
        }




        public static bool Any(int[] intAr, int element, ComparerDelegateForTwoInts comparerFunction)
        {
            for (int i = 0; i < intAr.Length; i++)
            {
                if (comparerFunction(intAr[i], element))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool All(int[] intAr, int element, ComparerDelegateForTwoInts comparerFunction)
        {
            for (int i = 0; i < intAr.Length; i++)
            {
                if (comparerFunction(intAr[i], element))
                {
                    return false;
                }
            }

            return true;
        }
        public static bool Any(List<int> intList, int element, ComparerDelegateForTwoInts comparerFunction)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (comparerFunction(intList[i],element))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool All(List<int> intList, int element, ComparerDelegateForTwoInts comparerFunction)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (comparerFunction(intList[i], element))
                {
                    return false;
                }
            }

            return true;
        }




        public static int[] Reverse(int[] collection)
        {
            Stack<int> stack = new();

            for (int i = 0; i < collection.Length; i++)
            {
                stack.Push(collection[i]);
            }

            return stack.ToArray();
        }
        public static List<int> Reverse(List<int> collection)
        {
            Stack<int> stack = new();

            for (int i = 0; i < collection.Count; i++)
            {
                stack.Push(collection[i]);
            }

            return stack.ToList();
        }

        //TODO Union
        //TODO Intersect

    }
}
