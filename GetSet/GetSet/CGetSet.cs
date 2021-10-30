using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class CGetSet
    {
        public int i { get; set; } //public metod
        private string s; 

        public string S
        {
            get { return s; }
            set { s = value; }
        }

        public string toString()
        {
            return "c# i=" + this.i + " S=" + this.s;
        }
    }
}
