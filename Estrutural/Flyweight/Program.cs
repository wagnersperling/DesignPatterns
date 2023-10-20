namespace Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Círculos Amarelos");
            for (int i = 0; i < 3; i++)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Amarelo");
                circulo.Desenhar();
            }

            Console.WriteLine("Círculos Verdes");
            for (int i = 0; i < 3; i++)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Verde");
                circulo.Desenhar();
            }

            Console.WriteLine("Círculos Azuis");
            for (int i = 0; i < 3; i++)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("Azul");
                circulo.Desenhar();
            }

            Console.WriteLine("Círculos Vermelhos");
            for (int i = 0; i < 3; i++)
            {
                var circulo = (Circulo)FormaFactory.GetForma("circulo");
                circulo.SetCor("vermelho");
                circulo.Desenhar();
            }
        }
    }
}