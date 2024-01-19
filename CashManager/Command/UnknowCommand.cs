
namespace CashManager;

public class UnknownCommand : ICommand
{
    public bool IsSupport(List<string> input)
    {
        throw new NotImplementedException();
    }
}
