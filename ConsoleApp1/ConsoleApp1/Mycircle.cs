using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Mycircle
    {
        private Mypoint center;
        private int radius;
        public Mycircle(int x, int y, int radius)
        {
            center = new Mypoint(x, y);
            this.radius = radius;
        }
        public Mycircle(Mypoint center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public Mycircle()
        {
            center = new Mypoint(0,0);
            this.radius = 1;
        }
        public int getRadius()
        {
            return radius;
        }
        public void setRadius(int newRadius)
        {
            this.radius = newRadius;
        }
        public Mypoint getCenter()
        {
            return center;
        }
        public void setCenter(Mypoint newCenter)
        {
            this.center = newCenter;
        }
        public int getCenterX()
        {
            return center.getX();
        }
        public void setCenteX(int x)
        {
            center.setX(x);
        }
        public int getCenterY()
        {
            return center.getY();
        }
        public void setCenterY(int y)
        {
            center.setY(y);
        }
        public int[] getCenterXY()
        {
            int[] cexy = new int[2];
            cexy[0] = this.getCenterX();
            cexy[1] = this.getCenterY();
            return cexy;
        }
        public void setCenterXY(int x, int y)
        {
            setCenteX(x);
            setCenterY(y);
        }
        public override string ToString()
        {
            return string.Format("MyCircle[radius = {0},center = {1}", this.radius, this.center);
            //return base.ToString();
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public double getCircumference()
        {
            return radius * 2 * Math.PI;
        }
        public double distance(Mycircle point)
        {
            return center.distance(point.center);
        }
    }   
}
