using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleApp
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            int A = a, B = b, C = c;
            string triangle;
            
            if (A == B && B== C) 
            {
                triangle = "This is an Equilateral Triangle";
                Console.WriteLine(triangle);
            }
            else if (A == B || A == C || B == C)
            {
                triangle = "This is an Isoceles Triangle";
                Console.WriteLine(triangle);
            }
            else 
            {
                triangle = "This is an Scalene Triangle";
                Console.WriteLine(triangle);
            }
            return triangle;
        }
        
    }
}









//public bool Analyze(int a, int b, int c)
//{
//    int A = a, B = b, C = c;

//    if (A == B && B == C)
//    {
//        Console.WriteLine("This is an Equilateral Triangle.");
//        return true;
//    }
//    else if (A == B || A == C || B == C)
//    {

//        Console.WriteLine("This is an Isoceles Triangle.");
//        return true;
//    }
//    else
//    {

//        Console.WriteLine("This is a Scalene Triangle.");
//        return true;
//    }

//}



