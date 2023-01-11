using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpGrupal.Terrestre;

namespace TpGrupal.Terrestre.APedal
{
    public class APedal:Terrestre
    {
        public string  Estilo { get; set; }
        public string Material { get; set; }
     

        public APedal(string color, string tipo, int ruedas, string estilo, string material) : base(color, tipo, ruedas)
        {
          Estilo= estilo;
          Material = material;  

        }
    }


}
