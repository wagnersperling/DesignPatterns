namespace FactoryMethod
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var factoryMethod = new FactoryMethod();
            Console.WriteLine("Liu Kang | Scorpion | Sub-Zero");
            Console.WriteLine();
            Console.WriteLine("Escolha seu personagem");
            string nomePersonagem = Console.ReadLine();
            IPersonagem personagem = factoryMethod.EscolherPersonagem(nomePersonagem);
            Console.Write("Você escolheu: ");
            personagem.ObterNomeEscolhido();
            Console.ReadKey();
        }
    }
}