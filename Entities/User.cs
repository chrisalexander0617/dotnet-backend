namespace WebApi.Entities;

using System.Text.Json.Serialization;

// This will help define your columns in your database
public class User
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
};