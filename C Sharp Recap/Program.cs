using System;

namespace C_Sharp_Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Hello, World!");

            Task7();
        }

        static void Task2()
        {
            // 2
            string input;
            float width = 0, height = 0;

            Console.WriteLine("Width:");
            input = Console.ReadLine();
            // if unable to parse - loop entering and trying to parse new input
            while (!float.TryParse(input, out width))
            {
                Console.WriteLine($"unable to parse '{input}'.");
                input = Console.ReadLine();
            }

            Console.WriteLine("Height:");
            input = Console.ReadLine();
            // if unable to parse - loop entering and trying to parse new input
            while (!float.TryParse(input, out height))
            {
                Console.WriteLine($"unable to parse '{input}'.");
                input = Console.ReadLine();
            }

            float area = width * height;
            float perimeter = (2 * width) + (2 * height);

            Console.WriteLine("Area: " + area + "; Perimeter: " + perimeter);
        }

        static void Task3()
        {
            // 3 & 4
            Console.WriteLine("Enter 10 integers");
            int[] numArray = new int[10];
            int largest = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                int temp;
                string tempString;
                Console.WriteLine("Integer " + (i + 1) + ":");
                tempString = Console.ReadLine();
                while (!int.TryParse(tempString, out temp))
                {
                    Console.WriteLine($"unable to parse '{tempString}'.");
                    tempString = Console.ReadLine();
                }
                numArray[i] = temp;
            }

            foreach (int i in numArray)
            {
                if (i > largest)
                {
                    largest = i;
                }
            }
            Console.WriteLine("Largest Number Entered = " + largest);

            for (int i = numArray.Length; i > 0; i--)
            {
                Console.WriteLine(numArray[i - 1]);
            }
        }

        static void Task5()
        {
            string input;
            // 5 & 6
            int a = 0, b = 0;

            Console.WriteLine("Number 1: ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out a))
            {
                Console.WriteLine($"unable to parse '{input}' to int.");
                input = Console.ReadLine();
            }

            Console.WriteLine("Number 2: ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out b))
            {
                Console.WriteLine($"unable to parse '{input}' to int.");
                input = Console.ReadLine();
            }

            Console.WriteLine("Result: " + Add(a, b));
        }

        static int Add(int a, int b)
        {
            return a + b; 
        }

        static float Add(float a, float b) 
        {
            return a + b;
        }

        static void Task7()
        {
            var rand = new Random().Next(100) + 1;
        }
    }
}
