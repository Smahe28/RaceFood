using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryBoyInterface;
using Database1;
using System.Data.SqlClient;
using System.Data;
using OrderInterface;
using DeliverOrder;
namespace AllDeliveryBoys
{
    public class DeliveryBoy : WantoDeliveryBoy
    {
        public List<YourOrdersModel> CompleteOrders(int FinishID)
        {
            List<YourOrdersModel> OrderList = new List<YourOrdersModel>();

            YourOrdersModel YourOrderData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select b.OrderID, a.UserID, b.DeliverAddress,b.TotalAmount,b.PaymentMethod,b.OrderDate,c.RestuarantName,c.Address,d.Name,a.FoodID,a.FoodName, a.FoodPrice, a.Quantity,a.Amount ,b.Finishtime from Addcart1 as a join CompleteOrders as b on a.OrderDate = b.OrderDate join RestuarantRegister as c on a.RestuarantID = c.ID  join Signup as d on a.UserID = d.ID  where b.OrderID='" + FinishID + "'", con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    YourOrderData = new YourOrdersModel();
                    YourOrderData.OrderID = Convert.ToInt32(dr["OrderID"].ToString());
                    YourOrderData.FoodName = dr["FoodName"].ToString();
                    YourOrderData.FoodPrice = dr["FoodPrice"].ToString();
                    YourOrderData.RestuarantName = dr["RestuarantName"].ToString();
                    YourOrderData.Address = dr["Address"].ToString();
                    YourOrderData.Amount = Convert.ToInt32(dr["Amount"].ToString());
                    YourOrderData.TotalAmount = dr["TotalAmount"].ToString();
                    YourOrderData.Quantity = Convert.ToInt32(dr["Quantity"].ToString());
                    YourOrderData.PaymentMethod = dr["PaymentMethod"].ToString();
                    YourOrderData.DelivaryAddress = dr["DeliverAddress"].ToString();
                    YourOrderData.UserName = dr["Name"].ToString();
                    YourOrderData.OrderDate = dr["OrderDate"].ToString();
                    YourOrderData.CancelTime = dr["CancelTime"].ToString();
                    OrderList.Add(YourOrderData);
                }
                con.Close();
            }
            return OrderList;
        }

        public bool FinishOrder(int OrderID)
        {
            Connection R_connection = new Connection();
            using (SqlConnection sqlConnection = R_connection.MyConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(" insert into CompleteOrders select b.ID, a.OrderID,a.UserID, a.DeliverAddress,a.MainArea,a.Coordinate,a.TotalAmount,a.PaymentMethod,a.OrderDate,c.Name,(CONVERT(VARCHAR, GETDATE(), 120)) as FinishTime,('Completed') as  Status from DeliverBoyAccept as a join DeliBoyRegister as b on a.MainArea=b.MainArea join Signup as c on c.ID=a.UserID where a.OrderID='"+OrderID+"'", sqlConnection);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            using (SqlConnection sqlConnection = R_connection.MyConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Delete From DeliverBoyAccept Where OrderID = " + OrderID+ ";Delete From PendingOrders Where OrderID = " + OrderID , sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

            return true;
        }

        public List<DelivaryModel> FoodDetails(int DeliBoyID)
        {
            List<DelivaryModel> FoodList = new List<DelivaryModel>();

            DelivaryModel FoodData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();


            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select a.OrderID, a.DeliverAddress,a.TotalAmount,a.PaymentMethod,a.OrderDate,C.Name from DeliverAddressBackup as a join DeliBoyRegister as b on b.MainArea = a.MainArea join Signup as c on c.ID = a.UserID where a.OrderDate >= DATEADD(Hour, -1, GETDATE()) and b.ID ="+ DeliBoyID, con);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    FoodData = new DelivaryModel();
                    FoodData.ID = Convert.ToInt32(dr["OrderID"].ToString());

                    FoodData.TotalAmount = dr["TotalAmount"].ToString();

                    FoodData.PaymentMethod = dr["PaymentMethod"].ToString();
                    FoodData.DelivaryAddress = dr["DeliverAddress"].ToString();
                    FoodData.Name = dr["Name"].ToString();
                    FoodData.Date = dr["OrderDate"].ToString();
                    FoodList.Add(FoodData);
                }
                con.Close();
            }
            return FoodList;
        }

        public DelivaryBoyModel Login(DelivaryBoyModel UserData)
        {

            DelivaryBoyModel LoginData = null;
            Connection R_connection = new Connection();
            using (SqlConnection con = R_connection.MyConnection())
            {
                SqlCommand cmd = new SqlCommand("select ID,Name,Password from DeliBoyRegister where Name=@Name AND Password=@Password", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@Name", UserData.Name);
                cmd.Parameters.AddWithValue("@Password", UserData.Password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        LoginData = new DelivaryBoyModel();
                        LoginData.ID = Convert.ToInt32(dr.GetValue(0).ToString());
                        LoginData.Name = dr.GetValue(1).ToString();
                    }


                }
                con.Close();
            }
            return LoginData;
        }

        public List<DelivaryModel> OrderDetails(int DeliBoyID)
        {
            List<DelivaryModel> FoodList = new List<DelivaryModel>();

            DelivaryModel FoodData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select OrderID, DeliverAddress,TotalAmount,PaymentMethod,OrderDate,Name from DeliverBoyAccept where DeliBoyID=" + DeliBoyID, con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    FoodData = new DelivaryModel();
                    FoodData.ID = Convert.ToInt32(dr["OrderID"].ToString());

                    FoodData.TotalAmount = dr["TotalAmount"].ToString();

                    FoodData.PaymentMethod = dr["PaymentMethod"].ToString();
                    FoodData.DelivaryAddress = dr["DeliverAddress"].ToString();
                    FoodData.Name = dr["Name"].ToString();
                    FoodData.Date = dr["OrderDate"].ToString();
                    FoodList.Add(FoodData);
                }
                con.Close();
            }
            return FoodList;
        }

        public bool OrderNotification(int OrderID)
        {

            Connection l_Connection = new Connection();
            using (SqlConnection sqlConnection = l_Connection.MyConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("insert into DeliverBoyAccept  select b.ID, a.OrderID,a.UserID, a.DeliverAddress,a.MainArea,a.Coordinate,a.TotalAmount,a.PaymentMethod,a.OrderDate,c.Name from DeliverAddressBackup as a join DeliBoyRegister as b on a.MainArea=b.MainArea join Signup as c on c.ID=a.UserID   where a.OrderID=" + OrderID, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
      
            using (SqlConnection sqlConnection = l_Connection.MyConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Delete From DeliverAddressBackup Where OrderID = " + OrderID, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

            return true;
        }
    }
}
