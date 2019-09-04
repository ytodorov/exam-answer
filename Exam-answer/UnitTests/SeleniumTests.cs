using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text;
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

                for (int i = 10; i < 20; i++)
                {
                    driver.Navigate().GoToUrl($"https://www.exam-answer.com/microsoft/az-900/question{i}");
                }
            }
        }

        // [Fact]
        public void RecordCrt251VideoTest()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            chromeOptions.AcceptInsecureCertificates = true;

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (ChromeDriver driver = new ChromeDriver(path, chromeOptions))
            {

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
}
