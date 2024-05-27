using System;
using Leaf.xNet;

class Program
{
    static string resp = "";
    static void Main(string[] args)
    {

        string token = "токен";


        string guildId = "1244590250420867192";
        string channelId = "1244590250420867199";
        string messageId = "1244606102897692762";
        string emoji = "🤠";


        resp = AddReaction(token, guildId, channelId, messageId, emoji);
        Console.WriteLine(resp);
    }

    static string AddReaction(string token, string guildId, string channelId, string messageId, string emoji)
    {
        string returnValue = null;

            var request = new HttpRequest();
            request.AddHeader("Authorization", token);
            request.AddHeader("Content-Type", "application/json");

            string url = $"https://discordapp.com/api/v6/channels/{channelId}/messages/{messageId}/reactions/{Uri.EscapeDataString(emoji)}/@me";

            var response = request.Put(url);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                returnValue = "Успех ^^";
            }
            else
            {
                returnValue = "Провал x_x";
            }
            return returnValue;
    }
}