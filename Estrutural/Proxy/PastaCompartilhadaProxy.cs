namespace Proxy
{
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada _pasta;
        private Funcionario _funcionario;

        public PastaCompartilhadaProxy(Funcionario funcionario)
        {
            _funcionario = funcionario;
        }

        public void OperacaoLeituraEscrita()
        {
            if (_funcionario.Perfil.ToUpper().Equals("CEO"))
            {
                _pasta = new PastaCompartilhada();
                _pasta.OperacaoLeituraEscrita();
            }
            else
            {
                Console.WriteLine("Você não tem permissão de acesso.");
            }
        }
    }
}