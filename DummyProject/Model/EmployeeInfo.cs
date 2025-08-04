
namespace DummyProject.Model;

public partial class EmployeeInfo
{
    public string EmployeeId { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string? FullName { get; set; }

    public string? MobileNo { get; set; }

    public string? MisysId { get; set; }

    public string? CbsBranchCode { get; set; }

    public string? CbsBranchName { get; set; }

    public string? CbsBranchMnemonic { get; set; }

    public string? OrbitBranchCode { get; set; }

    public string? OrbitBranchName { get; set; }

    public string? DesigName { get; set; }

    public string? FunctionName { get; set; }

    public string? DivisionName { get; set; }

    public string? EmpStatus { get; set; }

    public string? LineManagerCode { get; set; }

    public string? EmpGender { get; set; }

    public DateTime? Dob { get; set; }
}
