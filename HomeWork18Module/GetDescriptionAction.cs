using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace HomeWork18Module
{
    public class GetDescriptionAction : IAction
    {
        YoutubeClient _reciever;

        public GetDescriptionAction(YoutubeClient reciever)
        {
            _reciever = reciever;
        }
        public async Task Run(string url)
        {
            Console.WriteLine("Загружаем информацию о видео");
            var description = (await _reciever.Videos.GetAsync(url)).Description;
            Console.WriteLine($"Описание: {description}");
        }
    }
}
