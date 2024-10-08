using System;


namespace Assignments
{
    class Assignment2
    {

        public int solution(int[] A)
        {
            int x = A.Length;
            int overallmax = 0;
            int max = 0;
            int r = 0;

            for (int i = 0; i < x; i++)  // 0<=P<=Q<N
            {

                for (int j = r; j < x; j++)
                {
                    if (i == j) { max = A[i]; }
                    else { max = A[i] + A[j]; }

                    if (overallmax < max) { overallmax = max; }

                }

                r++;
            }

            return overallmax;

        }




        static void Main()
        {
            Assignment2 assign = new Assignment2();
            int[] A = { 3, 2, -6, 4, 0 };
            Console.WriteLine("Maximum value: " + assign.solution(A));
            Console.ReadLine();
            
        }
    }
}
