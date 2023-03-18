using System;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string combination = Console.ReadLine();
            string str = Console.ReadLine();
            

            int count = 0; 

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 1) == combination) 
                {
                    count++; 
                }
            }

            int countA = 0;
            int countB = 0;

            foreach (char c in str)
            {
                if (c == combination[0])
                {
                    countA++;
                }
                else if (c == combination[1])
                {
                    countB++;
                }
            }

            Console.WriteLine($"{countA + countB}");
        }
    }
}



using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main()
        {
            List<int> candidates = new List<int>() { 2, 5, 2, 1, 2 };
            int target = 5;

            int total = 0;

            List<int> answer = new List<int>();

            for (int i = 0; i < candidates.Count; i++)
            {
                total = 0;
                answer.Clear();
                for (int j = 0; j < candidates.Count; j++)
                {
                    if (i != j)
                    {
                        total += candidates[j];
                        answer.Add(candidates[j]);
                    }

                    if (total > target)
                    {
                        break;
                    }
                    else if (total == target)
                    {
                        for (int k = 0; k < answer.Count; k++)
                        {
                            Console.Write($"{answer[k]} ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}





using System;
using System.Collections.Generic;
namespace ConsoleApp4
{
    public class Program
    {
        static void Main()
        { 
            List<int> nums = new List<int>() {1, 2, 3, 4, 4};
            bool haveSame = false;
            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = 0; j < nums.Count; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] == nums[j])
                        {
                            haveSame = true;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(haveSame);
        }
    }
    }
