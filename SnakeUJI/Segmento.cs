using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeUJI
{
    internal class Segmento
    {
        public Keys keys { get; set; }
        public PictureBox picturebox { get; set; }
        public Segmento(int x, int y, Keys keys) 
        {  
            picturebox= new PictureBox();
            picturebox.Location= new System.Drawing.Point(x, y);
            picturebox.Size = new System.Drawing.Size(10, 10);
            picturebox.BackColor= System.Drawing.Color.Red;
            this.keys=keys; 
        
        }
    }
}
