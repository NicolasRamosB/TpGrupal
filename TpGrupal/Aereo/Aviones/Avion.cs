using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpGrupal.Aereo;

namespace TpGrupal.Aereo.Aviones
{
    public class Avion:Aereo
    {
        public Avion(string color, string modelo, int capacidad, string tipo) : base(color, modelo, capacidad)
        {
            Tipo= tipo;
           
        }

        public string Tipo { get; set; }
        


    }
}
