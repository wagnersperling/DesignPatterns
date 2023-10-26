namespace Mediator
{
    public class ChatGrupoMediator : IChatGrupoMediator
    {
        private List<Usuario> listaUsuario = new List<Usuario>();
        public void EnviarMensagem(string mensagem, Usuario usuario)
        {
            foreach (var usuarioLista in listaUsuario)
            {
                if (usuarioLista != usuario)
                {
                    usuarioLista.ReceberMensagem(mensagem);
                }
            }
        }

        public void RegistrarUsuario(Usuario usuario)
        {
            listaUsuario.Add(usuario);
        }
    }
}