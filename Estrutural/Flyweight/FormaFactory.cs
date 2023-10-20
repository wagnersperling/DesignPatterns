namespace Flyweight
{
    public class FormaFactory
    {
        private static Dictionary<string, IForma> formas = new Dictionary<string, IForma>();

        public static IForma GetForma(string chave)
        {
            IForma forma;

            if (formas.ContainsKey(chave))
            {
                return formas[chave];
            }
            else
            {
                if (chave == "circulo")
                {
                    forma = new Circulo();
                    formas.Add("circulo", forma);
                }
                else
                {
                    throw new Exception("Este tipo de objeto não pode ser criado");
                }
            }
            return forma;
        }
    }
}