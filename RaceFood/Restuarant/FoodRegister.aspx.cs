using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FoodCenter;
using FoodInterFacing;
using Restuarant;
using RestuarantCenter;
using RestuarantInterFacing;
namespace RaceFood.Restuarant
{
    public partial class FoodRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                LoadLabel();
            LoadGrid();
                
        }
            BtnUpdate.Visible = false;
    }




        private void LoadLabel()
        {
            int Rest_Id = Convert.ToInt32(Session["ID"].ToString());
            WantToRestuarant Restuarant = RestuarantService.GetRestuarantName();
            RestuarantModel Lbl = Restuarant.GetRestuarantName(Rest_Id);

            LblRestuarant.Text = Lbl.RestuarantName;
            LblAddress.Text = Lbl.Address;

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            FoodModel FoodInsert = new FoodModel();
            FoodInsert.RestuarantID = Convert.ToInt32(Session["ID"].ToString());
            FoodInsert.FoodName = TxtFoodName.Text;
            FoodInsert.FoodPrice = TxtPrice.Text;
            WantToFood FoodData = FoodService.AddFoodObject();
            FoodData.AddFood(FoodInsert);
           
            LoadGrid();
            TxtFoodName.Text = string.Empty;
            TxtPrice.Text = string.Empty;
        }
        private void LoadGrid()
        {

            int FoodID = Convert.ToInt32( Session["ID"].ToString());
            WantToFood Food = FoodService.GetFoodDetails();
            GridView1.DataSource = Food.GetFood(FoodID);
            GridView1.DataBind();
        }

        protected void LinkEdit_Click(object sender, EventArgs e)
        {

            BtnAdd.Visible = false;
            BtnUpdate.Visible = true;

            int ID = Convert.ToInt32((sender as LinkButton).CommandArgument);

            WantToFood FoodObject = FoodService.EditFood();
            FoodModel FoodUp = FoodObject.FoodEdit(ID);
            //hdnCustId.Value = Convert.ToString(l_Cut.ID);
            TxtFoodName.Text = FoodUp.FoodName;
            LblID.Text = Convert.ToString(FoodUp.FoodID);
            TxtPrice.Text = FoodUp.FoodPrice;

        }

        protected void LinkDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((sender as LinkButton).CommandArgument);

            WantToFood DeleteObj = FoodService.DeleteFood();
            DeleteObj.DeleteFood(ID);

            LoadGrid();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            FoodModel FoodUp = new FoodModel();
            FoodUp.FoodID = Convert.ToInt32(LblID.Text);
            FoodUp.FoodName = TxtFoodName.Text;
            FoodUp.FoodPrice = TxtPrice.Text;


            //Calling backend logic to add customer
            WantToFood l_CusomerObj = FoodService.UpdateFood();
            l_CusomerObj.UpdateFood(FoodUp);
            LoadGrid();

      
            BtnAdd.Visible = true;
            BtnUpdate.Visible = false;
            TxtFoodName.Text = string.Empty;
            TxtPrice.Text = string.Empty;
            LblID.Text = string.Empty;
            Lbl1.Text = "Update Successfully";
        }
    }
}
