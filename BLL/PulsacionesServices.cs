using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PulsacionesServices
    {
        List<Pulsaciones> lista;
        private PulsacionesRepository pulsacionesRepository;

        public PulsacionesServices()
        {
            pulsacionesRepository = new PulsacionesRepository();
            lista = new List<Pulsaciones>();
        }



        public void Guardar(Pulsaciones pulsaciones)
        {

            try
            {
                pulsaciones.CalcularPulsaciones();
                pulsacionesRepository.Guardar(pulsaciones);

            }
            catch (Exception)
            {
                Console.WriteLine("HUBO UN ERROR AL GUARDAR LOS DATOS");
                throw;
            }

        }

        public List<Pulsaciones> Consultar()
        {
            return pulsacionesRepository.Consultar();
        }
       
        public Pulsaciones BuscarPulsacion(string cedula)
        {
            return pulsacionesRepository.BuscarPulsaciones(cedula);
        }


    }
}
