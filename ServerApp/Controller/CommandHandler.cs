using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    internal static class CommandHandler
    {
        public static string HandleRequest(string request)
        {
            string[] parts = request.Split('|');
            string command = parts[0];

            if (command == "REGISTRATION")
            {
                return RegistrationUser(parts[1], parts[2], parts[3]);
            }
            else if (command == "LOGIN1")
            {
                return LoginUser1(parts[1], parts[2]);
            }
            else return "UNKNOWN_COMMAND";

        }

        private static string RegistrationUser(string orgName, string username, string password)
        {
            
            foreach (Organization org in Data.Organizations)
            {
                foreach (User user in org.Users)
                {
                    if (user.Username == username)
                    {
                        return "USER_ALREADY_REGISTERED";
                    }
                }
            }
            Organization organization = null;
            foreach (Organization org in Data.Organizations)
            {
                if (org.Name == orgName)
                {
                    organization = org;
                    break;
                }
            }

            User newUser = new User();
            newUser.Username = username;
            newUser.Password = password;
            organization.Users.Add(newUser);

            Data.SaveData();
            return "REGISTRATION_SUCCESS";
        }

        private static string LoginUser1(string username, string password)
        {
            bool userExist = false;
            foreach (Organization org in Data.Organizations)
            {
                foreach (User user in org.Users)
                {
                    if (user.Username == username)
                    {
                        userExist = true;
                        break;
                    }
                }
            }

            if (userExist)
            {
                return "LOGIN_SUCCESS";
            }
            else
            {
                return "LOGIN_FAILED";
            }
        }


    }
}

