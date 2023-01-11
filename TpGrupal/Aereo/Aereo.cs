using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal.Aereo
{
    public abstract class Aereo
    {
        public Aereo(string color, string modelo, int capacidad){
            Color = color;
            Modelo = modelo;
            Capacidad = capacidad;

     }
        public string Color { get; set; }
        public string Modelo { get; set; }

        public int Capacidad { get; set; }
    }
}
