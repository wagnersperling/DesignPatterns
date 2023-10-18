namespace Decorator
{
    public class Cebola : PizzaDecorator
    {
        public Cebola(IPizza pizza) : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n com extra de cebola";
            return pizza;
        }
    }
}