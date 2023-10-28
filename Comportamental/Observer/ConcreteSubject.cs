namespace Observer
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string Produto { get; set; }
        public int Preco { get; set; }
        public string Disponibilidade { get; set; }

        public ConcreteSubject(string produto, int preco, string status)
        {
            Produto = produto;
            Preco = preco;
            Disponibilidade = status;
        }

        public string GetDisponibilidade()
        {
            return Disponibilidade;
        }

        public void SetDisponibilidade(string status)
        {
            Disponibilidade = status;
            Console.WriteLine($"A disponibilidade mudou para {Disponibilidade}.");
            NotificarObservers();
        }

        public void NotificarObservers()
        {
            foreach (var observer in observers)
            {
                observer.Atualizar(Disponibilidade, Produto);
            }
        }

        public void RegistrarObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoverObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}