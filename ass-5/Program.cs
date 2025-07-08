using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace ass_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1-Write a program that prints an identity matrix using for loop, in other
            //words takes a value n from the user and shows the identity table of size n *
            //n.
            //Console.WriteLine("Enter size  of identity");
            //int.TryParse(Console.ReadLine(), out int value);

            //for (int i = 0; i < value; i++) {
            //    for (int j = 0; j < value; j++) {

            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //        }
            //         Console.WriteLine();

            //    }

            //}
            #endregion

            #region Q2-Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++) { 

            //    sum += array[i];
            //}

            //Console.WriteLine(sum);

            #endregion
            #region Q3-Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] array1 = { 18, 273, 37 };
            //int[] array2 = { 16, 27, 83 };
            //int[] mergedarray = new int[array1.Length*2];
            //for (int i = 0; i < array1.Length; i++) {
            //    mergedarray[i] = array1[i];
            //    mergedarray[array1.Length + i] = array2[i];

            //}
            //Array.Sort(mergedarray);
            //foreach (int num in mergedarray) { 
            //    Console.WriteLine(num);
            //}
            #endregion
            #region Q4- Write a program in C# Sharp to find maximum and minimum element in an
            //array = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 }
            //int[] numbers = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };
            //int max = numbers[0];
            //int min = numbers[0];
            //for (int i = 0; i < numbers.Length; i++) {
            //    if (numbers[i] > max)
            //    {
            //        max= numbers[i];
            //    }
            //}

            //for (int i = 0; i < numbers.Length; i++) {

            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }


            //}

            //Console.WriteLine(max);
            //Console.WriteLine(min);

            #endregion
            #region Q5-Write a program in C# Sharp to find the second largest element in an array.
            //int[] numbers = { 15,62,8,4,28,2 };
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[numbers.Length-2]);
            #endregion
            #region Q6
            // مش فاهم السؤال 
            #endregion
            #region Q7 -Given a list of space separated words, reverse the order of the words.
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //Array.Reverse(words);
            //string output = string.Join(" ", words);
            //Console.WriteLine(output);  
            #endregion
            #region Q8-Write a program to create two multidimensional arrays of same size. Accept
            //value from user and store them in first array. Now copy all the elements of
            //first array on second array and print second array.
            //Console.WriteLine("enter a number of rows");
            //int.TryParse(Console.ReadLine(), out int rows);
            //Console.WriteLine("enter a number of column");
            //int.TryParse(Console.ReadLine(), out int column);

            //int[,] array1 = new int[rows, column];
            //int[,] array2 = new int[rows, column];

            //Console.WriteLine("enter a numbers ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.WriteLine($"enter a numbers [{i},{j}] ");
            //        int.TryParse(Console.ReadLine(), out array1[i, j]);
            //    }

            //}

            //for (int i = 0;i < rows; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        array2[i,j] = array1[i, j];
            //    }

            //}

            //foreach (int i in array2)
            //{
            //    Console.WriteLine(i);
            //}




            #endregion

            #region Q9-Write a Program to Print One Dimensional Array in Reverse Order
            //int[] array1 = { 2, 5, 6, 2, 7, 5 };
            //for (int i = array1.Length-1; i >=0; i--) { 
            //Console.WriteLine(array1[i]);
            //}

            #endregion
        }
    }
}

