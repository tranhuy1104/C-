using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class GeometricObject
    {
        protected string color;
        protected double weight;
        //ca truc mac dinh
        protected GeometricObject()
        {
            color = "white";
            weight = 1.0;
        }
        //xay dung 1 doi tuong hinh hoc
        protected GeometricObject(string color, double weight)
        {
            this.color = color;
            this.weight = weight;
        }
        //tinh chat
        public string PColor
        {
            get { return color; }
            set { color = value; }
        }
        public double PWeight
        {
            get { return weight; }
            set { weight = value; }
        }
        public abstract double findArea();
        public abstract double findPerimeter();
    }
}
