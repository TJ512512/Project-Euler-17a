using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] OneToTen = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] Teens = {"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] Tens = { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] hundreds  = {};
            Array.Resize(ref hundreds, 9);
            for (int i = 0; i < OneToTen.Length; i++)
            {
                hundreds[i] = OneToTen[i] + "hundredand";
            }
            string AllNumbers = "";
            for (int i = 0; i < OneToTen.Length; i++)
            {
                AllNumbers = string.Concat(AllNumbers, OneToTen[i]);
                //Console.WriteLine(OneToTen[i]);
            }
            for (int i = 0; i < Teens.Length; i++)
            {
                AllNumbers = string.Concat(AllNumbers, Teens[i]);
                //Console.WriteLine(Teens[i]);
            }
            for (int i = 0; i < Tens.Length; i++)
            {
                AllNumbers = string.Concat(AllNumbers, Tens[i]);
                //Console.WriteLine(Tens[i]);
            }
            for (int i = 0; i < hundreds.Length; i++)
            {
                string hundred = hundreds[i].Remove(hundreds[i].Length - 3, 3);
                //Console.WriteLine(hundred);
                AllNumbers = string.Concat(AllNumbers, hundred);
            }
            for (int i = 0; i < hundreds.Length; i++)
            {
                string hundred = "";
                for (int j = 0; j < OneToTen.Length; j++)
                {
                   hundred  = String.Concat(hundreds[i], OneToTen[j]);
                    //Console.WriteLine(hundred);
                }
                AllNumbers = string.Concat(AllNumbers, hundred);
            }
            for (int i = 0; i < hundreds.Length; i++)
            {
                string hundred = "";
                for (int j = 0; j < Teens.Length; j++)
                {
                    hundred = String.Concat(hundreds[i], Teens[j]);
                    //Console.WriteLine(hundred);
                }
                AllNumbers = string.Concat(AllNumbers, hundred);
            }
            for (int i = 0; i < hundreds.Length; i++)
            {
                string hundred = "";
                for (int j = 0; j < Tens.Length; j++)
                {
                    hundred = String.Concat(hundreds[i], Tens[j]);
                    //Console.WriteLine(hundred);
                }
                AllNumbers = string.Concat(AllNumbers, hundred);
            }
            for (int i = 0; i < hundreds.Length; i++)
            {
                string hundred = "";
                for (int j = 1; j < Tens.Length; j++)
                {
                    for (int k = 0; k < OneToTen.Length; k++)
                    {
                        hundred = String.Concat(hundreds[i], Tens[j], OneToTen[k]);
                        //Console.WriteLine(hundred);
                    }
                }
                AllNumbers = string.Concat(AllNumbers, hundred);
            }
            for (int i = 1; i < Tens.Length; i ++)
            {
                for (int j = 0; j < OneToTen.Length; j ++)
                {
                    string Ten = String.Concat(Tens[i], OneToTen[j]);
                    AllNumbers = String.Concat(AllNumbers, Ten);
                    //Console.WriteLine(Ten);
                }
            }
            AllNumbers = string.Concat(AllNumbers, "onethousand");
            Console.WriteLine(AllNumbers);
            Console.WriteLine(AllNumbers.Length);
        }
    }
}
