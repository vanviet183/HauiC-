using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6._3
{
    internal class Program
    {
        public static void showCourses(List<Course> courses)
        {
            foreach(Course course in courses)
            {
                course.DisplayCourseAndStudents();
            }
        }

        public static void searchCourseById(List<Course> courses, String courseId)
        {
            int cnt = 0;
                foreach (Course course in courses)
                {
                    if (course.courseId == courseId)
                    {
                        cnt++;
                        course.DisplayCourseAndStudents();
                    }
                }
            if(cnt == 0)
            {
                Console.WriteLine("Invalid course with id: " + courseId);
            }
        }

        public static void searchStudentById(List<Course> courses, int studentId)
        {
            int cnt = 0;
                foreach (Course course in courses)
                {
                    List<Student> students = course.GetStudents();
                    foreach (Student student in students)
                    {
                        if(student.studentId == studentId)
                        {
                            cnt++;
                            student.ToString();
                        }
                    }
                }
            if(cnt == 0)
            {
                Console.WriteLine("Khong tn tai student co id = " + studentId);
            }
        }

        public static void deleteCourseById(List<Course> courses, String courseDel)
        {
            int cnt = 0;
            foreach (Course course in courses)
            {
                if (course.courseId == courseDel)
                {
                    courses.Remove(course);
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine("Invalid course with id: " + courseDel);
            }
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            List<Course> courses = new List<Course>();

            int choose;
            do
            {
                Console.WriteLine("1. Them 1 khoa hoc");
                Console.WriteLine("2. Hien thi cac khoa hoc");
                Console.WriteLine("3. Tim kiem khoa hoc");
                Console.WriteLine("4. Tim kiem sinh vien");
                Console.WriteLine("5. Xoa 1 khoa hoc");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.Write("Enter select: ");
                choose = int.Parse(Console.ReadLine());
                
                switch(choose)
                {
                    case 1: 
                        Course course = new Course();
                        Console.WriteLine("Enter information course: ");
                        course.InputCourse();
                        courses.Add(course);
                        break;

                    case 2: 
                        Console.WriteLine("List Information Course");
                        showCourses(courses);
                        break;

                    case 3: 
                        Console.Write("Enter id course want to search: ");
                        string courseId = Console.ReadLine();
                        searchCourseById(courses, courseId);
                        break;

                    case 4:
                        Console.Write("Enter id studendt want to search: ");
                        int studentId = int.Parse(Console.ReadLine());
                        searchStudentById(courses, studentId);
                        break;

                    case 5:
                        Console.Write("Enter id course want to search: ");
                        string courseDel = Console.ReadLine();
                        deleteCourseById(courses, courseDel);
                        break;

                    case 6:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                }
            } while (true);
        }
    }
}
