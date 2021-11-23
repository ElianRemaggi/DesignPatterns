using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    interface IStudentDao
    {
        List<Student> getAllStudents();
        void updateStudent();
        void deleteStudent(Student s);
        void addStudent(Student s);
    }
}
