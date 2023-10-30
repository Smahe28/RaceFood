using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserInterfacing;
using UserCenter;
using DeliverOrder;
namespace RaceFood.User
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            int OrderID = Convert.ToInt32( Request.QueryString["YoursOrderID"]);
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

        }

      
    }
}