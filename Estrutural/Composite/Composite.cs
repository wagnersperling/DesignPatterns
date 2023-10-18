namespace Composite
{
    public class Composite : Componente
    {
        private List<Componente> listaFilhos = new List<Componente>();
        public Composite(string nome) : base(nome) { }
        public override void Adicionar(Componente componente)
        {
            listaFilhos.Add(componente);
        }

        public override void MostrarComposicoes(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);
            foreach (var filho in listaFilhos)
            {
                filho.MostrarComposicoes(profundidade + 2);
            }
        }

        public override void Remover(Componente componente)
        {
            listaFilhos.Remove(componente);
        }
    }
}