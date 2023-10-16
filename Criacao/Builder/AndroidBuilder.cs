namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        private Celular _celular;
        public AndroidBuilder()
        {
            _celular = new Celular("Android");
        }
        public Celular Celular => _celular;

        public void BuildBateria()
        {
            _celular.Bateria = "Lítio 600mAh";
        }

        public void BuildCamera()
        {
            _celular.Camera = "15 MP";
        }

        public void BuildSistema()
        {
            _celular.SistemaOperacional = "Android";
        }

        public void BuildTela()
        {
            _celular.Tela = "8\"";
        }
    }
}