﻿//Ejercicio 1
//using System;
//class Program
//{
//    static void Main()
//    {
//        while (true)
//        {
//            Console.Write("Introduce un número entero positivo para poder avanzar: ");
//            int num = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Elige una opción: \n1. Calcular el factoria del numero \n2. Calcular la raiz cuadrada del numero \n3 Salir del programa ");
//            int opcion = Convert.ToInt32(Console.ReadLine());


//            switch (opcion)
//            {
//                case 1:
//                    Console.WriteLine("El factorial de " + num + " es " + Factorial(num));
//                    break;
//                case 2:
//                    Console.WriteLine("La raíz cuadrada de " + num + " es " + Math.Sqrt(num));
//                    break;
//                case 3:
//                    Console.WriteLine("Saliendo del programa");
//                    return;
//                default:
//                    Console.WriteLine("Opción no válida. Inténtalo de nuevo..");
//                    break;
//            }
//        }
//    }

//    static long Factorial(int num)
//    {
//        long factorial = 1;
//        for (int i = 1; i <= num; i++)
//        {
//            factorial *= i;
//        }
//        return factorial;
//    }
//}
//EJERCICIO 2
//using System;
//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            Console.WriteLine("Ingrese primer numero entero");
//            int num1 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Ingrese Segundo numero entero");
//            int num2 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Agregue el operador matemático que desea usar: \n + para suma. \n - para resta \n * para multiplicacion \n / para division");
//            string operador = Console.ReadLine();

//            switch (operador)
//            {
//                case "+":
//                    Console.WriteLine("Elegiste el operador suma");
//                    int resultado_de_suma = num1 + num2;
//                    Console.WriteLine("La suma de " + num1 + "+" + num2 + " Es: " + resultado_de_suma);
//                    break;
//                case "-":
//                    Console.WriteLine("Elegiste el operador resta");
//                    int resultado_de_resta = num1 - num2;
//                    Console.WriteLine("La resta de " + num1 + "-" + num2 + " Es: " + resultado_de_resta);
//                    break;
//                case "*":
//                    Console.WriteLine("Elegiste el operador multiplicacion");
//                    int resultado_de_multiplicacion = num1 * num2;
//                    Console.WriteLine("La multiplicacion " + num1 + "*" + num2 + " Es: " + resultado_de_multiplicacion);
//                    break;
//                case "/":
//                    Console.WriteLine("Elegiste el operador division");
//                    int resultado_de_division = num1 / num2;
//                    Console.WriteLine("La division de " + num1 + "/" + num2 + " Es: " + resultado_de_division);
//                    break;
//                default:
//                    Console.WriteLine("Elegiste una opcion equivocada");
//                    break;
//            }

//        } catch (Exception ex)
//        {
//            Console.WriteLine("Ha ingresado un valor invalido, vuelva a intentar ");
//        }
//    } 
//}
//Ejercicio 3
//using System;
//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            Console.WriteLine("Ingrese un numero entero para mostrarle una tabla de multiplicar el 1 al 10");
//            int num = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine(num + "*" + i + "=" + num * i);
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Ha ingresado un valor invalido, vuelva a intentar");
//        }
//    }
//}
//Ejercicio 4 
Random random = new Random();
int numeroAleatorio = random.Next(1, 101);
int intentos = 0;
int intentoUsuario;

Console.WriteLine("Adivina el numero correcto");
Console.WriteLine("Se ha generado un numero aleatorio entre 1 y 100 adivina cual es: ");

do
{
    Console.Write("Ingresa un numero: ");
    intentoUsuario = Convert.ToInt32(Console.ReadLine());
    intentos++;

    if (intentoUsuario < numeroAleatorio)
    {
        Console.WriteLine("El número es mayor. ¡Intenta nuevamente!");
    }
    else if (intentoUsuario > numeroAleatorio)
    {
        Console.WriteLine("El número es menor. ¡Intenta nuevamente!");
    }
    else
    {
        Console.WriteLine("¡Felicidades! Has adivinado el número en " + intentos + " intentos.");
    }

} while (intentoUsuario != numeroAleatorio);