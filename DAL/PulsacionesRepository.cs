using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PulsacionesRepository
    {
        // DESKTOP-IO6R9OL\SQLEXPRESS

        private readonly string FileName = "Pulsaciones.txt";
        List<Pulsaciones> lista;
        

        public PulsacionesRepository()
        {
            lista = new List<Pulsaciones>();
        }

        public void Guardar(Pulsaciones pulsaciones)
        {
            FileStream file = new FileStream(FileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);

            writer.WriteLine($"{pulsaciones.nombre};{pulsaciones.cedula};{pulsaciones.edad};{pulsaciones.sexo};{pulsaciones.pulsacion}");
            writer.Close();
            file.Close();

        }

        public List<Pulsaciones> Consultar()
        {
            try
            {
                using (StreamReader leer = new StreamReader(FileName))
                {
                    lista = new List<Pulsaciones>();
                    while (!(leer.EndOfStream))
                    {
                        Pulsaciones pulsacion = new Pulsaciones();
                        string linea = leer.ReadLine();
                        String[] dato = linea.Split(';');
                        pulsacion.nombre = dato[0];
                        pulsacion.cedula = dato[1];
                        pulsacion.edad = int.Parse(dato[2]);
                        pulsacion.sexo = dato[3];
                        pulsacion.pulsacion = double.Parse(dato[4]);
                        lista.Add(pulsacion);
                    }
                    leer.Close();
                }
            }
            catch (IOException e)
            {

            }
            return lista;
        }

        public Pulsaciones BuscarPulsaciones(string cedula)
        {
            lista.Clear();
            lista = Consultar();
            return lista.Where(p =>p.cedula.Equals(cedula)).FirstOrDefault();
        }


    }

}

