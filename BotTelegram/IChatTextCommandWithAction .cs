using System;
using System.Collections.Generic;
using System.Text;

namespace BotTelegram
{
    interface IChatTextCommandWithAction : IChatTextCommand
    {
        bool DoAction(Conversation chat);
    }
}
