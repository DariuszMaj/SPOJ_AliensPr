using System;

namespace Aliens
{
    class Program
    {
        static void Main(string[] args)
        {
            long test, first, second, i;
            long[] counting=new long[100001];
            test=long.Parse(Console.ReadLine());
            for(var q=test;q>0; q--)
            {
                string[] data = Console.ReadLine().Split(" ");
                first = long.Parse(data[0]);
                second = long.Parse(data[1]);
                string[] alien = Console.ReadLine().Split(" ");
                for(i=0;i<first;i++)
                { 
                    long sum = 0;
                    long LastSum = 0;
                    long FirstOne = 0;
                    long Last = 0;
                    long Amount = 0;

                    for (i = 0; i < first; i++)
                    {
                        counting[i] = long.Parse(alien[i]);
                        sum += counting[i];
                        Last = i;

                        while (sum > second)
                        {
                            sum -= counting[FirstOne];
                            FirstOne++;
                        }

                        if (Amount < (Last - FirstOne))
                        {
                            LastSum= sum;
                            Amount = Last - FirstOne;
                        }
                        else if (Amount == (Last - FirstOne) && LastSum > sum)
                        {
                            LastSum= sum;
                        }
                    }
                    Console.WriteLine(LastSum + " " + (long)(Amount + 1));
                }
            }
        }
    }
}
