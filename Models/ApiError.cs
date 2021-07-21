namespace webapi.Models
{
    public class ApiError
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public string DebugMessage { get; set; }
    }
}