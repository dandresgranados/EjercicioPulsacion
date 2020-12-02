using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class PulsacionesServicesDB
    {
        private readonly ConnectionManager conexion;
        private readonly PulsacionesRepositoryDB pulsacionesRepositoryDB;

        public PulsacionesServicesDB(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            pulsacionesRepositoryDB = new PulsacionesRepositoryDB(conexion);
        }

        public string Guardar(Pulsaciones pulsaciones)
        {
            try
            {
                conexion.Open();
                pulsacionesRepositoryDB.Guardar(pulsaciones);
                conexion.Close();
                return $"Se guardaron los datos satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }



    }
}
