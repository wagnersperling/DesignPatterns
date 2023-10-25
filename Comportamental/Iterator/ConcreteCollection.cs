namespace PadraoIterator
{
    //ConcreteAggregate
    public class ConcreteCollection : IAbstractCollection
    {
        private List<Cliente> listaClientes = new List<Cliente>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return listaClientes.Count; }
        }

        public void AddCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        public Cliente GetCliente(int posicao)
        {
            return listaClientes[posicao];
        }
    }
}