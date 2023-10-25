namespace PadraoIterator
{
    //Interator
    public interface IAbstractInterator
    {
        Cliente First();
        Cliente Next();
        bool IsDone { get; }
    }
}