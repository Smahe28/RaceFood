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
    public partial class CompleteOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrders()
        {
            WantToAdmin Orders = AdminService.CompleteOrders();
            GridView1.DataSource = Orders.CompleteOrders();
            GridView1.DataBind();
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string date = TxtSearch.Text;
            WantToAdmin completeorders = AdminService.CompleteOrders();
            GridView1.DataSource = completeorders.Filltercomplete(date);
            GridView1.DataBind();
            TxtSearch.Text = string.Empty;

        }
    }
}