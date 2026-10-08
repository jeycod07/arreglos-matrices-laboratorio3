using System;

class Program
{
    static void Main()
    // Sección 1: arreglo de 10 números
    {
        // Crear un arreglo de 10 números enteros
        int[] numeros = new int[10];

        Console.WriteLine("=== ARREGLO DE 10 NUMEROS ===");

        // Ingresar los 10 números
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese el numero " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Mostrar los números ingresados
        Console.WriteLine("\n=== NUMEROS INGRESADOS ===");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Posicion " + i + ": " + numeros[i]);
        }

        Console.Write("\nIngrese el nuevo valor para el tercer elemento: ");
        numeros[2] = int.Parse(Console.ReadLine());

        Console.WriteLine("\n=== ARREGLO MODIFICADO ===");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Posicion " + i + ": " + numeros[i]);
        }
        // Buscar un número
        Console.Write("\nIngrese un número para buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0; i < 10; i++)
        {
           if (numeros[i] == buscar)
            {
              encontrado = true;
              break;
            }
        }

        if (encontrado)
        {
          Console.WriteLine("El número SI existe en el arreglo.");
        }
        else
        {
          Console.WriteLine("El número NO existe en el arreglo.");
        }
        
        // Matriz de 3 x 3
        // Sección 4: matriz 3x3 y cálculo de suma
        int[,] matriz = new int[3, 3];

        Console.WriteLine("\n=== MATRIZ 3 X 3 ===");

        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
           {
              Console.Write("Ingrese el valor para [" + fila + "," + columna + "]: ");
              matriz[fila, columna] = int.Parse(Console.ReadLine());
            }
        }
         
        Console.WriteLine("\n=== MATRIZ ===");

        for (int fila = 0; fila < 3; fila++)
        {
          for (int columna = 0; columna < 3; columna++)
           {
             Console.Write(matriz[fila, columna] + "\t");
           }

            Console.WriteLine();
        }
        int suma = 0;

        for (int fila = 0; fila < 3; fila++)
       {
             for (int columna = 0; columna < 3; columna++)
            {
                suma += matriz[fila, columna];
            }
       }

        Console.WriteLine("\nSuma total: " + suma);

        // Sección 3: operaciones con listas
        List<int> lista = new List<int>();
        Console.Write("\nIngrese un número para agregar a la lista: ");
        int nuevoNumero = int.Parse(Console.ReadLine());

        lista.Add(nuevoNumero);

        Console.WriteLine("Número agregado correctamente.");

        Console.WriteLine("\n=== LISTA ACTUAL ===");

        for (int i = 0; i < lista.Count; i++)
       {
         Console.WriteLine("Posicion " + i + ": " + lista[i]);
       }
       Console.Write("\nIngrese la posicion que desea eliminar: ");
       int posicionEliminar = int.Parse(Console.ReadLine());

       if (posicionEliminar >= 0 && posicionEliminar < lista.Count)
       {
          lista.RemoveAt(posicionEliminar);
          Console.WriteLine("Elemento eliminado correctamente.");
       }
       else
       {
         Console.WriteLine("La posicion no es valida.");
       }
       Console.Write("\nIngrese un número para buscar en la lista: ");
       int numeroBuscar = int.Parse(Console.ReadLine());

       int posicionEncontrada = lista.IndexOf(numeroBuscar);

       if (posicionEncontrada != -1)
       {
         Console.WriteLine("El número se encuentra en la posición: " + posicionEncontrada);
       }
       else
       {
         Console.WriteLine("El número no se encuentra en la lista.");
       }

       Console.WriteLine("\n=== LISTA ACTUALIZADA ===");

       for (int i = 0; i < lista.Count; i++)
       {
         Console.WriteLine("Posicion " + i + ": " + lista[i]);
       }

       // Sección 4: ordenamiento burbuja y selección
       int[] listaOrdenar = { 5, 2, 9, 1, 7 };
       Console.WriteLine("\n=== ANTES DE ORDENAR ===");

       for (int i = 0; i < listaOrdenar.Length; i++)
       {
         Console.Write(listaOrdenar[i] + " ");
       }
       Console.WriteLine();

       for (int i = 0; i < listaOrdenar.Length - 1; i++)
       {
           for (int j = 0; j < listaOrdenar.Length - 1 - i; j++)
           {
              if (listaOrdenar[j] > listaOrdenar[j + 1])
               {
                 int temporal = listaOrdenar[j];
                 listaOrdenar[j] = listaOrdenar[j + 1];
                 listaOrdenar[j + 1] = temporal;
               }
           }
       }
       Console.WriteLine("\n=== DESPUES DE ORDENAR CON BURBUJA ===");

       for (int i = 0; i < listaOrdenar.Length; i++)
       {
         Console.Write(listaOrdenar[i] + " ");
       }
       Console.WriteLine();

       int[] listaSeleccion = { 5, 2, 9, 1, 7 };
       for (int i = 0; i < listaSeleccion.Length - 1; i++)
       {
          int posicionMenor = i;

          for (int j = i + 1; j < listaSeleccion.Length; j++)
           {
               if (listaSeleccion[j] < listaSeleccion[posicionMenor])
               {
                 posicionMenor = j;
               }
           }

           int temporal = listaSeleccion[i];
           listaSeleccion[i] = listaSeleccion[posicionMenor];
           listaSeleccion[posicionMenor] = temporal;
       }
       Console.WriteLine("\n=== DESPUES DE ORDENAR CON SELECCION ===");

       for (int i = 0; i < listaSeleccion.Length; i++)
       {
         Console.Write(listaSeleccion[i] + " ");
       }
       Console.WriteLine();
    }
}
