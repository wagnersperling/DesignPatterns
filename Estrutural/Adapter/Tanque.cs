namespace Adapter
{
    public class Tanque : IAtaqueInimigo
    {
        Random gerador = new Random();
        public void Atacar()
        {
            int danoAtaque = gerador.Next(10);
            Console.WriteLine($"O tanque atacou e fez {danoAtaque} % de dano.");
        }

        public void Mirar()
        {
            Console.WriteLine("O tanque está mirando.");
        }

        public void Movimentar()
        {
            int qtdMovimento = gerador.Next(10);
            Console.WriteLine($"O tanque movimentou-se {qtdMovimento} metros.");
        }
    }
}