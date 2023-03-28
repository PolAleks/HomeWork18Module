using YoutubeExplode;

namespace HomeWork18Module
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Downloader sender = new Downloader();
            YoutubeClient receiver = new YoutubeClient();
            string urlVideo = "https://www.youtube.com/watch?v=zSZxlSvysZE";

            List<IAction> actions = new List<IAction>()
            {
                new DownloaderAction(receiver),
                new GetDescriptionAction(receiver)
            };

            int numberCommand = SelectCommand();

            var command = actions[numberCommand];
            sender.SetAction(command);
            await sender.RunAction(urlVideo);
        }
        static int SelectCommand()
        {
            int answer = 0;
            do
            {
                Console.Write($"Что будем делать?\n" +
                              $"1. Скачаем видео\n" +
                              $"2. Прочитаем описание\n" +
                              $"Выбери 1 или 2: ");
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Вы выполнили некорректный ввод данных, попробуйте еще раз!");
                }
                Console.WriteLine(new string('-', 50));

            } while (answer < 1 || answer > 2);
            return answer - 1;
        }
    }
}