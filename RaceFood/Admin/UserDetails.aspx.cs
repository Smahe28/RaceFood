using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Admininterfacing;
using AdninCenter;
namespace RaceFood.Admin
{
    public partial class UserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            WantToAdmin Users = AdminService.GetUsers();
            GridView2.DataSource = Users.UserList();
            GridView2.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int UserID= Convert.ToInt32((sender as LinkButton).CommandArgument);
            WantToAdmin UserDelete = AdminService.DeleteUser();
            UserDelete.DeleteUser(UserID);
            LoadUsers();
        }
    }
}