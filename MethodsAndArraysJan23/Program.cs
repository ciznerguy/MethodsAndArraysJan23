using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndArraysJan23
{
    internal class Program
    {
         public static void CheckNum(int num)
        {
            Console.WriteLine(  $"x is {num}"    );

            num = 109;
            // מה יודפס
           Console.WriteLine($"x is {num}");
        }


        public static void GetArray(int[] arr2)
        {
            arr2[0] = 100;
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + ", ");
            }
            Console.WriteLine(  );
        }   


        
        // יש לכתוב פעולה המקבלת מערך ומחזירה מערך חדש בסדר הפוך
        public static int[] ReverseArray(int[] arr) 
        {
            int[] newArray = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++) 
            {
                newArray[i] = arr[arr.Length -i -1];
            }
            return newArray;
        }

        // יש לכתוב פעולה המקבלת מערך ומחזירה מערך חדש של רק האיברים הזוגיים
        public static int CountEven(int[] arr) 
        {
            int count = 0;
            for(int i = 0;i < arr.Length; i++) 
            {
                if (arr[i] % 2 == 0) 
                {
                    count++;
                }
            }
            return count;
        }
        public static int[] OnlyEven(int[] arr) 
        {
            int length = CountEven(arr);
            int[] arrToReturn = new int[length];
            int index = 0;
            for(int i = 0;i < arr.Length; i++) 
            {
                if (arr[i] % 2 == 0) 
                {
                    arrToReturn[index] = arr[i];
                    index++;
                }
            }
            return arrToReturn;
        }

        // יש לכתוב פעולה המקבלת מערך ממויין בסדר עולה ומחזירה מערך ממויין בסדר יורד


        public static int[] Targil5077(int length, int num) 
        {
            int[] arrToReturn = new int[length];
            for(int i = 0;i < arrToReturn.Length; i++)
            {
                arrToReturn[i] = num;
                num++;
            }
            return arrToReturn;
        }
        public static int[] Targil5078(int[] arr1, int[] arr2) 
        {
            int length = Math.Min(arr1.Length, arr2.Length);
            int[] arrToReturn = new int[length];
            if(arr1.Length == arr2.Length) 
            {
                for(int i = 0; i < arr1.Length; i++)
                {
                    arrToReturn[i] = arr1[i] + arr2[i];
                }
            }
            else 
            {
                for (int i = 0; i < arrToReturn.Length; i++)
                {
                    arrToReturn[i] = -1;
                }
            }
            return arrToReturn;
        }
        static void Main(string[] args)
        {

            /*int num = -7098;
            CheckNum(num);
            Console.WriteLine($"x is {num}");*/

            int[] arr1 = { 2, 4, 6 };
            int[] arr2 = { 3, 5, 7, 18};
            int[] arr = Targil5078(arr1, arr2);
            //int[] arr = Targil5077(3, 5);
            for(int i = 0;i < arr.Length; i++) 
            {
                Console.Write(arr[i] + ", ");
            }

            int[] arr = { 1, 5, 3, 1, 5 };
            /* int[] newArr = ReverseArray(arr);
             for(int i = 0;i < newArr.Length;i++) 
             {
                 Console.Write(newArr[i]+", ");
             }
            int[] newArr = OnlyEven(arr);
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + ", ");
            }
            */
        }
    }
}
