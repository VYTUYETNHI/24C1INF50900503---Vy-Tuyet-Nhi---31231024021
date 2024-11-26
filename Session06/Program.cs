using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Session_06
    {
        /// <summary>
        /// 1. Khai báo mảng với n phần tử, n nhập từ bàn phím
        /// 1.1 Enter item values for this array
        /// 1.2 Print the array to screen
        /// 1.3 Write a function that increase each item of the array by adding it with 2.
        /// 1.4 Print to screen again
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            //nhap(a);
            generateRandomArray(a);
            InMang(a);

            Console.Write("\nNhap so can tim: ");
            int soCanTim = int.Parse(Console.ReadLine());
            int pos = timkiem_linear(a, soCanTim);
            if (pos == -1)
            {
                Console.WriteLine($"So {soCanTim} khong ton tai trong mang.");
            }
            else
            {
                Console.WriteLine($"So {soCanTim} xuat hien tai vi tri {pos + 1}");
            }
        }

        static void nhap(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i}");
                int v = int.Parse(Console.ReadLine());
                a[i] = v;

            }

        }

        static void generateRandomArray(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 100);

            }
        }

        static void InMang(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write($"{i}, ");
            }
        }
        /// <summary>
        /// Tim 1 so co trong mang hay khong
        /// </summary>
        /// <param name="a">la mang so nguyen</param>
        /// <param name="soCanTim">la so can tim trong mang</param>
        /// <returns><li>-1 neu khong tim thay</li>/returns>
        /// <li> vi tri xuat hien neu tim thây</li>
        /// </returns>

        static int timkiem_linear(int[] a, int soCanTim)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == soCanTim)
                    return i;
            }
            return -1;
        }
    }
}
