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

using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese primer numero entero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese Segundo numero entero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Agregue el operador matemático que desea usar: \n + para suma. \n - para resta \n * para multiplicacion \n / para division");
            string operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.WriteLine("Elegiste el operador suma");
                    int resultado_de_suma = num1 + num2;
                    Console.WriteLine("La suma de " + num1 + "+" + num2 + " Es: " + resultado_de_suma);
                    break;
                case "-":
                    Console.WriteLine("Elegiste el operador resta");
                    int resultado_de_resta = num1 - num2;
                    Console.WriteLine("La resta de " + num1 + "-" + num2 + " Es: " + resultado_de_resta);
                    break;
                case "*":
                    Console.WriteLine("Elegiste el operador multiplicacion");
                    int resultado_de_multiplicacion = num1 * num2;
                    Console.WriteLine("La multiplicacion " + num1 + "*" + num2 + " Es: " + resultado_de_multiplicacion);
                    break;
                case "/":
                    Console.WriteLine("Elegiste el operador division");
                    int resultado_de_division = num1 / num2;
                    Console.WriteLine("La division de " + num1 + "/" + num2 + " Es: " + resultado_de_division);
                    break;
                default:
                    Console.WriteLine("Elegiste una opcion equivocada");
                    break;
            }
        
        } catch (Exception ex)
        {
            Console.WriteLine("Ha ingresado un valor invalido, vuelva a intentar ");
        }
    } 
}