using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class EmpleadoHoras : Empleado
    {
        private decimal sueldo;
        private decimal horas;

        public EmpleadoHoras(string nombre, string apellido, string numero,
            decimal sueldohoras, decimal horastrabajo) : base (nombre, apellido, numero)
        {
            Sueldo = sueldohoras;
            horas = horastrabajo;
        }

        public decimal Sueldo
        {
            get { return sueldo; }
            set { sueldo = ( value >= 0 ) ? value : 0; }
        }
        public decimal Horas
        {
            get { return horas; }
            set { horas = ( ( value >= 0 ) && ( value <= 168 ) ) ? value : 0; }
        }

        public override decimal Ingresos()
        {
            if (Horas <= 40)
            {

                return Sueldo * Horas;
            }

            else
                return (40 * Sueldo) + ((Horas - 40) * Sueldo * 1.5M);
        }

        public override string ToString()
        {
            return String.Format(
                " empleado por horas: {0}\n{1}: {2:C}; {3}: {4:F2}",
                base.ToString(), "sueldo por horas", Sueldo, "horas trabajadas", Horas);
        }
    }
}
