using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using DAL;

namespace Project
{
    public partial class frmStudent : System.Web.UI.Page
    {
        DataTable dt = frmLogin.dtLogg;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserDetails.Text=dt.Rows[0]["Name"].ToString()+","+dt.Rows[0]["SurName"].ToString()+"\n"+dt.Rows[0]["Email"].ToString()+"("+dt.Rows[0]["UserRole"].ToString()+")";
        }
    }
}