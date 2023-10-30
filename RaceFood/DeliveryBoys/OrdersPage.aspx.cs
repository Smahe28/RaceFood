using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeliveryBoyInterface;
using DeliveryBoycenter;
using OrderInterface;
namespace RaceFood.DeliveryBoys
{
    public partial class OrdersPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LoadFood();
            }
        }
        private void LoadFood()
        {
            int DeliBoyID = Convert.ToInt32(Session["ID"]);
            WantoDeliveryBoy Foods = DeliveryBoyService.DeliBoyOrder();
            List<DelivaryModel> l_CompleteOrders= Foods.OrderDetails(DeliBoyID);
            GridView1.DataSource = l_CompleteOrders;
            GridView1.DataBind();
            if (l_CompleteOrders.Count <= 0)
            {
                LblNoOrders.Text = "Please Go and Check Notifications";
            }
        }

        protected void LinkFinish_Click(object sender, EventArgs e)
        {

            int OrderID = Convert.ToInt32((sender as LinkButton).CommandArgument);

            WantoDeliveryBoy DeleteObj = DeliveryBoyService.FinishOrder();
            DeleteObj.FinishOrder(OrderID);

            LoadFood();
        }
    }
}