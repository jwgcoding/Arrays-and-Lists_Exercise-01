using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;

namespace Arrays_and_Lists_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the methods you create below to print out the contents

            // TODO: Declare and initialize a List<int> using Explicit typing
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };


            // TODO: Declare and initialize a List<int> using Implicit typing

            var list2 = new List<int>() { 1, 2, 3, 4, 5 };

            // TODO: Declare and initialize an empty list of integers called myIntegerList

            List<int> myIntegerList = new List<int>();

            // TODO: Add 3 ints to the list you just created using the Add() function

            myIntegerList.Add(1);
            myIntegerList.Add(2);
            myIntegerList.Add(3);

            // TODO: Declare and initialize an empty array of doubles called myDoublesArray with a size of 5

            double[] myDoublesArray = new double[5];


            // TODO: Add 5 doubles to the array you just created using bracket notation
            myDoublesArray[0] = 1.1;
            myDoublesArray[1] = 2.2;
            myDoublesArray[2] = 3.3;
            myDoublesArray[3] = 4.4;
            myDoublesArray[4] = 5.5;


            // TODO: Declare and initialize an int array using ALL 5 of the different ways you are allowed to

            int[] scores = new int[5] { 100, 99, 98, 97, 96 };
            int[] scores1 = new int[] { 100,99,98,97,96};
            int[] scores2 = { 100, 99, 98, 97, 96 };
            var scores3 = new int[5] { 100, 99, 98, 97, 96 };
            var scores4 = new int[] { 100, 99, 98, 97, 96 };
            // TODO: Declare and initialize a string array using initializer syntax

            string[] weekDays = { "Sun", "Mon", "Tues", "Wed", "Thr", "Fri", "Sat" };

            // TODO: Declare and initialize a char array using initializer syntax
            char[] days = { 'S', 'M', 'T', 'W', 'T', 'F', 'S' };


            // TODO: Declare and initialize a bool array using initializer syntax
            bool[] todaysDay = { false, false, false, true, false, false, false };


            // TODO: Declare and initialize a list of strings using initializer syntax

            List<string> cars = new List<string>() { "Toyota", "Honda", "Cheverolet", "Ford", "Bently" };


            // TODO: Declare and initialize a list of doubles using initializer syntax
            var doubleList = new List<double>() { .2, .3, .4, .5, .6 };


            // TODO: Declare and initialize a list of floats using initializer syntax

            var floatList = new List<float>() { .1f, .2f, .3f, .4f, .5f };

            // TODO: Declare and initialize a list of chars using initializer syntax
            var charList = new List<char>() { 'A', 'B', 'C', 'D', 'F' };

            PrintNums(floatList);
        }

        // TODO: Create a method called PrintNums() that accepts a list of ints, removes the first item from the list, and then prints the entire list to the console

        
        public static void PrintNums(List<int> list)
        {
            list.RemoveAt(0); 
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create an overload of the above method that accepts a list of strings, removes the first item from the list, and then prints the entire list to the console
        public static void PrintNums(List<string> list)
        {
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }


        // TODO: Create an overload of the above method that accepts a list of doubles, removes the first item from the list, and then prints the entire list to the console

        public static void PrintNums(List<double> list)
        {
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create an overload of the above method that accepts a list of floats, removes the first item from the list, and then prints the entire list to the console

        public static void PrintNums(List<float> list)
        {
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create a method that accepts an array of ints, removes the first item from the array, and then prints the entire array to the console

        public static void PrintNums(int[] arr)
        {
            int[] copy = new int[arr.Length - 1];
            
            for (int i = 1; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }
            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }
        }

        // TODO: Create an overload of the above method that accepts a array of strings, removes the first item from the array, and then prints the entire array to the console
        public static void PrintNums(string[] arr)
        {
            string[] copy = new string[arr.Length - 1];
            
            for (int i = 1; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }
            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }
        }


        // TODO: Create an overload of the above method that accepts a array of chars, removes the first item from the array, and then prints the entire array to the console


        public static void PrintNums(char[] arr)
        {
            char[] copy = new char[arr.Length - 1];

            for (int i = 1; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }
            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }
        }
        // TODO: Create an overload of the above method that accepts a array of doubles, removes the first item from the array, and then prints the entire array to the console
        public static void PrintNums(double[] arr)
        {
            double[] copy = new double[arr.Length - 1];

            for (int i = 1; i < arr.Length; i++)
            {
                copy[i] = arr[i];
            }
            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }
        }

    }
}
