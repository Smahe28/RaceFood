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
    public partial class FoodPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadFood();
        }
        private void LoadFood()
        {

            string FoodName = Request.QueryString["FoodName"];
            WantToUser Food = UserService.FoodSearch();
            GridView1.DataSource = Food.FoodSearch(FoodName);
            GridView1.DataBind();
        }
    }
}