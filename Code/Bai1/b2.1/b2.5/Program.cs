using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._5
{
    internal class Program
    {
        /*Thêm vào Solution đã tạo ở Bài tập 1 project mới có tên là HeCoSo. Thiết lập nó 
        là project mặc định.
        Viết chương trình cho phép chuyển đổi hệ cơ số bằng ngôn ngữ C#:
        Khoa Công nghệ thông tin – Trường Đại học công nghiệp Hà nội
        Trang 2
        1. Chuyển đổi số nguyên N từ hệ cơ số 10 sang hệ cơ số B bất kỳ.
        2. Chuyển đổi một số N từ hệ cơ số B bất kỳ sang hệ cơ số 10.
        Trong đó N, B nhập vào từ bàn phím.
         */

        static int convertNumber(int n, int b)
        {
            if (n < 0 || b < 2 || b > 16)
            {
                Console.WriteLine("He co so hoac gia tri chuyen doi khong hop le!");
                return 0;
            }
            int i;
            char[] arr = new char[20];
            int count = 0;
            int m;
            int remainder = n;
            while (remainder > 0)
            {
                if (b > 10)
                {
                    m = remainder % b;
                    if (m >= 10)
                    {
                        arr[count] = (char)(m + 55);
                        count++;
                    }
                    else
                    {
                        arr[count] = (char)(m + 48);
                        count++;
                    }
                }
                else
                {
                    arr[count] = (char)((remainder % b) + 48);
                    count++;
                }
                remainder = remainder / b;
            }
            // hien thi he co so
            for (i = count - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            return 1;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Nhap co so 10: ");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.Write("Nhap he co so muon chuyen: ");
            int b = Convert.ToInt16(Console.ReadLine());

            
            Console.Write(n + " = ");

            convertNumber(n, b);

        }
    }
}
