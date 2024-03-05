using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeCancerCompany
{
    public class Persona
    {
        public string cedula;
        public string nombre;
        public string apellido;
        public int edad;
        public string sexo;
        public string condicion;
        public bool enfermo;
        public double deuda;

        public Persona(string cedula, string nombre, string apellido, string edad, string sexo, string condicion, bool enfermo, string deuda)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = Convert.ToInt16(edad);
            this.sexo = sexo;
            this.condicion = condicion;
            this.enfermo = enfermo;
            this.deuda = Convert.ToDouble(deuda);
        }

    }
}
