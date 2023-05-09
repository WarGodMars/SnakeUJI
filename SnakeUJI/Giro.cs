using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeUJI
{
    internal class Giro
    {
        public Keys keys { get; set; }
        public int dimx { get; set; }
        public int dimy { get; set; }

        public Giro(Keys keys, int x, int y)
        {
            this.keys = keys;
            this.dimx = x;
            this.dimy = y;
        }

    }
}
