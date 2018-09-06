using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest
{
    class Registration
    {
        public Login login = new Login();
        string Registration_Main_button = "toggle_register";
        string Email_Textbox = "txtEmail";
        string Password_Textbox = "txtPassword";
        string Confirm_Password_Textbox = "txtconfirmpass";
        string Customer_Over_18_Checkbox = "customer_check";
        string Receive_Content_Checkbox = "ctl00$VerifyClientOS$register_content$chkSmsPromo";
        string Form1_Registration_Button = "btnRegister";
        string Send_Email_Verification = "verify_resend_link";
        string First_Mailinator_Mail = "all_message-min";
        string Balance_Link = "pBalanceValDsk";
        string First_Name = "txtFirstName";
        string Last_Name = "txtLastName";

        public void RegistrationProcessStep1(string name, string email)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.casinoclub.com";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id(Registration_Main_button)).Click();
            driver.FindElement(By.Id(Email_Textbox)).SendKeys(email);
            driver.FindElement(By.Id(Password_Textbox)).SendKeys("geron320");
            driver.FindElement(By.Id(Confirm_Password_Textbox)).SendKeys("geron320");
            driver.FindElement(By.ClassName(Customer_Over_18_Checkbox)).Click();
            driver.FindElement(By.Name(Receive_Content_Checkbox)).Click();
            driver.FindElement(By.Id(Form1_Registration_Button)).Click();
            driver.FindElement(By.ClassName(Send_Email_Verification)).Click();
            IWebDriver driver2 = new ChromeDriver();
            driver2.Url = $"https://www.mailinator.com/v2/inbox.jsp?zone=public&query={name}";
            driver2.Manage().Window.Maximize();
            Console.WriteLine("Press any key after you receive the Confirmation Mail");
            Console.ReadKey();
            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver2.FindElement(By.ClassName(First_Mailinator_Mail)).Click();
        }
        public void RegistrationProcessStep2(string Username, string Password, string PhoneNum)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.casinoclub.com";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.FindElement(By.Id(login.Loginmainbutton)).Click();
            driver.FindElement(By.Id(login.Username_Textbox)).SendKeys(Username + "@mailinator.com");
            driver.FindElement(By.Id(login.Password_Textbox)).SendKeys(Password);
            driver.FindElement(By.Id(login.Login_window_button)).Click();
            driver.FindElement(By.Id(login.Continue_Button)).Click();
            driver.FindElement(By.Id(Balance_Link)).Click();

            driver.FindElement(By.Id(First_Name)).SendKeys("Bar");
            driver.FindElement(By.Id("txtLastName")).SendKeys("geron");
            driver.FindElement(By.ClassName("chk_answer_yes")).Click();
            driver.FindElement(By.Id("reg_phoneNr_Fin")).SendKeys(PhoneNum);
            driver.FindElement(By.Id("txtStreet")).SendKeys("Azrieli");
            driver.FindElement(By.Id("txtHouseNr")).SendKeys("123");
            driver.FindElement(By.Id("txtZip")).SendKeys("321");
            driver.FindElement(By.Id("txtCity")).SendKeys("Berlin");
            driver.FindElement(By.XPath("//*[@id='reg_section_address']/div[7]/div[1]/span/span[1]/input[1]")).SendKeys("02");
            driver.FindElement(By.XPath("//*[@id='reg_section_address']/div[7]/div[1]/span/span[1]/input[2]")).SendKeys("02");
            driver.FindElement(By.XPath("//*[@id='reg_section_address']/div[7]/div[1]/span/span[1]/input[3]")).SendKeys("1980");
            driver.FindElement(By.Id("txtNickName")).Click();
            driver.FindElement(By.Id("btnSaveFinalize")).Click();






        }
    }
}
