using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestuarantCenter;
using RestuarantInterFacing;
namespace RaceFood.User
{
    public partial class UserEntrance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRestuarant();
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User/Foodpage.aspx?FoodName=" + TxtSearch.Text);
        }
        private void LoadRestuarant()
        {
            WantToRestuarant Restuarant = RestuarantService.GetRestuarant();

            Repeater1.DataSource = Restuarant.RegisterRestuarant();
            Repeater1.DataBind();
        }
    }
}