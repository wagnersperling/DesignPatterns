namespace Bridge
{
    public class Seriado : ICanal
    {
        public string ObterCanal()
        {
            return "Este canal é de seriados.";
        }

        public string ObterStatus()
        {
            return "Você está assistindo Game of Thrones.";
        }
    }
}