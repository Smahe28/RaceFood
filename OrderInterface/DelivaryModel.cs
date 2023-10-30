using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderInterface
{
    public class DelivaryModel
    {
        private int id;
        private int deliBoyid;
        private string delivaryaddress;
        private string coordinate;
        private string totalamount;
        private string paymentmethod;
        private int userid;
        private string date;
        private string name;
        private string mainarea;
        private string finishtime;
        private string canceltime;
        private string status;




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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ID
        {
            get { return id; }
            set {  id=value; }
        }
        public int DeliBoyID
        {
            get { return deliBoyid; }
            set { deliBoyid = value; }
        }
        public int UserID
        {
            get { return userid; }
            set { userid = value; }
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
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
