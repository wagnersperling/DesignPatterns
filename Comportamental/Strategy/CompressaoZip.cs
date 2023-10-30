namespace Strategy
{
    public class CompressaoZip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"O arquivo {nomeArquivo} está compactado com a extensão .zip");
        }
    }
}