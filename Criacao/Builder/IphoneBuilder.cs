namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        private Celular _celular;
        public IphoneBuilder()
        {
            _celular = new Celular("Iphone");
        }
        public Celular Celular => _celular;

        public void BuildBateria()
        {
            _celular.Bateria = "Lítio 900mAh";
        }

        public void BuildCamera()
        {
            _celular.Camera = "16 MP";
        }

        public void BuildSistema()
        {
            _celular.SistemaOperacional = "iOS";
        }

        public void BuildTela()
        {
            _celular.Tela = "9\"";
        }
    }
}