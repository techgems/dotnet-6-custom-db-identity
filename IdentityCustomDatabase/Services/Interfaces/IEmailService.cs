namespace CustomIdentity.Web.Services.Interfaces;

public interface IEmailService
{
    public Task SendMail(List<string> to, string subject, string body);

}

