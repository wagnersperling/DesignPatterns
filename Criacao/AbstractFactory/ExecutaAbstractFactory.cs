namespace AbstractFactory
{
    public class ExecutaAbstractFactory
    {
        public static Carro MontarCarro(string tipoCarro)
        {
            CarroFactory carroFactory = null;

            switch (tipoCarro)
            {
                case "luxo":
                    carroFactory = new CarroLuxoFactory();
                    break;
                case "popular":
                    carroFactory = new CarroPopularFactory();
                    break;
            }
            Carro carro = new Carro();
            if (carroFactory != null)
            {
                carro.Roda = carroFactory.MontarRoda();
                carro.Som = carroFactory.MontarSom();
            }
            return carro;
        }
    }
}