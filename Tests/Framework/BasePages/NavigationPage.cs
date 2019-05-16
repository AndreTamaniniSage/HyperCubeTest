using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using Framework.Configuration;
using OpenQA.Selenium.Interactions;

namespace HyperCubeTest
{
    [Binding]
    public class NavigationPage
    {   
        private double DefaultWaitTime = ObjectRepository.Config.DefaultElementWaitTime();
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private Actions _action => new Actions(_driver);

    #region Constructor
        public NavigationPage(IWebDriver driver)
        {   
             _wait = new WebDriverWait(driver,TimeSpan.FromSeconds(DefaultWaitTime));
            _driver = driver;
        }
    #endregion
        public void OpenInitialUrl()
        {
            _driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebSite());
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("application-logo")));
        }

        public void NavigateByMenu(string pathMenu)
        {
            string[] listMenus = pathMenu.Split('|');
            int count = 0;

            foreach(string menu in listMenus){
                IWebElement elementMenu = GetElement(menu);
                _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elementMenu));

                if (count==0) _action.MoveToElement(elementMenu).Build().Perform();

                else elementMenu.Click();

                count ++;
            }
        }

        #region AuxiliaryMethods
        public IWebElement GetElement(string findElement)
        {
            IWebElement element = null;
            //Menu
            //Retorna o elemento Menu a ser clicado
            if(element == null) element = ActionFindSingleElement(By.XPath(string.Format("//span[@class='carbon-link__content'] [.='{0}']/..",findElement)));

            if(element == null) throw new Exception("Elemento para navegação não encontrado");

            return element;
        }
          public IWebElement ActionFindSingleElement(By byFind)
        {
            try
            {
                return _driver.FindElement(byFind);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
        #endregion

    }
}
