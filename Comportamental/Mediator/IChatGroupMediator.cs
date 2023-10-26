namespace Mediator
{
    public interface IChatGrupoMediator
    {
        void EnviarMensagem(string mensagem, Usuario usuario);
        void RegistrarUsuario(Usuario usuario);
    }
}