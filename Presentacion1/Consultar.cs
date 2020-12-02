using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion1
{
    public partial class Consultar : Form
    {
        PulsacionesServices pulsacionesServices;
        PulsacionesServicesDB pulsacionesServicesDB;
        List<Pulsaciones> lista;
        
        public Consultar()
        {
            pulsacionesServices = new PulsacionesServices();

            var connectionString = ConfigConnection.ConnectionString;
            pulsacionesServicesDB = new PulsacionesServicesDB(connectionString);

            lista = new List<Pulsaciones>();
            InitializeComponent();
            consultar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pintarTabla()
        {
            
            tablaDePulsaciones.DataSource = null;
            tablaDePulsaciones.DataSource = lista;
            tablaDePulsaciones.Refresh();
        }
        private void consultar()
        {
            // lista = pulsacionesServices.Consultar();
            lista = pulsacionesServicesDB.ConsultarTodos();
                pintarTabla();
                
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
