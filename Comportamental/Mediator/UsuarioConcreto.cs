namespace Mediator
{
    public class UsuarioConcreto : Usuario
    {
        public UsuarioConcreto(IChatGrupoMediator mediator, string nome) : base(mediator, nome)
        {
        }

        public override void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"{nome} enviou: {mensagem}");
            mediator.EnviarMensagem(mensagem, this);
        }

        public override void ReceberMensagem(string mensagem)
        {
            Console.WriteLine($"{nome} recebeu: {mensagem}");
        }
    }
}