using System.Net.Mime;
using System.Text;
using Notifier.Configuration;
using Notifier.Interfaces;
using Notifier.Models;

namespace Notifier.Services;

public class EmailNotifier : IEmailNotifier
{
    private const string API_KEY_HEADER_NAME = "X-API-KEY";
    
    public async Task<HttpResponseMessage> SendEmail(Email email, NotifierAPIConfiguration apiConfiguration)
    {
        var client = new HttpClient();

        client.BaseAddress = new Uri(apiConfiguration.URL);
        client.DefaultRequestHeaders.Add(API_KEY_HEADER_NAME, apiConfiguration.Key);

        var body = email.EmailBody.Body;
        var content = new StringContent(body, Encoding.UTF8, MediaTypeNames.Application.Json);

        return await client.PostAsync(EndpointNames.SEND_EMAIL, content);
    }
}

file static class EndpointNames
{
    public static string SEND_EMAIL = "email";
}