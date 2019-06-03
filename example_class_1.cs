using System;

namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;
        public int number;

        public void count()
        {
            num++;
            number++;
        }
        public int getNum()
        {
            return num;
        }
        public int getNumber()
        {
            return number;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();

            s1.count();
            s1.count();
            s1.count();

            s2.count();
            s2.count();
            s2.count();

            Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            Console.WriteLine("Variable num for s2: {0}", s2.getNum());
            Console.WriteLine("Variable number for s1: {0}", s1.getNumber());
            Console.WriteLine("Variable number for s2: {0}", s2.getNumber());

            StaticVar s3 = new StaticVar();
            s3.count();
            Console.WriteLine("Variable num for s2: {0}", s3.getNum());
            Console.WriteLine("Variable number for s3: {0}", s3.getNumber());
            Console.ReadKey();

        }
    }
}