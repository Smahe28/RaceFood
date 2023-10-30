using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserCenter;
using UserInterfacing;
using Users;
namespace RaceFood
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUserid.Text=="kalai" && TxtPassword.Text=="kalai4545")
            {
                Response.Redirect("~/Admin/DashBoard.aspx");
            }
            else if(TxtUserid.Text != "kalai" && TxtPassword.Text != "kalai4545")
            { 
         UserModel    Login = new UserModel();

            Login.Name = TxtUserid.Text;
            Login.Password = TxtPassword.Text;
            WantToUser User = UserService.Login();
            UserModel LoginDetail = User.Login(Login);
            Session["ID"] = LoginDetail.ID;
            Session["Name"] = LoginDetail.Name;
            Response.Redirect("~/User/UserEntrance.aspx");
            }
        }
    }
}