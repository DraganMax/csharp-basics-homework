using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Points
    {
        private int _x;
        private int _y;

        public Points(int xCoord, int yCoord)
        {
            _x = xCoord;
            _y = yCoord;
        }
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }

    }
}
