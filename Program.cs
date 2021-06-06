using System;
using System.Collections.Generic;
namespace DPRN2_U3_A4_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            string a="a. Agregar elemento a ticket";
            string b="b. Eliminar elemento del ticket";
            string c="c. Finalizar venta";
            string d="d. Cancelar venta";
            string e="e. Imprimir ticket";
            //Este programa debe de pedir el número de tickets y productos 
            System.Console.WriteLine("Ingresar el número de tickets: ");  
            var numeroDeticket = System.Console.ReadLine();
            int numberOfTickets = int.Parse(numeroDeticket);
            System.Console.WriteLine("Ingresar el número de productos: ");  
            var numeroDeProductos = System.Console.ReadLine();
            int numberOfProducts = int.Parse(numeroDeProductos);
            try
            {
                string eleccion ="";
                System.Console.WriteLine("¿Qué deseas hacer?");
                System.Console.WriteLine(a+"\n"+b+"\n"+c+"\n"+d+"\n"+e);
                var opcion = Console.ReadLine();
                eleccion=opcion;
                //Definimos una lista que guardará datos de tipo String
                List<string> listaProductos = new List<string>();
                List<string> listaPrecios = new List<string>();
                while(eleccion=="a"||eleccion=="b"||eleccion=="c"||eleccion=="d"||eleccion=="e"){
                    do
                    {
                        switch(eleccion)
                        {
                            case "a" when (eleccion=="a"):
                                System.Console.WriteLine("Por favor ingresa el nombre del producto:");
                                var nombreDelProducto= Console.ReadLine();
                                listaProductos.Add(nombreDelProducto);
                                System.Console.WriteLine("Por favor ingresa el precio del producto:");
                                var precioDelProducto= Console.ReadLine();
                                listaPrecios.Add(precioDelProducto);
                            break;
                            case "b" when (eleccion=="b"):
                                System.Console.WriteLine("Procederemos a eliminar elementos del ticket. ");
                                System.Console.WriteLine("Indícanos qué producto deseas eliminar: ");
                                foreach (string producto in listaProductos)
                                {
                                    System.Console.WriteLine(producto);
                                }
                                var productoAEliminar=Console.ReadLine();
                                listaProductos.Remove(productoAEliminar);
                            break;
                            case "c" when (eleccion=="c"):
                                System.Console.WriteLine("Procederemos a finalizar al venta.");
                                Environment.Exit(0);
                            break;
                            case "d" when (eleccion=="d"):
                                System.Console.WriteLine("Se ha cancelado la venta.");
                                Environment.Exit(0);
                            break;
                            case "e" when (eleccion=="e"):
                                System.Console.WriteLine("Procederemos a imprimir el ticket.");
                                Producto ticketInterface = new Producto(numberOfTickets,numberOfProducts);        
                                ticketInterface.mostrarHeaderDelTicket();

                                ticketInterface.mostrarFinalDelTicket();
                                Environment.Exit(0);
                            break;    
                        }

                        if(eleccion=="a" || eleccion=="b" || eleccion=="c" || eleccion=="d"|| eleccion=="e")
                        {
                            System.Console.WriteLine("¿Qué otra cosa deseas hacer?\n"+a+"\n"+b+"\n"+c+"\n"+d+"\n"+e);
                            var quedesea = Console.ReadLine();
                            eleccion=quedesea;
                            if(eleccion=="a"){
                                System.Console.WriteLine("Agregaremos otro elemento al ticket");
                                System.Console.WriteLine("Por favor ingresa el nombre del producto:");
                                var nombreDelProducto= Console.ReadLine();
                                listaProductos.Add(nombreDelProducto);
                                System.Console.WriteLine("Por favor ingresa el precio del producto:");
                                var precioDelProducto= Console.ReadLine();
                                listaPrecios.Add(precioDelProducto);
                            }
                            else if(eleccion=="b"){
                                System.Console.WriteLine("Eliminaremos un elemento del ticket");
                                System.Console.WriteLine("Indícanos qué producto deseas eliminar: ");
                                foreach (string producto in listaProductos)
                                {
                                    System.Console.WriteLine(producto);
                                }
                                var productoAEliminar=Console.ReadLine();
                                listaProductos.Remove(productoAEliminar);
                            }
                            else if (eleccion=="c"){
                                System.Console.WriteLine("La venta finalizará.");
                                Environment.Exit(0);
                            }
                            else if (eleccion=="d")
                            {
                                System.Console.WriteLine("Se realizó la cancelación de la venta.");
                                Environment.Exit(0);
                            }
                            else if (eleccion=="e")
                            {
                                System.Console.WriteLine("Imprimiremos el ticket.");
                                Producto ticketInterface = new Producto(numberOfTickets,numberOfProducts);        
                                ticketInterface.mostrarHeaderDelTicket();
                                 
                                ticketInterface.mostrarFinalDelTicket();
                                Environment.Exit(0);
                            }
                        }
                    }
                    while(eleccion=="a"||eleccion=="b");  
                }
            }
            catch(IndexOutOfRangeException arrayException)
            {
                System.Console.WriteLine(arrayException);
            }
        }
    }
}
