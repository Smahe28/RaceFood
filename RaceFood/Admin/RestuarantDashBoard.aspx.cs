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
    public partial class RestuarantDashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Requests();
            }
        }
        private void Requests()
        {
            WantToAdmin Usercount = AdminService.TotalCounts();
            AdminModel l_Users = Usercount.Counts();
            
        }
    }
}