namespace Bridge
{
    public class Televisao
    {
        public ICanal CanalAtual { get; set; }

        public void ExibirCanalAtual()
        {
            if (CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.ObterCanal);
            }
            else
            {
                Console.WriteLine("Por favor, selecine um canal!");
            }
        }

        public void ExibirProgramacao()
        {
            if (CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.ObterStatus);
            }
            else
            {
                Console.WriteLine("Por favor, selecine um programa para assistir!");
            }
        }

    }
}