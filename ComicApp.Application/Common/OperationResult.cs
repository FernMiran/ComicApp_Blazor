namespace ComicApp.Application.Common
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public IEnumerable<string> ErrorMessages { get; set; }
    }

    public class OperationResult<T> : OperationResult where T: class
    {
        public T Data { get; set; }
    }
}
