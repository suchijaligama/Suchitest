//Open Chrome browser
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

IWebDriver webDriver = new ChromeDriver();
webDriver.Manage().Window.Maximize();

// Launch TurnUp portal and navigate to login page
webDriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

//Identify username textbox and enter valid username
IWebElement usernameTextbox = webDriver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter valid password
IWebElement passwordTextbox = webDriver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify login button and click on the button
IWebElement loginButton = webDriver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

//Check if user has logged in sucessfully
IWebElement helloHarilink = webDriver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (helloHarilink.Text == "Hello hari!")
{
    Console.WriteLine("user has logged in successfully");
}
else
{
    Console.WriteLine("user hasn't been logged in.");
}
// Check if user has logged in successful