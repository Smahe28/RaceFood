using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Admininterfacing;
using AdninCenter;
using FoodInterFacing;
namespace RaceFood.Admin
{
    public partial class FoodDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            int RestuarantID = Convert.ToInt32(Request.QueryString["RestuarantID"]);
            WantToAdmin OrderDe = AdminService.GetFoods();
            List<FoodModel> l_Users = OrderDe.FoodList(RestuarantID);
            GridView1.DataSource = l_Users;
            GridView1.DataBind();

            //display only one item in the label
            if (l_Users.Count > 0)
            {
                FoodModel l_OrderModel = l_Users[0];
                LblRestuarantName.Text = l_OrderModel.RestuarantName;
                LblAddress.Text = l_OrderModel.Address;
         
            }
            else
            {
                LblRestuarantName.Text = "Empty Food List";
            }
        }
    }
}