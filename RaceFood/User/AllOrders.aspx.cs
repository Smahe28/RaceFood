using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserInterfacing;
using UserCenter;
using DeliverOrder;
using OrderInterface;
using Admininterfacing;
using AdninCenter;
namespace RaceFood.User
{
    public partial class AllOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
                //Loadstatus();
            }
        }
        private void LoadGrid()
        {
            int UserID = Convert.ToInt32(Session["ID"]);
            WantToUser OrderDe = UserService.YourOrders();
            List<DelivaryModel> l_Orders = OrderDe.YourOrdersDetails(UserID);
            GridView1.DataSource = l_Orders;
            GridView1.DataBind();
            if (l_Orders.Count <= 0)
            {
                
                LblNoOrders.Text = "No Orders";

            }
        }

        protected void LinkDelete_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            WantToUser DeleteObj = UserService.CancelYourOrder();
            DeleteObj.CancelOrder(OrderID);

            LoadGrid();
        }

        //private void Loadstatus()
        //{
        //    int OrderID = Convert.ToInt32(GridView1.Rows.Cells[1].Text);
        //    WantToAdmin OrderDe = AdminService.CompleteForUser();
        //    DelivaryModel l_Orders = OrderDe.Completestatus(OrderID);
        //    GridViewRow gvRow = GridView1.Rows[OrderID];
        //    Button btnpending = (gvRow.Cells[7].FindControl("btnpending") as Button);
        //    btnpending.Text = "Completed";
        //}


    }
}