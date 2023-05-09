using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeUJI
{
    internal class Bocado
    {
        public  int tiempo;
        public int value;
        public PictureBox pic= new PictureBox();    



        public Bocado()
        {
            pic.Size= new System.Drawing.Size(10,10);

            Random random = new Random();
            pic.Location= new System.Drawing.Point(random.Next(736),random.Next(501));
            
            
            tiempo = random.Next(10, 17);
            value = random.Next(2, 7);

            if(value==2)
            {
                pic.BackColor= Color.White;

            }else if(value==3) 
            {
                pic.BackColor= Color.CadetBlue;
            }
            else if (value == 4)
            {
                pic.BackColor = Color.DarkBlue;
            }
            else if (value == 5)
            {
                pic.BackColor = Color.Purple;
            }
            else if (value == 6)
            {
                pic.BackColor = Color.Black;
            }
           

        }
    }
}
