namespace PadraoIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCollection colecao = new ConcreteCollection();
            colecao.AddCliente(new Cliente(5, "Carlos"));
            colecao.AddCliente(new Cliente(9, "Aline"));
            colecao.AddCliente(new Cliente(20, "Wagner"));
            colecao.AddCliente(new Cliente(48, "Maria"));

            Iterator iterator = colecao.CreateIterator();

            Console.WriteLine("Iterando sobre a coleção.");
            for (Cliente cliente = iterator.First(); !iterator.IsDone; cliente = iterator.Next())
            {
                Console.WriteLine($"ID : {cliente.Id}  Nome : {cliente.Nome}");
            }
            Console.Read();
        }
    }
}