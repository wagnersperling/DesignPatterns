namespace Command
{
    public class Garcom
    {
        private Pedido _pedido;

        public Garcom(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executar()
        {
            _pedido.Execute();
        }
    }
}