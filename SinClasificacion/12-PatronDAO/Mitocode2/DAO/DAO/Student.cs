using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Student
    {
        private string _name;
        private int _id;

        public Student()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }


    }
}
