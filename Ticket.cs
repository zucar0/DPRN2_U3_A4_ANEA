abstract class Ticket{
    //Datos miembro.
    protected int numeroDeTicket;
    protected int numeroDeProductos;
    //Declaración de variables
    string separador="****************************";
    //Método Pais con parámetros
    public Ticket(int numeroTicket, int numerProductos){
        numeroDeTicket=numeroTicket;
        numeroDeProductos=numerProductos;
    }
    //Método para mostrar país elegido
    public void mostrarHeaderDelTicket(){
        if(numeroDeTicket>=1){
            System.Console.WriteLine("          SHOP NAME           ");
            System.Console.WriteLine("  Address: Lorem Ipsum, 23-10 ");
            System.Console.WriteLine("         Telp. 11223344       ");
            System.Console.WriteLine(separador);
            System.Console.WriteLine("          CASH RECEIPT        ");
            System.Console.WriteLine(separador);
        }else{
            System.Console.WriteLine("Existió un error al generar el ticket.");
        }
    }
    public abstract int mostrarFinalDelTicket();
    //Interfaz para el pais
    public int DatoTicket{
        get{
            return numeroDeTicket;
        }set{
            numeroDeTicket = value;
        }
    }
    public int DatoProducto{
        get
        {
            return numeroDeProductos;
        }
        set
        {
            numeroDeProductos = value;
        }
    }
    //Destructor
    ~Ticket() {
        numeroDeProductos=0; 
        numeroDeTicket=0;
        // Console.Write("Este es el destructor ejecutándose para destruir el objeto de la clase Factura");
    } 
}