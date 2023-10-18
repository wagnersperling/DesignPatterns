namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string ObterCanal()
        {
            return "Este canal é de culinária.";
        }

        public string ObterStatus()
        {
            return "Você está assistindo MasterChef.";
        }
    }
}