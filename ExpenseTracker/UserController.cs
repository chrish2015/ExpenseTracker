using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    class UserController
    {
        public User VerifyLogin(String username, String password)
        {
            using (ExpenseTrackerDBEntities et = new ExpenseTrackerDBEntities())
            {

                User user = et.Users.FirstOrDefault(r => r.username == username && r.password == password);
                return user;
            }
        }
        

    }
}
