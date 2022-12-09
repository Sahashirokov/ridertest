using System;
using System.Linq;
using System.Threading;

namespace Crider2
{
    internal class Program
    {
        static int TwoMyArray( int a)
        {
            int[] MyArray = new int[a] ;
            int count = 0;
 
            Random rnd = new Random();
 
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] =rnd.Next(-15,15);
                Console.Write($"{MyArray[i]} ");
                if (MyArray[i]>0)
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
             int a  = int.Parse(Console.ReadLine());
 
            int b  = int.Parse(Console.ReadLine());
 
            int count =  TwoMyArray( a);
            Console.WriteLine();
           Thread.Sleep(1000);
            int count2=TwoMyArray(b);
            Console.WriteLine();
            Console.WriteLine($"кол-во положительных эл 1 массива = {count}, второго =  {count2}");
            
           
        }
    }
}