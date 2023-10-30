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
    public partial class CancelOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            LoadOrders();
        }
        private void LoadOrders()
        {
            WantToAdmin Orders = AdminService.CancelOrdes();
          List<DelivaryModel> L_CancelOrders= Orders.CancelOrders();
            GridView1.DataSource = L_CancelOrders;
            GridView1.DataBind();
            if(L_CancelOrders.Count<=0)
            {
                searchrow.Visible = false;
            }
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string date = TxtSearch.Text;
            WantToAdmin completeorders = AdminService.CancelOrdes();
            GridView1.DataSource = completeorders.FillterCancel(date);
            GridView1.DataBind();
            TxtSearch.Text = string.Empty;
        }
    }
}