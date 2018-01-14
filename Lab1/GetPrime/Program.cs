﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;

            for(int i=2; i*i<=n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your list of numbers in a row: ");
            char[] splitter = {' ', '.'};
            string line = Console.ReadLine();
            string[] numbers = line.Split(splitter);
            int n = numbers.Length;
            var primes = new List<int>();
            for(int i=0; i<n; i++)
            {
                int t = int.Parse(numbers[i]);
                if (IsPrime(t))
                {
                    primes.Add(t);
                }
            }

            primes.Sort();
            Console.WriteLine("\nPrimes in your list are: ");
            foreach(var i in primes)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
