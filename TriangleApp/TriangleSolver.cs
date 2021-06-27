using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleApp
{
    public class TriangleSolver
    {
        public void Analyze(int a, int b, int c)
        {
            int A = a, B = b, C = c;
            
            if (A == B && B== C) 
            {
                Console.WriteLine("This is an Equilateral Triangle.");
                
            }
            else if (A == B || A == C || B == C)
            {
              
                Console.WriteLine("This is an Isoceles Triangle.");
            }
            else 
            {
              
                Console.WriteLine("This is an Scalene Triangle.");
            }
       
        }

    }
}
