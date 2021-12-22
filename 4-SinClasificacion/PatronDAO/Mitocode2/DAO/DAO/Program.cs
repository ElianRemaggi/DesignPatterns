using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentDao Students = new StudentDaoImpl();


            Student a = new Student();
            a.Name = "Elian";
            a.Id = 0;

            Students.addStudent(a);

            Student b = new Student();
            b.Name = "Homero el mero mero";
            b.Id = 1;

            Students.addStudent(b);

            Student c = new Student();
            c.Name = "YSY A";
            c.Id = 2;

            Students.addStudent(c);

            foreach (var p in Students.getAllStudents())
            {
                Console.WriteLine(p.Id + " " + p.Name);
            }

            Console.WriteLine("---------------------");
            Students.deleteStudent(a);

            foreach (var p in Students.getAllStudents())
            {
                Console.WriteLine(p.Id + " " + p.Name);
            }

            Console.ReadKey();
        }
    }
}
