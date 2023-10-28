namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteSubject celualar = new ConcreteSubject("Samsung M53", 1700, "Sem estoque.");
            Console.WriteLine($"Samsung M53 - {celualar.Disponibilidade}");

            ConcreteObserver carlos = new ConcreteObserver("Carlos", celualar);
            ConcreteObserver aline = new ConcreteObserver("Aline", celualar);
            ConcreteObserver charles = new ConcreteObserver("Charles", celualar);

            celualar.SetDisponibilidade("10 em estoque.");

            Console.ReadKey();
        }
    }
}
