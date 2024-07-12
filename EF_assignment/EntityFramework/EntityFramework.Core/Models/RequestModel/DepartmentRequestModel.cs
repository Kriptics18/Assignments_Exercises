using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Core.Models.RequestModel;

public class DepartmentRequestModel
{
    [Required(ErrorMessage = "DepartmentName is required")]
    [StringLength(50)]
    public string? DepartmentName { get; set; }

    public string? Location { get; set; }
}