Imports System.Windows.Forms
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI

Module Module1
    Sub Main()

        Dim driver As IWebDriver

        driver = New ChromeDriver("~\LoginAutomation\LoginAutomation\chromedriver_win32\")

        driver.Navigate().GoToUrl("http://www.facebook.com")

        driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("user")
        driver.FindElement(By.XPath("//*[@id='pass']")).SendKeys("pass")
        driver.FindElement(By.XPath("//*[@id='u_0_2']")).Submit()

        'driver.Dispose()

    End Sub
End Module
