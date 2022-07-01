using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomIdentity.Shared.Auth;

public class LoginViewModel
{
    [Required]
    [DisplayName("Email")]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    [DisplayName("Password")]
    public string? Password { get; set; }

    [DisplayName("Remember Me")]
    public bool RememberMe { get; set; }
}

