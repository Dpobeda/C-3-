/*using Project1;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Class123
    {
        public virtual void C123()
        {
            Console.WriteLine("123");
        }
    }

    class Class12 : Class123
    {
        public override void C123()
        {
            Console.WriteLine("12");
        }
    }

    partial class Program
    {
        static void Main(string[] args)
        {

        }
    }
}


namespace Project1
{
        class MyClass
        {
            int num { get; set; }

        }

        class MyClass2 : MyClass
        {

        }

        abstract class Abs
        {
            public virtual void AD()
            {
                Console.WriteLine("Hello");
            }

            public abstract void ADS();
        }
        class Abs2 : Abs
        {
            public override void ADS()
            {

            }
            public override void AD()
            {
                base.AD(); //
            }

            public static int operator +(Abs2 a, Abs2 b)
            {
                int asd = 1;
                return asd;
            }
        }

        sealed class ClasS2 // Не хотим чтобы от этого класса что-то следовалась.
        {

        }

}
*/
using System.Data.Common;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Matrix
{
    class Matrix
    {
        int y;
        int z;
        int[,] arr;

        public Matrix(int y, int z)
        {
            this.y = y;
            this.z = z;
            arr = new int[y, z];
            return;
        }

        public void Matrix1()
        {
            Random rnd = new Random();
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                }

            }

        }
        public void Matrix2()
        {
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }

        public static Matrix operator +(Matrix z, Matrix y)
        {
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    z[i, j] + y[i, j];
                }
            }
        }

        public void Matrix3()
        {
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Z");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите Y");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("\nМатрица 1:");
            Matrix A = new Matrix(z, y);
            A.Matrix1();
            A.Matrix2();

            Console.WriteLine("\nМатрица 2:");
            Matrix B = new Matrix(z, y);
            B.Matrix1();
            B.Matrix2();

            Console.WriteLine("\nМатрица 3:");
            Matrix ab = new Matrix(z, y);
            ab.Matrix3();
            Console.WriteLine(A + B);
        }
     
    }
}
