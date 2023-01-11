using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpGrupal.Terrestre;

namespace TpGrupal.Terrestre.Auto
{
    public class Auto : Terrestre
    {
        public string VelocidadMaxima { get; set; }
        public string Año { get; set; }
        public string Puertas { get; set; }

        public string ModeloAuto { get; set; }

        public Auto(string color, string tipo, int ruedas, string velocidadMaxima, string año, string puertas, string modeloAuto) : base(color, tipo, ruedas)
        {
            VelocidadMaxima = velocidadMaxima;
            Año = año;
            Puertas = puertas;
            ModeloAuto = modeloAuto;
        }

        
    }
}
