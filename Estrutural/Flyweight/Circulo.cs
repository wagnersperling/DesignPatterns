namespace Flyweight
{
    public class Circulo : IForma
    {
        //estado estrínseco
        public string Cor { get; set; }

        //estado intrínseco
        private int x = 10;
        private int y = 20;
        private int raio = 30;

        public void SetCor(string cor)
        {
            Cor = cor;
        }

        public void Desenhar()
        {
            Console.WriteLine($"Circulo: Desenhar() [Cor: {Cor} x: {x}, y: {y}, raio: {raio}]");
        }
    }
}