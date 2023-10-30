namespace Strategy
{
    public class CompressaoContext
    {
        private ICompressao _icompressao;

        public CompressaoContext(ICompressao icompressao)
        {
            _icompressao = icompressao;
        }

        public void DefinirStrategy(ICompressao icompressao)
        {
            _icompressao = icompressao;
        }

        public void CriarArquivoCompactado(string nomeArquivo)
        {
            _icompressao.ComprimirArquivo(nomeArquivo);
        }
    }
}