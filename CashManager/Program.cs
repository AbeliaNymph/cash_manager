
namespace CashManager;

public class Program 
{
    static void Main(string[] args)
    {
        List<string> input = new(args);

        Commands commands = new();

        ICommand command = commands.FindSupportOne(input);

        CommandResult<string, string> result = command.Execute(input);

        if (result.IsOk()) {
            Console.WriteLine(result.OkValue);
        }
        else {
            Console.Error.WriteLine(result.ErrValue);
        }
    }
}