namespace ProductAPI.Utilities
{
    public interface IResult
    {
        string Message { get; }
        bool Success { get; }
    }
}
