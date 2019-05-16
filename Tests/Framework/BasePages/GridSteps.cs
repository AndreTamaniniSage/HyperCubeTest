using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace HyperCubeTest
{   
    [Binding]
    public class GridSteps
    {
        private double DefaultWaitTime = ObjectRepository.Config.DefaultElementWaitTime();
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public GridSteps(IWebDriver driver)
        {
            _wait = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
            _driver = driver;
        }

        public Table RealTable(string keyRowValue){

            Table table = new Table();

            return table;

        }

        #region AuxiliaryMethods
        public IWebElement GetTableElement(string tableLocator)
        {
            IWebElement element = null;

            //Geral
            //Retorna a tabela por Xview como referência o nome da div.
            if(element == null) element = GridFindSingleElement(By.XPath(string.Format("//b[.='{}']/ancestor::div[@class='carbon-pod__content'] [position()=1]//table/tbody",tableLocator)));

            //Retorna a tabela por Xpath usando como referencia a classe data-component
            if(element == null) element = GridFindSingleElement(By.XPath(string.Format("//div[@data-component='table']//table/tbody")));

            if (element == null) throw new Exception("Tabela não encontrada");

            return element;
        }

        public List<IWebElement> FindHearders(string tableLocator){

            List<IWebElement> row = null;

            if(row == null) row = GridFindListElements(tableLocator, By.XPath(string.Format(".//tr")));
            
            if (row == null) throw new Exception("Linha não encontrada");

            return row;
        }

        public List<IWebElement> FindKeyRow(string tableLocator, string keyRowValue){

            List<IWebElement> row = null;

            if(row == null) row = GridFindListElements(tableLocator,By.XPath(string.Format(".//td[.='{0}']/..//td",keyRowValue)));

            if (row == null) throw new Exception("Linha não encontrada");

            return row;
        }

        public IWebElement GridFindSingleElement(By byFind)
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


        public List<IWebElement> GridFindListElements(string tableLocator, By byFind)
        {
            try
            {
                return GetTableElement(tableLocator).FindElements(byFind).ToList();;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        #endregion

    }
}
