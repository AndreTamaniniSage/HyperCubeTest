using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace HyperCubeTest
{   
    [Binding]
    public class ValuePage
    {
        private double DefaultWaitTime = ObjectRepository.Config.DefaultElementWaitTime();
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public ValuePage(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
            _driver = driver;
        }

        public void InsertValueToField(string value, string field){
            IWebElement element = getElement(field);
            element.SendKeys(value);
        } 

        public String ReturnValueFromField(string field){
            IWebElement element = getElement(field);
            return element.Text;
        } 

        #region AuxiliaryMethods
        public IWebElement getElement(string field)
        {
            IWebElement element = null;

            //InputText
            //Retorna o Input pela label.
            if(element == null) element = ValueFindSingleElement(By.CssSelector(string.Format("input[labeltext='{0}']",field)));
            
            //Retorna o Input pelo xView (nó irmão e primeiro input descentente)
            if(element == null) element = ValueFindSingleElement(By.XPath(string.Format("//label[.='{0}']/following-sibling::*//descendant::input[position()=1]",field)));
            
            //Retorna o Input pelo ID.
            if(element == null) element = ValueFindSingleElement(By.Id(field));

            if(element == null) throw new Exception("Elemento não encontrado");

            return element;
        }
          public IWebElement ValueFindSingleElement(By byFind)
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
