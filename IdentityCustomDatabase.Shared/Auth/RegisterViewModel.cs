using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentity.Shared.Auth
{
    public class RegisterViewModel
    {
        [Required]
        [DisplayName("Preferred Name")]
        public string? PreferredName { get; set; }

        [Required]
        [DisplayName("Email")]
        public string? Email { get; set; }

        [Required]
        [DisplayName("Password")]
        public string? Password { get; set; }

        [Required]
        [DisplayName("Confirm Password")]
        public string? RepeatPassword { get; set; }
    };
}
