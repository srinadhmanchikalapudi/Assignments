using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment2v2
    {
        public int solution(int[] A)
        {
            // Initialize variables
            int Max = A[0];
            int overallMax = A[0];

            // Iterate through the array
            for (int i = 1; i < A.Length; i++)
            {
                // Update the current maximum sum
                Max = Math.Max(A[i], Max + A[i]);

                // Update the global maximum sum
                overallMax = Math.Max(overallMax, Max);
            }

            // Return the maximum sum of any slice
            return overallMax;
        }

        static void Main()
        {
            Assignment2v2 assign3 = new Assignment2v2();
            int[] A = { 3, 2, -6, 4, 0 };
            Console.WriteLine(assign3.solution(A));  // Output: 5
            Console.ReadLine();
        }
    }
}
