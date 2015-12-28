using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Main
{
    class MyPair : IComparable<MyPair>
    {
        public int x=0, y=0;

        public MyPair(int xi, int yi)
        {
            x = xi;
            y = yi;
        }

        public static bool operator <(MyPair obj1, MyPair obj2)
        {
            if (obj1.y < obj2.y)
                return true;
            if (obj1.y > obj2.y)
                return false;
            if (obj1.x <= obj2.x)
                return true;
            else
                return false;
            
        }

        public static bool operator >(MyPair obj1, MyPair obj2)
        {
            if (obj1.y < obj2.y)
                return false;
            if (obj1.y > obj2.y)
                return true;
            if (obj1.x <= obj2.x)
                return false;
            else
                return true;

        }

        public int CompareTo(MyPair obj2)
        {
            if (this.y < obj2.y)
                return -1;
            if (this.y > obj2.y)
                return 1;
            if (this.x < obj2.x)
                return -1;
            if (this.x > obj2.x)
                return 1;
            else
                return 0;
        }
    }
}
