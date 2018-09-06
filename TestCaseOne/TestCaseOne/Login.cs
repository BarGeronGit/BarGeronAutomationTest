using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest
{
    public class Login
    {
        public string Loginmainbutton = "toggle_login";
        public string Username_Textbox = "LoginPopupUI_LoginPopup_UI_txtLoginUser";
        public string Password_Textbox = "LoginPopupUI_LoginPopup_UI_txtLoginPass";
        public string Login_window_button = "ql_login";
        public string Continue_Button = "TC_btn_play";


        public void LoginProcess(string Username, string Password)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.casinoclub.com";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.FindElement(By.Id(Loginmainbutton)).Click();
            driver.FindElement(By.Id(Username_Textbox)).SendKeys(Username);
            driver.FindElement(By.Id(Password_Textbox)).SendKeys(Password);
            driver.FindElement(By.Id(Login_window_button)).Click();
            driver.FindElement(By.Id(Continue_Button)).Click();
        }
    }
}

