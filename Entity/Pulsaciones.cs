using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pulsaciones
    {
        public Pulsaciones(string nombre, string cedula, string sexo, double edad)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
        }

        public Pulsaciones()
        {
        }

        public string nombre { get; set; }
        public string cedula { get; set; }
        public double edad { get; set; }
        public string sexo { get; set; }
        public double pulsacion { get; set; }

        public void CalcularPulsaciones()
        {

            if (sexo == "Femenino")
            {
                pulsacion = (220 - edad) / 10;
            }
            if (sexo == "Masculino")
            {
                pulsacion = (210 - edad) / 10;
            }


        }
    }
}
