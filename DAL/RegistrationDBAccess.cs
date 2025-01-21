using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RegistrationDBAccess
    {
        //Add users who registers
        public bool InsertUsers(Registration registration)
        {
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@Name",registration.Name),
                new SqlParameter("@SurName",registration.SurName),
                new  SqlParameter("@Email",registration.Email),
                new SqlParameter("@Password",registration.Password),
                new SqlParameter("@UserRole",registration.UserRole)
            };
            return DBHelper.ExecuteNonQuery("sp_InsertRegisteredUsers", CommandType.StoredProcedure, sqlParameter);
        }
        //Selects user Email and password for Login
        public List<Registration> GetLogin()
        {
            List<Registration> registrationsList = null;

            using (DataTable dt=DBHelper.ExecuteSelectCommand("sp_GetLogin",CommandType.StoredProcedure))
            {
                if(dt.Rows.Count>0)
                {
                    registrationsList = new List<Registration>();
                    foreach(DataRow dataRow in dt.Rows)
                    {
                        Registration registration = new Registration();
                        registration.Name = dataRow["Name"].ToString();
                        registration.Password = dataRow["Password"].ToString();
                        registrationsList.Add(registration);
                    }
                }
            }
            return registrationsList;
        }
    }
}
