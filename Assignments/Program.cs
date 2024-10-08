using Assignments;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Solution
    {
        public int solution(int[] A)
        {
            int result = 0;

            // XOR all the elements in the array
            foreach (int num in A)
            {
                result ^= num;
            }

            // The result will be the unpaired element
            return result;
        }
    }




    class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[] A = { 9, 3, 9, 3, 9, 7, 9, 3, 9,3, 9 };
            Console.WriteLine("individual element: "+ sol.solution(A));
            Debugger.Break();
        }
    }

}
