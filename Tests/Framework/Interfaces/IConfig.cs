using Framework.Configuration;

namespace Framework.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetUsername();
        string GetPassword();
        string GetWebSite();
        double DefaultElementWaitTime();
    }
}