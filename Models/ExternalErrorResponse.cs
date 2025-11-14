namespace sprinklrGcs.Models
{
    public class ExternalErrorResponse
    {
        public List<object> Data { get; set; }  // usually empty when error
        public List<ExternalError> Errors { get; set; }
    }

    public class ExternalError
    {
        public string Id { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
    }
}

