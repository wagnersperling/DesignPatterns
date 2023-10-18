namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza queijoDecorator = new QueijoDecorator(pizza);
            IPizza baconDecorator = new BaconDecorator(queijoDecorator);

            Console.WriteLine(baconDecorator.BuscarTipoPizza());
            Console.WriteLine();
        }
    }
}
