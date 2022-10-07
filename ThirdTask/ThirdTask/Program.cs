using System;
using System.Linq;
using System.Text;

namespace ThirdTask3
{
    class Smartphones
    {
        public int RAM { get; set; }
        public int Camera { get; set; }
        public void ShowPoperties()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine(GetType().Name);
            foreach (var propertyInfo in GetType().GetProperties())
            {
                Console.WriteLine($"{propertyInfo.Name}: {propertyInfo.PropertyType}");
            }
            Console.WriteLine();
        }
    }

    class Iphone : Smartphones
    {
        public bool GPS { get; set; }
    }

    class Xiaomi : Smartphones
    {
        public bool NFC { get; set; }
    }

    class Samsung : Smartphones
    {
        public bool IrDA { get; set; }
    }

    class OnePlus : Smartphones
    {
        public bool NanoSim { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Характеристики смартфонів:");
            Iphone iphone = new Iphone();
            Xiaomi xiaomi = new Xiaomi();
            Samsung samsung = new Samsung();
            OnePlus oneplus = new OnePlus();
            iphone.ShowPoperties();
            xiaomi.ShowPoperties();
            samsung.ShowPoperties();
            oneplus.ShowPoperties();
            Console.ReadKey();
        }
    }
}
