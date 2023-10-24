namespace Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IAbstractExpression> expressoes = new List<IAbstractExpression>();
            Context context = new Context(DateTime.Now);

            Console.WriteLine($"Data atual : {context.Data}");

            Console.WriteLine("Digite um formato de data");

            context.Expressao = Console.ReadLine().ToUpper();

            expressoes.Add(new ExpressaoDia());
            expressoes.Add(new ExpressaoMes());
            expressoes.Add(new ExpressaoAno());
            expressoes.Add(new Ceparador());

            foreach (var expressao in expressoes)
            {
                expressao.Avaliar(context);
            }

            Console.WriteLine(context.Expressao);
            Console.ReadKey();
        }
    }
}
