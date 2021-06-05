using System;
using System.IO; 
class Producto:Ticket{
    public Producto(int numeroDeTicket, int numeroDeProductos):base(numeroDeTicket, numeroDeProductos){}

    string separador="************************";
    public override int mostrarFinalDelTicket()
    {
        try{
            Random random = new Random();
            int approvalCode = random.Next(999999);
            Random randomCard = new Random();
            int bankCard = randomCard.Next(999);
            System.Console.WriteLine(separador);
            System.Console.WriteLine(separador);
            System.Console.WriteLine("Bank card        .... .... .... "+bankCard); 
            System.Console.WriteLine("Approval Code       #"+approvalCode);
            System.Console.WriteLine(separador);
            System.Console.WriteLine("       THANK YOU!       ");
            System.Console.WriteLine(" | || ||| | || || ||||| ");
        }catch(IOException ioe){
            throw new NotImplementedException();
            System.Console.WriteLine(ioe);
        }
        return base.numeroDeProductos;
    }

    public override int agregarProductos()
    {
        try
        {
            //Definimos una lista que guardará datos de tipo String
            // List<string> lista = new List<string>();

            // //Se guardan 4 nombre de personas.
            // lista.Add("Antonio");
            // lista.Add("Josimar");
            // lista.Add("Enríquez");
            // lista.Add("Alvarado");

            // //Se muestra el contenido de la lista con un ciclo foreach
            // System.Console.WriteLine("Lista de Elementos: ");
            // foreach (string nombre in lista)
            // {
            //     System.Console.WriteLine(nombre);
            // }
        }catch(IOException ioe)
        {
            throw new NotImplementedException();
            System.Console.WriteLine(ioe);
        }
        return base.numeroDeTicket;
    }
}