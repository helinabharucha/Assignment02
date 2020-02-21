using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    
    public static class TriangleSolver
    {
        
        public static string triangle;

        public static String Analyze(int s1, int s2, int s3)
        {
            if (((s1 + s2) > s3) && ((s1 + s3) > s2) && ((s2 + s3) > s1))
            {
                if (s1 == s2 && s2 == s3 && s3 == s1)
                {
                    triangle = "Triangle is Equilateral Triangle";
                }
                else if (s1 == s2 || s2 == s3 || s1 == s2)
                {
                    triangle = "Triangle is isosceles";
                }
                else
                {
                    triangle = "Triangle is Scalene Triangle";
                }
            }


            else
            {
                triangle = "Sorry the sides do not form a triangle";
            }
            return triangle;

        }
    }
}
