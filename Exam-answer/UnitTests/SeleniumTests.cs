using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading;
using Xunit;

namespace UnitTests
{
    public class SeleniumTests
    {
        [Fact]
        public void PreloadSiteTest()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            chromeOptions.AcceptInsecureCertificates = true;

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (ChromeDriver driver = new ChromeDriver(path, chromeOptions))
            {
                for (int i = 1; i <= 130; i++)
                {
                    driver.Navigate().GoToUrl($"https://www.exam-answer.com/microsoft/az-900/question{i}");
                }

                for (int i = 1; i <= 60; i++)
                {
                    driver.Navigate().GoToUrl($"https://www.exam-answer.com/salesforce/salesforce-certified-field-service-lightning-consultant/question{i}");
                }

                for (int i = 1; i <= 100; i++)
                {
                    driver.Navigate().GoToUrl($"https://www.exam-answer.com/salesforce/crt-251/question{i}");
                }

                for (int i = 1; i <= 112; i++)
                {
                    driver.Navigate().GoToUrl($"https://www.exam-answer.com/microsoft/az-100/question{i}");
                }

                for (int i = 1; i <= 243; i++)
                {
                    driver.Navigate().GoToUrl($"https://www.exam-answer.com/microsoft/az-300/question{i}");
                }

                for (int i = 1; i <= 73; i++)
                {
                    driver.Navigate().GoToUrl($"https://www.exam-answer.com/microsoft/az-400/question{i}");
                }
            }
        }

        [Fact]
        public void RecordCrt251VideoTest()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            chromeOptions.AcceptInsecureCertificates = true;

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using ChromeDriver driver = new ChromeDriver(path, chromeOptions);
            string baseAddress = "https://www.exam-answer.com";

            // string baseAddress2 = "https://localhost:44356";
            for (int i = 1; i <= 100; i++)
            {
                driver.Navigate().GoToUrl($"{baseAddress}/salesforce/crt-251/question{i}");
                Thread.Sleep(1000);

                driver.ClickButtonFoss(".showAnswer");

                Thread.Sleep(2000);
            }

            driver.Navigate().GoToUrl("https://www.exam-answer.com/salesforce/crt-251/question11");

            Thread.Sleep(1000);

            driver.FindElementByClassName("showAnswer").Click();

            Thread.Sleep(1000);
        }
    }
}