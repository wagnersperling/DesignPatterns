namespace Observer
{
    public class ConcreteObserver : IObserver
    {
        public string Usuario { get; set; }

        public ConcreteObserver(string nome, ISubject subject)
        {
            Usuario = nome;
            subject.RegistrarObserver(this);
        }
        public void Atualizar(string disponibilidade, string produto)
        {
            Console.WriteLine($"Oi {Usuario} a diponibilidade do produto {produto} agora é {disponibilidade}.");
        }
    }
}