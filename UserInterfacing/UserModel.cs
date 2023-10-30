using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfacing
{
    public class UserModel
    {
        private int Id;
        private string name;
        private string gender;
        private string dateOfBirth;
        private string password;
        private string contact;
        private string email;
        private string address;
        private string signDate;


        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string ContactNumer
        {
            get { return contact; }
            set { contact = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string SignDate
        {
            get { return signDate; }
            set { signDate = value; }
        }

    }
}
