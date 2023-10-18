namespace Decorator
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = "Está é uma pizza normal";
            return pizza;
        }
    }
}