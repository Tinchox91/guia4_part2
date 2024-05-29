using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4_part2
{
    internal class Inicio
    {
        static void Main(string[] args)
        {
            Ejercicios ej = new Ejercicios();
            int op = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Indica opcion:");
                Console.WriteLine("1. Sumar numeros");
                Console.WriteLine("2. Contar hasta un numero");
                Console.WriteLine("3. Convertir Temperaturas");
                Console.WriteLine("4. Contador de Vocales");
                Console.WriteLine("5. Calculadora Basica");
                Console.WriteLine("6. Numero para o impar");
                Console.WriteLine("7. Validar Edad");
                Console.WriteLine("8. Determinar la longitud de una cadena");
                Console.WriteLine("9. Calcular el area de un Circulo");
                Console.WriteLine("10. Convertir texto a Mayusculas");
                Console.WriteLine("11. Encontrar el Mayor de Tres numeros");
                Console.WriteLine("12. Calcular el Promedio de N numeros");
                Console.WriteLine("13. Juego de adivinar numero");
                Console.WriteLine("14. Verificar si un Numero es Primo");
                Console.WriteLine("15. Reversar una Cadena de Texto");
                op=int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:ej.sumarNumeros();break;
                    case 2: ej.sumarNumeros();break;
                    case 3:ej.contar();break;
                    case 4:ej.convertir();break;
                    case 5: ej.calculadora();break;
                    case 6:ej.par();break;
                    case 7:ej.edad();break;
                    case 8:ej.cadenas();break;
                    case 9:ej.areaCirculo();break;
                    case 10:ej.mayusculas();break;
                    case 11:ej.mayor();break;
                    case 12:ej.calcularPromedios();break;
                    case 13:ej.adivinar();break;
                    case 14:ej.numeroPrimo();break;
                    case 15:ej.reversar();break;
                }
                Console.Clear();


            } while (op!=0);
        }
    }
}
