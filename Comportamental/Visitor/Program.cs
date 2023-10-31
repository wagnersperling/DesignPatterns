namespace Visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro() { Nome = "Eco Sport", Preco = 20000, Modelo = "Ford" });
            carros.Add(new Carro() { Nome = "Gol", Preco = 10000, Modelo = "volkswagen" });
            carros.Add(new Carro() { Nome = "Onix", Preco = 40000, Modelo = "Chevrolet" });

            List<ILoja> lojas = new List<ILoja>();

            Console.WriteLine("Preço normal dos carros");
            foreach (var carro in carros)
            {
                Console.WriteLine($"{carro.Modelo} {carro.Nome} R${carro.Preco}");
                lojas.Add(carro);
            }

            Console.WriteLine("Novos preços dos carros");
            PrecoVisitor precoVisitor = new PrecoVisitor();
            foreach (var loja in lojas)
            {
                loja.Visit(precoVisitor);
            }
        }
    }
}
