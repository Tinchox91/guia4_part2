using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4_part2
{
    internal class Ejercicios
    {
        public void sumarNumeros() {
            int n = 0;
            int suma = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Para salir oprima '0'");
            do {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ingrese un numero: ");
                Console.ForegroundColor = ConsoleColor.White;
                n = int.Parse(Console.ReadLine());

                suma += n;
            } while (n != 0);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("La suma es: " + suma);
            Console.ReadKey();

        }

        public void contar()
        {
            int num;
            int cont = 0;
            int cont2 = 0;
            do
            {
                num = 0;
                cont2 = 0;
                Console.Write("Ingrese un numero: ");
                cont = int.Parse(Console.ReadLine());
                while (cont2 < cont)
                {
                    cont2++;

                    if (cont2 == cont)
                    {
                        Console.Write(cont2);
                    }
                    else
                    {
                        Console.Write($"{cont2} -");
                    }
                }
                Console.WriteLine("\n Oprima '0' para salir o otro numero para continuar...");
                num = int.Parse(Console.ReadLine());
            } while (num != 0);

        }
        public void convertir()
        {
            int contador = 0;
            double celcius = 0;
            double far;
            int contador2;
            do
            {
                contador2 = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ingrese los grados Celsius: ");
                Console.ForegroundColor = ConsoleColor.White;
                celcius = double.Parse(Console.ReadLine());
                far = 1.8 * celcius + 32;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Total seria: {celcius}° = {far}F");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Desea continuar? - Apretar cualquier numero para SI / '0' par SALIR ");
                Console.ForegroundColor = ConsoleColor.White;
                contador2 = int.Parse(Console.ReadLine());

            } while (contador2 != 0);
        }
        public void contadorDeVocales()
        {
            string vocal = "";
            int contador1 = 0;
            int contador2 = 0;
            int vocales = 0;
            do
            {
                Console.Write("Inserte una palabra: ");
                vocal = Console.ReadLine();
                vocal = vocal.ToLower();
                contador2 = 0;
                vocales = 0;

                while (contador2 < vocal.Length)

                {
                    if (vocal[contador2] == 'a' || vocal[contador2] == 'e' || vocal[contador2] == 'o' || vocal[contador2] == 'u' || vocal[contador2] == 'i')
                    {
                        vocales++;
                    }
                    contador2++;
                }
                Console.WriteLine("En total hay " + vocales);

                Console.WriteLine("Desea continuar?_Inserte '0' para Salir. U otro numero para continuar...");
                contador1 = int.Parse(Console.ReadLine());
            } while (contador1 != 0);

            Console.ReadLine();
        }
        public void calculadora()
        {
            double num1,num2;
            int cont = 0;
            double total;
            do
            {
                total= 0;
                cont = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el primer numero: ");
                num1=double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Indica la operacion que desea realizar");
                Console.WriteLine("1.SUMA");
                Console.WriteLine("2.RESTA");
                Console.WriteLine("3.MULTIPLICACION");
                Console.WriteLine("4.DIVISION");
                Console.WriteLine("0.SALIR");
                cont=int.Parse(Console.ReadLine());
                switch (cont)
                {
                    case 1: total = num1 + num2;
                        Console.WriteLine("El total es: " + total);
                        break;
                        case 2: total = num1 - num2;
                        Console.WriteLine("El total es: " + total);
                        break;
                        case 3: total = num1 * num2;
                        Console.WriteLine("El total es: " + total);
                        break;
                        case 4: if (num1!= 0 && num2 != 0)
                        {
                            total=num1/num2;
                            Console.WriteLine("El total es: "+total);
                        }
                        else
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("NO SE PUEDE DIVIDIR POR 0");
                        }
                        break;
                }


            } while (cont != 0);
            
        }
        public void par() { 
            double num = 0;      
                do
	{
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Ingrese '0' para SALIR.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Ingrese un numero: ");
                num=double.Parse(Console.ReadLine());
if (num % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Es PAR");
                }else
                {
                    Console.ForegroundColor= ConsoleColor.DarkMagenta;
                    Console.WriteLine("Es IMPAR");
                }
                
               

            } while (num!=0);

        }
        public void edad() {
            int edad = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Ingrese '0' para SALIR.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Ingrese EDAD: ");
                edad = int.Parse(Console.ReadLine());
                if (edad< 18)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Es Menor");
                }
                else if (edad>= 18)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Es Mayor");
                }



            } while (edad != 0);
        }
        public void cadenas()
        {
            string cadena="";
            int cantidad;
            int cont=0;
            do
            {
               Console.ForegroundColor=ConsoleColor.DarkBlue;
                Console.WriteLine("Para salir solo apretar enter");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Ingrese cadena: ");
                Console.ForegroundColor = ConsoleColor.White;
                cadena = Console.ReadLine();
                cantidad =cadena.Length;
                Console.WriteLine("Cantidad de caracteres: "+cantidad);
               
            } while (cantidad!=0);
            
        }
        public void areaCirculo()
        {
            double area,radio;
            do
            {
                radio = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese 0 para Salir...");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Ingrese Radio: ");
                Console.ForegroundColor = ConsoleColor.White;
                radio = double.Parse(Console.ReadLine());
                area=3.14* (radio*radio);
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("El area es: "+area);

            } while (radio!=0);
            
        }
        public void mayusculas()
        {
            string texto;
            string mayuscula;
            int salir;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Ingrese texto: ");
                Console.ForegroundColor = ConsoleColor.White;
                texto = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                mayuscula = texto.ToUpper();
                Console.WriteLine(mayuscula);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Desea continuar? ingrese '0' para salir: ");
                try
                {
                    salir = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {                                    
                    salir = 1;                    
                }               

            } while (salir!=0);
        }
        public void mayor()
        {
            int num1,num2,num3;
            int mayor;
            int salir = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el numero: ");
                num1 = int.Parse(Console.ReadLine());
               
                Console.Write("Ingrese el numero: ");
                num2 = int.Parse(Console.ReadLine());
                if (num1>num2)
                {
                    mayor = num1;
                }
                else
                {
                    mayor = num2;
                }
                Console.Write("Ingrese el numero: ");
                num3 = int.Parse(Console.ReadLine());
                if (mayor < num3)
                {
                    mayor = num3;
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"el mayor es: {mayor}");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Ingrese '0' para salir: ");
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    salir = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    salir = 1;

                }
               
                
            } while (salir!=0);
            
        }
        public void calcularPromedios()
        {
            double num, prom,cantidad;
            int cont = 0;
            int val2 = 0;
            cantidad = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Ingrese '0' para salir...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingresa un numero ");
                num = double.Parse(Console.ReadLine());
                if (num != 0)
                {
                    cantidad +=num;
                }
                else
                {
                    break;
                }
                
                cont ++;
            } while (num!=0);
            prom = cantidad / cont;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"El promedio total de {cont} numeros es: {prom}");
            Console.ReadKey();
        }
        public void adivinar()
        {
            Random random = new Random();
            int numeroScreto = random.Next(1, 100);
            Console.WriteLine(numeroScreto);
            int num = 0;
            int cont = 0;
            int val;
              
            do
            {
                Console.Write("Ingrese un numero: ");
                val = int.Parse(Console.ReadLine());
                cont++;
                if (val == numeroScreto)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Numero Descubierto!!!!!");
                    cont = 100;
                }
            } while (cont!=100);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadKey();
                
        }
        public void numeroPrimo()
        {
            double num, primo;
            Boolean esPrimo = false;
            int cont = 0;
            do
            {
                esPrimo = false;
                cont = 2;
                primo = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingresar numero: ");
                num = double.Parse(Console.ReadLine());
                
                if (num == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO ES PRIMO");
                }
                else
                {
                    while (cont<=Math.Sqrt(num))
                    {
                        if (num % cont == 0)
                        {
                            esPrimo = true;
                        }
                        
                        cont++;
                    }
                    if (esPrimo)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NO ES PRIMO");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(" ES PRIMO");
                    }
                }
                

               
            } while (num!=0);
          
           
            Console.ReadKey();
        }
        public void reversar()
        {
            string cadena1;
            string cadena2 = "";
            int val = 0;
            int cont,indice;

            do
            {
                indice = 0;
                cont = 0;
                cadena2 = "";
               
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Ingrese cadena");
                Console.ForegroundColor = ConsoleColor.White;
                cadena1 = Console.ReadLine();
                int longi = cadena1.Length;
                while (cont!=cadena1.Length)
                {
                    indice = longi - cont;
                    cadena2+= cadena1[indice-1];
                    cont++;
                }
                
                Console.Write("La palabra en reversa: ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(cadena2);
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Quiere continuar?...Ingresar 0 para salir");
                    val = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    val = 2;  
                }
                
            } while (val!=0);
            Console.ReadLine();
        }
        }
    }

