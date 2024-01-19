
namespace CashManager;

public class UnknownCommand : ICommand
{
    public CommandResult<string, string> Execute(List<string> input)
    {
        return CommandResult<string, string>.Err("未知命令");
    }

    public bool IsSupport(List<string> input)
    {
        throw new NotImplementedException();
    }
}
