namespace Bridge
{
    public class program
    {
        public static void Main(string[] args)
        {
            Televisao televisao = new Televisao();
            Console.WriteLine("Selecione um canal.");
            Console.WriteLine("1 - Filmes. \n 2 - Seriados. \n 3 - Culinária.");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    televisao.CanalAtual = new Filme();
                    break;
                case "2":
                    televisao.CanalAtual = new Seriado();
                    break;
                case "3":
                    televisao.CanalAtual = new Culinaria();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine(televisao.CanalAtual.ObterCanal());
            Console.WriteLine(televisao.CanalAtual.ObterStatus());
            Console.ReadKey();
        }
    }
}

