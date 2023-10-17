namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAtaqueInimigo atacante = new Tanque();
            AtacarInimigo(atacante);

            Robo robo = new Robo();
            robo.Pular();
            robo.ProcurarInimigo();
            robo.AtacarComAsMaos();

            IAtaqueInimigo atacante2 = new RoboAdapter(robo);
            AtacarInimigo(atacante2);
        }

        private static void AtacarInimigo(IAtaqueInimigo atacante)
        {
            atacante.Movimentar();
            atacante.Mirar();
            atacante.Atacar();
        }
    }
}
