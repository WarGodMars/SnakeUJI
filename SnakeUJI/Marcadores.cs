using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace SnakeUJI
{
    internal class Marcadores
    {
        public Label miLabel= new Label();
        public int puntos { get; set; }
        public int tiempo_restante { get; set; }
        public Marcadores()
        {
            miLabel.Font = new Font("Courier", 18);
            miLabel.AutoSize = true;
            this.puntos= 0;
            this.tiempo_restante = 0;
        }

        
    }
}
