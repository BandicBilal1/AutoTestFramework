using System.ComponentModel;

namespace AutoTestFramework
{
    public static class Config
    {
        public static string BaseUrl = "http://testing.todorvachev.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string UserName = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "exapmple@exapmle.com";

            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string FourChar = "asdf";
                    public static string FiveChar = "asdfg";
                }

            }

            public static class AlertMessages
            {
                public static string SuccessfulLogin = "Succesful login!";
            }
        }
    }
}
