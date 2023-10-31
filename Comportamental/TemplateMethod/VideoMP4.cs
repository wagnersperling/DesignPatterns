namespace TemplateMethod
{
    public class VideoMP4 : VideoPlayer
    {
        public override void DecodeVideoFormato()
        {
            Console.WriteLine("Vídeo está sendo processado para o formato MP4");
        }
    }
}