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
    public partial class frmLogin : System.Web.UI.Page
    {
        Registration registration = new Registration();
        RegistrationHandler registrationHandler = new RegistrationHandler();
        //stores user details thats logged in
        public static DataTable dtLogg = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            //get user input from textboxes
            //dtLogg = registrationHandler.GetLogin();
            registration.Name = txtName.Text;
            registration.Password = txtPassword.Text;
            string role = dtLogg.Rows[0]["UserRole"].ToString();
            if(dtLogg.Rows.Count>0)
            {
                //riderects user to specific form based on their Roles
                if(role=="Student")
                {
                    Response.Redirect("Student.aspx");
                }
                else if(role=="Admin")
                {
                    Response.Redirect("Admin.aspx");
                }
                else if(role=="Teacher")
                {
                    Response.Redirect("Teacher.aspx");
                }
                else if(role=="Parent")
                {
                    Response.Redirect("Parent.aspx");
                }
                else if(role=="Subject Coordinator")
                {
                    Response.Redirect("Subject Coordinator.aspx");
                }
                else
                {
                    lblInvalid.Visible = true;//error message if password or username is incorrect
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            dtLogg = null;
            Response.Redirect("frmRegistration.aspx");
        }
    }
}