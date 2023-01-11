using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpGrupal.Terrestre;

namespace TpGrupal.Terrestre.Camion
{
    public class Camion : Terrestre
    {

        
        public Camion(string tipo, string color, int ruedas, string carga, int eje) : base(color, tipo, ruedas)
        {
           
           
            Carga = carga;
            Eje = eje;
        }
        public string Carga { get; set; }
        public int Eje { get; set; }




        //Camion camionFlete = new Camion();

        //camionFlete.Tipo = "Juan";
        //camionFlete.Color = "Juan";
        //camionFlete.Carga = "Juan";
        //camionFlete.Eje = 4;

        //    Camion camionCarga = new Camion();

        //camionCarga.Tipo = "Juan";
        //camionCarga.Color = "Juan";
        //camionCarga.Carga = "Juan";
        //camionCarga.Eje = 4;

        //    Camion camionFrigorifico = new Camion();

        //camionFrigorifico.Tipo = "Juan";
        //camionFrigorifico.Color = "Juan";
        //camionFrigorifico.Carga = "Juan";
        //camionFrigorifico.Eje = 4;
        



    }
}
