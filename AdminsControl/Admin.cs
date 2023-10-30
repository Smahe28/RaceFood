using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admininterfacing;
using Database1;
using System.Data.SqlClient;
using FoodInterFacing;
using UserInterfacing;
using DeliverOrder;
using OrderInterface;
using DeliveryBoyInterface;
using System.Data;

namespace AdminsControl
{
    public class Admin : WantToAdmin
    {
        public bool DeleteRestuarant(int RestuarantID)
        {
            string sql = "Delete From RestuarantRegister Where ID=" + RestuarantID;
            Connection l_Connection = new Connection();
            using (SqlConnection sqlConnection = l_Connection.MyConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

            return true;
        }

        public bool DeleteUser(int UserID)
        {
            string sql = "Delete From Signup Where ID=" + UserID;
            Connection l_Connection = new Connection();
            using (SqlConnection sqlConnection = l_Connection.MyConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

            return true;
        }

        public List<FoodModel> FoodList(int RestuarantID)
        {
            List<FoodModel> FoodList = new List<FoodModel>();

            FoodModel FoodData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            string sql = "select a.FoodID, a.RestuarantID,a.FoodPrice ,a.FoodName, b.RestuarantName,b.Address from FoodRegister as a join RestuarantRegister as b on a.RestuarantID=b.ID  where a.RestuarantID=" + RestuarantID;
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    FoodData = new FoodModel();

                    FoodData.FoodID = Convert.ToInt32(dr["FoodID"].ToString());
                    FoodData.FoodName = dr["FoodName"].ToString();
                    FoodData.FoodPrice = dr["FoodPrice"].ToString();
                    FoodData.RestuarantName = dr["RestuarantName"].ToString();
                    FoodData.Address = dr["Address"].ToString();

                    FoodList.Add(FoodData);
                }
                con.Close();
            }
            return FoodList;
        }

