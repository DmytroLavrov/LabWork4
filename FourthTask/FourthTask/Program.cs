using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class ApplicationLicense
    {
        bool Free { get; set; }
        bool Pro { get; set; }
        bool Trial { get; set; }
        string KeyFree { get; set; }
        string KeyPro { get; set; }
        string KeyTrial { get; set; }
        public ApplicationLicense(string Key)
        {
            this.KeyFree = "Free";
            this.KeyPro = "Pro";
            this.KeyTrial = "Trial";
            switch (Key)
            {
                case "Free":
                    this.CaseFree();
                    break;

                case "Pro":
                    this.CasePro();
                    break;

                case "Trial":
                    this.CaseTrial();
                    break;

                default:
                    this.CaseDefault();
                    break;
            }
        }
        void CaseFree()
        {
            this.Free = true;
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Ваш тип ліцензії ПО - Free (безкоштовний).");
        }
        void CaseTrial()
        {
            this.Trial = true;
            this.Free = false;
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Ваш тип ліцензії ПО - Trial (пробний).");
        }
        void CasePro()
        {
            this.Pro = true;
            this.Free = false;
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Ваш тип ліцензії ПО - Pro (професійний).");
        }
        void CaseDefault()
        {
            this.Free = true;
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Ліцензійний ключ - неправильний. Спробуйте ввести ще раз");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.Default;
                Console.Clear();
                Console.Write("Введіть ліцензійний ключ (англійською): ");
                string version = Console.ReadLine();
                ApplicationLicense applicationLicense = new ApplicationLicense(version);
                break;
            }
            Console.ReadKey();
        }
    }
}