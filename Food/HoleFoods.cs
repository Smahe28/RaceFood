using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodInterFacing;
using Database1;
using System.Data;
using System.Data.SqlClient;
using SearchFoodInterFace;
namespace Food
{
    public class HoleFoods : WantToFood
    {
        public void AddFood(FoodModel FoodData)
        {
            Connection R_connection = new Connection();
            using (SqlConnection con = R_connection.MyConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into FoodRegister( RestuarantID,FoodName,Foodprice) values(@RestuarantID,@FoodName,@FoodPrice) ", con);
                con.Open();

                cmd.Parameters.AddWithValue("@RestuarantID", FoodData.RestuarantID);
                cmd.Parameters.AddWithValue("@FoodName", FoodData.FoodName);
                cmd.Parameters.AddWithValue("@FoodPrice", FoodData.FoodPrice);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public bool DeleteFood(int ID)
        {
            string sql = "Delete From FoodRegister Where FoodID=" + ID;
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

        public FoodModel FoodEdit(int ID)
        {
            FoodModel FoodData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            string sql = "select FoodID,RestuarantID,FoodPrice,FoodName from FoodRegister where FoodID=" + ID;
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

                }
                con.Close();
            }
            return FoodData;
        }

        public List<FoodModel> GetFood(int RestID)
        {
            List<FoodModel> FoodList = new List<FoodModel>();

            FoodModel FoodData = null;
            Connection R_connection = new Connection();
            DataTable dt = new DataTable();
            string sql = "select FoodID,RestuarantID,FoodPrice,FoodName from FoodRegister where RestuarantID=" + RestID;
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
                    FoodList.Add(FoodData);
                }
                con.Close();
            }
            return FoodList;
        }

        public FoodModel UpdateFood(FoodModel FoodDt)
        {
            FoodModel UpdateFood = new FoodModel();
            Connection l_Connection = new Connection();

            using (SqlConnection l_Con = l_Connection.MyConnection())
            {
                l_Con.Open();
                string l_Query = " update FoodRegister " +
                                 "set FoodName = '" + FoodDt.FoodName + "', Foodprice = '" + FoodDt.FoodPrice + "'   where FoodID ='" + FoodDt.FoodID + "' ";


                SqlCommand l_Command = new SqlCommand(l_Query, l_Con);
                l_Command.ExecuteNonQuery();
                l_Con.Close();
            }

            return UpdateFood;
        }


    }
}
