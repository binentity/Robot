using Microsoft.Extensions.Logging;

using Telegram.Bot;
using Telegram.Bot.Types;

namespace Robot {

    internal class Robot {

        private const string TOKEN = "7673984185:AAGs7l6UkrsEg-LP7TnkrYadyZ6rrs3Y_s4";

        public static async Task Hello() {
            TelegramBotClient bot = new(TOKEN);
            User me = await bot.GetMe();
            Console.WriteLine($"I am user {me.Id} and my name is {me.FirstName}.");
        }

        private static void LogSome(string? message) {
            ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger log = factory.CreateLogger("Main Logger: ");
            log.LogInformation(message);
        }

        public static void Main() {
            Task hello = Hello();
            hello.Wait();
            LogSome("hello world");
        }
    }
}
