namespace Facade
{
    public class Facade
    {
        private SubsistemaUm _subsistemaUm;
        private SubsistemaDois _subsistemaDois;
        private SubsistemaTres _subsistemaTres;
        public Facade()
        {
            _subsistemaUm = new SubsistemaUm();
            _subsistemaDois = new SubsistemaDois();
            _subsistemaTres = new SubsistemaTres();
        }

        public void ExibirInformacoes()
        {
            _subsistemaUm.ExibirInformacoes();
            _subsistemaDois.ExibirInformacoes();
            _subsistemaTres.ExibirInformacoes();
        }
    }
}