using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Session_03
    {
        public static void Main(string[] args)
        {
            //Exercise_01();
            //Exercise_02();
            Exercise_03();
        }

        public static void Exercise_01()
        {
            Console.Write("Nhap so do Celcius: ");

            int celcius = int.Parse(Console.ReadLine());

            int kelvin = celcius + 273;
            Console.WriteLine($"kelvin= {kelvin}");

            int fahrenheit = celcius * 18 / 10 + 32;
            Console.WriteLine($"fahrenheit= {fahrenheit}");

        }

        public static void Exercise_02()
        {
            double pi = Math.PI;
            Console.Write("Nhap ban kinh: ");
            string input = Console.ReadLine();
            double radius;

            if (double.TryParse(input, out radius) && radius > 0)
            {
                double surface = 4 * pi * radius * radius;
                double volume = 4 / 3 * pi * radius * radius * radius;

                Console.WriteLine($"Surface: {surface}");
                Console.WriteLine($"Volume: {volume}");
            }
            else
            {
                Console.WriteLine("Ban kinh phai lon hon 0.");
            }

        }

        public static void Exercise_03()
        {
            Console.Write("Nhap so a: ");
            string so_a = Console.ReadLine();
            Console.Write("Nhap so b: ");
            string so_b = Console.ReadLine();

            int a, b;

            if (int.TryParse(so_a, out a) && int.TryParse(so_b, out b))
            {
                int tong = a + b;
                int hieu = a - b;
                int tich = a * b;

                if (b != 0)
                {
                    int thuong = a / b;
                    int soDu = a % b;
                    Console.WriteLine($"{a} + {b} = {tong}");
                    Console.WriteLine($"{a} - {b} = {hieu}");
                    Console.WriteLine($"{a} x {b} = {tich}");
                    Console.WriteLine($"{a} / {b} = {thuong}");
                    Console.WriteLine($"{a} mod {b} = {soDu}");
                }

                else
                {
                    Console.WriteLine("Khong the chia cho 0");
                }
            }

            else
            {
                Console.WriteLine("Gia tri nhap khong hop le.");
            }

        }
    }
}