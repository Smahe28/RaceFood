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
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                LoadRestuarant();
            
        }
        private void LoadRestuarant()
        {
            WantToAdmin Usercount = AdminService.TotalCounts();
            AdminModel l_Users = Usercount.Counts();
            LblUserResult.Text = Convert.ToString(l_Users.Usercount);
            LblDeliveryBoyResult.Text= Convert.ToString(l_Users.DeliBoyCount);
            LblNotifyResult.Text= Convert.ToString(l_Users.RestuarantCount);
        }
    }
}