using System;


namespace HomeWorkC
{
    public interface shape
    {

        public double getMeasure();
        public void set();

    }

    class triangle : shape
    {
        private int a, b, c;//三角形的三边

        public triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void set()
        {
            while (true)
            {
                Console.WriteLine("请输入三角形三边长");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                int c = Int32.Parse(Console.ReadLine());
                this.a = a;
                this.b = b;
                this.c = c;
                if (a + b > c && a + c > b && b + c > a && a - b < c && a - c < b && b - c < a)
                    break;
                else
                    Console.WriteLine("请重新输入");
            }
            
        }

        public  bool isTriangle()
        {
            if (a + b > c && a + c > b && b + c > a && a - b < c && a - c < b && b - c < a)
            {
                Console.WriteLine("三角形合法");
                return true;
            }
            else
            {
                Console.WriteLine("三角形不合法");
                return false;
            }

        }

        public double getMeasure()
        {
            double area = 0;
            if (isTriangle())
            {
                double p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return area;
        }
    }

    class rectangle : shape
    {
        private int a, b;

        public rectangle()
        {
            a = 0;
            b = 0;
        }

        public rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double getMeasure()
        {
            return a * b;
        }
        public void set()
        {
            Console.WriteLine("请输入长方形两边长");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            this.a = a;
            this.b = b;
        }

    }

    class square : shape
    {
        private int a;

        public square()
        {
            a = 0;
        }
        public square(int a)
        {
            this.a = a;
        }


        public double getMeasure()
        {
            return a * a;
        }
        public void set()
        {
            Console.WriteLine("请输入正方形边长");
            int b = Int32.Parse(Console.ReadLine());
            this.a = b;
        }
    }
}

