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

        public void ClickButton(string button){
            IWebElement element = GetElement(button);
            element.Click();
        }

        public void ClickCheckBoxComboBox(string option, string action){
            IWebElement element = GetElement(option);

            if (action.ToUpper().Equals("MARCADA") & !element.Selected) element.Click(); 

            if (action.ToUpper().Equals("DESMARCADA") & element.Selected) element.Click(); 
        }

        public Boolean ReturnCheckBoxComboBoxCondition(string option){
            IWebElement element = GetElement(option);

            if (element.Selected) return true;

            else return false;
        }
        #region AuxiliaryMethods
        public IWebElement GetElement(string field)
        {
            IWebElement element = null;

            //Geral
            //Retorna o elemento pelo ID
            if(element == null) element = ActionFindSingleElement(By.Id(field));

            //Button
            //Retorna o elemento botão pela label do botão
            if(element == null) element = ActionFindSingleElement(By.XPath(string.Format("//button[.='{0}']",field)));

            //CheckBox
            //RetornaOCheckBox pela label utilixando XView (nó irmão e primeiro input com classe chebox descentente)
            if(element == null) element = ActionFindSingleElement(By.XPath(string.Format("//label[.='{0}']/following-sibling::*//descendant::input[@type='checkbox'] [position()=1]",field)));

            if(element == null) throw new Exception("Elemento para ação não encontrado");

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
