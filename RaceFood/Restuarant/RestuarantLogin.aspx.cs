using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Restuarant;
using RestuarantInterFacing;
using RestuarantCenter;
namespace RaceFood.Restuarant
{
    public partial class RestuarantLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Remove("ID");
            Session.Remove("RestuarantName");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
          RestuarantModel  objLogin = new RestuarantModel();
        
            objLogin.RestuarantName = TxtRestuarantID.Text;
            objLogin.Password = TxtPassword.Text;
            WantToRestuarant Restuarant = RestuarantService.Login();
           RestuarantModel LoginDetail= Restuarant.Login(objLogin);
            Session["ID"] = LoginDetail.ID;
            Session["RestuarantName"] = LoginDetail.RestuarantName;
            Response.Redirect("~/Restuarant/FoodRegister.aspx");
        }
      
    }
}