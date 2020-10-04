using System;
namespace classt
{
    class triangle
    {
        static void Main(string[] args)
        {
            TTriangle ex = new TTriangle(5, 5, 5);
            Console.WriteLine("1 сторона: " + ex.SideA);
            Console.WriteLine("2 сторона: " + ex.SideB);
            Console.WriteLine("3 сторона: " + ex.SideC);
            Console.WriteLine("Ваш периметр: " + ex.P());
            Console.WriteLine("Ваша площа: " + ex.S());
            Console.ReadKey();
        }
    }

    class TTriangle
    {
        protected double a;
        protected double b;
        protected double c;
        public TTriangle() { }

        public TTriangle(double a, double b, double c)
        {

            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool Exist()
        {
            if (((a + b > c) && (b + c > a) && (c + a > b)) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SideA
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double SideB
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public double SideC
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }


        }
        public double P()
        {
            return (a + b + c);
        }
        public double S()
        {
            return (a + b + c) / 2;
        }
    }
}
