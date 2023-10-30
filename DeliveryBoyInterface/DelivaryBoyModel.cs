using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryBoyInterface
{
    public class DelivaryBoyModel
    {
        private int id;
        private string name;
        private string address;
        private string email;
        private string contactNo;
        private string datofbirth;
        private string gender;
        private string password;
        private string date;
        private string mainarea;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string DateOfBirth
        {
            get { return datofbirth; }
            set { datofbirth = value; }
        }
        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string MainArea
        {
            get { return mainarea; }
            set { mainarea = value; }
        }
    }
}
