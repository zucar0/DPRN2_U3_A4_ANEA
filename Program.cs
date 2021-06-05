using System;

namespace DPRN2_U3_A4_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este programa debe de pedir el número de tickets y productos 
            System.Console.WriteLine("Ingresar el número de tickets: ");  
            var numeroDeticket = System.Console.ReadLine();
            int numberOfTickets = int.Parse(numeroDeticket);
            System.Console.WriteLine("Ingresar el número de productos: ");  
            var numeroDeProductos = System.Console.ReadLine();
            int numberOfProducts = int.Parse(numeroDeProductos);
            try
            {
                Producto ticketInterface = new Producto(numberOfTickets,numberOfProducts);
                ticketInterface.mostrarHeaderDelTicket();
                // ticketInterface.mostrarFinalDelTicket();
            }
            catch(IndexOutOfRangeException arrayException)
            {
                System.Console.WriteLine(arrayException);
            }
        }
    }
}
