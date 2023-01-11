using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TpGrupal.Aereo;

namespace TpGrupal.Aereo.Zeppelin
{
    public class Zeppelin:Aereo
    {
        

        public Zeppelin(string color, string modelo, int capacidad, decimal diametro, decimal longitud) : base(color, modelo, capacidad)
        {
            Diametro = diametro;
            Longitud = longitud;

        }
        public decimal Diametro { get; set; }
        public decimal Longitud { get; set; }
    }
}
