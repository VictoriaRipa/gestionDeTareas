using System;
using System.Collections.Generic; // permite utilizar la clase List

class Program
{
    static List<string> tareas = new List<string>(); //  lista que almacena las descripciones de las tareas. 

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir) // inicia un bucle while que se ejecutará mientras la variable salir sea false
        {
            Console.WriteLine("\nSistema de Gestión de Tareas");
            Console.WriteLine("1. Agregar una tarea");
            Console.WriteLine("2. Listas de tareas pendientes");
            Console.WriteLine("3. Salir del programa");
            Console.Write("Seleccione una opción: \n");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarTarea();
                        break;
                    case 2:
                        ListasDeTareasPendientes();
                        break;
                    case 3:
                        salir = true; // establece la variable salir en true, lo que provoca que el bucle while finalice y el programa termine
                        break;
                    default:
                        Console.WriteLine("\nIngrese una opcion valida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nSeleccione una opción válida.");
            }
        }
    }

    static void AgregarTarea() // permite al usuario ingresar una descripción para una nueva tarea y la agrega a la lista de tareas
    {
        Console.Write("Ingrese la descripción de la tarea: ");
        string descripcion = Console.ReadLine(); //  para obtener la descripción ingresada por el usuario
        tareas.Add(descripcion); //  la agrega a la lista
        Console.WriteLine("\nTarea agregada con éxito.");
    }

    static void ListasDeTareasPendientes() //  muestra todas las tareas en la lista tareas con sus números de tarea
    {
        Console.WriteLine("\nTareas Pendientes:");
        for (int i = 0; i < tareas.Count; i++) //  para recorrer la lista y mostrar cada tarea.
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}"); // esta es una cadena, Utiliza el formato de cadena interpolada, $. i es el índice de la tarea en la lista y se suma 1 para que las tareas se numeren a partir de 1. se muestra la descripción de la tarea (tareas[i]). Por ejemplo, si i es 0 y la descripción de la tarea es "Ir a comprar", se mostrará "1. Ir a comprar" en la consola.
        }
    }
}