namespace State
{
    public class Program
    {
        public static void Main()
        {
            Context context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            Console.ReadKey();
        }
    }
}