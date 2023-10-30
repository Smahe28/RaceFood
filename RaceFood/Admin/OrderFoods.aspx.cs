using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserInterfacing;
using DeliverOrder;
using UserCenter;
using OrderInterface;
using SearchFoodInterFace;
using DeliveryBoycenter;
using DeliveryBoyInterface;
namespace RaceFood.Admin
{
    public partial class OrderFoods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            LoadGrid();






        }
        private void LoadGrid()
        {
            int OrderID = Convert.ToInt32(Request.QueryString["YoursOrderID"]);
            WantToUser OrderDe = UserService.YourOrders();
            List<YourOrdersModel> l_Users = OrderDe.YourPendingOrder(OrderID);
            GridView1.DataSource = l_Users;
            GridView1.DataBind();

            //display only one item in the label
            if (l_Users.Count > 0)
            {
                YourOrdersModel l_OrderModel = l_Users[0];
                LblTotalAmount.Text = l_OrderModel.TotalAmount;
                LblDAddress.Text = l_OrderModel.DelivaryAddress;
                lblPaymethod.Text = l_OrderModel.PaymentMethod;
                LblOrderdate.Text = l_OrderModel.OrderDate;
            }
            else if (l_Users.Count == 0)
            {




                int CancelID = Convert.ToInt32(Request.QueryString["YoursOrderID"]);
                WantToUser orders = UserService.YourOrders();
                List<YourOrdersModel> CancelOrd = OrderDe.CanceledOrder(CancelID);
                GridView1.DataSource = CancelOrd;
                GridView1.DataBind();

                //display only one item in the label
                if (CancelOrd.Count > 0)
                {
                    YourOrdersModel l_OrderModel = CancelOrd[0];
                    LblTotalAmount.Text = l_OrderModel.TotalAmount;
                    LblDAddress.Text = l_OrderModel.DelivaryAddress;
                    lblPaymethod.Text = l_OrderModel.PaymentMethod;
                    LblOrderdate.Text = l_OrderModel.OrderDate;
                }
            }
            else if (l_Users.Count == 0)
            {




                int FinishID = Convert.ToInt32(Request.QueryString["YoursOrderID"]);
                WantoDeliveryBoy Finish = DeliveryBoyService.FinishOrder();
                List<YourOrdersModel> FinishOrd = Finish.CompleteOrders(FinishID);
                GridView1.DataSource = FinishOrd;
                GridView1.DataBind();

                //display only one item in the label
                if (FinishOrd.Count > 0)
                {
                    YourOrdersModel l_OrderModel = FinishOrd[0];
                    LblTotalAmount.Text = l_OrderModel.TotalAmount;
                    LblDAddress.Text = l_OrderModel.DelivaryAddress;
                    lblPaymethod.Text = l_OrderModel.PaymentMethod;
                    LblOrderdate.Text = l_OrderModel.OrderDate;
                }
            }
        }
    }
}
