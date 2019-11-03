using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Mytriangle
    {
        private Mypoint v1;
        private Mypoint v2;
        private Mypoint v3;

        public Mytriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            v1 = new Mypoint(x1, y1);
            v2 = new Mypoint(x2, y2);
            v3 = new Mypoint(x3, y3);
        }
        public Mytriangle(Mypoint v1, Mypoint v2, Mypoint v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
        public override string ToString()
        {
            return string.Format("MyTriangle[v1={0},v2={1},v3={2}]", this.v1, this.v2, this.v3);
            //return base.ToString();
        }
        public double getPerimeter()
        {
            return v1.distance() + v2.distance() + v3.distance();
        }
        public string getType()
        {
            string result = "";
            if (v1.distance(v2) == v2.distance(v3) && v1.distance(v2) == v1.distance(v3) && v1.distance(v3) == v2.distance(v3))
                result = "equilateral";
            else if (v1.distance(v2) == v2.distance(v3) || v1.distance(v2) == v1.distance(v3) || v1.distance(v3) == v2.distance(v3))
                    result = "isosceles";
            else if (v1.distance(v2) != v2.distance(v3) && v1.distance(v2) != v1.distance(v3) && v1.distance(v3) != v2.distance(v3))
                    result = "scalene";
            return result;

        }
    }   
}