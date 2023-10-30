using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeliveryBoyInterface;
using DeliveryBoycenter;
namespace RaceFood.DeliveryBoys
{
    public partial class DeliveryBoyLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            DelivaryBoyModel Login = new DelivaryBoyModel();

            Login.Name = TxtUserid.Text;
            Login.Password = TxtPassword.Text;
            WantoDeliveryBoy User = DeliveryBoyService.DeliveryBoyLogin();
            DelivaryBoyModel LoginDetail = User.Login(Login);
            Session["ID"] = LoginDetail.ID;
            Session["Name"] = LoginDetail.Name;
            Response.Redirect("~/DeliveryBoys/OrdersPage.aspx");
        }
    }
}