using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public abstract class Empleado
    {
        private string pNombre;
        private string aPaterno;
        private string nISSS;

        public Empleado( string nombre, string apellido, string numero)
        {
            pNombre = nombre;
            aPaterno = apellido;
            nISSS = numero;
        }

        public string Nombre { get { return pNombre; } }
        public string Apellido { get { return aPaterno; } }
        public int NISSS { get { return nISSS; } }

        public override string ToString()
        {
            return string.Format("{0} {1}\nnúmero de seguro social: {2}",
                pNombre, aPaterno, nISSS);
        }

        public abstract decimal Ingresos();
    }
}
