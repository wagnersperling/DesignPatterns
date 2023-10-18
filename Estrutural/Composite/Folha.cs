namespace Composite
{
    public class Folha : Componente
    {
        public Folha(string nome) : base(nome)
        {
        }

        public override void Adicionar(Componente componente)
        {
            Console.WriteLine("Não foi possível adicionar a folha.");
        }

        public override void MostrarComposicoes(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);
        }

        public override void Remover(Componente componente)
        {
            Console.WriteLine("Não é possível remover a folha.");
        }
    }
}