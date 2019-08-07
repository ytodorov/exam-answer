using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace UnitTests
{
    public static class IRemoteWebDriverExtensions
    {
        public static RemoteWebDriver SetValueOfTextBoxElementFoss(this RemoteWebDriver driver, string cssSelector, string valToSet)
        {
            driver.WaitFoss();

            driver.WaitWhileElementExistsFoss(cssSelector);

            driver.FindElementByCssSelector(cssSelector).SendKeys(valToSet);

            driver.WaitFoss();
            return driver;
        }

        public static string GetValueOfInputElementFoss(this RemoteWebDriver driver, string cssToFindElement)
        {
            string scriptToExecute = $@"
return document.querySelectorAll(""{cssToFindElement}"")[0].value;
";
            string res = driver.ExecuteScript(scriptToExecute)?.ToString();
            return res;
        }

        public static RemoteWebDriver ClickButtonFoss(this RemoteWebDriver driver, string cssSelector, int numberInList = 0)
        {
            driver.WaitFoss();

            driver.WaitWhileElementExistsFoss(cssSelector);

            //Utils.WriteInfoMessageToConsole($"ClickButtonFoss: cssSelector: {cssSelector}, numberInList: {numberInList}");

            string jsToBeExecuted = $@"document.querySelectorAll(""{cssSelector}"")[{numberInList.ToString()}].click();";
            string result = ((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted)?.ToString();
            driver.WaitFoss();
            return driver;
        }

        public static RemoteWebDriver WaitWhileElementExistsFoss(this RemoteWebDriver driver, string cssSelector)
        {
            Thread.Sleep(10);
            for (int i = 0; i < 1000; i++)
            {
                string result = ((IJavaScriptExecutor)driver).ExecuteScript($"return document.querySelectorAll(\"{cssSelector}\").length")?.ToString();
                if (result != "0")
                {
                    break;
                }
                Thread.Sleep(50);
            }

            return driver;
        }

        // A specific class MUST exists before this method is called!
        public static RemoteWebDriver FilterClasses(this RemoteWebDriver driver)
        {
            // TO DO: will be parameters.
            driver.ClickButtonFossByContent("button", "Clear Filters");
            //driver.SelectValueFromDropDownFoss("#quarter", "div", "Winter");
            //driver.SelectValueFromDropDownFoss("#year", "div", "2019");

            driver.ClickButtonFossByCssAndContent("[data-test-id=fromTime-hour]", "Hour");
            driver.ClickButtonFossByCssAndContent("div", "1:30");

            driver.ClickButtonFossByContent("span", "open");
            driver.ClickButtonFossByContent("span", "BB1");
            driver.ClickButtonFossByContent("span", "Once a Week");
            driver.ClickButtonFossByContent("span", "Mon");
            driver.ClickButtonFossByContent("span", "Advanced");
            driver.ClickButtonFossByContent("span", "Group");
            driver.ClickButtonFoss(".c-button.c-button--primary.c-button--no-width"); // Search

            return driver;
        }

        public static RemoteWebDriver ClickButtonFossByContent(this RemoteWebDriver driver, string tag, string content, int numberInList = 0)
        {
            driver.WaitFoss();
            content = content.ToLowerInvariant().Trim();

            string jsToBeExecuted = $@"var aTags = document.getElementsByTagName('{tag}');
var searchText = '{content}';
var found;
var numberInList = '{numberInList}';
var counter = 0;
for (var i = 0; i < aTags.length; i++) {{
  if (typeof(aTags[i].textContent) != 'undefined' && aTags[i].textContent.trim().toLowerCase() == searchText) {{
    if (numberInList == counter)
    {{
        console.log(aTags[i]);
        found = aTags[i];
        found.click();
        break;
  }}
counter = counter + 1;
}}


}}";



            string result = ((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted)?.ToString();
            driver.WaitFoss();
            return driver;
        }


        public static RemoteWebDriver ClickButtonFossByCssAndContent(this RemoteWebDriver driver, string css, string content)
        {
            driver.WaitFoss();
            content = content.ToLowerInvariant().Trim();

            string jsToBeExecuted = $@"var aTags = document.querySelectorAll('{css}');
var searchText = '{content}';
var found;

for (var i = 0; i < aTags.length; i++) {{
  if (typeof(aTags[i].textContent) != 'undefined' && aTags[i].textContent.trim().toLowerCase() == searchText) {{
console.log(aTags[i]);
    found = aTags[i];
    found.click();
    break;
  }}
}}";

            string result = ((IJavaScriptExecutor)driver).ExecuteScript(jsToBeExecuted)?.ToString();
            driver.WaitFoss();
            return driver;  
        }

        /// <summary>
        /// Set value of an input element and force input event to fire.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="cssToFindElement"></param>
        /// <param name="valueToSet"></param>
        /// <returns></returns>
        public static RemoteWebDriver SetValueOfInputFoss(this RemoteWebDriver driver,
            string cssToFindElement, string valueToSet)
        {
            string scriptToExecute = $@"
document.querySelector('{cssToFindElement}').value = '{valueToSet}';

var event = new Event('input', {{
    'bubbles': true,
    'cancelable': true
}});

document.querySelector('{cssToFindElement}').dispatchEvent(event);";

            driver.ExecuteScript(scriptToExecute);

            return driver;
        }

        public static string GetInnerTextOfElement(this RemoteWebDriver driver, string css, int numberInList = 0)
        {
            string countOfElementsScript = $@"return document.querySelectorAll(""{css}"").length";
            string count = ((IJavaScriptExecutor)driver).ExecuteScript(countOfElementsScript)?.ToString();

            if (count == "0")
            {
                return string.Empty;
            }

            string script = $@"return document.querySelectorAll(""{css}"")[{numberInList}].textContent";
            string result = ((IJavaScriptExecutor)driver).ExecuteScript(script)?.ToString();
            return result;
        }

        public static RemoteWebDriver ExecuteScriptFoss(this RemoteWebDriver driver, string script)
        {
            string result = ((IJavaScriptExecutor)driver).ExecuteScript(script)?.ToString();
            return driver;
        }

        public static RemoteWebDriver WaitFoss(this RemoteWebDriver driver, int ms = 0)
        {
            Thread.Sleep(50);
            return driver;
        }

        public static RemoteWebDriver SelectValueFromDropDownFoss(this RemoteWebDriver driver, string cssSelector,
            string tagOfContentElement, string contentToBeSelected)
        {
            driver.WaitFoss();

            driver.ClickButtonFoss(cssSelector);
            driver.ClickButtonFossByCssAndContent($"foss-select {tagOfContentElement}, foss-combobox {tagOfContentElement}", contentToBeSelected);

            driver.WaitFoss();

            return driver;
        }

       
        public static string GetBaseAddress(this RemoteWebDriver driver)
        {
            string urlString = driver.Url;

            Uri uri = new Uri(urlString);

            string baseAddress = uri.AbsoluteUri.Replace(uri.PathAndQuery, string.Empty);

            return baseAddress;
        }

        public static void NavigateFoss(this RemoteWebDriver driver, string toUrl)
        {
            string baseAddress = driver.GetBaseAddress();

            string fullUrl = toUrl;

            if (!toUrl.ToUpperInvariant().Contains(baseAddress.ToUpperInvariant()))
            {
                if (toUrl.StartsWith("/"))
                {
                    fullUrl = $"{baseAddress}{toUrl}";
                }
                else
                {
                    fullUrl = $"{baseAddress}/{toUrl}";
                }
            }

            //driver.WaitFoss(1000); // TO DO - Remove this in future.

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement inputUserNameLogOut = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("nav")));


            driver.Navigate().GoToUrl(fullUrl);

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            inputUserNameLogOut = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("nav")));

            //Thread.Sleep(1000);
            driver.WaitFoss();
        }

        /// <summary>
        /// Gets all rates from rates-and-fees screen
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static List<string> GetAllValuesFromComboboxFoss(this RemoteWebDriver driver, string cssToFindCombobox)
        {
            driver.ClickButtonFoss(cssToFindCombobox); // open
            object res = driver.ExecuteScript("return Array.prototype.slice.call(document.querySelectorAll('div.select__option div')).map(function f(a) { return a.innerText})");
            driver.ClickButtonFoss(cssToFindCombobox); // close

            ReadOnlyCollection<object> arr = res as ReadOnlyCollection<object>;

            driver.ClickButtonFoss(".c-header-nav-container.ng-scope");

            List<string> strings = arr.Select(s => s.ToString()).ToList();
            return strings;
        }

        /// <summary>
        /// Gets all rates from rates-and-fees screen
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static List<string> SelectAttributeValuesOfElementsFoss(this RemoteWebDriver driver,
            string cssToFindElelement, string attributeName)
        {
            string script = $"return Array.prototype.slice.call(document.querySelectorAll('{cssToFindElelement}')).map(function f(a) {{ return a.getAttribute('{attributeName}')}})";
            object res = driver.ExecuteScript(script);

            ReadOnlyCollection<object> arr = res as ReadOnlyCollection<object>;

            List<string> strings = arr.Select(s => s.ToString()).ToList();
            return strings;
        }
    }
}
