using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FoodInterFacing;
using FoodCenter;
using SearchFoodInterFace;
using UserInterfacing;
using UserCenter;
namespace RaceFood.User
{
    public partial class Verify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadFood();
        }
        private void LoadFood()
        {
            int FoodID = Convert.ToInt32( Request.QueryString["FoodID"]);
           WantToUser  FoodOrder = UserService.OrderFood();
            SearchFoodModel FoodObject = FoodOrder.OrderFood(FoodID);
            TxtFoodName.Text = FoodObject.FoodName;
            TxtFoodPrice.Text = FoodObject.FoodPrice;
            Label1.Text = Convert.ToString( FoodObject.RestuarantID);
            Label2.Text = Convert.ToString( FoodObject.ID);
        }

        protected void BtnCard_Click(object sender, EventArgs e)
        {
            SearchFoodModel Cart = new SearchFoodModel();
            Cart.FoodName = TxtFoodName.Text;
            Cart.FoodPrice = TxtFoodPrice.Text;
            Cart.RestuarantID =  Convert.ToInt32( Label1.Text);
            Cart.ID = Convert.ToInt32(Label2.Text);
            Cart.Quantity = Convert.ToInt32( TxtQuantity.Text);
            Cart.UserID = Convert.ToInt32(Session["ID"]);
            WantToUser Carts = UserService.AddCart();
            Carts.AddCarts(Cart);
            TxtFoodName.Text = string.Empty;
            TxtFoodPrice.Text = string.Empty;
            TxtQuantity.Text = string.Empty;
            Response.Redirect("~/User/AddCart.aspx");
         
        }

        protected void BtnOrder_Click(object sender, EventArgs e)
        {
            SearchFoodModel Cart = new SearchFoodModel();
            Cart.FoodName = TxtFoodName.Text;
            Cart.FoodPrice = TxtFoodPrice.Text;
            Cart.RestuarantID = Convert.ToInt32(Label1.Text);
            Cart.ID = Convert.ToInt32(Label2.Text);
            Cart.Quantity = Convert.ToInt32(TxtQuantity.Text);
            Cart.UserID = Convert.ToInt32(Session["ID"]);
            WantToUser Carts = UserService.AddCart();
            Carts.AddCarts(Cart);
            TxtFoodName.Text = string.Empty;
            TxtFoodPrice.Text = string.Empty;
            TxtQuantity.Text = string.Empty;
            Response.Redirect("~/User/AddCart.aspx");
        }
    }
}