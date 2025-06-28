using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessKarateClubPreojact
{
    public class clsBeltRanksData
    {
        public static DataTable GetAllBeltRanks()
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);

            string Qurry = "select * from BeltRanks";
            SqlCommand command = new SqlCommand(Qurry, connection);

            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool FindBtByName(ref int RankID,  string RankName, ref int TestFees)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "select * from BeltRanks Where RankName = @RankName";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@RankName", RankName);

            bool ISFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ISFound = true;
                    RankID = (int)reader["RankID"];
                    TestFees = Convert.ToInt32(reader["TestFees"]);
                }
                else
                    ISFound = false;
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ISFound;
        }

        public static bool FindBtID(int RankID, ref string RankName, ref int TestFees)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "select * from BeltRanks Where RankID = @RankID";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@RankID", RankID);

            bool ISFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ISFound = true;
                    RankName = (string)reader["RankName"];
                    TestFees = Convert.ToInt32(reader["TestFees"]);
                }
                else
                    ISFound = false;
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ISFound;
        }

        public static bool UpdateRank(int RankID, string RankName, int TestFees)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Update BeltRanks Set RankName = @RankName,TestFees = @TestFees Where RankID = @RankID";
            SqlCommand command = new SqlCommand(Qurey, connection);

            command.Parameters.AddWithValue("@RankID", RankID);
            command.Parameters.AddWithValue("@RankName", RankName);
            command.Parameters.AddWithValue("@TestFees", TestFees);

            int RowAffceted = 0;

            try
            {
                connection.Open();
                RowAffceted = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return RowAffceted > 0;
        }


        public static int AddNewRank( string RankName, int TestFees)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Insert Into BeltRanks (RankName ,TestFees) values (@RankName,@TestFees) ";
            SqlCommand command = new SqlCommand(Qurey, connection);

            command.Parameters.AddWithValue("@RankName", RankName);
            command.Parameters.AddWithValue("@TestFees", TestFees);

            int RowAffceted = -1;

            try
            {
                connection.Open();
             object   Addtiinal = command.ExecuteScalar();


                if(Addtiinal != null && int.TryParse(Addtiinal.ToString(),out RowAffceted))
                {

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return RowAffceted;
        }
    }
}
