/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_6_2
{
    public class Point
    {
        private double x, y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point()
        {

        }
        public Point(double X, double Y)
        {
            this.x = X;
            this.y = Y;
        }
        ~Point()
        {

        }

        public void InputPoint()
        {
            Console.Write("\nX: "); this.X = double.Parse(Console.ReadLine());
            Console.Write("Y: "); this.Y = double.Parse(Console.ReadLine());
        }

        public void OutputPoint()
        {
            Console.WriteLine("X: "+ this.X);
            Console.WriteLine("Y: "+ this.Y);
        }
    }

    public abstract class Shape
    {
        private Point p1 = new Point();
        private Point p2 = new Point();
        private double distance;

        public Point P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public Point P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        public Shape()
        {

        }
        public Shape(Point P1, Point P2)
        {
            this.p1 = P1;
            this.p2 = P2;
        }

        ~Shape()
        {

        }

        public virtual void Input()
        {
            Console.Write("\nP1: "); this.P1.InputPoint();
            Console.Write("P2: "); this.P2.InputPoint();
        }

        public abstract void Calculate();

        public virtual double lineCalculate()
        {
            distance = Math.Sqrt(Math.Pow((this.P2.X - this.P1.X),2) + Math.Pow((this.P2.Y - this.P1.Y), 2));
            return distance;
        }

        public virtual void Output()
        {
            Console.WriteLine("OUtput");
            this.P1.OutputPoint();
            this.P2.OutputPoint();
        }
    }

    public class LINE : Shape
    {
        private double lineDistance;
        public double LineDistance
        {
            get { return this.lineDistance; }
        }
        public LINE() : base()
        { 

        }

        ~LINE()
        { 
        
        }

        public override void Input()
        {
            Console.WriteLine("Line");
            Console.Write("Input location of line: ");
            base.Input();
        }

        public override void Calculate()
        {
            this.lineDistance = lineCalculate();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("The distance of line: " + this.lineDistance);
        }
    }

    public class RECTANGLE : Shape
    {
        private double length, width, area;

        public double Length
        {
            get { return length; }
            set { this.length = value; }
        }
        public double Width
        {
            get { return width; }
            set { this.width = value; }
        }
        public double Area
        {
            get { return this.area; }
        }
        public RECTANGLE()
        { }

        ~RECTANGLE()
        { }

        public RECTANGLE(double Length, double Width) : base()
        {
            this.length = Length;
            this.width = Width;
        }

        public override void Input()
        {
            Console.WriteLine("RectAngle");
            this.InputLength();
            this.InputWidth();
        }

        public void InputLength()
        {
            Console.Write("Input location of length: ");
            base.Input();           
            length = lineCalculate();
        }

        public void InputWidth()
        {
            Console.Write("Input location of width: ");
            base.Input();            
            width = lineCalculate();
        }

        public override void Calculate()
        {
            this.area = this.length * this.width;
        }

        public override void Output()
        {
            base.Output();
            Calculate();
            Console.WriteLine("Length of rectangle: " + this.length);
            Console.WriteLine("Width of rectangle: " + this.width);
            Console.WriteLine("Area of rectangle: " + this.area);
        }
    }

    public class TRIANGLE : Shape
    {
        private double bottomEdge, height, area;

        public double BottomEdge
        {
            get { return bottomEdge; }
            set { this.bottomEdge = value; }
        }
        public double Height
        {
            get { return height; }
            set { this.height = value; }
        }
        public double Area
        {
            get { return this.area; }
        }
        public TRIANGLE()
        { }

        ~TRIANGLE()
        { }

        public TRIANGLE(double BottomEdge, double Height) : base()
        {
            this.bottomEdge = BottomEdge;
            this.height = Height;
        }

        public override void Input()
        {
            Console.WriteLine("TriAngle");
            this.InputLength();
            this.InputWidth();
        }

        public void InputLength()
        {
            Console.Write("Input location of bottom Edge: ");
            base.Input();            
            bottomEdge = lineCalculate();
        }

        public void InputWidth()
        {
            Console.Write("Input location of height: ");
            base.Input();
            height = lineCalculate();
        }

        public override void Calculate()
        {
            this.area = this.bottomEdge * this.height;
        }

        public override void Output()
        {
            base.Output();
            Calculate();
            Console.WriteLine("Bottom Edge of triangle: " + this.bottomEdge);
            Console.WriteLine("Height of triangle: " + this.height);
            Console.WriteLine("Area of triangle: " + this.area);
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            LINE h1 = new LINE();
            RECTANGLE h2 = new RECTANGLE();
            TRIANGLE h3 = new TRIANGLE();

            List<Shape> lHinh = new List<Shape>();
            lHinh.Add(h1);
            lHinh.Add(h2);
            lHinh.Add(h3);

            foreach (Shape h in lHinh)
            {
                h.Input();
                h.Calculate();
                h.Output();
            }
        }
    }
}
*/