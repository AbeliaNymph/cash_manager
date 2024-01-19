
using System.Security.Cryptography;

namespace CashManager;

public class Commands
{
    private List<ICommand> _commands;

    internal Commands() {
        _commands = [];
    }

    internal ICommand FindSupportOne(List<string> input)
    {
        return _commands.Where(it => it.IsSupport(input))
            .FirstOrDefault(new UnknownCommand());
    }
}
