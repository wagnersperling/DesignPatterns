namespace Adapter
{
    public class RoboAdapter : IAtaqueInimigo
    {
        private Robo _robo;
        public RoboAdapter(Robo robo)
        {
            _robo = robo;
        }

        public void Atacar()
        {
            _robo.AtacarComAsMaos();
        }

        public void Mirar()
        {
            _robo.ProcurarInimigo();
        }

        public void Movimentar()
        {
            _robo.Pular();
        }
    }
}