using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODOS LOS DERECHOS RESERVADOS 2017
            Console.Write("┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴" + "\n");
            Console.Write("WILLI J. BIDO LORA - 15 -EISN-1-159" + "\n");
            Console.Write("┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬" + "\n");
            Console.Write("\n");

            //VARIABLES
            int numero1, numero2, numero3;
            string leerLinea;

            //VALORES POR TECLADO
            Console.Write("Ingrese el primer numero ");
            leerLinea = Console.ReadLine();
            numero1 = int.Parse(leerLinea);
            Console.Write("Ingrese el segundo numero ");
            leerLinea = Console.ReadLine();
            numero2 = int.Parse(leerLinea);
            Console.Write("Ingrese el tercer numero ");
            leerLinea = Console.ReadLine();
            numero3 = int.Parse(leerLinea);

            //UNO ES MAYOR QUE DOS??
            if (numero1 > numero2)
            {
                if (numero1 > numero3)
                {
                    Console.Write("\n");
                    Console.Write("┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ " + "\n");
                    Console.Write("El numero mayor es " + numero1 + "\n");
                    Console.Write("┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ " + "\n");
                    //WHILE EXTRA
                    while(numero1 <= 5)
                    {
                        Console.Write(numero1);
                        Console.Write(", ");
                        numero1 = numero1 + 1;
                    }
                }
                else
                {
                    Console.Write("\n");
                    Console.Write("┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ " + "\n");
                    Console.Write("El numero mayor es " + numero3 + "\n");
                    Console.Write("┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ " + "\n");
                    //WHILE EXTRA
                    while (numero3 <= 5)
                    {
                        Console.Write(numero3);
                        Console.Write(", ");
                        numero3 = numero3 + 1;
                    }
                }
            }
            else 
            {
                //DOS ES MAYOR QUE TRES??
                if (numero2 > numero3)
                {
                    Console.Write("\n");
                    Console.Write("┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ " + "\n");
                    Console.Write("El numero mayor es " + numero2 + "\n");
                    Console.Write("┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ " + "\n");
                    //WHILE EXTRA
                    while (numero2 <= 5)
                    {
                        Console.Write(numero2);
                        Console.Write(", ");
                        numero2 = numero2 + 1;
                    }
                }
                else 
                {
                    Console.Write("\n");
                    Console.Write("┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ " + "\n");
                    Console.Write("El numero mayor es " + numero3 + "\n");
                    Console.Write("┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ " + "\n");
                    //WHILE EXTRA
                    while (numero3 <= 5)
                    {
                        Console.Write(numero3);
                        Console.Write(", ");
                        numero3 = numero3 + 1;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
