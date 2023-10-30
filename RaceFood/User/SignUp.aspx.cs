using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserCenter;
using UserInterfacing;
using Users;
namespace RaceFood.User
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            UserModel RSign = new UserModel();
            RSign.Name = TxtName.Text;
            RSign.Gender = DdlType.SelectedItem.Text;
            RSign.DateOfBirth = TxtDOB.Text;
            RSign.Email = TxtEmail.Text;
            RSign.ContactNumer = TxtPhoneNo.Text;
            RSign.Address = TxtAddress.Text;
            RSign.Password = TxtPassword.Text;
            WantToUser Userobj = UserService.GetUserObject();
            Userobj.AddUser(RSign);
            TxtName.Text = string.Empty;
                TxtDOB.Text= string.Empty;
            TxtEmail.Text= string.Empty;
            TxtPhoneNo.Text= string.Empty;
            TxtAddress.Text= string.Empty;
            TxtPassword.Text= string.Empty;
        }
    }
}