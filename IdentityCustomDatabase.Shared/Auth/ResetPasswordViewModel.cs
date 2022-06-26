using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCustomDatabase.Shared.Auth;

public class ResetPasswordViewModel
{
    [Display(Name = "Email")]
    public string Email { get; set; } = string.Empty;

    [Display(Name = " New Password")]
    public string Password { get; set; } = string.Empty;

    [Display(Name = "Confirm password")]
    public string ConfirmPassword { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public bool ResetPasswordSuccessful { get; set; }
}

