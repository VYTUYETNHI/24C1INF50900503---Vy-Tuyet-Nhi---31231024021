public class Session_02
{
    public static void Main()
    {
        //Question_01();
        //Question_02();
        //Question_03();
        //Question_04();
        //Question_05();
        //Question_06();
        //Question_07();
        //Question_08();
        //Question_09();
        Question_10();

        Console.ReadKey();
    }

    public static void Question_01()
    {
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        //Console.WriteLine(a + " + " + b + "= " + c);
        //Console.WriteLine("{0} + {1} = {2}", a,b,c);
        Console.WriteLine($"{a} + {b} = {c}");
    }

    public static void Question_02()
    {
        int a, b, temp;
        Console.Write("Nhap so a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        b = int.Parse(Console.ReadLine());
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Sau khi doi cho: ");
        Console.WriteLine("So a: " + a);
        Console.WriteLine("So b: " + b);

        Console.Read();
    }

    public static void Question_03()
    {
        float a, b, ketqua;
        Console.Write("Nhap so dau phay dong a: ");
        a = float.Parse(Console.ReadLine());
        Console.Write("Nhap so dau phay dong b: ");
        b = float.Parse(Console.ReadLine());
        ketqua = a * b;
        Console.WriteLine("Ket qua nhan 2 so: " + ketqua);

    }

    public static void Question_04()
    {
        double feet, meters;
        Console.Write("Nhap so feet: ");
        feet = Convert.ToDouble(Console.ReadLine());
        meters = feet * 0.3048;
        Console.WriteLine(feet + " feet bang " + meters + " meters.");

    }

    public static void Question_05()
    {
        double c, f;
        Console.Write("Nhap so do Celsius: ");
        c = Convert.ToDouble(Console.ReadLine());
        f = (c * 9 / 5) + 32;
        Console.WriteLine(c + "°C bang " + f + "°F.");
        Console.Write("Nhap so do Fahrenheit: ");
        f = Convert.ToDouble(Console.ReadLine());
        c = (f - 32) * 5 / 9;
        Console.WriteLine(f + "°F bang " + c + "°C.");

    }

    public static void Question_06()
    {
        Console.WriteLine("Kich thuoc cua  int: " + sizeof(int) + " bytes");
        Console.WriteLine("Kich thuoc cua float: " + sizeof(float) + " bytes");
        Console.WriteLine("Kich thuoc cua double: " + sizeof(double) + " bytes");
        Console.WriteLine("Kich thuoc cua char: " + sizeof(char) + " bytes");
        Console.WriteLine("Kich thuoc cua bool: " + sizeof(bool) + " bytes");
    }

    public static void Question_07()
    {
        Console.Write("Nhap mot ki tu: ");
        char kitu = Convert.ToChar(Console.ReadLine());
        int Maascii = (int)kitu;
        Console.WriteLine("Ma ASCII cua " + kitu + " la: " + Maascii);
    }

    public static void Question_08()
    {
        const double PI = 3.14159;
        double bankinh, dientich;
        Console.Write("Nhap ban kinh hinh tron: ");
        bankinh = Convert.ToDouble(Console.ReadLine());
        dientich = PI * bankinh * bankinh;
        Console.WriteLine("Dien tich hinh tron la: " + dientich);
    }

    public static void Question_09()
    {
        double canh, dientich;
        Console.Write("Nhap canh hinh vuong: ");
        canh = Convert.ToDouble(Console.ReadLine());
        dientich = canh * canh;
        Console.WriteLine("Dien tich hinh vuong la: " + dientich);
    }

    public static void Question_10()
    {
        Console.Write("Nhap so ngay can tinh: ");
        int days = int.Parse(Console.ReadLine());
        int year = days / 365;
        int week = (days - year * 365) / 7;
        int day = (days - year * 365) % 7;

        Console.WriteLine($"{days} ngay = {year} nam, {week} tuan, {day} ngay");
    }
}

