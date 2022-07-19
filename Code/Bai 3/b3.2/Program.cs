using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3._2
{
    internal class Program
    {
        static void inputArr(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
        }

        static void showArr(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        static void request(int[] arr, int n)
        {
            int[] arrChan = new int[50];
            int[] arrLe = new int[50];

            int a = 0, b = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrChan[a] = arr[i];
                    a++;

                }
                else
                {
                    arrLe[b] = arr[i];
                    b++;
                }
            }
            Console.WriteLine("Mang so chan: ");
            showArr(arrChan, a);

            Console.WriteLine("Mang so le: ");
            showArr(arrLe, b);


        }

        static void Main(string[] args)
        {
            int[] arr = new int[50];
            Console.Write("Nhap vao so luong phan tu mang: ");
            int n = Convert.ToInt16(Console.ReadLine());

            inputArr(arr, n);

            showArr(arr, n);

            request(arr, n);

        }
    }
}
