using CustomIdentity.Web.Services.Interfaces;

namespace CustomIdentity.Web.Services;

public class EmailService : IEmailService
{
    public Task SendMail(List<string> to, string subject, string body)
    {
        throw new NotImplementedException();
    }
}

