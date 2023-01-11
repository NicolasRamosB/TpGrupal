using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpGrupal.Aereo.Aviones;
using TpGrupal.Terrestre.Auto;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto("Rojo", "Nafta", 4, "240", "2016", "4", "Auto Urbano" );

            MessageBox.Show($"El auto es de color: {auto.Color}" +
                $"\nEl tipo de combustible que usa es: {auto.Tipo} " +
                $"\nLa cantidad de ruedas son: {auto.Ruedas}" +
                $"\nLa velocidad maxima en km/h es: {auto.VelocidadMaxima}" +
                $"\nEl año de creacion es: {auto.Año}" +
                $"\nLa cantidad de puertas es: {auto.Puertas}" +
                $"\nEl modelo de auto es: {auto.ModeloAuto}"  );
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion("Blanco", "Plano", 130, "Comercial" );

            MessageBox.Show($"El avion es de color:  {avion.Color}" +
                $"\nEl modelo es: {avion.Modelo} " +
                $"\nLa capacidad de pasajeros es: {avion.Capacidad}" +
                $"\nEl tipo de avion es: {avion.Tipo}") ;
        }
    }
}
