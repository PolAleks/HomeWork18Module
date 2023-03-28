using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork18Module
{
    public interface IAction
    {
        Task Run(string url);
    }
}
