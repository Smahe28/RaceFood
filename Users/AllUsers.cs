using Database1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfacing;
using SearchFoodInterFace;
using OrderInterface;
using DeliverOrder;
using FoodInterFacing;
using DeliveryBoyInterface;
namespace Users
{
    public class AllUsers : WantToUser
    {
        public void AddCarts(SearchFoodModel CartData)
        {
            Connection R_connection = new Connection();
            using (SqlConnection con = R_connection.MyConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into Addcart( FoodID,RestuarantID,FoodName,Foodprice,UserID,Quantity) values(@FoodID,@RestuarantID,@FoodName,@FoodPrice,@UserID,@Quantity) ", con);
                con.Open();

                cmd.Parameters.AddWithValue("@RestuarantID", CartData.RestuarantID);
                cmd.Parameters.AddWithValue("@FoodName", CartData.FoodName);
                cmd.Parameters.AddWithValue("@FoodPrice", CartData.FoodPrice);
                cmd.Parameters.AddWithValue("@FoodID", CartData.ID);
                cmd.Parameters.AddWithValue("@UserID", CartData.UserID);
                cmd.Parameters.AddWithValue("@Quantity", CartData.Quantity);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void AddUser(UserModel UserData)
        {
            Connection R_connection = new Connection();
            using (SqlConnection con = R_connection.MyConnection())
            {
                con.Open();
                string sql = "insert into SignUp(Name,Gender,DateOfBirth,PhoneNo,Email,Password,Address) values(@Name,@Gender,@DateOfBirth,@PhoneNo,@Email,@Password,@Address)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", UserData.Name);
                cmd.Parameters.AddWithValue("@Gender", UserData.Gender);
                cmd.Parameters.AddWithValue("@Address", UserData.Address);
                cmd.Parameters.AddWithValue("@DateOfBirth", UserData.DateOfBirth);
                cmd.Parameters.AddWithValue("@Email", UserData.Email);
                cmd.Parameters.AddWithValue("@PhoneNo", UserData.ContactNumer);
                cmd.Parameters.AddWithValue("@Password", UserData.Password);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<SearchFoodModel> CartDetails(int UserID)
        {
            List<SearchFoodModel> Cartlist = new List<SearchFoodModel>();
            SearchFoodModel CartData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            string sql = "select a.ID,a.Foodname,a.FoodPrice,a.Quantity, b.RestuarantName,b.Address,(a.FoodPrice*a.Quantity) as Amount from AddCart as a join RestuarantRegister as b on a.RestuarantID=b.ID  where UserID =@ID";
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@ID", UserID);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    CartData = new SearchFoodModel();
                    CartData.ID = Convert.ToInt32(dr["ID"].ToString());
                    CartData.FoodName = dr["FoodName"].ToString();
                    CartData.FoodPrice = dr["FoodPrice"].ToString();
                    CartData.Quantity = Convert.ToInt32(dr["Quantity"].ToString());
                    CartData.RestuarantName = dr["RestuarantName"].ToString();
                    CartData.Address = dr["Address"].ToString();
                    CartData.Amount = Convert.ToInt32(dr["Amount"].ToString()) /*Convert.ToInt32(dr["ID"].ToString()) * Convert.ToInt32( dr["FoodPrice"].ToString())*/;
                    Cartlist.Add(CartData);

                }
                con.Close();
            }
            return Cartlist;
        }
        public UserModel Login(UserModel UserData)
        {
            UserModel LoginData = null;
            Connection R_connection = new Connection();
            using (SqlConnection con = R_connection.MyConnection())
            {
                SqlCommand cmd = new SqlCommand("select ID,Name,Password from Signup where Name=@Name AND Password=@Password", con);
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
                        LoginData = new UserModel();
                        LoginData.ID = Convert.ToInt32(dr.GetValue(0).ToString());
                        LoginData.Name = dr.GetValue(1).ToString();
                    }
                }
                con.Close();
            }
            return LoginData;
        }

