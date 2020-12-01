using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion1
{
    public partial class Inicio : Form
    {
        PulsacionesServices pulsacionesServices;
        List<Pulsaciones> lista;
        public Inicio()
        {
            InitializeComponent();
            pulsacionesServices = new PulsacionesServices();
            lista = new List<Pulsaciones>();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        private void Guardar()
        {

            string nombre, identificacion, sexo;
            double edad;

            nombre = TxtNombre.Text.Trim();
            identificacion = TxtCedula.Text.Trim();
            sexo = comboSexo.Text.Trim();
            edad = Convert.ToDouble(TxtEdad.Text.Trim());

            Pulsaciones pulsaciones = new Pulsaciones(nombre, identificacion, sexo, edad);
            pulsacionesServices.Guardar(pulsaciones);
            pulsaciones.CalcularPulsaciones();

            labelMostrarPulsacion.Text = "" + pulsaciones.pulsacion;



            Console.ReadLine();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            consultar.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           BuscarPulsacion();
        }

        private void BuscarPulsacion()
        {

            Pulsaciones pulsacion = new Pulsaciones();
            pulsacion = pulsacionesServices.BuscarPulsacion(TxtCedula.Text);
            TxtNombre.Text = pulsacion.nombre;
            TxtEdad.Text = pulsacion.edad.ToString();
            comboSexo.Text = pulsacion.sexo;
            labelMostrarPulsacion.Text = pulsacion.pulsacion.ToString();
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
