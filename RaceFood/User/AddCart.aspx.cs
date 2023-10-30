using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserInterfacing;
using UserCenter;
using SearchFoodInterFace;
using OrderInterface;
using System.Data;
using System.Data.SqlClient;
namespace RaceFood.User
{
    public partial class AddCart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            UserCarts();
        }
        private void UserCarts()
        {
            int UserID = Convert.ToInt32(Session["ID"]);
            WantToUser CartDe = UserService.CartFood();
            List<SearchFoodModel> l_cart = CartDe.CartDetails(UserID);
            GridView1.DataSource = l_cart;
            GridView1.DataBind();
            int Amount = 0;

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                Amount += Convert.ToInt32(GridView1.Rows[i].Cells[6].Text);
            }
            LblTotalAmount.Text = Convert.ToString(Amount);
            if (l_cart.Count <= 0)
            {
                LblNoCarts.Text = "No Carts Available";
                BtnConfirm.Visible = false;
                HyperLink1.Visible = false;
                Total.Visible = false;
                LblTotalAmount.Visible = false;
            }
        }


        protected void LinkDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            WantToUser Remove = UserService.RemoveCart();
            Remove.Removecart(ID);
            UserCarts();
        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {
            Delivary.Visible = true;
            BtnConfirm.Enabled = false;
        }

        protected void BtnPayment_Click(object sender, EventArgs e)
        {
            DelivaryModel OrderFinish = new DelivaryModel();
            OrderFinish.UserID = Convert.ToInt32(Session["ID"]);
            OrderFinish.DelivaryAddress = TxtAddress.Text;
            OrderFinish.Coordinate = TxtCo.Text;
            OrderFinish.PaymentMethod = DdlPayment.SelectedItem.Text;
            OrderFinish.TotalAmount = LblTotalAmount.Text;
            OrderFinish.MainArea = DdlArea.SelectedItem.Text;
            SearchFoodModel OrderDone = new SearchFoodModel();
            WantToUser l_Order = UserService.OrderComplete();
            l_Order.OrderConfirm(OrderDone);
            WantToUser Delivary = UserService.OrderComplete();
            Delivary.DelivaryDetails(OrderFinish);
            TxtAddress.Text = string.Empty;
            TxtCo.Text = string.Empty;
            LblTotalAmount.Text = string.Empty;
            int UserID = Convert.ToInt32(Session["ID"]);
            WantToUser CartComplete = UserService.FinishCart();
            CartComplete.FinishCart(UserID);
            UserCarts();
            RemoveLabel();
        }
        private void RemoveLabel()
        {
            Delivary.Visible = false;
            BtnConfirm.Visible = false;
            LblTotalAmount.Visible = false;
            Total.Visible = false;
            HyperLink1.Visible = false;
        }
    }
}