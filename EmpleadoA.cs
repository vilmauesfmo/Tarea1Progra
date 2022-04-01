using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class EmpleadoA : Empleado
    {
        private decimal sSemanal;

        public EmpleadoA( string nombre, string apellido, string numero, 
            decimal salario) : base (nombre, apellido, numero)
        {
            sSemanal = salario;
        }
        
        public decimal SSemanal
        {
            get { return SSemanal; }
            set { SSemanal = ( ( value >= 0) ? value : 0); }
        }

        public override decimal Ingresos()
        {
            return SSemanal;
        }

        public override string ToString()
        {
            return String.Format("empleado asalariado: {0}\n{1}: {2:C}",
                base.ToString(), "salario semanal", SalarioSemanal);
        }
    }
}
