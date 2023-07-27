using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal class Addition
    {

        private static int bon;
        public Addition() { 
        
            bon= 6;

        }
       
         internal void add( int x, int y , out int a ,out int b ) {

            a = bon + x;
            b = bon + y;
        }   
      
        
    }
}
