

using DiscordToTelegramBot;
using DSharpPlus;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;




TelegramBotClient telegramClient = new TelegramBotClient(token: Environment.GetEnvironmentVariable("TG_TOKEN"));

var client = new DiscordClient(new DiscordConfiguration
{
    Token = Environment.GetEnvironmentVariable("DISCORD_TOKEN"),
    Intents = DiscordIntents.AllUnprivileged
});


client.Ready += async (client, args) =>
{
    Console.WriteLine("Connecting telegram.");
    var handler = new Handler();
    handler.DiscordClient = client;

    telegramClient.StartReceiving(handler.AsyncUpdateHandler, handler.HandleError, new ReceiverOptions { }, CancellationToken.None);

    var me = await telegramClient.GetMeAsync();


    Console.WriteLine($"Telegram bot @{me.Username} ready to accept updates...");

};

await client.ConnectAsync();

await Task.Delay(-1);