using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject2
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://login.yahoo.com/?.src=ym&lang=en-US&done=https%3A%2F%2Fmail.yahoo.com%2F%3Fguce_referrer%3DaHR0cHM6Ly93d3cuZ29vZ2xlLmNvbS8%26guce_referrer_sig%3DAQAAADt-lZ5YIPSVuWRT3KHPEd7vnTyqTgFbcEkVmBS9SkVmGKf9s5eP9qmMnheBYa3J5rVtCs1DY31pmbtGzyzQAnAfdOoIVIDc6j_sSOcKVEw1IS-3E7GOFb2qgftVJiYAS71jn3SU_Pq9d1S69akRFVCuMIj2CwVJEOMAdOFOgjR0");
            driver.FindElement(By.Id("login-username")).SendKeys("abc@yahoo.com");
        }
        [TearDown]
        public void Clean()
        {
            driver.Quit();
        }
    }
}