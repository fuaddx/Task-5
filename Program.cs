namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle -> " + Area(8));
            Console.WriteLine("Rectangle -> " + Area(8,2));
            Console.WriteLine("Parallelepiped -> " + Area(8,2,3));
            Console.WriteLine("Triangle -> " + Area(8,2,3,5));
        }



        public static int Area(int r)
        {
            int P = 3;
            return P * r * r;
        }
        public static int Area(int a, int b)
        {
            return a * b;
        }
        public static int Area(int a, int b, int c)
        {
            return 2*(a*b + a*c + b*c);
        }
        public static float Area(int a, int b, int c,int r)
        {
            float p = (a+b+c)/2f;
            return p * r;
        }
    }
}