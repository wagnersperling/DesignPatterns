namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GerenteProjetos gerenteProjetos = new GerenteProjetos();
            SupervisorEquipe supervisorEquipe = new SupervisorEquipe();
            SetorRh setorRh = new SetorRh();

            gerenteProjetos.ProximoAutorizador(supervisorEquipe);
            supervisorEquipe.ProximoAutorizador(setorRh);

            gerenteProjetos.AutorizarLicenca(4);
            gerenteProjetos.AutorizarLicenca(15);
            gerenteProjetos.AutorizarLicenca(25);
            gerenteProjetos.AutorizarLicenca(50);
        }
    }
}