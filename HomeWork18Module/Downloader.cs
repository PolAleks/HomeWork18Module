using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork18Module
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    public class Downloader
    {
        IAction _action;

        public void SetAction(IAction action)
        {
            _action = action;
        }
        public async Task RunAction(string url)
        {
            await _action.Run(url);
        }

    }
}
