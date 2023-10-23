namespace ChainOfResponsibility
{
    public class SupervisorEquipe : Autorizador
    {
        private const int _nrDiasAutorizado = 20;
        public override void AutorizarLicenca(int nrDias)
        {
            if (nrDias <= _nrDiasAutorizado)
            {
                Console.WriteLine($"O supervisor de projetos autorizou a licença de {nrDias} dias.");
            }
            else
            {
                autorizador.AutorizarLicenca(nrDias);
            }
        }
    }
}