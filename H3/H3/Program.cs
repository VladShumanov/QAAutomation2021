using System;

namespace H3
{
    class Program
    {
        class Credentials
        {
            private string loginName;
            private string password;
            private string secretQuestion;

            public Credentials(string loginName, string password, string secretQuestion)
            {
                this.loginName = loginName;
                this.password = password;
                this.secretQuestion = secretQuestion;
            }

            public bool IsEquals(Credentials creds)
            {
                return (loginName == creds.loginName && password == creds.password && secretQuestion == creds.secretQuestion);
            }
        }

        // Entry point
        static void Main(string[] args)
        {
            Credentials cred = new Credentials("name2", "password2", "secretQuestion2");

            if (CheckAuthentification(cred) == true)
            {
                Login();
            }
            else
            {
                throw new Exception("Can't authentificate!");
            }
        }

        static bool CheckAuthentification(Credentials creds)
        {
            Credentials[] dbCredentials = GetCredentialsFromDB();
            foreach (Credentials credData in dbCredentials)
            {
                if (credData.IsEquals(creds))
                {
                    return true;
                }
            }
            return false;
        }

        static void Login()
        {
            Console.WriteLine("Login");
            Console.ReadKey();
            /// Login
        }

        static Credentials[] GetCredentialsFromDB()
        {
            // Data base
            Credentials[] dataBaseCreds = new Credentials[3];
            dataBaseCreds[0] = new Credentials("name1", "password1", "secretQuestion1");
            dataBaseCreds[1] = new Credentials("name2", "password2", "secretQuestion2");
            dataBaseCreds[2] = new Credentials("name3", "password3", "secretQuestion3");
            return dataBaseCreds;
        }
    }
}