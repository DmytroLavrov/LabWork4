using System;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.Drawing;

namespace FirstTask
{
    class Showing : Outlet
    {
        Random random = new Random();
        public override void Show(params object[] points)
        {
            foreach (var point in points)
            {
                Console.OutputEncoding = System.Text.Encoding.Default;
                Console.ForegroundColor = (ConsoleColor)random.Next(0, 10);
                Console.WriteLine($"Тип елемента: {point.GetType()}");
                Console.WriteLine($"Вартість предмета: {point}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class Outlet
    {
        public virtual void Show(params object[] points)
        {
            foreach (var point in points)
            {
                Debug.WriteLine($"item: {point}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Outlet outlet = new Outlet();
            outlet.Show("A", 16, "Правда");
            Showing showing = new Showing();
            showing.Show("B", 47, "Неправда");
            Console.ReadKey();
        }
    }
}