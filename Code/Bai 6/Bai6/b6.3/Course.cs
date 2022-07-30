using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6._3
{
    internal class Course
    {
        public string courseId { get; set; }
        public string courseName { get; set; }
        public double fee { get; set; }
        public List<Student> students { get; set; }

        public Course()
        {
            students = new List<Student>();
        }

        public void InputCourse()
        {
            Console.Write("Enter course id: ");
            courseId = Console.ReadLine();

            Console.Write("Enter course name: ");
            courseName = Console.ReadLine();

            Console.Write("Enter course fee: ");
            fee = double.Parse(Console.ReadLine());

            Console.Write("Enter amount student: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                student.InputStudent();
                students.Add(student);
            }

        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void DisplayCourseAndStudents()
        {
            Console.WriteLine("Course id: " + courseId);
            Console.WriteLine("Course name: " + courseName);
            Console.WriteLine("Course fee: " + fee);
            Console.WriteLine("List Student Of Course");
            foreach(Student student in students)
            {
                student.ToString();
            }
        }

    }
}
