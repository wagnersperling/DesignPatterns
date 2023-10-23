namespace ChainOfResponsibility
{
    public class SetorRh : Autorizador
    {
        private const int _nrDiasAutorizado = 30;
        public override void AutorizarLicenca(int nrDias)
        {
            if (nrDias <= _nrDiasAutorizado)
            {
                Console.WriteLine($"O setor de RH autorizou a licença de {nrDias} dias.");
            }
            else
            {
                Console.WriteLine($"Não é possivel autorizar {nrDias} dias de licença.");
            }
        }
    }
}