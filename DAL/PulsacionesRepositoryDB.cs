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
        private readonly List<Pulsaciones> listaPulsaciones;
        public PulsacionesRepositoryDB(ConnectionManager connection)
        {
            _connection = connection._conexion;
            listaPulsaciones = new List<Pulsaciones>();
        }

        public void Guardar(Pulsaciones pulsacion)
        {
            using (var comando = _connection.CreateCommand())
            {
                comando.CommandText = @"INSERT INTO Pulsaciones(Cedula,Nombre,Sexo,Edad,Pulsacion) 
                                        VALUES (@Cedula,@Nombre,@Sexo,@Edad,@Pulsacion)";
                comando.Parameters.AddWithValue("@Cedula", pulsacion.cedula);
                comando.Parameters.AddWithValue("@Nombre", pulsacion.nombre);
                comando.Parameters.AddWithValue("@Sexo", pulsacion.sexo);
                comando.Parameters.AddWithValue("@Edad", pulsacion.edad);
                comando.Parameters.AddWithValue("@Pulsacion", pulsacion.pulsacion);
                comando.ExecuteNonQuery();
            }
        }

        public List<Pulsaciones> ConsultarTodos()
        {
            listaPulsaciones.Clear();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Pulsaciones";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Pulsaciones pulsacion = DataReaderMapToPerson(dataReader);
                        listaPulsaciones.Add(pulsacion);
                    }
                }
            }
            return listaPulsaciones;
        }

        private Pulsaciones DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Pulsaciones pulsacion = new Pulsaciones(); ;
            
                
            
            pulsacion.cedula = (string)dataReader["Cedula"];
            pulsacion.nombre = (string)dataReader["Nombre"];
            pulsacion.sexo = (string)dataReader["Sexo"];
            pulsacion.edad = (int)dataReader["Edad"];
            pulsacion.pulsacion = (double)dataReader["Pulsacion"];

            return pulsacion;
        }

        public void Eliminar(Pulsaciones pulsacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM Pulsaciones WHERE Cedula=@Cedula";
                command.Parameters.AddWithValue("@Cedula", pulsacion.cedula);
                command.ExecuteNonQuery();
            }
        }
    }
}
