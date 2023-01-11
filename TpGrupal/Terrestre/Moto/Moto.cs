using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpGrupal.Terrestre;

namespace TpGrupal.Terrestre.Moto
{
    public class Moto : Terrestre
    {

        public int Cilindros { get; set; }
        public string ModeloMoto { get; set; }

        public string Patente { get; set; }

        public Moto(string color, string tipo, int ruedas, int cilindros, string modeloMoto, string patente) : base(color, tipo, ruedas)
        {
            Cilindros = cilindros;
            ModeloMoto = modeloMoto;
            Patente = patente;
        }

    }

}
