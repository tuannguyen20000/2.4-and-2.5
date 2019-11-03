using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Mypoint
    {
        private int x;
        private int y;

        public Mypoint(int x, int y)
        {
            this.x = 0;
            this.y = 0;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int[] getXY()
        {
            int[] xy = new int[2];
            xy[0] = this.x;
            xy[1] = this.y;
            return xy;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1})", this.x, this.y);
            //return base.ToString();
        }
        public double distance(int x, int y)
        {
            int deltaX = this.x - x;
            int deltaY = this.y - y;
            return Math.Sqrt((deltaX) * (deltaX) + (deltaY) * (deltaY));
        }
        public double distance(Mypoint point)
        {
            return distance(point.x, point.y);
        }
        public double distance()
        {
            return distance(0, 0);
        }
    }
}

