namespace Strategy
{
    public class CompressaoRar : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"O arquivo {nomeArquivo} está compactado com a extensão .rar");
        }
    }
}