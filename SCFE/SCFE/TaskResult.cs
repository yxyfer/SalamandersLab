namespace SCFE
{
    public class TaskResult
    {
        public TaskResult(bool success, string message = "")
        {
            Message = message;
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}