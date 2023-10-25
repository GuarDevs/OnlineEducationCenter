using Microsoft.AspNetCore.Components;

namespace OnlineEducationCenter.Web.Models.Teachers;

public class Teacher
{
    [Parameter]
    public string FirstName { get; set; }

    [Parameter]
    public string LastName { get; set; }

    [Parameter]
    public DateTime Date { get; set; }

    [Parameter]
    public string Phone { get; set; }

    [Parameter]
    public string Email { get; set; }
}
