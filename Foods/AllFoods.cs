using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Foods
{
    public class AllFoods:
    {
        public void AddRestuarant(RestuarantModel RestuarantData)
        {
            Connection R_connection = new Connection();
            using (SqlConnection con = R_connection.MyConnection())
            {
                con.Open();
                string sql = "insert into AddRestuarant(RestuarantName, RestuarantNo, Address, Category, Email, ContactNo) Values(@RestuarantName, @RestuarantNo, @Address, @Category, @Email, @ContactNo)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@RestuarantName", RestuarantData.RestuarantName);
                cmd.Parameters.AddWithValue("@RestuarantNo", RestuarantData.RestuarantNo);
                cmd.Parameters.AddWithValue("@Address", RestuarantData.Address);
                cmd.Parameters.AddWithValue("@Category", RestuarantData.Category);
                cmd.Parameters.AddWithValue("@Email", RestuarantData.Email);
                cmd.Parameters.AddWithValue("@ContactNo", RestuarantData.ContactNo);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
