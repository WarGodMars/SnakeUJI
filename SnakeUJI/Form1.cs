using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeUJI
{
    public partial class Form1 : Form
    {
        private const int anchoEscenario = 735;
        private const int altoEscenario = 500;
        //private Marcador marcador; // Aquí se define
        //private Serpiente serpiente; // Aquí se define
        //private Comida comida;


        public const Keys arriba = Keys.Up;
        public const Keys abajo = Keys.Down;
        public const Keys izquierda = Keys.Left;
        public const Keys derecha = Keys.Right;
        
        
        Snake serpiente = new Snake(); // Aquí se crea
        Comidas comida = new Comidas();
        Marcadores marcador = new Marcadores();

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.UserPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.SupportsTransparentBackColor, true);
            this.Text = "Serpiente VJ1208";
            this.Width = anchoEscenario;
            this.Height = altoEscenario;
            this.BackColor = Color.LawnGreen;
            
            Controls.Add(serpiente.cab.picturebox);
            Controls.Add(serpiente.cola[0].picturebox);// Aquí se añade a Controls
            
            Controls.Add(comida.bocados[0].pic);
            
            Controls.Add(marcador.miLabel);
            marcador.miLabel.SendToBack();
            
            // Aquí pueden venir más acciones iniciales …

        }

        public void FinishGame()
        {
            if (serpiente.cab.picturebox.Location.X<0 | serpiente.cab.picturebox.Location.X > 735 | serpiente.cab.picturebox.Location.Y < 0 | serpiente.cab.picturebox.Location.Y > 500)
            {
                this.Close();
            }

            for(int i=0; i< serpiente.cola.Count; i++)
            {
                if (serpiente.cab.picturebox.Bounds.IntersectsWith(serpiente.cola[i].picturebox.Bounds))
                {
                    this.Close();
                }
            }
                
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string lastmove = "";


            switch (e.KeyCode)
            {
                case arriba:
                    if (lastmove != "arriba")
                    {
                        serpiente.giro.Add(new Giro(arriba, serpiente.cab.picturebox.Location.X, serpiente.cab.picturebox.Location.Y));
                    }
                    lastmove = "arriba";
                    break;


	            case abajo:
                    if (lastmove != "abajo")
                    {
                        serpiente.giro.Add(new Giro(abajo, serpiente.cab.picturebox.Location.X, serpiente.cab.picturebox.Location.Y));
                    }
                    lastmove = "abajo";
                    break;


	            case izquierda:
                    if (lastmove != "izquierda")
                    {
                        serpiente.giro.Add(new Giro(izquierda, serpiente.cab.picturebox.Location.X, serpiente.cab.picturebox.Location.Y));
                    }
                    lastmove = "izquierda";
                    break;


	            case derecha: 
                    
                    if (lastmove != "derecha") {
                        serpiente.giro.Add(new Giro(derecha, serpiente.cab.picturebox.Location.X, serpiente.cab.picturebox.Location.Y));
                    }
                    lastmove = "derecha";                        
                    break;


	            
            }

        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            serpiente.Draw();
            serpiente.NuevoCola();
            serpiente.Cambio_POS_Cabeza();
            serpiente.Giro();
            comida.Refresher();
            FinishGame();
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
