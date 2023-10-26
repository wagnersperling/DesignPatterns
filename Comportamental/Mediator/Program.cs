namespace Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IChatGrupoMediator chatGrupoMadiator = new ChatGrupoMediator();

            Usuario carlos = new UsuarioConcreto(chatGrupoMadiator, "Carlos");
            Usuario aline = new UsuarioConcreto(chatGrupoMadiator, "Aline");
            Usuario charles = new UsuarioConcreto(chatGrupoMadiator, "Charles");
            Usuario joao = new UsuarioConcreto(chatGrupoMadiator, "João");

            chatGrupoMadiator.RegistrarUsuario(carlos);
            chatGrupoMadiator.RegistrarUsuario(aline);
            chatGrupoMadiator.RegistrarUsuario(charles);
            chatGrupoMadiator.RegistrarUsuario(joao);

            carlos.EnviarMensagem("Olá pessoal, tudo bem?");

            charles.EnviarMensagem("Oi tudo bem ótimo ;)");

            aline.EnviarMensagem("Bom dia!!");
            Console.ReadKey();
        }
    }
}