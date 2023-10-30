using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeliveryBoyInterface;
using Admininterfacing;
using AdninCenter;
namespace RaceFood.Admin
{
    public partial class DeliveryBoyRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            DelivaryBoyModel DeliBoy = new DelivaryBoyModel();
            DeliBoy.Name = TxtName.Text;
            DeliBoy.Address = TxtAddress.Text;
            DeliBoy.Gender = DdlType.SelectedItem.Text;
            DeliBoy.ContactNo = TxtConatactNo.Text;
            DeliBoy.Email = TxtEmail.Text;
            DeliBoy.DateOfBirth = Txtdob.Text;
            DeliBoy.Password = TxtPassword.Text;
            DeliBoy.MainArea = ddllocate.SelectedItem.Text;
            WantToAdmin  Boy = AdminService.DeliboyRegister();
            Boy.RegisterDeliveryBoy(DeliBoy);
            LblMessage.Text = "Send Successfully....";
            TxtName.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            TxtConatactNo.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            Txtdob.Text = string.Empty;
            TxtPassword.Text = string.Empty;
           
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/DelivaryBoysList.aspx");
        }
    }
}