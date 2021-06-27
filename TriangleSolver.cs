using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleApp
{
    class TriangleSolver
    {
        public static int Analyze(int a, int b, int c)
        {
            int A = a, B = b, C = c;
            string result;
            if (A == B && B== C) 
            {
                result = "This is an Equilateral Triangle.";
            
            }
            else if (A == B || A == C || B == C)
            {
                result = "This is an Isoceles Triangle.";

            }
            else 
            {
                result = "This is an Scalene Triangle.";

            }

            return Convert.ToInt32(result);
        }



    }
}
