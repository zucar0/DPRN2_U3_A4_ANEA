using System;
using System.IO; 
class Producto:Ticket{
    //Variables

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
}