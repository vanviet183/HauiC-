using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6._1
{
    internal class Program
    {
        static void getStudents(List<Student> listStudent)
        {
            foreach (Student student in listStudent)
            {
                student.Output();
            }
        }

        static void getStudentById(List<Student> listStudent, int id)
        {
            int cnt = 0;
            foreach (Student student in listStudent)
            {
                if (student.id == id)
                {
                    cnt++;
                    student.Output();
                }
            }
            if (cnt == 0)
                Console.WriteLine("Id invalid");
        }

        static void getStudenthByAddress(List<Student> listStudents, string address)
        {
            int cnt = 0;

            foreach (Student student in listStudents)
            {
                if (student.address.Equals(address))
                {
                    cnt++;
                    student.Output();
                }
            }
            if (cnt == 0)
                Console.WriteLine("Không tồn tại student ở: " + address);
        }

        static void deleteStudentById(List<Student> listStudent, int id)
        {
            int cnt = 0;
            foreach (Student student in listStudent)
            {
                if (student.id == id)
                {
                    cnt++;
                }
            }
            if (cnt > 0)
            {
                listStudent.RemoveAt(0);
                Console.WriteLine("\tDelete success");
            }
            else
                Console.WriteLine("Id invalid");
        }

        static void showTitle()
        {
            Console.WriteLine("\t\tTHÔNG TIN DANH SÁCH STUDENT");
            Console.WriteLine($"{"Id",10}" + $"{"Name",10}" + $"{"Address",10}" + $"{"Math",10}" + $"{"Physics",10}" + $"{"Total",10}");
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> listStudent = new List<Student>();

            do
            {
                Console.WriteLine("1. Nhập 1 student");
                Console.WriteLine("2. Hiển thị danh sách student");
                Console.WriteLine("3. Hiển thị student theo id");
                Console.WriteLine("4. Hiển thị thí sinh theo địa chỉ");
                Console.WriteLine("5. Xóa student theo id");
                Console.WriteLine("6. Exit");

                Console.Write("Nhập lựa chọn: ");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Student student = new Student();
                        student.Input();
                        listStudent.Add(student);
                        break;

                    case 2:
                        showTitle();
                        getStudents(listStudent);
                        break;

                    case 3:
                        Console.Write("Nhập id student cần tìm: ");
                        int id = int.Parse(Console.ReadLine());

                        showTitle();
                        getStudentById(listStudent, id);
                        break;

                    case 4:
                        Console.Write("Nhập địa chỉ cần tìm: ");
                        String address = Console.ReadLine();

                        showTitle();
                        getStudenthByAddress(listStudent, address);
                        break;

                    case 5:
                        Console.Write("Nhập id student cần xóa: ");
                        int idInput = int.Parse(Console.ReadLine());

                        deleteStudentById(listStudent, idInput);
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }

            } while (true);
        }
    }
}