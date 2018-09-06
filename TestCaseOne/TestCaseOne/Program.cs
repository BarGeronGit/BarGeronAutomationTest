using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPick();
        }

        private static void MenuPick()
        {
            Login LoginTest = new Login();
            Registration RegistrationTest = new Registration();
            Console.WriteLine("Hello QA User, Please choose the Test you would like to perform");
            Console.WriteLine("1) Login Test");
            Console.WriteLine("2) Registration Test Step 1");
            Console.WriteLine("3) Registration Test Step 2");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Login(LoginTest);
                    break;
                case 2:
                    RegistrationStep1(RegistrationTest);
                    break;
                case 3:
                    RegistrationStep2(RegistrationTest);
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;

            }
        }
        private static void RegistrationStep1(Registration RegistrationTest)
        {
            Console.WriteLine("Enter the Mailinator you would like to register with(Only name!)");
            string name = Console.ReadLine();
            string Email = name + "@mailinator.com";
            RegistrationTest.RegistrationProcessStep1(name, Email);
        }
        private static void RegistrationStep2(Registration RegistrationTest)
        {
            Console.WriteLine("Please enter your verified Username and Password");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Phone Number: ");
            string PhoneNum = Console.ReadLine();
            RegistrationTest.RegistrationProcessStep2(username, password, PhoneNum);
        }
        private static void Login(Login LoginTest)
        {
            Console.WriteLine("Please enter your Username");
            string UserName = Console.ReadLine(); ;
            Console.WriteLine("Please enter your Password");
            string Password = Console.ReadLine();
            LoginTest.LoginProcess(UserName, Password);
        }
    }
}
