namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var funcionario = new Funcionario
            {
                Nome = "Carlos Wagner",
                Idade = 36,
                Matricula = 485
            };

            var funcionarioClonado = (Funcionario)funcionario.Clone();
            funcionarioClonado.Idade = 30;
            funcionarioClonado.Matricula = 988;

            Console.WriteLine($"Dados do funcionário original: Nome: {funcionario.Nome} Idade: {funcionario.Idade} Matrícula: {funcionario.Matricula} ");
            Console.WriteLine($"Dados do funcionário clonado: Nome: {funcionarioClonado.Nome} Idade: {funcionarioClonado.Idade} Matrícula: {funcionarioClonado.Matricula} ");
            Console.ReadKey();
        }
    }
}