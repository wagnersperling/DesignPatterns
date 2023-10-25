namespace PadraoIterator
{
    public class Iterator : IAbstractInterator
    {
        private int _current = 0;
        private int _step = 1;

        private ConcreteCollection collection;

        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }

        public bool IsDone
        {
            get
            {
                return _current >= collection.Count;
            }
        }

        public Cliente First()
        {
            _current = 0;
            return collection.GetCliente(_current);
        }

        public Cliente Next()
        {
            _current += _step;
            if (!IsDone)
            {
                return collection.GetCliente(_current);
            }
            else
            {
                return null;
            }
        }
    }
}