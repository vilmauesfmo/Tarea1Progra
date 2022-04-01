using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    internal class EmpleadoBMComision : EmpleadoComision
    {
        private decimal salarioB;

        public EmpleadoBMComision(string nombre, string apellido, string numero, decimal ventas,
            decimal tarifa, decimal salario) : base (nombre, apellido, numero,  ventas, tarifa)
        {
            SalarioB = salario; 
        }

        public decimal SalarioB
        {
            get { return salarioB; }
            set { salarioB = ( value >= 0 ) ? value : 0; }
        }

        public override decimal Ingresos()
        {
            return SalarioB + base.Ingresos();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}; {2}: {3:C}",
                "salario base +", base.ToString(), "salario base", SalarioB);
        }
    }
}
