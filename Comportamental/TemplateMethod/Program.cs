namespace TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vídeo em MP4");
            VideoPlayer videoMp4 = new VideoMP4();
            videoMp4.CarregarVideo();
            videoMp4.DecodeVideoFormato();
            videoMp4.ExecutarVideo();

            Console.WriteLine("---------------");

            Console.WriteLine("Vídeo em AVI");
            VideoPlayer videoAvi = new VideoAVI();
            videoAvi.CarregarVideo();
            videoAvi.DecodeVideoFormato();
            videoAvi.ExecutarVideo();

            Console.ReadKey();
        }
    }
}