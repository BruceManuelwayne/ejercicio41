using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] fechasArray = new DateTime[5];
            int contador = 0;

            bool ingresoCorrecto;
            bool ok = false;
            string ingreso;



            Console.WriteLine("Ingrese una serie de fechas:");


            do
            {
                ingreso = Console.ReadLine();
                ingresoCorrecto = DateTime.TryParse(ingreso, out DateTime fechaValida);
                if (!ingresoCorrecto)
                {
                    Console.WriteLine("Fecha invalida, ingrese otra: ");
                    continue; //continue vuelve al inicio del ciclo , si hay un error conitnua, do for while for each
                }
                else
                {

                    fechasArray[contador] = fechaValida;
                    contador++;
                    Console.WriteLine("Quiere ingresar otra Fecha? S/N");
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.N)
                    {
                        ok = true;
                    }
                   
                }
            } while (contador > fechasArray.Length || !ok);
            Array.Sort(fechasArray);

            for (int i = 0; i < fechasArray.Length; i++)
            {
                Console.WriteLine(fechasArray[i]);
            }
            Console.ReadKey();
        }
    }
}

               

            
             
 

