namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var funcionarioTi = new Funcionario("Carlos", "12345", "TI");
            PastaCompartilhadaProxy pastaProxy1 = new PastaCompartilhadaProxy(funcionarioTi);
            pastaProxy1.OperacaoLeituraEscrita();

            var funcionarioCeo = new Funcionario("Wagner", "54321", "CEO");
            PastaCompartilhadaProxy pastaProxy2 = new PastaCompartilhadaProxy(funcionarioCeo);
            pastaProxy2.OperacaoLeituraEscrita();
        }
    }
}
