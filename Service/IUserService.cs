using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.Model;
using IPZ_Proj.Validators;

namespace IPZ_Proj.Service
{
    interface IUserService
    {
        List<User> GetUsers();
        void ChangeEmail([EmailValidator] string email);
        void ChangeLogin([LoginValidator]string login);
        void ChangePassword([PasswordValidator]string password);
        void ChangeNumber([NonZeroValidator]int number);
        void ChangeRole([RoleValidator]string role);
    }
}
