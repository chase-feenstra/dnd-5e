// See https://aka.ms/new-console-template for more information
using Roller.Domain;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;

var command = new Command("roll", "Roll the dice!")
{
    new Argument<string>("die", "The dice you want to roll (e.g, 3d6, 1d4, 5d20)"),
    new Option(new[] { "--verbose", "-v" }, "Show the detailed roll")
};
command.Handler = CommandHandler.Create(RollHandler);

static void RollHandler(string die, bool verbose)
{
    var times = int.Parse(die.Split('d').First());
    var dieNum = int.Parse(die.Split('d').Last());

    var roller = new RollerService();
    var rolls = roller.Roll(times, dieNum);

    Console.WriteLine($"Rolled d{dieNum} {times} times.");

    Console.WriteLine(verbose
        ? string.Join(Environment.NewLine, rolls)
        : rolls.Sum());
} 

var root = new RootCommand()
{
    command
};

return await root.InvokeAsync(args);
