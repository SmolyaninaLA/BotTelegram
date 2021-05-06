using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace BotTelegram
{
   public class ShowDictonaryCommand : ChatTextCommandOption, IChatTextCommandWithAction
    {
        private ITelegramBotClient botClient;
        private string dictionary = "Словарь:";

        public ShowDictonaryCommand()
        {
            CommandText = "/dictionary";
             
        }

        public bool DoAction(Conversation chat)
        {
            

            foreach (var Buffer in chat.dictionary)
            {
                dictionary = String.Concat(dictionary, "\n");
                dictionary = String.Concat(dictionary, Buffer.Key);
            }
            return true;
        }

        public string ReturnText()
        {
            return dictionary;
        }

        //public async void ShowTextAsync(Conversation chat)
        //{
        //   string dictionary = "Словарь:";

        //    foreach ( var Buffer in chat.dictionary)
        //    {
        //        dictionary = String.Concat(dictionary, "\n");
        //        dictionary = String.Concat(dictionary, Buffer.Key);
        //    }

        //    await SendCommandText(dictionary, chat.GetId());

        //}
        //private async Task SendCommandText(string text, long chat)
        //{
        //    await botClient.SendTextMessageAsync(chatId: chat, text: text);

        //}

    }
}
