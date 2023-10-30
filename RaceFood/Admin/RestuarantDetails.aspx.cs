using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestuarantInterFacing;
using RestuarantCenter;
using Admininterfacing;
using AdninCenter;
namespace RaceFood.Admin
{
    public partial class RestuarantDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRestuarant();
        }
        private void LoadRestuarant()
        {
            WantToRestuarant AddRestuarant = RestuarantService.RestuarantObject();
            GridView2.DataSource = AddRestuarant.RegisterRestuarant();
            GridView2.DataBind();
        }

        protected void LinkDelete_Click(object sender, EventArgs e)
        {
            int RestuarantID = Convert.ToInt32((sender as LinkButton).CommandArgument);

            WantToAdmin DeleteObj = AdminService.DeleteResturant();
            DeleteObj.DeleteRestuarant(RestuarantID);

            LoadRestuarant();
        }
    }
}