        public void DelivaryDetails(DelivaryModel OrderData)
        {
            Connection R_connection = new Connection();

            using (SqlConnection con = R_connection.MyConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into DeliverAddress(UserID,DeliverAddress,MainArea,Coordinate,TotalAmount,PaymentMethod,OrderDate) values(@UserID,@DeliverAddress,@MainArea,@Coordinate,@TotalAmount,@PaymentMethod, convert(varchar, getdate(), 120));insert into DeliverAddressHistory(UserID,DeliverAddress,MainArea,Coordinate,TotalAmount,PaymentMethod,OrderDate) values(@UserID,@DeliverAddress,@MainArea,@Coordinate,@TotalAmount,@PaymentMethod, convert(varchar, getdate(), 120));insert into DeliverAddressBackup(UserID,DeliverAddress,MainArea,Coordinate,TotalAmount,PaymentMethod,OrderDate) values(@UserID,@DeliverAddress,@MainArea,@Coordinate,@TotalAmount,@PaymentMethod, convert(varchar, getdate(), 120));insert into PendingOrders(UserID,DeliverAddress,MainArea,Coordinate,TotalAmount,PaymentMethod,OrderDate) values(@UserID,@DeliverAddress,@MainArea,@Coordinate,@TotalAmount,@PaymentMethod, convert(varchar, getdate(), 120))", con);
                con.Open();

                cmd.Parameters.AddWithValue("@UserID", OrderData.UserID);
                cmd.Parameters.AddWithValue("@DeliverAddress", OrderData.DelivaryAddress);
                cmd.Parameters.AddWithValue("@Coordinate", OrderData.Coordinate);
                cmd.Parameters.AddWithValue("@TotalAmount", OrderData.TotalAmount);
                cmd.Parameters.AddWithValue("@PaymentMethod", OrderData.PaymentMethod);
                cmd.Parameters.AddWithValue("@MainArea", OrderData.MainArea);
                cmd.ExecuteNonQuery();
                con.Close();
            }
          



        }

