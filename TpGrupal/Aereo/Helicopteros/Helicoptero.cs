using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpGrupal.Aereo;

namespace TpGrupal.Aereo.Helicopteros
{
    public class Helicoptero:Aereo 
    {
        public Helicoptero(string color, string modelo, int capacidad, string uso) : base(color, modelo, capacidad)
        {
            Uso = uso;

        }

        public string Uso { get; set; }
    }
    //public void  prueba  Helicoptero helicoptero = new Helicoptero("Juan");

    
}
