using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Admininterfacing;
using AdninCenter;
using OrderInterface;
namespace RaceFood.Admin
{
    public partial class CompleteForDeliBoy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            LoadOrders();
        }
        private void LoadOrders()
        {
            int DeliBoyID = Convert.ToInt32(Request.QueryString["DeliBoyID"]);
            WantToAdmin Orders = AdminService.CompleteOrders();
            List<DelivaryModel> l_DeliBoy= Orders.CompleteOrdersForDeliBoy(DeliBoyID);
            GridView1.DataSource = l_DeliBoy;
            GridView1.DataBind();
            if(l_DeliBoy.Count<=0)
            {
                LblNoOrders.Text = "No Completed Orders";
            }
        }
    }
}