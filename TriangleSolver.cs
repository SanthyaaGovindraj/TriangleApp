using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleApp
{
    public class TriangleSolver
    {
        public bool Analyze(int a, int b, int c)
        {
            int A = a, B = b, C = c;
            
            if (A == B && B== C) 
            {
                Console.WriteLine("This is an Equilateral Triangle.");
                return true;
            }
            else if (A == B || A == C || B == C)
            {
              
                Console.WriteLine("This is an Isoceles Triangle.");
                return true;
            }
            else 
            {
              
                Console.WriteLine("This is a Scalene Triangle.");
                return true;
            }
           
        }

    }
}



