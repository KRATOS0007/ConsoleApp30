using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;


namespace ConsoleApp30
{
    class Result
    {


        public static int sockMerchant(int n, List<int> ar)
        {
            
            int counter = 0;
            int count = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                count = 1;
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        count++;
                    }
                }

                if (count % 2 == 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
        class Program
    {

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.sockMerchant(n, ar);

            Console.WriteLine(result);
        }
    }
}
