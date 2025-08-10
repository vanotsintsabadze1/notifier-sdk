using Notifier.Configuration;
using Notifier.Models;

namespace Notifier.Interfaces;

public interface IEmailNotifier
{
    Task<HttpResponseMessage> SendEmail(Email email, NotifierAPIConfiguration apiConfiguration);
}