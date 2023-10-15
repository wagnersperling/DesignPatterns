namespace Bola
{
    public class Program
    {
        static void Main(string[] agrs)
        {
            var jogadorUm = Bola.ObterInstancia;
            Console.WriteLine("Jogador um está com a bola.");

            var jogadorDois = Bola.ObterInstancia;
            Console.WriteLine("Jogador dois recebeu a bola.");

            var jogadorTres = Bola.ObterInstancia;
            Console.WriteLine("Jogador três pegou a bola.");

            Console.ReadKey();
        }
    }
}
