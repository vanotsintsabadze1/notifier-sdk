namespace Notifier.Configuration;

public class NotifierAPIConfiguration
{
    public string URL { get; set; }
    public string Key { get; set; }

    public NotifierAPIConfiguration(string url, string key)
    {
        URL = url;
        Key = key;
    }
}