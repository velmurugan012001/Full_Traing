using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Assignment
{ 
    public void coordinate(int X,int Y)

    {
        if (X > 0 && Y > 0)
        {
            Console.WriteLine("The corrdinate point (" + X + "," + Y + ") lies in the First quadrant.");
        }

        else if (X < 0 && Y > 0)
        {
            Console.WriteLine("The corrdinate point (" + X + "," + Y + ") lies in the Second quadrant.");
        }

        else if (X < 0 && Y < 0)
        {
            Console.WriteLine("The corrdinate point (" + X + "," + Y + ") lies in the Third quadrant.");
        }

        else if (X > 0 && Y < 0)
        {
            Console.WriteLine("The corrdinate point (" + X + "," + Y + ") lies in the Fourth quadrant.");
        }
        else
        { Console.WriteLine("The points are in Orgin"); }
        
    }
}
