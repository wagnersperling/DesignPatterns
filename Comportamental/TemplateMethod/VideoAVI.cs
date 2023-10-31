namespace TemplateMethod
{
    public class VideoAVI : VideoPlayer
    {
        public override void DecodeVideoFormato()
        {
            Console.WriteLine("Vídeo está sendo processado para o formato AVI");
        }
    }
}