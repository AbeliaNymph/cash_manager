
namespace CashManager;

public interface ICommand
{
    CommandResult<string, string> Execute(List<string> input);
    bool IsSupport(List<string> input);
}
