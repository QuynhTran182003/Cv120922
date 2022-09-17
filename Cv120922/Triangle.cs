using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv120922
{
    internal class Triangle
    {
        private int a;
        private int b;
        private int c;

        public Triangle(int a, int b, int c)
        {
            if (TriangleInequality(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("Cannot create triangle due to unavailable value of sides.");
            }
            
        }

        public int A
        {
            get { return a; }
            set
            {
                if(a < 0)
                {
                    throw new Exception("Side must not be smaller than 0.");
                }
            }
        }

        public int B { 
            get { return b; }
            set
            {
                if (b < 0)
                {
                    throw new Exception("Side must not be smaller than 0");
                }
            }
        }

        public int C
        {
            get { return c; }
            set
            {
                if (c < 0)
                {
                    throw new Exception("Side must not be smaller than 0");
                }

            }
        }

        //check triangle inequality
        public bool TriangleInequality(int a, int b, int c)
        {
            bool res = false;
            if (a < b + c && b < a + c && c < a + b)
            {
                res = true;
            }
            return res;
        }

        //check equilateral triangle
            // todo
        //check isosceles triangle
            // todo
        //check rightangled triangle
            // todo
        public override string ToString()
        {
            return "Triangle " + this.a + ", " + this.b + ", " + this.c;
        }
    }
}
