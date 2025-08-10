namespace Notifier.Models;

public class Email
{
    public EmailBody EmailBody { get; set; }
    public List<string> From { get; set; }
    public List<string> To { get; set; }
    public List<string>? Cc { get; set; }
    public List<string>? Bcc { get; set; }

    public Email(EmailBody emailBody, string from, string to)
    {
        EmailBody = emailBody;
        From = [from];
        To = [to];
    }

    public Email(EmailBody emailBody, string from, string to, string cc, string bcc)
    {
        EmailBody =  emailBody;
        From = [from];
        To = [to];
        Cc = [cc];
        Bcc = [bcc];
    }

    public Email(EmailBody emailBody, List<string> from, List<string> to)
    {
        EmailBody =  emailBody;
        From = from;
        To = to;
    }

    public Email(EmailBody emailBody, List<string> from, List<string> to, List<string> cc, List<string> bcc)
    {
        EmailBody =  emailBody;
        From = from;
        To = to;
        Cc = cc;
        Bcc = bcc;
    }
}