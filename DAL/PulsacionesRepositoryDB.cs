using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PulsacionesRepositoryDB
    {
        private readonly SqlConnection _connection;
        public PulsacionesRepositoryDB(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Pulsaciones pulsacion)
        {
            using (var comando = _connection.CreateCommand())
            {
                comando.CommandText = @"Insert Into Pulsaciones(Cedula,Nombre,Sexo,Edad,Pulsacion) 
                                        values (@Cedula,@Nombre,@Sexo,@Edad,@Pulsacion)";
                comando.Parameters.AddWithValue("@Cedula", pulsacion.cedula);
                comando.Parameters.AddWithValue("@Nombre", pulsacion.nombre);
                comando.Parameters.AddWithValue("@Sexo", pulsacion.sexo);
                comando.Parameters.AddWithValue("@Edad", pulsacion.edad);
                comando.Parameters.AddWithValue("@Pulsacion", pulsacion.pulsacion);
                comando.ExecuteNonQuery();
            }
        }
    }
}
