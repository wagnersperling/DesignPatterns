namespace Interpreter
{
    public class Ceparador : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            string expressao = context.Expressao;
            context.Expressao = expressao.Replace(" ", "-");
        }
    }
}