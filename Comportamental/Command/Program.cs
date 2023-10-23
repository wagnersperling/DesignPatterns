namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chef chef = new Chef();

            Pedido pedido = new Pedido(chef, "Prato");
            Garcom garcom = new Garcom(pedido);
            garcom.Executar();

            pedido = new Pedido(chef, "Sobremesa");
            garcom = new Garcom(pedido);
            garcom.Executar();

            Console.ReadKey();
        }
    }
}
