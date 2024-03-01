using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Introduce un número entero positivo para poder avanzar: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elige una opción: \n1. Calcular el factoria del numero \n2. Calcular la raiz cuadrada del numero \n3 Salir del programa ");
            int opcion = Convert.ToInt32(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El factorial de " + num + " es " + Factorial(num));
                    break;
                case 2:
                    Console.WriteLine("La raíz cuadrada de " + num + " es " + Math.Sqrt(num));
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo..");
                    break;
            }
        }
    }

    static long Factorial(int num)
    {
        long factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}