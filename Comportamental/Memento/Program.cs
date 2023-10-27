namespace Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";

            o.RestoreState(c.Memento);

            Console.ReadKey();
        }
    }
}
