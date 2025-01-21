using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;


namespace Project
{
    public partial class frmRegistration : System.Web.UI.Page
    {
        //string messageVariable = "Registration Sucessfull";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Options to choose from in the comboBox for user Role
            cmbUserRole.Items.Add("Admin");
            cmbUserRole.Items.Add("Student");
            cmbUserRole.Items.Add("Lecturer");
            cmbUserRole.Items.Add("Teacher");
            cmbUserRole.Items.Add("Subject Coordinator");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //instantiate class that has the column names of registration table
            Registration registration = new Registration();
            //getting user input from textboxes and putting them in specific columns in table
            registration.Name = txtName.Text;
            registration.SurName = txtSurName.Text;
            registration.Email = txtEmail.Text;
            registration.Password = txtPassword.Text;
            registration.UserRole = cmbUserRole.SelectedValue.ToString();
            //instantiates registrationHandler(in Business Logic Layer)
            RegistrationHandler registrationHandler = new RegistrationHandler();

            if(registrationHandler.InsertUsers(registration)==true)
            {
                //label display when inserting user is successfull 
                lblRegistrationSuccess.Visible=true;
                Response.Redirect("frmLogin.aspx");
                //MessageBox to display in asp
               //ClientScript.RegisterStartupScript(this.GetType(),"myalert","alert('" + messageVariable +"'); ",true);
            }
            else
            {
                //display error message in label
                lblRegistrationFailed.Visible = true;
            }

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            //When Sign In buttton is clicked it riderects user to Login Page
            Response.Redirect("frmLogin.aspx");
        }
       
    }
}