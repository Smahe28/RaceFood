using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarantInterFacing
{
    public class RestuarantModel
    {
        private int id;
        private string restuarantName;
        private string restuarantNo;
        private string address;
        private string category;
        private string email;
        private string contactNo;
        private string date;
        private string password;
        private string registerDate;
        private string requestdate;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string RestuarantName
        {
            get { return restuarantName; }
            set { restuarantName = value; }
        }
        
        public string RestuarantNo
        {
            get { return restuarantNo; }
            set { restuarantNo = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string RegisterDate
        {
            get { return registerDate; }
            set { registerDate = value; }
        }
        public string RequestDate
        {
            get { return requestdate; }
            set { requestdate = value; }
        }
    }
}
