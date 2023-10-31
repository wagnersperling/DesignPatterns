namespace TemplateMethod
{
    public abstract class VideoPlayer
    {
        public void ExecutarVideo()
        {
            CarregarVideo();
            DecodeVideoFormato();
            IniciarExecucao();
        }

        public abstract void DecodeVideoFormato();
        public void IniciarExecucao()
        {
            Console.WriteLine("Execução do vídeo iniciada");
        }

        public void CarregarVideo()
        {
            Console.WriteLine("Carregando arquivo");
        }
    }
}