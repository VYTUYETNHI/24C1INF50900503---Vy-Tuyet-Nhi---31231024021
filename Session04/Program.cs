using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Session_04
    {
        public static void Main(string[] args)
        {
            //Exercise_01();
            //Exercise_02();
            //Exercise_03();
            //Exercise_04();
            //Exercise_05();
            //Exercise_06();
            //Exercise_07a();
            //Exercise_07b();
            //Exercise_07c();
            //Exercise_10();
            GameDoanSo();

        }

        public static void Exercise_01()
        {
            Console.Write("Nhap mot so: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("So da nhap la so chan");
            else
                Console.WriteLine("So da nhap la so le");
        }

        public static void Exercise_02()
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            Console.WriteLine($"So lon nhat trong 3 so la {max}");
        }

        public static void Exercise_03()
        {
            Console.Write("Nhap toa do mot diem:\nx = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("Toa do thuoc phan tu thu nhat");
            else if (x < 0 && y > 0)
                Console.WriteLine("Toa do thuoc phan tu thu hai");
            else if (x < 0 && y < 0)
                Console.WriteLine("Toa do thuoc phan tu thu ba");
            else if (x > 0 && y < 0)
                Console.WriteLine("Toa do thuoc phan tu thu tu");
            else if (x == 0 && y == 0)
                Console.WriteLine("Toa do da cho la goc toa do");
            else
                Console.WriteLine("Toa do da cho nam tren truc toa do");
        }

        public static void Exercise_04()
        {
            Console.Write("Nhap canh a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            int c = int.Parse(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("Tam giac da cho la tam giac deu");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Tam giac da cho la tam giac can");
            }
            else
            {
                Console.WriteLine("Tam giac da cho la tam giac khong can");
            }
        }

        public static void Exercise_05()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhap so thu {i}: ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            double average = sum / 10.0;
            Console.WriteLine($"Tong 10 so la: {sum}");
            Console.WriteLine($"Trung binh 10 so la: {average}");
        }

        public static void Exercise_06()
        {
            Console.Write("Nhap so nguyen: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }

        public static void Exercise_07a()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void Exercise_07b()
        {
            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{num} ");
                    num++;
                }
                Console.WriteLine();
            }
        }
        public static void Exercise_07c()
        {
            int num = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }

        public static void Exercise_08()
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (double)1 / i;
                Console.Write($"1/{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua chuoi dieu hoa la: {sum}");
        }

        public static void Exercise_09()
        {
            Console.Write("Nhap khoang so bat dau: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Nhap khoang so ket thuc: ");
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            return sum == num;
        }

        public static void Exercise_10()
        {
            Console.Write("Nhap so can kiem tra: ");
            int num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
            {
                Console.WriteLine($"{num} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{num} khong phai la so nguyen to");
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        public static void GameDoanSo()
        {
            do
            {
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1;
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.Write("Ban doan so may? <1..10> ");
                    int user_num = int.Parse(Console.ReadLine());
                    if (user_num == comp_num)
                    {
                        Console.WriteLine($"Ban doan trung sau {count} lan.");
                        isContinue = false;
                    }
                    else
                    {
                        if (user_num > comp_num)
                            Console.WriteLine("So ban doan lon hon so may nghi.");
                        else
                            Console.WriteLine("So ban doan nho hon so may nghi.");
                    }

                }
                while (isContinue);

                Console.WriteLine("=====================================");
                Console.WriteLine("Choi nua khong? <C/K>");
                string traLoi = Console.ReadLine();
                if (traLoi.ToUpper().Equals("K"))
                {
                    Console.WriteLine("Thang ma cho go. Lan sau khong choi nua!");
                    return;
                }

            } while (true);
        }
    }
}
