using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestuarantInterFacing;
using Restuarant;
using RestuarantCenter;
namespace RaceFood.Admin
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            RestuarantModel Hotel = new RestuarantModel();
            Hotel.RestuarantName = TxtRName.Text;
            Hotel.RestuarantNo = TxtRNo.Text;
            Hotel.Category = TxtCategory.Text;
            Hotel.ContactNo = TxtPhoneNo.Text;
            Hotel.Email = TxtEmail.Text;
            Hotel.Address = TxtAddress.Text;
            Hotel.Password = TxtPassword.Text;
            
            WantToRestuarant Restuarant = RestuarantService.RestuarantRegister();
            Restuarant.Register(Hotel);
            LblMessage.Text = "Restuarant Register Succcessfully";
        }
    
    }
}