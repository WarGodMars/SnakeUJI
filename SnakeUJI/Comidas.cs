using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeUJI
{
    internal class Comidas
    {
         public List<Bocado> bocados = new List<Bocado>();
        Random rand = new Random();
        int anchoescenario = 735;
        int altoescenario = 500;
        


        public Comidas()
        {
            bocados.Add(new Bocado());
        }

        public void Refresher()
        {
            for(int i=0; i < bocados.Count; i++ ){

                    bocados[i].pic.Refresh();

            }
        }
    }
}
