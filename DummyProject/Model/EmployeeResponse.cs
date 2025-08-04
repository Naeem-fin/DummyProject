namespace DummyProject.Model
{
    public class EmployeeResponse
    {
        public string? StatusCode { get; set; }
        public string? Message { get; set; }
        public List<EmployeeInfo>? Data { get; set; }
        public string? Error { get; set; }
    }
}
