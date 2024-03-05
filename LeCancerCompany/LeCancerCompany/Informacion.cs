using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeCancerCompany
{
    public static class Informacion
    {
        public static List<Persona> enfermos = new List<Persona>();
        public static List<Persona> saludables = new List<Persona>();

        public static int contadorSanos = 0;
        public static int contadorEnfermos = 0;
        public static int contadorTotal = 0;
        public static int contador = 0;

        public static void vaciar(List<Persona> lista)
        {
            lista.Clear();
        }

        public static bool anadir ( bool enfermo , Persona paciente ) {
            if (enfermo)
            {
                foreach (Persona persona in enfermos)
                {
                    if (persona.cedula == paciente.cedula)
                    {
                        return false;
                    }
                }
                enfermos.Add(paciente);
                contadorTotal++;
                return true;
            }
            else 
            {
                foreach (Persona persona in saludables)
                {
                    if (persona.cedula == paciente.cedula)
                    {
                        return false;
                    }
                }
                saludables.Add(paciente);
                contadorTotal++;

                return true;
            }
        }
    }

    
}
