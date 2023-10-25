using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms1
{
    internal static class Accounts
    {
        private static List<User> _users = new List<User>();

        public static bool TryAddUser(string username, string password)
        {
            if (_users.Exists(user => user.Username == username))
                return false;

            _users.Add(new User(username, password));
            return true;
        }

        public static bool CheckUser(string username, string password) =>
            _users.Exists(user => user.Username == username && user.Password == password);
    }
}
