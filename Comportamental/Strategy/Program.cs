namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CompressaoContext compressaoContext = new CompressaoContext(new CompressaoRar());
            compressaoContext.CriarArquivoCompactado("Arquivo1");

            compressaoContext.DefinirStrategy(new CompressaoZip());
            compressaoContext.CriarArquivoCompactado("Arquivo2");

            compressaoContext.DefinirStrategy(new CompressaoGzip());
            compressaoContext.CriarArquivoCompactado("Arquivo3");

            Console.ReadKey();
        }
    }
}
