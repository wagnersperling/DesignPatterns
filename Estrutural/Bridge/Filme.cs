namespace Bridge
{
    public class Filme : ICanal
    {
        public string ObterCanal()
        {
            return "Este canal é de fimes.";
        }

        public string ObterStatus()
        {
            return "Você está assistindo Capitão América.";
        }
    }
}