using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Exceptions;
using IPZ_Proj.Model;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class UserService : IUserService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        IUserRepository userRepository = new UserRepository();

        public List<User> GetUsers()
        {
            MySqlConnection connection = connectionFactory.ConnectionUsers;
            try
            {
                return userRepository.GetUsers(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }

        public void ChangeEmail(string email)
        {
            throw new InvalidEmailException();
        }

        public void ChangeLogin(string login)
        {
            throw new InvalidLoginException();
        }

        public void ChangePassword(string password)
        {
            throw new InvalidPasswordException();
        }

        public void ChangeNumber(int number)
        {
            throw new ZeroException();
        }

        public void ChangeRole(string role)
        {
            throw new InvalidRoleException();
        }
    }
}