        public SearchFoodModel OrderFood(int FoodID)
        {
            SearchFoodModel FoodList = new SearchFoodModel();

            SearchFoodModel FoodData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select a.FoodID,a.FoodPrice,a.FoodName,b.RestuarantName,b.Address ,a.RestuarantID from FoodRegister  a join RestuarantRegister b on a.RestuarantID=b.ID where a.FoodID=@FoodID", con);
                da.SelectCommand.Parameters.AddWithValue("@FoodID", FoodID);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    FoodData = new SearchFoodModel();
                    FoodData.FoodID = Convert.ToInt32(dr["FoodID"].ToString());
                    FoodData.FoodName = dr["FoodName"].ToString();
                    FoodData.FoodPrice = dr["FoodPrice"].ToString();
                    FoodData.RestuarantID = Convert.ToInt32(dr["RestuarantID"].ToString());


                }
                con.Close();
            }
            return FoodData;
        }

        public bool Removecart(int ID)
        {

            string sql = "Delete From Addcart Where ID=" + ID;
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

        List<SearchFoodModel> WantToUser.FoodSearch(string FoodName)
        {
            List<SearchFoodModel> FoodList = new List<SearchFoodModel>();

            SearchFoodModel FoodData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select a.FoodID,a.FoodPrice,a.FoodName,b.RestuarantName,b.Address from FoodRegister  a join RestuarantRegister b on a.RestuarantID=b.ID where FoodName like CONCAT('%',@FoodName,'%')", con);
                da.SelectCommand.Parameters.AddWithValue("@FoodName", FoodName);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    FoodData = new SearchFoodModel();
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

        public bool FinishCart(int UserID)
        {
            string sql = "Delete From Addcart Where UserID=" + UserID;
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

        public List<DelivaryModel> YourOrdersDetails(int UserID)
        {
            List<DelivaryModel> OrderList = new List<DelivaryModel>();

            DelivaryModel YourOrderData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select b.OrderID, a.UserID, b.DeliverAddress, b.TotalAmount, b.PaymentMethod, b.OrderDate, c.RestuarantName, c.Address, d.Name, a.FoodID, a.FoodName, a.FoodPrice, a.Quantity, a.Amount, isnull(e.Status, 'Pending') as Status " +
                                                            "from Addcart1 as a " +
                                                            "join DeliverAddress as b on a.OrderDate = b.OrderDate " +
                                                            "join RestuarantRegister as c on a.RestuarantID = c.ID " +
                                                            "join Signup as d on a.UserID = d.ID " +
                                                            "left join CompleteOrders as e on e.OrderID = b.OrderID " +
                                                            "where a.UserID ='" + UserID + "'", con);
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
                    YourOrderData.Status = dr["Status"].ToString();

                    OrderList.Add(YourOrderData);
                }
                con.Close();
            }
            return OrderList;

        }
        public void OrderConfirm(SearchFoodModel UserData)
        {
            Connection R_connection = new Connection();
            using (SqlConnection con = R_connection.MyConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into Addcart1 select RestuarantID,FoodID,UserID,FoodName,FoodPrice,Quantity,(foodprice*Quantity) as Amount,(CONVERT(VARCHAR, GETDATE(), 120)) as OrderDate from Addcart", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public bool CancelOrder(int OrderID)
        {
            Connection l_Connection = new Connection();
            using (SqlConnection sqlConnection = l_Connection.MyConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("insert into CancelOrder select  a.OrderID, a.UserID, a.DeliverAddress, a.Coordinate, a.TotalAmount, a.PaymentMethod, a.OrderDate, c.Name,(CONVERT(VARCHAR, GETDATE(), 120)) as CancelTime from DeliverAddress as a  join Signup as c on c.ID = a.UserID Where OrderID='" + OrderID + "'", sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            using (SqlConnection sqlConnection = l_Connection.MyConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Delete From DeliverAddress Where OrderID='" + OrderID + "';Delete From DeliverAddressBackup Where OrderID='" + OrderID + "';Delete From DeliverBoyAccept Where OrderID='" + OrderID + "';Delete From PendingOrders Where OrderID='" + OrderID + "'", sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

            return true;
        }

        public List<YourOrdersModel> YourPendingOrder(int OrderID)
        {
            List<YourOrdersModel> OrderList = new List<YourOrdersModel>();

            YourOrdersModel YourOrderData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select b.OrderID, a.UserID, b.DeliverAddress,b.TotalAmount,b.PaymentMethod,b.OrderDate,c.RestuarantName,c.Address,d.Name,a.FoodID,a.FoodName, a.FoodPrice, a.Quantity,a.Amount from Addcart1 as a join DeliverAddress as b on a.OrderDate = b.OrderDate join RestuarantRegister as c on a.RestuarantID = c.ID  join Signup as d on a.UserID = d.ID  where b.OrderID='" + OrderID + "'", con);
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
                    OrderList.Add(YourOrderData);
                }
                con.Close();
            }
            return OrderList;

        }

        public List<YourOrdersModel> CanceledOrder(int CancelID)
        {
            List<YourOrdersModel> OrderList = new List<YourOrdersModel>();
            YourOrdersModel YourOrderData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select b.OrderID, a.UserID, b.DeliverAddress,b.TotalAmount,b.PaymentMethod,b.OrderDate,c.RestuarantName,c.Address,d.Name,a.FoodID,a.FoodName, a.FoodPrice, a.Quantity,a.Amount ,b.CancelTime from Addcart1 as a join CancelOrder as b on a.OrderDate = b.OrderDate join RestuarantRegister as c on a.RestuarantID = c.ID  join Signup as d on a.UserID = d.ID  where b.OrderID='" + CancelID + "'", con);
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
        }
    }


