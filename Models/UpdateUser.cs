namespace WebApi.Models.Users;
using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateUser
{
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    private string replaceEmptyWithNull(string value)
    {
        // replace empty string with null to make field optional
        return string.IsNullOrEmpty(value) ? null : value;
    }
}