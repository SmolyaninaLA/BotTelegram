using System;
using System.Collections.Generic;
using System.Text;

namespace BotTelegram
{
    public abstract class ChatTextCommandOption : AbstractCommand
    {
        public override bool CheckMessage(string message)
        {
            return message.StartsWith(CommandText);
        }

        public string ClearMessageFromCommand(string message) => message[(CommandText.Length + 1)..];

    }
}
