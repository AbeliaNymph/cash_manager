

namespace CashManager;

public class CommandResult<T, E>
{
    private CommandResult(T? t, E? e)
    {
        OkValue = t;
        ErrValue = e;
    }

    public T? OkValue { get; }

    public E? ErrValue { get; }

    internal bool IsOk() {    
        return OkValue != null;
    }

    public static CommandResult<T, E> Ok(T value) {
        return new CommandResult<T, E>(value, default);
    }

    internal static CommandResult<T, E> Err(E value)
    {
        return new CommandResult<T, E>(default, value);
    }
}
