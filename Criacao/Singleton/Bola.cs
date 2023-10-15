namespace Bola
{
    public class Bola
    {
        private static Bola? _instancia;

        public static Bola ObterInstancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Bola();

                return _instancia;
            }
        }
    }
}