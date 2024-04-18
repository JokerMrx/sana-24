using System.ComponentModel.DataAnnotations;

namespace mvc_app.Models;

public class UserModel
{
    [Required(ErrorMessage = "Email is required!")]
    public string Username { get; set; }
}