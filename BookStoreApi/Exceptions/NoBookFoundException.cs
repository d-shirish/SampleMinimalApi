namespace BookapiMinimal.Exceptions;
public class NoBookFoundException : Exception
{
    public NoBookFoundException() : base("No books found")
    { }
}