using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestuarantInterFacing;
using Database1;
using System.Data.SqlClient;
using System.Data;
namespace Restuarant
{
    public class HoleRestuarant : WantToRestuarant
    {
       
        public bool DeleteRestuarant(int ID)

        {
            string sql = "Delete From AddRestuarant Where ID=" + ID;
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
        public List<RestuarantModel> RestuarantDetails()
        {
            List<RestuarantModel> Requestlist = new List<RestuarantModel>();
            RestuarantModel RestuarantData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            string sql = "select ID, RestuarantName, RestuarantNo, Address, Category, Email, ContactNo, convert(VARCHAR, Date,105) as Date  from AddRestuarant";
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    RestuarantData = new RestuarantModel();
                    RestuarantData.ID = Convert.ToInt32(dr["ID"].ToString());
                    RestuarantData.RestuarantName = dr["RestuarantName"].ToString();
                    RestuarantData.RestuarantNo = dr["RestuarantNo"].ToString();
                    RestuarantData.Address = dr["Address"].ToString();
                    RestuarantData.Category = dr["Category"].ToString();
                    RestuarantData.Email = dr["Email"].ToString();
                    RestuarantData.ContactNo = dr["ContactNo"].ToString();
                    RestuarantData.Date = dr["Date"].ToString();
                    Requestlist.Add(RestuarantData);

                }
                con.Close();
            }
            return Requestlist;
        }
   

      

        public void Register(RestuarantModel RestuarantData)
        {
            Connection R_connection = new Connection();
            using (SqlConnection con = R_connection.MyConnection())
            {
                con.Open();
                string sql = "insert into RestuarantRegister(RestuarantName, RestuarantNo, Address, Category, Email, ContactNo,Password) Values(@RestuarantName, @RestuarantNo, @Address, @Category, @Email, @ContactNo,@Password)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@RestuarantName", RestuarantData.RestuarantName);
                cmd.Parameters.AddWithValue("@RestuarantNo", RestuarantData.RestuarantNo);
                cmd.Parameters.AddWithValue("@Address", RestuarantData.Address);
                cmd.Parameters.AddWithValue("@Category", RestuarantData.Category);
                cmd.Parameters.AddWithValue("@Email", RestuarantData.Email);
                cmd.Parameters.AddWithValue("@ContactNo", RestuarantData.ContactNo);
                cmd.Parameters.AddWithValue("@Password", RestuarantData.Password);
              
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public RestuarantModel Login(RestuarantModel RestuarantData)
        {
            RestuarantModel LoginData = null;
            Connection R_connection = new Connection();
            using (SqlConnection con = R_connection.MyConnection())
            {
                SqlCommand cmd = new SqlCommand("select ID,RestuarantName,Password from RestuarantRegister where RestuarantName=@RestuarantName AND Password=@Password", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Parameters.AddWithValue("@RestuarantName", RestuarantData.RestuarantName);
            cmd.Parameters.AddWithValue("@Password", RestuarantData.Password);
            SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        LoginData = new RestuarantModel();
                        LoginData.ID = Convert.ToInt32(dr.GetValue(0).ToString());
                        LoginData.RestuarantName = dr.GetValue(1).ToString();
                    }

                    
                }
                con.Close();
            }
            return LoginData;
        }

        public RestuarantModel GetRestuarantName(int RestID)
        {
            RestuarantModel RestuarantData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            string sql = "select ID, RestuarantName ,Address   from RestuarantRegister where ID=" + RestID;
            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    RestuarantData = new RestuarantModel();
                    RestuarantData.RestuarantName = dr["RestuarantName"].ToString();
                    RestuarantData.Address = dr["Address"].ToString();
                   
                }
                con.Close();
            }
            return RestuarantData;
        }

        public List<RestuarantModel> RegisterRestuarant()
        {
            List<RestuarantModel> Requestlist = new List<RestuarantModel>();
            RestuarantModel RestuarantData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            string sql = "select ID, RestuarantName, RestuarantNo, Address, Category, Email, ContactNo, (CONVERT(VARCHAR, RegisterDate, 105)) as  RegisterDate ,Password from RestuarantRegister";

            using (SqlConnection con = R_connection.MyConnection())

            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    RestuarantData = new RestuarantModel();
                    RestuarantData.ID = Convert.ToInt32(dr["ID"].ToString());
                    RestuarantData.RestuarantName = dr["RestuarantName"].ToString();
                    RestuarantData.RestuarantNo = dr["RestuarantNo"].ToString();
                    RestuarantData.Address = dr["Address"].ToString();
                    RestuarantData.Category = dr["Category"].ToString();
                    RestuarantData.Email = dr["Email"].ToString();
                    RestuarantData.ContactNo = dr["ContactNo"].ToString();
                    RestuarantData.Date = dr["RegisterDate"].ToString();
                    RestuarantData.Password = dr["Password"].ToString();
                    Requestlist.Add(RestuarantData);

                }
                con.Close();
            }
            return Requestlist;
        }
    }

}
