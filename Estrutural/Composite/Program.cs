using System.ComponentModel.Design.Serialization;

namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Composite root = new Composite("ROOT");
            root.Adicionar(new Folha("Folha A"));
            root.Adicionar(new Folha("Folha B"));
            Composite composite = new Composite("Composite X");
            composite.Adicionar(new Folha("Folha XA"));
            composite.Adicionar(new Folha("Folha XB"));
            root.Adicionar(composite);

            root.Adicionar(new Folha("Folha C"));

            Folha folha = new Folha("Folha D");
            folha.Adicionar(new Folha("Folha E"));
            root.Adicionar(folha);
            root.Remover(folha);

            root.MostrarComposicoes(1);

            Console.ReadKey();
        }
    }
}
