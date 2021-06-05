using System;
using System.Collections.Generic;

namespace DPRN2_U3_A4_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //Definimos una lista que guardará datos de tipo String
            List<string> lista = new List<string>();

            //Se guardan 4 nombre de personas.
            lista.Add("Antonio");
            lista.Add("Josimar");
            lista.Add("Enríquez");
            lista.Add("Alvarado");

            //Se muestra el contenido de la lista con un ciclo foreach
            System.Console.WriteLine("Lista de Elementos: ");
            foreach (string nombre in lista)
            {
                System.Console.WriteLine(nombre);
            }
            
        }
    }
}
