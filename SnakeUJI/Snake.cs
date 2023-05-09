using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeUJI
{
    internal class Snake
    {
        
        public List<Segmento> cola= new List <Segmento>();

        public List<Giro> giro = new List<Giro>();

        public Segmento cab = new Segmento(376, 250, Form1.arriba);

        public Snake ()
        {
             
            this.cola.Add(new Segmento(376, 250 + 10, Form1.arriba));
            this.cola.Add(new Segmento(376, 250 + 15, Form1.arriba));
            
        }

        public void Draw()
        {
            cab.picturebox.Refresh();

            foreach (Segmento c in cola)
            {
                cab.picturebox.Refresh();
            }
        }

        public void Cambio_POS_Cabeza()
        {

            if (cab.keys == Form1.arriba) {
                cab.picturebox.Location = new Point(cab.picturebox.Location.X, cab.picturebox.Location.Y - 1);
            } else if (cab.keys == Form1.derecha) {
                cab.picturebox.Location = new Point(cab.picturebox.Location.X + 1, cab.picturebox.Location.Y);
            }
            else if (cab.keys == Form1.izquierda){ 
            
                cab.picturebox.Location = new Point(cab.picturebox.Location.X - 1, cab.picturebox.Location.Y);
            }else if (cab.keys == Form1.abajo) { 
            
                cab.picturebox.Location = new Point(cab.picturebox.Location.X, cab.picturebox.Location.Y + 1);
            }

                    
                    

           
        }

        public void Giro()
        {
            for (int i = 0; i < giro.Count; i++)
            {
                foreach (Segmento c in cola)
                {
                    if (c.picturebox.Location.X == giro[i].dimx && c.picturebox.Location.Y == giro[i].dimy)
                    {
                        c.keys = giro[i].keys;
                    }
                }
            }
            if (giro.Count > 0)
            {
                int j = giro.Count - 1;
                if (cola[j].picturebox.Location.X == giro[0].dimx && cola[j].picturebox.Location.Y == giro[0].dimy)
                {
                    giro.RemoveAt(0);
                }
            }
        }


        public void NuevoCola() { 
           
            foreach(Segmento c in cola)
            {
                 if (cab.keys== Form1.abajo)
                {
                    c.picturebox.Location = new Point(c.picturebox.Location.X, c.picturebox.Location.Y + 1);

                }
                else if(cab.keys== Form1.arriba)
                {
                    c.picturebox.Location = new Point(c.picturebox.Location.X, c.picturebox.Location.Y - 1);

                }
                else if (cab.keys == Form1.derecha)
                {
                    c.picturebox.Location = new Point(c.picturebox.Location.X, c.picturebox.Location.Y);

                }
                else if (cab.keys == Form1.izquierda)
                {
                    c.picturebox.Location = new Point(c.picturebox.Location.X - 1, c.picturebox.Location.Y);

                }
            }
        }
    }
}
    

