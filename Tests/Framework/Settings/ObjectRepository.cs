using Framework.Interfaces;
using OpenQA.Selenium;

namespace HyperCubeTest
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }

        public static IWebDriver Driver { get; set; }
    }
}