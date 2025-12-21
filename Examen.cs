using System;
using System.Linq;

namespace EXAMEN_2DO_PARCIAL;

public static class Program
{
    public static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("Menu de operaciones:");
            Console.WriteLine("1 Calcular el doble de un numero");
            Console.WriteLine("2 Calcular el triple de un número");
            Console.WriteLine("3 Calcular el cuadrado de un número");
            Console.WriteLine("4 Salir");
            Console.WriteLine("Elija una opcion");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nOpcion elegida = {opcion}");

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Elegiste Calcular el doble de un numero");
                    Console.WriteLine("Elige un numero:");
                    int numero1 = int.Parse(Console.ReadLine());
                    int doble = numero1 * 2;
                    Console.WriteLine($"\nEl doble del numero es = {doble}");
                    break;
                case 2:
                    Console.WriteLine("Elegiste Calcular el triple de un numero");
                    Console.WriteLine("Elige un numero");
                    int numero2 = int.Parse(Console.ReadLine());
                    int triple = numero2 * 3;
                    Console.WriteLine($"\nEl triple del numero es = {triple}");
                    break;
                case 3:
                    Console.WriteLine("Elegiste Calcular el cuadrado de un numero");
                    Console.WriteLine("Elige un numero");
                    int numero3 = int.Parse(Console.ReadLine());
                    int cuadrado = numero3 * numero3;
                    Console.WriteLine($"\nEl cuadrado del numero es = {cuadrado}");
                    break;
                case 4:
                    Console.WriteLine("Elegiste salir, gracias por usar la calculadora");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } while (opcion != 4);
    }
}


