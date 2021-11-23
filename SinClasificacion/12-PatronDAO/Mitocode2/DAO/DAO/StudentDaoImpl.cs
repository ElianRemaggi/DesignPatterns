using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class StudentDaoImpl : IStudentDao
    {

        private List<Student> Students;

        public StudentDaoImpl()
        {
            this.Students = new List<Student>();
        }

        public void addStudent(Student s)
        {
            this.Students.Add(s);
        }

        public void deleteStudent(Student s)
        {
            this.Students.Remove(s);
        }

        public List<Student> getAllStudents()
        {
            return this.Students;
        }

        public void updateStudent()
        {
            throw new NotImplementedException();
        }
    }
}
