namespace Composite
{
    public abstract class Componente
    {
        protected string nome;

        public Componente(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(Componente componente);
        public abstract void Remover(Componente componente);
        public abstract void MostrarComposicoes(int profundidade);
    }
}