namespace Strategy
{
    public class CompressaoGzip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"O arquivo {nomeArquivo} está compactado com a extensão .gzip");
        }
    }
}