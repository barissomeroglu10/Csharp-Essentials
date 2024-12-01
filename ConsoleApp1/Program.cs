#region Explanation About Code
/*
 Purpose of the code is learn some essentials about C#

Developer: Barış Someroğlu
Date: 01.12.2024 - 11:00 pm
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        #region Factorial Method
        static int Factorial(int x)
        {
            if (x <= 0)
            {
                return 1;
            }

            return x * Factorial(x-1);
        }
        #endregion

        #region Methods
        // No Parameters - No Return Value
        static void WriteScreen()
        {
            Console.WriteLine("Hello World!");
        }

        // Parameter Field - Not Returning Value
        static void WriteScreen(string Name)
        {
            Console.WriteLine("Hello" + Name);
        }

        // Parameter Field - Returning Value
        static int Sum(int a, int b)
        {
            return a + b;
        }

        // params
        static int SumParams(params int[] values)
        {
            int Addition = 0;

            foreach (var i in values)
            {
                Addition += i;
            }

            return Addition;
        }

        // Takes an Array as a Parameter - Returns an Array
        static int[] Square(int[] Array)
        {
            // make an object
            int[] arr = new int[Array.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * i;
            }

            return arr;
        }

        #endregion

        #region Lambda Functions
        static Func<int, int, int> Sum2 = (i, j) => i + j;
        static Func<int, int> Square2 = x => x * x;
        static Action<string> Warning = Name => Console.WriteLine(Name + " Warning");
        #endregion

        static void Main(string[] args)
        {
            #region Getting Value
            int x;

            Console.Write("Please Enter a Number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial of " + x + ": " + Factorial(x));
            #endregion

            #region Array, foreach
            // Define array1
            byte[] array1 = { 10, 20, 30, 40 };

            Console.WriteLine("\narray1[0]: " + array1[0]);

            // Define array2
            byte[] array2 = new byte[array1.Length];
            // ... = new ...
            // we derive an object from System.Array class

            Console.WriteLine("\n");

            // Get value from user for array2
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("Please Enter a Value for " + i + ". index: ");
                array2[i] = Convert.ToByte(Console.ReadLine());
            }

            Console.WriteLine("\n");

            Console.Write("array2: ");
            // Write array2 to console with using foreach
            foreach (byte item in array2)
            {
                Console.Write(item + " ");
            }
            #endregion

            #region Matrix
            // Define a matrix
            int[,] matrix1 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

            // Define a three dimensional matrix
            int[,,] matrix2 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

            // Write three dimensional matrix on console
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(2); k++)
                    {
                        Console.WriteLine(matrix2[i,j,k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion

            #region List
            // Define a list
            List<string> Names = new List<string>();

            // Add to list
            Names.Add("Baris");
            Names.Add("Yaser");
            Names.Add("Diyar");
            Names.Add("Coskun");

            // Write list to console with lambda
            Names.ForEach(i => Console.WriteLine(i));

            // Remove from list
            Names.Remove("Coskun");
            Names.RemoveAt(0);

            Console.WriteLine();
            Names.ForEach((i) => Console.WriteLine(i));

            // Add to list
            Names.Insert(0, "Hüseyin");

            Console.WriteLine();
            Names.ForEach((i) => Console.WriteLine(i));

            // Boolen output
            Console.WriteLine(Names.Contains("Coskun"));
            Console.WriteLine(Names.Contains("Hüseyin"));

            // Order the list
            Names.Sort();

            Console.WriteLine();
            Names.ForEach(i => Console.WriteLine(i));

            Names.Remove("Hüseyin");

            Console.WriteLine();
            Console.WriteLine(Names[0]);
            #endregion

            #region Using Methods
            // Call function
            WriteScreen();
            WriteScreen("Baris");

            // Call function
            int Collection = Sum(10, 7);
            Console.WriteLine("\n" + Collection);

            int Collection2 = SumParams(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("\n" + Collection2);

            int[] ints = { 1, 2, 3, 4 };
            int[] ints2 = Square(ints);

            Console.WriteLine("\n");
            foreach (int i in ints2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nSum: " + Sum(15, 35));
            #endregion

            #region Using Lambda Functions
            Console.WriteLine("\n30 + 3: " + Sum2(30, 3));
            Console.WriteLine("\n3 * 3: " + Square2(3));

            string Name;

            Console.Write("Enter a Name: ");
            Name = Console.ReadLine();

            Warning(Name);
            #endregion

            Console.ReadKey();

        }
    }
}
