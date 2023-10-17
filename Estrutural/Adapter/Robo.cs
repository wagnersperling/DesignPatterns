namespace Adapter
{
    public class Robo
    {
        Random gerador = new Random();
        public void AtacarComAsMaos()
        {
            int qtdInimigos = gerador.Next(10);
            Console.WriteLine($"O robo atacou {qtdInimigos} inimigos.");
        }

        public void ProcurarInimigo()
        {
            Console.WriteLine("O robo está procurando o inimigo.");
        }

        public void Pular()
        {
            Console.WriteLine($"O robo pulou.");
        }
    }
}