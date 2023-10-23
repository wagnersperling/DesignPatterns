namespace ChainOfResponsibility
{
    public abstract class Autorizador
    {
        protected Autorizador autorizador;

        public void ProximoAutorizador(Autorizador autorizador)
        {
            this.autorizador = autorizador;
        }

        public abstract void AutorizarLicenca(int nrDias);
    }
}