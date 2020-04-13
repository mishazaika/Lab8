using System;
using System.Text;

namespace LaboratoryWork6_5_
{
    class Overload
    {
        private int a = 11;
        private int b = 12;
        private string s;
        public Overload()
        {
            Console.OutputEncoding = Encoding.UTF8;
        }
        public void SomeMethod()
        {
            Console.WriteLine("Сума: " + (a+b));
        }
        public void SomeMethod(int a)
        {
            this.a = a;
            Console.WriteLine("Збільшуємо на 1: " + (++a));
        }
        public void SomeMethod(string s)
        {
            this.s = s;
            Console.WriteLine("Ваше речення: " + s);
        }

        public double SomeMethod(int a, int b)
        {
            Console.WriteLine("Возвести першу числа у степінь:");
            double d = Math.Pow(a, b);
            return d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Overload ov = new Overload();
            ov.SomeMethod();
            ov.SomeMethod(11);
            ov.SomeMethod("Привіт");
            Console.WriteLine(ov.SomeMethod(2, 4));
        }
    }
}
