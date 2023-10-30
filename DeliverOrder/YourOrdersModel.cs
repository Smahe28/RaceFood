using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverOrder
{
    public class YourOrdersModel
    {
        private int id;
        private string delivaryaddress;
        private string coordinate;
        private string totalamount;
        private string paymentmethod;
        private int userid;
        private int orderID;
        private string canceltime;
        private string finishtime;
        private string restuarantname;
        private string address;
        private string foodname;
        private string foodprice;
        private string orderdate;
        private string username;
        private int quantity;
        private int amount;
       

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
      
        public string RestuarantName
        {
            get { return restuarantname; }
            set { restuarantname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string FoodName
        {
            get { return foodname; }
            set { foodname = value; }
        }
        public string FoodPrice
        {
            get { return foodprice; }
            set { foodprice = value; }
        }
        public int UserID
        {
            get { return userid; }
            set { userid = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        
      
        public string DelivaryAddress
        {
            get { return delivaryaddress; }
            set { delivaryaddress = value; }
        }
        public string TotalAmount
        {
            get { return totalamount; }
            set { totalamount = value; }
        }
        public string PaymentMethod
        {
            get { return paymentmethod; }
            set { paymentmethod = value; }
        }
        public string Coordinate
        {
            get { return coordinate; }
            set { coordinate = value; }
        }
        public string OrderDate
        {
            get { return orderdate; }
            set { orderdate = value; }
        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        public string CancelTime
        {
            get { return canceltime; }
            set { canceltime = value; }
        }
        public string FinishTime
        {
            get { return finishtime; }
            set { finishtime = value; }
        }
       
    }


}
