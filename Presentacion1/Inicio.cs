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
        PulsacionesServicesDB pulsacionesServicesDB;
        List<Pulsaciones> lista;
        public Inicio()
        {
            InitializeComponent();
            pulsacionesServices = new PulsacionesServices();    

            var connectionString = ConfigConnection.ConnectionString;
            pulsacionesServicesDB = new PulsacionesServicesDB(connectionString);

            lista = new List<Pulsaciones>();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            // GuardarTxt();
            GuardarDB();
        }

        private void GuardarDB()
        {

            string nombre, identificacion, sexo, mensaje;
            double edad;

            nombre = TxtNombre.Text.Trim();
            identificacion = TxtCedula.Text.Trim();
            sexo = comboSexo.Text.Trim();
            edad = Convert.ToInt32(TxtEdad.Text.Trim());

            Pulsaciones pulsaciones = new Pulsaciones(nombre, identificacion, sexo, edad);
            
            pulsaciones.CalcularPulsaciones();
            mensaje = pulsacionesServicesDB.Guardar(pulsaciones);
            
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            labelMostrarPulsacion.Text = "" + pulsaciones.pulsacion;

        }


        private void GuardarTxt()
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

        private void botonConsultarTodos(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            consultar.Show();

        }
    }
}
