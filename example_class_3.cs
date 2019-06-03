using System;

namespace InheritanceApplication
{
    class Shape
    {
        public void setSide(int a)
        {
            side = a;
        }
        public void setHeight(int h)
        {
            height = h;
        }

        public void setSide1(int b)
        {
            side1 = b;
        }

        protected int side;
        protected int height;
        protected int side1;

    }

    // Derived class
    class Rectangle : Shape
    {
        public int getArea()
        {
            return  (((side+side1)*height) /2);
        }
    }
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setSide(5);
            Rect.setSide1(6);
            Rect.setHeight(4);

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}
