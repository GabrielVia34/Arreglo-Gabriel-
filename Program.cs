using System;


namespace Arreglo
{
    class Arreglo
    {
        static void Main()
        {
            Console.Write("Ingresar la cantidad de palabras en el arreglo: ");
            int n = int.Parse(Console.ReadLine());


            string[] arreglo = new string[n];


            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingresar la palabra para la posición {i}: ");
                arreglo[i] = Console.ReadLine();
            }


            Console.WriteLine("Arreglo original: ");
            MostrarArreglo(arreglo);


            Console.Write("Ingresar la posición que desea eliminar: ");
            int posicion = int.Parse(Console.ReadLine());


            if (posicion < 0 || posicion >= n)
            {
                Console.WriteLine("La posición inválida. Por favor ingrese un número entre 0 y " + (n - 1));
            }
            else
            {

                string[] nuevoArreglo = new string[n - 1];


                for (int i = 0, j = 0; i < n; i++)
                {
                    if (i != posicion)
                    {
                        nuevoArreglo[j] = arreglo[i];
                        j++;
                    }
                }


                Console.WriteLine("El Arreglo después de eliminar la palabra en la posición " + posicion + ":");
                MostrarArreglo(nuevoArreglo);
            }
        }


        static void MostrarArreglo(string[] arr)
        {
            foreach (string palabra in arr)
            {
                Console.Write(palabra + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
