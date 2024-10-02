﻿using System;
using System.Collections.Generic;

namespace C_Sharp_Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Hello, World!");

            Hangman.Hangman hangman = new Hangman.Hangman();
            hangman.Update();
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
                Console.WriteLine($"unable to parse '{input}' to float.");
                input = Console.ReadLine();
            }

            Console.WriteLine("Height:");
            input = Console.ReadLine();
            // if unable to parse - loop entering and trying to parse new input
            while (!float.TryParse(input, out height))
            {
                Console.WriteLine($"unable to parse '{input}' to float.");
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
                    Console.WriteLine($"unable to parse '{tempString}'  to int.");
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
            string input;
            int guess = 0;

            Console.WriteLine("Guess what number i'm thinking from 1 to 100:");

            do
            {
                input = Console.ReadLine();
                while (!int.TryParse(input, out guess))
                {
                    Console.WriteLine($"unable to parse '{input}' to int.");
                }
                if (guess > rand)
                {
                    Console.WriteLine("Too High");
                }
                else if (guess < rand)
                {
                    Console.WriteLine("Too Low");
                }
            } while (guess != rand);
            Console.WriteLine("Correct");
        }

        static void Task8()
        {
            Animal[] animalsArray = new Animal[]
            {
                new Dog(), new Cat(), new Horse()
            };
            int temp;
            string tempString;

            Console.WriteLine("Select an Animal.");
            for (int i = 0; i < animalsArray.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + animalsArray[i].name);
            }
            tempString = Console.ReadLine();
            while (!int.TryParse(tempString, out temp))
            {
                Console.WriteLine($"unable to parse '{tempString}' to int.");
                tempString = Console.ReadLine();
            }
            animalsArray[temp-1].Speak();
        } 
    }

    internal class Animal
    {
        public string name = "Base";

        public virtual void Speak()
        {
            Console.WriteLine("Performing base class speak.");
        }
    }

    internal class Dog : Animal
    {
        public Dog()
        {
            name = "Dog";
        }

        public override void Speak()
        {
            Console.WriteLine("Woof.");
        }
    }

    internal class Cat : Animal
    {
        public Cat()
        {
            name = "Cat";
        }
        public override void Speak()
        {
            Console.WriteLine("Meow.");
        }
    }

    internal class Horse : Animal
    {
        public Horse()
        {
            name = "Horse";
        }
        public override void Speak()
        {
            Console.WriteLine("Neigh.");
        }
    }
}


namespace Hangman
{
    class Hangman
    {
        //Member Variables
        int m_Lives = 6;
        List<char> m_IncorrectLetters;
        List<char> m_CorrectLetters;
        string[] m_Words = { };
        string m_Word;
        bool m_Won = false;
        char m_PlayAgain = 'n';

        public Hangman()
        {
            //init
        }

        public void Update()
        {
            char userInput;

            //Check to see if the user has used a value 
            while (m_IncorrectLetters.Contains((userInput = Char.ToLower(Console.ReadKey().KeyChar))))
            {
                Console.WriteLine(": has already been guessed");
            }

            //Clear the screen
            Console.Clear();
        }

        //Draw Hangman
        void ShowHangman()
        {
            Console.WriteLine("     |------+  ");
            Console.WriteLine("     |      |  ");
            Console.WriteLine("     |      " + (m_Lives < 6 ? "O" : ""));
            Console.WriteLine("     |     " + (m_Lives < 4 ? "/" : "") + (m_Lives < 5 ? "|" : "") + (m_Lives < 3 ? @"\" : ""));
            Console.WriteLine("     |     " + (m_Lives < 2 ? "/" : "") + " " + (m_Lives < 1 ? @"\" : ""));
            Console.WriteLine("     |         ");
            Console.WriteLine("===============");
        }
    }
}
