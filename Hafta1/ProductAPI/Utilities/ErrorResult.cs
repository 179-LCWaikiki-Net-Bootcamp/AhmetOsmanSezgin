namespace ProductAPI.Utilities
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {
        }
    }
}
