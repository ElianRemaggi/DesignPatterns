using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class JavaGetSet
    {
        private int i;
        private string s;

        public int geti()
        {
            return this.i;
        }

        public void seti(int i)
        {
            this.i = i;
        }

        public string gets()
        {
            return this.s;
        }

        public void sets(string s)
        {
            this.s = s;
        }

        public string toString()
        {
            return "Java i="+this.geti()+" S="+this.gets(); 
        }
    }
}
