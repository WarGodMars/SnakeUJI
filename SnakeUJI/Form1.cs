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


        public static Keys arriba = Keys.Up;
        public static  Keys abajo = Keys.Down;
        public static Keys izquierda = Keys.Left;
        public static Keys derecha = Keys.Right;




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
            Snake serpiente = new Snake(); // Aquí se crea
            Controls.Add(serpiente.picturebox); // Aquí se añade a Controls
            Comidas comida = new Comidas();
            Controls.Add(comida.MiPictureBox);
            Marcadores marcador = new Marcadores();
            Controls.Add(marcador.MiLabel);
            marcador.miLabel.SendToBack();
            
            // Aquí pueden venir más acciones iniciales …

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*switch (e.KeyCode)
            {
                case arriba: arriba+= 1;                                // aquí escribimos que queremos que haga en este caso
	            case abajo: abajo += 1;                                // aquí escribimos que queremos que haga en este caso
	            case izquierda: izquierda += 1;                         // aquí escribimos que queremos que haga en este caso
	            case derecha: derecha += 1;                             // aquí escribimos que queremos que haga en este caso
	            default:
            }*/

        }

        
    }
}
