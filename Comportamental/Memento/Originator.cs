namespace Memento
{
    public class Originator
    {
        private string _state;
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Console.WriteLine($"State = {_state}");
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void RestoreState(Memento memento)
        {
            Console.WriteLine("Restaurando o estado...");
            State = memento.State;
        }
    }
}