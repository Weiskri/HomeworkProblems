using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework: Method Practice
            //// problem 1: create a method which uses two user inputs and returns the greatest, use a loop to receive user inputs

            //int[] userInput = new int[2];

            //for (int i = 0; i < userInput.Length; i++)
            //{
            //    Console.WriteLine("Please enter a number.");
            //    userInput[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("The greatest number is " + (Greater(userInput[0], userInput[1])));

            // problem 2: Create a method which uses two user inputs and tells if they are equal, use a loop to receive user inputs

            //int[] userNum = new int[2];
            //    for (int i = 0; i < userNum.Length; i++)
            //    {
            //        Console.WriteLine("Please enter a number");
            //        userNum[i] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("it is " + Equality(userNum[0], userNum[1]) + " that the numbers are equal");

            // problem 3: Create a method which takes in the user's three favorite foods and returns and prints the three foods in a sentence (use a loop to receiver user inputs)

            //    string[] foods = new string[3];

            //    for (int i = 0; i  <foods.Length; i++)
            //    {
            //        Console.WriteLine("Please enter a favorite food.");
            //        foods[i] = Console.ReadLine();
            //    }

            //    FoodMessage(foods[0], foods[1], foods[2]);

            // problem 4: Create a method which takes two sides of a triangle and returns the third side (use a loop to receiver user inputs).

            double[] triangleSides = new double[2];

            for (int i = 0; i < triangleSides.Length; i++)
            {
                Console.WriteLine("Enter the length of a side.");
                triangleSides[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine(TriangleLength(triangleSides[0], triangleSides[1]));
        }

        static double TriangleLength (double sideOne, double sideTwo)
        {
            double pythCalc = ((sideOne * sideOne) + (sideTwo * sideTwo));
            double thirdSide = Convert.ToDouble(Math.Sqrt(pythCalc));

            return thirdSide;
        }


        //static int Greater(int numberOne, int numberTwo) // goes with homework problem 1
        //{

        //    int greatestNumber = 0;
        //    if (numberOne > numberTwo)
        //    {
        //        greatestNumber = numberOne;
        //    }
        //    if (numberOne < numberTwo)
        //    {
        //        greatestNumber = numberTwo;
        //    }
        //    return greatestNumber;
        //}

        //static bool Equality(int numberOne, int numberTwo) // goes with homework problem 2
        //{
        //    bool status;
        //    if (numberOne == numberTwo)
        //    {
        //        status = true;
        //    }
        //    else { status = false; }
        //    return status;
        //}

        //static void FoodMessage(string foodOne, string foodTwo, string foodThree) // goes with homework problem 3
        //{
        //    Console.WriteLine("Your favorite foods are {0}, {1}, and {2}", foodOne.ToLower(), foodTwo.ToLower(), foodThree.ToLower());
        //}
    }
}
