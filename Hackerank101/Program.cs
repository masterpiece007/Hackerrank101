using System;
using System.Collections.Generic;

namespace Hackerank101
{
    class Program
    {
        static void Main(string[] args)
        {
            //var str = new string[5] { "5", "2", "C", "D", "+" };
            //CalPoints(str);  
            //BinarySearch01(2, new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Console.WriteLine($"target exist? { BinarySearch01(-1, new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })}");
            //Console.WriteLine($"isPrime? {IsPrimeNum(77)}");
        }

        static int CalPoints(string[] ops)
        {
            var holder = new List<string>();
            var summ = 0;
            var opCode = new List<string> {"C", "D", "+" };
            var lastIndex = 0;
            //bool isOpCode = false;
            for (int i = 0; i < ops.Length; i++)
            {
                lastIndex = holder.Count - 1;

                //isOpCode = opCode.Exists(x => x == ops[i]);
                //string final =  isOpCode ? (ops[i] == opCode[0]
                //    ? holder.RemoveAt(lastIndex) : ops[i] == opCode[1] 
                //    ? holder.Add((2 * Convert.ToInt32(holder[lastIndex])).ToString()) : ops[i] == opCode[2] 
                //    ? holder.Add((Convert.ToInt32(holder[lastIndex]) + Convert.ToInt32(holder[lastIndex - 1])).ToString()) :) : "" ;

                if (ops[i] == opCode[0])
                {
                    if (holder.Count > 0)
                    {
                        holder.RemoveAt(lastIndex);
                    }
                }
                else if(ops[i] == opCode[1])
                {
                    if (holder.Count > 0)
                    {
                        holder.Add((2 * Convert.ToInt32(holder[lastIndex])).ToString());
                    }
                }
                else if (ops[i] == opCode[2])
                {
                    if (holder.Count > 0)
                    {
                        holder.Add((Convert.ToInt32(holder[lastIndex]) + Convert.ToInt32(holder[lastIndex - 1])).ToString());
                    }
                }
                else
                {
                    holder.Add(ops[i]);
                }
            }
            holder.ForEach(a => summ += Convert.ToInt32(a));
            return summ;
        }

        static bool IsPrimeNum(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i+= 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
            
        }

        //Fibonacci
        //Sort Algorithm
        //Search Algorithm
        //Binary Search Algorithm

        //public static List<int> IceCreamParlor(int m, List<int> arr)
        //{
        //    while (arr[0] != arr[arr.Count - 1])
        //    {
        //        int mid = (arr[0] + arr[arr.Count - 1])/2;
        //        if (mid < m)
        //        {

        //        }
        //    }
        //} 
        
        public static int BinarySearch(int target, List<int> arr)
        {
            //arr[0] != arr[arr.Count - 1]
            int leftIndex = 0;
            int rightIndex = arr.Count - 1;
           while (leftIndex <= rightIndex)
            {

                int mid = (leftIndex + rightIndex) / 2;
                if (arr[mid] > target)
                {
                    rightIndex = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    leftIndex = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;

        }

        public static int BinarySearch01(int target, List<int> arr)
        {
            int l = 0;
            int r = arr.Count - 1;

            while (l <= r)
            {
                int m = (l + r) / 2;
                if (arr[m] > target)
                {
                    r = m - 1;
                }
                else if (arr[m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    return m;
                }
            }
            return -1;

        }
    }




}
