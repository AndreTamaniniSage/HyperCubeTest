using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace HyperCubeTest
{   
    [Binding]
    public class ActionPage
    {
        private double DefaultWaitTime = ObjectRepository.Config.DefaultElementWaitTime();
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public ActionPage(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
            _driver = driver;
        }

        public void clickButton(string button){
            IWebElement element = getElement(button);
            element.Click();
        }

        #region AuxiliaryMethods
        public IWebElement getElement(string field)
        {
            IWebElement element = null;

            //Button
            //Retorna o elemento botão pela label do botão
            if(element == null) element = ActionFindSingleElement(By.XPath(string.Format("//button[.='{0}']",field)));

            //Retorna o elemento botão pelo ID
            if(element == null) element = ActionFindSingleElement(By.Id(field));

            if(element == null) throw new Exception("Elemento não encontrado");

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
