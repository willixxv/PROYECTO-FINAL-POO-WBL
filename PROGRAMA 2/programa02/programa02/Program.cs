using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa02
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero,numero2, index, index2;
            string leer, leer2;

            //TODOS LOS DERECHOS RESERVADOS 2017
            Console.Write("┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴" + "\n");
            Console.Write("WILLI J. BIDO LORA - 15 -EISN-1-159" + "\n");
            Console.Write("┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬" + "\n");
            Console.Write("\n");

            //PRIMER NUMERO
            Console.Write("Ingrese el valor del numero » » » ");
            leer = Console.ReadLine();
            numero = float.Parse(leer);
            index = 1;

            while(index <= numero)
            {
                Console.Write(index);
                if (numero >= 20)
                {
                    index = index * 2;
                }
                Console.Write(" » (" + (index * index) + ")");
                Console.Write("\n");
                index = index + 1;
            }

            //SEGUNDO NUMERO
            Console.Write("\n");
            Console.Write("Ingrese el valor del numero » » » ");
            leer2 = Console.ReadLine();
            numero2 = float.Parse(leer2);
            index2 = 1;

            while (index2 <= numero2)
            {
                Console.Write(index2);
                if (numero2 >= 10)
                {
                    index2 = index2 + 1000;
                }
                Console.Write(" » (" + (index2 * index2) + ")");
                Console.Write("\n");
                index2 = index2 + 1;
            }

            //GLICH ERROR!!!
            if(numero >= 15)
            {
                while (numero >= numero2)
                {
                    Console.Write("┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴ ┴" + "\n");
                    Console.Write("WILLI J. BIDO LORA - 15 -EISN-1-159" + "\n");
                    Console.Write("┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬ ┬" + "\n");
                }

            }
            
            Console.ReadKey();
        }
    }

}
