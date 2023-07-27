using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    internal class GenUse<T> where T : Exception
    {
        /*
        private T expepobj;
        
        public GenUse(T expepobj)
        {
            this.expepobj = expepobj;
        }
        public T disp()
        {
            return expepobj;
        }
    
        */

       /* private T[] arr;

        public GenUse(int size)
        {
            arr = new T[size];
        }

        public T getarr(int index)
        {
            return arr[index];
        }

        public void setarr(int index , T value)
        {
            arr[index] = value;
        }*/

        /*
        private T number;


        public GenUse(T number)
        {
            this.Number = number;
        }

        public T Number { get => number; set => number = value; }
        */
    }
}
