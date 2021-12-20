using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class PalabraIterator : IEnumerator
    {
        char[] _palabra;
        int _pos;
        public PalabraIterator(string palabra)
        {
            _palabra = palabra.ToCharArray();
            _pos = -1;
        }
        public object Current => _palabra[_pos];

        public bool MoveNext()
        {
            if(_pos < _palabra.Length - 1)
            {
                _pos++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _pos = -1;
        }
    }  
    
}
