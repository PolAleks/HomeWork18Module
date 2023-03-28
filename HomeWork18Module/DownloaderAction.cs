using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace HomeWork18Module
{
    /// <summary>
    /// Команда на загрузку видео
    /// </summary>
    public class DownloaderAction : IAction
    {
        YoutubeClient _reciever;
        
        public DownloaderAction(YoutubeClient reciever)
        {
            _reciever = reciever;
        }
        public async Task Run(string url)
        {
            Console.WriteLine("Считываем название видео файла");
            string fileExtension = ".mp4";
            var fileName = (await _reciever.Videos.GetAsync(url)).Title + fileExtension;
             
            Console.WriteLine("Начинаем загрузку видео");
            await _reciever.Videos.DownloadAsync(url, fileName, builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Загрузка видео завершена");
            
        }
    }
}
