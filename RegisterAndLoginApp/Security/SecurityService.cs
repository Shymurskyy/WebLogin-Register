using RegisterAndLoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLoginApp.Security
{
    public class SecurityService
    {
        UserDAO userDao = new UserDAO();
        public SecurityService()
        {
           
        }
        public bool isValid(UserModel user)
        {
            //true if found
            return userDao.FindUserByNameAndPassword(user);
        }
        public bool registerSuccess(UserModel user)
        {
            return userDao.RegisterNewUser(user);
        }
    }
}
