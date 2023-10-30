using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderComplete
{
    public class OrderModel
    {
        private int id;
        private string delivaryaddress;
        private string coordinate;
        private string totalamount;
        private string paymentmethod;
        private int userid;


        public int ID
        {
            get { return id; }
            set { value = id; }
        }
        public int UserID
        {
            get { return userid; }
            set { value = userid; }
        }
        public string DelivaryAddress
        {
            get { return delivaryaddress; }
            set { value = delivaryaddress; }
        }
        public string TotalAmount
        {
            get { return totalamount; }
            set { value = totalamount; }
        }
        public string PaymentMethod
        {
            get { return paymentmethod; }
            set { value = paymentmethod; }
        }
        public string Coordinate
        {
            get { return coordinate; }
            set { value = coordinate; }
        }
    }
}
