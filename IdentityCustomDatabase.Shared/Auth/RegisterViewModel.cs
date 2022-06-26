using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCustomDatabase.Shared.Auth
{
    public record RegisterViewModel(
        string PreferredName, 
        string Email, 
        string Password, 
        string RepeatPassword
    );
}
