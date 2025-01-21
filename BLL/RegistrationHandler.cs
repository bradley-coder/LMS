using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class RegistrationHandler
    {
        RegistrationDBAccess dBAccess = null;
        
        public RegistrationHandler()
        {
            dBAccess = new RegistrationDBAccess();
        }
        public bool InsertUsers(Registration registration)
        {
            return dBAccess.InsertUsers(registration);
        }
        public List<Registration> GetLogin()
        {
            //throw new NotImplementedException();
            return dBAccess.GetLogin();
        }
    }
}
