using System.Globalization;

namespace Visitor
{
    public interface IVisitor
    {
        void Accept(Carro carro);
    }
}