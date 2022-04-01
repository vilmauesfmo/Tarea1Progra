using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoA empleadoA = new EmpleadoA("John", "Smith", "111-111-11", 800.00M);
            EmpleadoHoras empleadoHoras = new EmpleadoHoras("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            EmpleadoComision empleadoComision = new EmpleadoComision("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            EmpleadoBMComision empleadoBMComision = new EmpleadoBMComision("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Empleados procesados en forma individual:\n");
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoA, "ingresos", empleadoA.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoHoras, "ingresos", empleadoHoras.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoComision, "ingresos", empleadoComision.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoBMComision, "ingresos", empleadoBMComision.Ingresos());

            Empleado[] empleados = new Empleado[4];

            empleados[0] = empleadoA;
            empleados[1] = empleadoHoras;
            empleados[2] = empleadoComision;
            empleados[3] = empleadoBMComision;

            Console.WriteLine(" Empleado procesado :\n");

            foreach (Empleado empleadoActual in empleados)
            {
                Console.WriteLine(empleadoActual);
                if (empleadoActual is EmpleadoBMComision)
                {
                    EmpleadoBMComision empleado = (EmpleadoBMComision) empleadoActual;
                    empleado.SalarioB *= 1.10M;
                    Console.WriteLine( "nuevo salario base con incremento del 10%: {0:C}",
                    empleado.SalarioB);
                }
               Console.WriteLine("ingresos {0:C}\n", empleadoActual.Ingresos());
                }
               for (int j = 0; j < empleados.Length; j++)
                Console.WriteLine("Empleado {0} es un {1}", j,
                empleados[j].GetType());
        }
      }
 }