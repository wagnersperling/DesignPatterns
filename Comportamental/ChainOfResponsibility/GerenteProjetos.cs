namespace ChainOfResponsibility
{
    public class GerenteProjetos : Autorizador
    {
        private const int _nrDiasAutorizado = 5;
        public override void AutorizarLicenca(int nrDias)
        {
            if (nrDias <= _nrDiasAutorizado)
            {
                Console.WriteLine($"O gerente de projetos autorizou a licença de {nrDias} dias.");
            }
            else
            {
                autorizador.AutorizarLicenca(nrDias);
            }
        }
    }
}