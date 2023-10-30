using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeliveryBoycenter;
using DeliveryBoyInterface;
using OrderInterface;
namespace RaceFood.DeliveryBoys
{
    public partial class DeliveryBoyPage : System.Web.UI.Page
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
            int DeliBoyID = Convert.ToInt32(Session["ID"].ToString());
            WantoDeliveryBoy Foods = DeliveryBoyService.DeliverFoodDetails();
          List<DelivaryModel> l_Orders= Foods.FoodDetails(DeliBoyID);
            GridView1.DataSource = l_Orders;
            GridView1.DataBind();
            if(l_Orders.Count<=0)
            {
                LblNoOrders.Text = "No Orders";
            }
        }

        protected void LinkAccept_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32((sender as LinkButton).CommandArgument);

            WantoDeliveryBoy DeleteObj = DeliveryBoyService.OrderNotification();
            DeleteObj.OrderNotification(OrderID);

            LoadFood();
        }
    }
}