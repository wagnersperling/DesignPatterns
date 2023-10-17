namespace Prototype
{
    public class Funcionario : IFuncionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Matricula { get; set; }
        public IFuncionario Clone()
        {
            return this.MemberwiseClone() as IFuncionario;
        }
    }
}