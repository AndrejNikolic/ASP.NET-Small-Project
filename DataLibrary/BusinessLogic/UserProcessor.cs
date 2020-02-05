using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessLogic
{
    public static class UserProcessor
    {
        public static int CreateUser(string firstName, string lastName, string emailAddress, string password, DateTime birthday, string gender)
        {
            UserModels data = new UserModels
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                Password = password,
                BirthDay = birthday,
                Gender = gender
            };

            string sql = @"INSERT INTO dbo.[User] (FirstName, LastName, EmailAddress, Password, BirthDay, Gender)
                            VALUES (@FirstName, @LastName, @EmailAddress, @Password, @BirthDay, @Gender)";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<UserModels> LoadUsers()
        {
            string sql = @"SELECT Id, FirstName, LastName, EmailAddress, Password, BirthDay, Gender FROM dbo.[User]";

            return SqlDataAccess.LoadData<UserModels>(sql);
        }
    }
}
