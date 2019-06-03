using System;

namespace BoxApplication
{
    class Box
    {
        private double length;   // Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box

        public Box() { } //default constructor;

        public Box(double l, double b, double h)
        {
            length = l;
            breadth = b;
            height = h;
        }

        public double getLength()
        {
            return length;
        }

        public double getBreadth()
        {
            return breadth;
        }

        public double getHeight()
        {
            return height;
        }

        public void setLength(double l)
        {
            length = l;
        }

        public void setBreadth(double b)
        {
            breadth = b;
        }

        public void setHeight(double h)
        {
            height = h;
        }


    } // end class 

    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box(5,5,7);   // Declare Box1 of type Box
           
            double volume = 0.0;    // Store the volume of a box here

            // volume of box 1
            volume = Box1.getHeight() * Box1.getLength() * Box1.getBreadth();
            Console.WriteLine("Volume of Box1 : {0}", volume);


            //update the height

            Box1.setHeight(10);
            volume = Box1.getHeight() * Box1.getLength() * Box1.getBreadth();
            Console.WriteLine("Update the volume of Box1 : {0}", volume);

            Console.ReadKey();
        }
    }
}
