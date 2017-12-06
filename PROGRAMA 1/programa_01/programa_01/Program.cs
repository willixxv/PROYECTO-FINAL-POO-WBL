using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODOS LOS DERECHOS RESERVADOS 2017
            Console.Write("┴ ┴ l┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴" + "\n");
            Console.Write("WILLI J. BIDO LORA - 15 -EISN-1-159" + "\n");
            Console.Write("┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬" + "\n");
            Console.Write("\n");

            int numero, numero2;

            string linea, linea2;

            //AQUI IMPRIME EL LETRERO DE LA PRIMERA TABLA
            Console.Write("\n");
            Console.Write("======== PRIMERA TABLA ========"+"\n");
            Console.Write("Ingrese el primer numero a multiplicar:=> ");

            linea = Console.ReadLine();

            numero = int.Parse(linea);

            //CICLO DE MULTIPLICACIÓN HASTA EL 12
            for (int i = 1; i <= 12; i++) {
                Console.Write(i + " X " + numero + " = " + i * numero + "\n");
            }

            //AQUI IMPRIME EL LETRERO DE LA SEGUNDA TABLA
            Console.Write("\n");
            Console.Write("======== SEGUNDA TABLA ========" + "\n");
            Console.Write("Ingrese el segundo numero a multiplicar:=> ");

            linea2 = Console.ReadLine();

            numero2 = int.Parse(linea2);

            //AQUI COMIENZA EL CICLO PARA MULTIPLICAR LA SEGUNDA TABLA
            for (int a = 1; a <= 12; a++)
            {
                Console.Write(a + " X " + numero2 + " = " + a * numero2 + "\n");
            }

            //AQUI COMPARA LOS NUMEROS DE LAS TABLAS PARA DETERMINAR CUAL ES LA MAYOR O SI SON IGUALES.

            //¿EL NUMERO 1 ES MAYOR QUE EL NUMERO 2?: ENTONCES LA TABLA UNO ES MAYOR QUE LA SEGUNDA
            if(numero > numero2){
                Console.Write("\n");
                Console.Write("│=======================│" + "\n");
                Console.Write("La primera tabla es mayor");
                Console.Write("\n" + "│=======================│");
            }

            //¿EL NUMERO 2 ES MAYOR QUE EL NUMERO 1?: ENTONCES LA TABLA DOS ES MAYOR QUE LA PRIMERA
            if (numero2 > numero){
                Console.Write("\n");
                Console.Write("│=======================│" + "\n");
                Console.Write("La segunda tabla es mayor");
                Console.Write("\n" + "│=======================│");
            }

            //¿EL NUMERO 1 ES IGUAL QUE EL NUMERO 2?: ENTONCES LA TABLA UNO ES IGUAL QUE LA SEGUNDA
            if (numero2 == numero){
                Console.Write("\n");
                Console.Write("│=======================│" + "\n");
                Console.Write("Las tablas son iguales");
                Console.Write("\n" + "│=======================│"); ;
            }
 
            Console.ReadKey();
        }
    }
}
