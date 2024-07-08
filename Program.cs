using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up the Chrome driver
            IWebDriver driver = new ChromeDriver();

           
                // Navigate to the Sauce Labs Sample Application
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                Thread.Sleep(2000);

            // Log in to the application
            driver.FindElement(By.Id("user-name")).SendKeys("performance_glitch_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(2000);

            // Add a T-shirt to the cart
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
                driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            Thread.Sleep(2000);


            // Go to the cart
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Thread.Sleep(2000);

            // Proceed to checkout
            driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(2000);

            // Enter checkout information
            driver.FindElement(By.Id("first-name")).SendKeys("Sunday");
                driver.FindElement(By.Id("last-name")).SendKeys("Charles");
                driver.FindElement(By.Id("postal-code")).SendKeys("101283");
                driver.FindElement(By.Id("continue")).Click();
            Thread.Sleep(2000);

            // Finish the purchase
            driver.FindElement(By.Id("finish")).Click();

                Console.WriteLine("Test completed successfully.");
                
            
        }
    }
}
