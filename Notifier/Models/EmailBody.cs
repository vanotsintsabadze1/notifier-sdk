namespace Notifier.Models;

public class EmailBody
{
    public string Subject { get; set; }
    public string Body { get; set; }
    public TextFormat Format { get; set; } = TextFormat.Text;

    public EmailBody(string subject, string body)
    {
        Subject = subject;
        Body = body;
    }

    public EmailBody(string subject, string body, TextFormat format)
    {
        Subject = subject;
        Body = body;
        Format = format;
    }
}