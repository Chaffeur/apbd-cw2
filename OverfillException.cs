namespace Containers;

class OverfillException : Exception
{
    public OverfillException() : base()
    {
    }

    public OverfillException(string message) : base(message)
    {
    }

    public OverfillException(string message, Exception innerException) : base(message, innerException)
    {
    }
    
}