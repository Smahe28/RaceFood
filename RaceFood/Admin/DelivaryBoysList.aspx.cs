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
    public partial class DelivaryBoysList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            LoadDeliBoy();
        }
        private void LoadDeliBoy()
        {
            WantToAdmin DeliBoy = AdminService.DeliboyList();
            GridView1.DataSource = DeliBoy.DeliBoyList();
            GridView1.DataBind();
        }

        protected void LinkDelete_Click(object sender, EventArgs e)
        {
            int DeliBoyID = Convert.ToInt32((sender as LinkButton).CommandArgument);

            WantToAdmin DeleteBoy = AdminService.DeleteDeliboy();
            DeleteBoy.DeleteDeliBoy(DeliBoyID);

            LoadDeliBoy();
        }
    }
}