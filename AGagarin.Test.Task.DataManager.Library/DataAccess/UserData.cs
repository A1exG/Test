using AGagarin.Test.Task.DataManager.Library.Internal;
using AGagarin.Test.Task.DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGagarin.Test.Task.DataManager.Library.DataAccess
{
    public class UserData
    {
        public UserModel GetUserById(int Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id };


            //var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "AccountingDataDb");

            return null;
        }

        public List<UserModel> GetAllUser()
        {
            SqlDataAccess sql = new SqlDataAccess();

            //var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "AccountingDataDb");

            return null;
        }
    }
}
