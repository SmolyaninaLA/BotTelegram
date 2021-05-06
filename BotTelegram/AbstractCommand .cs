using System;
using System.Collections.Generic;
using System.Text;

namespace BotTelegram
{
    public abstract class AbstractCommand : IChatCommand
    {
        public string CommandText;

        public virtual bool CheckMessage(string message)
        {
            return CommandText == message;
        }
    }
}
