using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucesion
{
    class Program
    {

        static void Main(string[] args)
        {

            int suc = 0;
            int term = 0;
            int cant = 0;
            int men = 2;
            int may = 1800;

            Console.WriteLine("La sucesion 2,5,7,10,12,15, 17... 1800 es: ");
            Console.WriteLine("--------------------------------------------");

            while (suc < 1800)
            {
                cant++; //Cuenta la cantidad de numeros para despues sacar la suma de la sucesion

                term++; //Va contando la posicion del termino para posteriormente sumar 2 o 3 segun corresponda

                if (term % 2 == 0) //Verifica si la posicion del termino en la sucesion es par o impar
                {
                    suc = suc + 3; //Si la posicion del termino en la sucesion es par suma 3

                }
                else
                {
                    suc = suc + 2; //Si la posicion del termino en la sucecion es impar suma 2
                }

                Console.WriteLine(suc);

            }

            int suma = (may + men) * (cant / 2); //Suma total de la sucesion


            Console.WriteLine("--------------------------------------");
            Console.WriteLine("La cantidad de terminos es: " + cant); //OPCIONAL, muestra la cantidad de terminos en total
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("La suma de la sucesion es: " + suma);

            Console.ReadKey();
        }
    }
}