        public List<YourOrdersModel> YourOrder()
        {
            List<YourOrdersModel> Orders = new List<YourOrdersModel>();
            YourOrdersModel OrderData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            string sql = "select b.OrderID, a.UserID, b.DeliverAddress,b.TotalAmount,b.PaymentMethod,b.OrderDate,c.RestuarantName,c.Address,d.Name,a.FoodID,a.FoodName, a.FoodPrice, a.Quantity,a.Amount from Addcart1 as a join DeliverAddress as b on a.OrderDate = b.OrderDate join RestuarantRegister as c on a.RestuarantID = c.ID  join Signup as d on a.UserID = d.ID ";
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    OrderData = new YourOrdersModel();
                    OrderData.OrderID = Convert.ToInt32(dr["OrderID"].ToString());
                    OrderData.FoodName = dr["FoodName"].ToString();
                    OrderData.FoodPrice = dr["FoodPrice"].ToString();
                    OrderData.RestuarantName = dr["RestuarantName"].ToString();
                    OrderData.Address = dr["Address"].ToString();
                    OrderData.Amount = Convert.ToInt32(dr["Amount"].ToString());
                    OrderData.TotalAmount = dr["TotalAmount"].ToString();
                    OrderData.Quantity = Convert.ToInt32(dr["Quantity"].ToString());
                    OrderData.PaymentMethod = dr["PaymentMethod"].ToString();
                    OrderData.DelivaryAddress = dr["DeliverAddress"].ToString();
                    OrderData.UserName = dr["Name"].ToString();
                    OrderData.OrderDate = dr["OrderDate"].ToString();
                    Orders.Add(OrderData);

                }
                con.Close();
            }
            return Orders;

        }

        public List<UserModel> UserList()
        {
            List<UserModel> Users = new List<UserModel>();
            UserModel UserData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            string sql = "select ID, Name, Gender, Address, DateOfBirth, Email, PhoneNo, SignDate ,Password from Signup  ORDER BY ID DESC ";
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    UserData = new UserModel();
                    UserData.ID = Convert.ToInt32(dr["ID"].ToString());
                    UserData.Name = dr["Name"].ToString();
                    UserData.Gender = dr["Gender"].ToString();
                    UserData.DateOfBirth = dr["DateOfBirth"].ToString();
                    UserData.Address = dr["Address"].ToString();
                    UserData.SignDate = dr["SignDate"].ToString();
                    UserData.Email = dr["Email"].ToString();
                    UserData.ContactNumer = dr["PhoneNo"].ToString();
                    UserData.Password = dr["Password"].ToString();
                    Users.Add(UserData);

                }
                con.Close();
            }
            return Users;
        }

        public List<DelivaryModel> OrdersList()
        {
            List<DelivaryModel> OrderList = new List<DelivaryModel>();

            DelivaryModel YourOrderData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select b.OrderID, b.DeliverAddress,b.TotalAmount,b.PaymentMethod,b.OrderDate,a.Name from PendingOrders as b join Signup as a on a.ID=b.UserID  ", con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    YourOrderData = new DelivaryModel();
                    YourOrderData.ID = Convert.ToInt32(dr["OrderID"].ToString());
                    YourOrderData.TotalAmount = dr["TotalAmount"].ToString();
                    YourOrderData.PaymentMethod = dr["PaymentMethod"].ToString();
                    YourOrderData.DelivaryAddress = dr["DeliverAddress"].ToString();
                    YourOrderData.Name = dr["Name"].ToString();
                    YourOrderData.Date = dr["OrderDate"].ToString();
                    OrderList.Add(YourOrderData);
                }
                con.Close();
            }
            return OrderList;
        }


        public void RegisterDeliveryBoy(DelivaryBoyModel DeboyData)
        {
            Connection R_connection = new Connection();

            using (SqlConnection con = R_connection.MyConnection())
            {
                con.Open();
                string sql = "insert into DeliBoyRegister(Name,Gender,DateOfBirth,PhoneNo,Email,Address,MainArea,Password) values(@Name,@Gender,@DateOfBirth,@PhoneNo,@Email,@Address,@MainArea,@Password)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", DeboyData.Name);
                cmd.Parameters.AddWithValue("@Gender", DeboyData.Gender);
                cmd.Parameters.AddWithValue("@Address", DeboyData.Address);
                cmd.Parameters.AddWithValue("@DateOfBirth", DeboyData.DateOfBirth);
                cmd.Parameters.AddWithValue("@Email", DeboyData.Email);
                cmd.Parameters.AddWithValue("@PhoneNo", DeboyData.ContactNo);
                cmd.Parameters.AddWithValue("@MainArea", DeboyData.MainArea);
                cmd.Parameters.AddWithValue("@Password", DeboyData.Password);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<DelivaryBoyModel> DeliBoyList()
        {
            List<DelivaryBoyModel> DeBoyList = new List<DelivaryBoyModel>();

            DelivaryBoyModel BoyData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select ID,Name,Gender,DateOfBirth,PhoneNo,Email,Address,Password,RegisterDate from DeliBoyRegister ORDER BY ID DESC ", con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    BoyData = new DelivaryBoyModel();
                    BoyData.ID = Convert.ToInt32(dr["ID"].ToString());

                    BoyData.Name = dr["Name"].ToString();
                    BoyData.DateOfBirth = dr["DateOfBirth"].ToString();
                    BoyData.Gender = dr["Gender"].ToString();
                    BoyData.Address = dr["Address"].ToString();
                    BoyData.Email = dr["Email"].ToString();
                    BoyData.ContactNo = dr["PhoneNo"].ToString();
                    BoyData.Password = dr["Password"].ToString();
                    BoyData.Date = dr["RegisterDate"].ToString();
                    DeBoyList.Add(BoyData);

                }
                con.Close();
            }
            return DeBoyList;
        }

        public bool DeleteDeliBoy(int DeliBoyID)
        {
            string sql = "Delete From DeliBoyRegister Where ID=" + DeliBoyID;
            Connection l_Connection = new Connection();
            using (SqlConnection sqlConnection = l_Connection.MyConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

            return true;
        }

        public List<DelivaryModel> CompleteOrders()
        {
            List<DelivaryModel> OrderList = new List<DelivaryModel>();

            DelivaryModel YourOrderData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(" select ID,OrderID,UserID,DeliverAddress,Coordinate,TotalAmount,PaymentMethod,OrderDate,Name ,FinishTime from CompleteOrders ORDER BY FinishTime DESC ", con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    YourOrderData = new DelivaryModel();
                    YourOrderData.ID = Convert.ToInt32(dr["OrderID"].ToString());
                    YourOrderData.DeliBoyID = Convert.ToInt32(dr["ID"].ToString());
                    YourOrderData.UserID = Convert.ToInt32(dr["UserID"].ToString());
                    YourOrderData.TotalAmount = dr["TotalAmount"].ToString();
                    YourOrderData.Coordinate = dr["Coordinate"].ToString();
                    YourOrderData.PaymentMethod = dr["PaymentMethod"].ToString();
                    YourOrderData.DelivaryAddress = dr["DeliverAddress"].ToString();
                    YourOrderData.Name = dr["Name"].ToString();
                    YourOrderData.Date = dr["OrderDate"].ToString();
                    YourOrderData.FinishTime = dr["FinishTime"].ToString();
                    OrderList.Add(YourOrderData);
                }
                con.Close();
            }
            return OrderList;
        }

        public List<DelivaryModel> CancelOrders()
        {
            List<DelivaryModel> OrderList = new List<DelivaryModel>();

            DelivaryModel YourOrderData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())
            {
                con.Open();
                SqlDataAdapter da = new  SqlDataAdapter("select OrderID,UserID,DeliverAddress,Coordinate,TotalAmount,PaymentMethod,OrderDate,Name,CancelTime from CancelOrder ORDER BY CancelTime DESC ", con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    YourOrderData = new DelivaryModel();
                    YourOrderData.ID = Convert.ToInt32(dr["OrderID"].ToString());

                    YourOrderData.UserID = Convert.ToInt32(dr["UserID"].ToString());
                    YourOrderData.TotalAmount = dr["TotalAmount"].ToString();
                    YourOrderData.Coordinate = dr["Coordinate"].ToString();
                    YourOrderData.PaymentMethod = dr["PaymentMethod"].ToString();
                    YourOrderData.DelivaryAddress = dr["DeliverAddress"].ToString();
                    YourOrderData.Name =   dr["Name"].ToString();
                    YourOrderData.Date = dr["OrderDate"].ToString();
                    YourOrderData.CancelTime = dr["CancelTime"].ToString();
                    OrderList.Add(YourOrderData);
                }
                con.Close();
            }
            return OrderList;
        }

        public List<DelivaryModel> CompleteOrdersForDeliBoy(int DeliBoyID)
        {
            List<DelivaryModel> OrderList = new List<DelivaryModel>();

            DelivaryModel YourOrderData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(" select ID,OrderID,UserID,DeliverAddress,Coordinate,TotalAmount,PaymentMethod,OrderDate,Name ,FinishTime from CompleteOrders where FinishTime >= DATEADD(day, -1, GETDATE()) and ID=" + DeliBoyID, con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    YourOrderData = new DelivaryModel();
                    YourOrderData.ID = Convert.ToInt32(dr["OrderID"].ToString());
                    YourOrderData.DeliBoyID=
                    YourOrderData.UserID = Convert.ToInt32(dr["UserID"].ToString());
                    YourOrderData.TotalAmount = dr["TotalAmount"].ToString();
                    YourOrderData.Coordinate = dr["Coordinate"].ToString();
                    YourOrderData.PaymentMethod = dr["PaymentMethod"].ToString();
                    YourOrderData.DelivaryAddress = dr["DeliverAddress"].ToString();
                    YourOrderData.Name = dr["Name"].ToString();
                    YourOrderData.Date = dr["OrderDate"].ToString();
                    YourOrderData.FinishTime = dr["FinishTime"].ToString();
                    OrderList.Add(YourOrderData);
                }
                con.Close();
            }
            return OrderList;
        }

        public  AdminModel Counts()
        {
            
            AdminModel Counts = null;
            Connection R_connection = new Connection();
            using (SqlConnection con = R_connection.MyConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("  select (select count(*) as Total from signup) as UT, (select count(*) as Total from RestuarantRegister) as RT, (select count(*) as Total from DeliBoyRegister) as DT,(select count(*) as Total from AddRestuarant) as AT ,(select count(*) as Total from PendingOrders) as PT,(select count(*) as Total from CompleteOrders) as CT,(select count(*) as Total from CancelOrder) as CaT", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       Counts = new AdminModel();
                        Counts.Usercount = Convert.ToInt32(dr.GetValue(0).ToString());
                        Counts.RestuarantCount= Convert.ToInt32(dr.GetValue(1).ToString());
                        Counts.DeliBoyCount= Convert.ToInt32(dr.GetValue(2).ToString());
                        Counts.ResRequestCount= Convert.ToInt32(dr.GetValue(3).ToString());
                        Counts.PendingOrdersCount= Convert.ToInt32(dr.GetValue(4).ToString());
                        Counts.CompleteOrdersCount= Convert.ToInt32(dr.GetValue(5).ToString());
                        Counts.CancelOrdersConut= Convert.ToInt32(dr.GetValue(6).ToString());
                    }
                }
              
                con.Close();
            }
            return Counts;
        }

        public List<DelivaryModel> Filltercomplete(string OrderDate)
        {
            List<DelivaryModel> COmFillterList= new  List<DelivaryModel>();
            DelivaryModel ComFillterData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select ID,OrderID,UserID,DeliverAddress,Coordinate,TotalAmount,PaymentMethod, OrderDate,Name ,FinishTime from CompleteOrders where cast(OrderDate as date) = cast( @OrderDate as date) ", con);

                da.SelectCommand.Parameters.AddWithValue("@OrderDate", OrderDate);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ComFillterData = new DelivaryModel();
                    ComFillterData.ID = Convert.ToInt32(dr["OrderID"].ToString());
                    ComFillterData.DeliBoyID = Convert.ToInt32(dr["ID"].ToString());
                    ComFillterData.UserID = Convert.ToInt32(dr["UserID"].ToString());
                    ComFillterData.TotalAmount = dr["TotalAmount"].ToString();
                    ComFillterData.Coordinate = dr["Coordinate"].ToString();
                    ComFillterData.PaymentMethod = dr["PaymentMethod"].ToString();
                    ComFillterData.DelivaryAddress = dr["DeliverAddress"].ToString();
                    ComFillterData.Name = dr["Name"].ToString();
                    ComFillterData.Date = dr["OrderDate"].ToString();
                    ComFillterData.FinishTime = dr["FinishTime"].ToString();
                    COmFillterList.Add(ComFillterData);
                }
                con.Close();
            }
            return COmFillterList;


        }

      
        

        public List<DelivaryModel> FillterCancel(string OrderDate)
        {
            List<DelivaryModel> COmFillterList = new List<DelivaryModel>();
            DelivaryModel ComFillterData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select OrderID,UserID,DeliverAddress,Coordinate,TotalAmount,PaymentMethod, OrderDate,Name ,CancelTime from CancelOrder where cast(OrderDate as date) = cast( @OrderDate as date) ", con);

                da.SelectCommand.Parameters.AddWithValue("@OrderDate", OrderDate);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ComFillterData = new DelivaryModel();
                    ComFillterData.ID = Convert.ToInt32(dr["OrderID"].ToString());
                    ComFillterData.UserID = Convert.ToInt32(dr["UserID"].ToString());
                    ComFillterData.TotalAmount = dr["TotalAmount"].ToString();
                    ComFillterData.Coordinate = dr["Coordinate"].ToString();
                    ComFillterData.PaymentMethod = dr["PaymentMethod"].ToString();
                    ComFillterData.DelivaryAddress = dr["DeliverAddress"].ToString();
                    ComFillterData.Name = dr["Name"].ToString();
                    ComFillterData.Date = dr["OrderDate"].ToString();
                    ComFillterData.CancelTime = dr["CancelTime"].ToString();
                    COmFillterList.Add(ComFillterData);
                }
                con.Close();
            }
            return COmFillterList;
        }
        //public DelivaryModel Completestatus( int OrderID)
        //{
        //    DelivaryModel CompleteData = null;
        //    Connection R_connection = new Connection();
        //    using (SqlConnection con = R_connection.MyConnection())
        //    {
        //        SqlCommand cmd = new SqlCommand("select OrderID from CompleteOrders where OrderID='"+OrderID+"' ", con);
        //            con.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        con.Close();
        //    }
        //    return CompleteData;
        //}
    }
}



