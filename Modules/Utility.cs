using System;
using Discord.WebSocket;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace RinBot
{
    public class UtilityModule : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task HelpAsync(){
            await ReplyAsync("Help yourself...");

            var commandList = 
            "**Useful Commands:**\n" +
            "`help` \n" +
            "**Weirdo Commands:**\n"+
            "`yay` `owo` `oof`\n" +
            "**Other Stuff:** \n" + 
            "Try using @someone and see what happens. ;) \n";

            await Context.Channel.TriggerTypingAsync();
            await Task.Delay(500);
            EmbedBuilder builder = new EmbedBuilder()
            .WithTitle("Rin Command List")
            .WithFooter("Made by Toreole")
            .WithDescription(commandList);

            await ReplyAsync("", false, builder.Build(), null);
        }
    }
}