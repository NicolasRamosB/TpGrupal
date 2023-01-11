using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal.Terrestre
{
   
        public abstract class Terrestre
        {

            public string Color { get; set; }
            public string Tipo { get; set; }
            public int Ruedas { get; set; }

            public Terrestre(string Color, string Tipo, int Ruedas)
            {

                this.Color = Color;
                this.Tipo = Tipo;
                this.Ruedas = Ruedas;

            }


        }
    }

