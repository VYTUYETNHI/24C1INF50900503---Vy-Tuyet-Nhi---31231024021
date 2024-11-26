using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class Session_07
    {
        static void Main()
        {
            // Nhập chuỗi từ người dùng
            Console.Write("Nhap mot chuoi: ");
            string input = Console.ReadLine();

            // 1. In ra chuỗi
            Console.WriteLine("Chuoi da nhap: " + input);

            // 2. Tính độ dài chuỗi mà không sử dụng hàm thư viện
            int length = 0;
            foreach (char c in input)
            {
                length++;
            }
            Console.WriteLine("Do dai cua chuoi: " + length);

            // 3. Tách các ký tự riêng lẻ
            Console.WriteLine("Cac ky tu trong chuoi:");
            foreach (char c in input)
            {
                Console.WriteLine(c);
            }

            // 4. In các ký tự của chuỗi theo thứ tự ngược lại
            Console.WriteLine("Cac ky tu theo thu tu nguoc lai:");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();

            // 5. Đếm số từ trong chuỗi
            int wordCount = 0;
            bool isInWord = false;
            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    isInWord = false;
                }
                else if (!isInWord)
                {
                    isInWord = true;
                    wordCount++;
                }
            }
            Console.WriteLine("So tu trong chuoi: " + wordCount);

            // 6. So sánh hai chuỗi mà không dùng thư viện
            Console.Write("Nhap chuoi thu hai de so sanh: ");
            string secondInput = Console.ReadLine();
            bool areEqual = true;
            if (input.Length != secondInput.Length)
            {
                areEqual = false;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != secondInput[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            Console.WriteLine("Hai chuoi " + (areEqual ? "bang nhau" : "khac nhau"));

            // 7. Đếm số chữ cái, chữ số và ký tự đặc biệt trong chuỗi
            int letters = 0, digits = 0, specials = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                    letters++;
                else if (char.IsDigit(c))
                    digits++;
                else
                    specials++;
            }
            Console.WriteLine($"So chu cai: {letters}, So chu so: {digits}, Ky tu dac biet: {specials}");

            // 8. Đếm số nguyên âm và phụ âm
            int vowels = 0, consonants = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c))
                    vowels++;
                else if (char.IsLetter(c))
                    consonants++;
            }
            Console.WriteLine($"So nguyen am: {vowels}, So phu am: {consonants}");

            // 9. Kiểm tra xem một chuỗi con có xuất hiện trong chuỗi hay không
            Console.Write("Nhap chuoi con: ");
            string substring = Console.ReadLine();
            bool containsSubstring = input.Contains(substring);
            Console.WriteLine("Chuoi con \"" + substring + "\" " + (containsSubstring ? "co" : "khong co") + " trong chuoi.");

            // 10. Tìm vị trí của chuỗi con trong chuỗi
            int index = input.IndexOf(substring);
            Console.WriteLine($"Vi tri cua chuoi con \"{substring}\" trong chuoi la: {index}");

            // 11. Kiểm tra xem một ký tự có phải là chữ cái hay không và kiểm tra chữ hoa/chữ thường
            Console.Write("Nhap mot ky tu de kiem tra: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(character))
            {
                if (char.IsUpper(character))
                    Console.WriteLine($"Ky tu '{character}' la chu cai viet hoa.");
                else
                    Console.WriteLine($"Ky tu '{character}' la chu cai viet thuong.");
            }
            else
            {
                Console.WriteLine($"Ky tu '{character}' khong phai la chu cai.");
            }

            // 12. Tìm số lần xuất hiện của chuỗi con trong chuỗi
            int countSubstring = 0;
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                if (input.Substring(i, substring.Length) == substring)
                {
                    countSubstring++;
                }
            }
            Console.WriteLine($"Chuoi con \"{substring}\" xuat hien {countSubstring} lan trong chuoi.");

            // 13. Chèn một chuỗi con trước lần xuất hiện đầu tiên của chuỗi con trong chuỗi
            Console.Write("Nhap chuoi con de chen vao: ");
            string insertBefore = Console.ReadLine();
            Console.Write("Nhap chuoi ban muon chen: ");
            string toInsert = Console.ReadLine();

            int insertIndex = input.IndexOf(insertBefore);
            if (insertIndex != -1)
            {
                string result = input.Substring(0, insertIndex) + toInsert + input.Substring(insertIndex);
                Console.WriteLine("Chuoi sau khi chen: " + result);
            }
            else
            {
                Console.WriteLine($"Khong tim thay chuoi con \"{insertBefore}\" trong chuoi.");
            }
        }
    }

}