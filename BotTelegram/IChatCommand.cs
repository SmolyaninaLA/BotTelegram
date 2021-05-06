using System;
using System.Collections.Generic;
using System.Text;

namespace BotTelegram
{
    public interface IChatCommand
    {
        bool CheckMessage(string message);
    }
}
