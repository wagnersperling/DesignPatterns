namespace Builder
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Fabricante fabricante = new Fabricante();
            ICelular celularBuilder;

            //celularBuilder = new AndroidBuilder();
            celularBuilder = new IphoneBuilder();
            fabricante.Construtor(celularBuilder);

            Console.WriteLine("O Celular construido foi o: " + celularBuilder.Celular.Nome);
            Console.ReadKey();
        }
    }
}