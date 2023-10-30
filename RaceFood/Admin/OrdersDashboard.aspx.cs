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
    public partial class OrdersDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRestuarant();
            }
        }
        private void LoadRestuarant()
        {
            WantToAdmin Usercount = AdminService.TotalCounts();
            AdminModel l_Orders = Usercount.Counts();
            LblPending.Text = Convert.ToString(l_Orders.PendingOrdersCount);
            LblComplete.Text = Convert.ToString(l_Orders.CompleteOrdersCount);
            LblCancel.Text=  Convert.ToString(l_Orders.CancelOrdersConut);
        }
    }
}