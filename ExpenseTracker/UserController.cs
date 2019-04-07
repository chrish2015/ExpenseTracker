using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    class UserController
    {
        public bool VerifyLogin(String username, String password)
        {
            using (ExpenseTrackerDBEntities et = new ExpenseTrackerDBEntities())
            {

                User user = et.Users.FirstOrDefault(r => r.username == username && r.password == password);
                if (user != null)
                {
                    MainView mainView = new MainView(user);
                    mainView.Show();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }


    }
}
