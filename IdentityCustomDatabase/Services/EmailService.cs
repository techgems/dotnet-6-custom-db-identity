using IdentityCustomDatabase.Services.Interfaces;

namespace IdentityCustomDatabase.Services;

public class EmailService : IEmailService
{
    public Task SendMail(List<string> to, string subject, string body)
    {
        throw new NotImplementedException();
    }
}

