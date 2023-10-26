namespace Mediator
{
    public abstract class Usuario
    {
        protected IChatGrupoMediator mediator;
        protected string nome;

        protected Usuario(IChatGrupoMediator mediator, string nome)
        {
            this.mediator = mediator;
            this.nome = nome;
        }

        public abstract void EnviarMensagem(string mensagem);
        public abstract void ReceberMensagem(string mensagem);
    }
}