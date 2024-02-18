namespace CommandApp.Exceptions;

public class BaseException : Exception
{
    public BaseException()
    {
    }

    public BaseException(string? message) : base(message)
    {
    }

    public BaseException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}

public class QuitInputRead : BaseException
{
}

public class CommandNotFound(string value) : BaseException
{
    public override string Message { get; } = $"Command `{value}` doesn't exist.";
}