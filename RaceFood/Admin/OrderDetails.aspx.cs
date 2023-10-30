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
    public partial class OrderDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            LoadOrders();
        }
        private void LoadOrders()
        {
            WantToAdmin Orders = AdminService.GetOrders();
            List<DelivaryModel> l_PendingOrders = Orders.OrdersList();
            GridView1.DataSource = l_PendingOrders;
            GridView1.DataBind();
            if(l_PendingOrders.Count<=0)
            {
                LblNoOrders.Text = "No Pending Orders";
            }
        }

      





        //protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        //{

        //    }

        //protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    int index = Convert.ToInt32(e.CommandArgument);
        //    GridViewRow gvRow = GridView1.Rows[index];
        //    switch (e.CommandName)
        //    {


        //          .Text = " Finish";
        //            btnhold.Text = "Hold";
        //            btnhold.CssClass = "btn btn-warning";
        //            btnFinish.Visible = true;
        //    }
        //}
    }
}