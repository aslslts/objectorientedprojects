using System;

namespace RectangleApplication
{
    class Arsa
    {

        //member variables
        protected double length;
        protected double width;

        public Arsa(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle  
    class Arsacost : Arsa
    {
        private double cost;
        public Arsacost(double l, double w) : base(l, w) { }

        public double PriceofArsa()
        {
            return (cost/6.33) * GetArea();
        }

        public void setCost(double c)
        {
            cost = c;
        }

        public double getCost()
        {
            return cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("The price of 1 sq m: {0}", cost);
            Console.WriteLine("Cost: {0}", PriceofArsa());
        }


    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Arsacost t = new Arsacost(3000, 20, 15);

            t.Display();

            t.setCost(6000);
            t.Display();


            Console.ReadLine();
        }
    }
}