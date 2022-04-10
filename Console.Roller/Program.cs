// See https://aka.ms/new-console-template for more information
using Roller.Domain;
using System.CommandLine;
using System.CommandLine.Invocation;

var command = new Command("roll", "Roll the dice!");

var dieArg = new Argument<string>("die", "The dice you want to roll");
var verbOpt = new Option(new[] { "--verbose", "-v" }, "Show the detailed roll");

command.Add(dieArg);
command.Add(verbOpt);

command.SetHandler((string die, bool verbose) =>
{
    var times = int.Parse(die.Split('d').First());
    var dieNum = int.Parse(die.Split('d').Last());

    var roller = new RollerService();
    var rolls = roller.Roll(times, dieNum);

    Console.WriteLine($"Rolled d{dieNum} {times} times.");

    Console.WriteLine(verbose 
        ? string.Join(Environment.NewLine, rolls) 
        : rolls.Sum());

});


static void Handler(string die, bool verbose)
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
