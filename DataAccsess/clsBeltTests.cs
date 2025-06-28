using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessKarateClubPreojact
{
    public class clsBeltTestsDate
    {
        public static DataTable GetAllBeltTests()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"select TestID,MemberName,InstructorName,TestFees,RankName,Result,Date from BeltTest_View";

            SqlCommand command = new SqlCommand(Query, connection);

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
   
       public static int AddNewselectBeltTest(int MemberID,int RankID,bool Result,int TestedByInstructorID,int PaymentID,DateTime Date)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"INSERT INTO BeltTests (MemberID,RankID,Result,Date,TestedByInstructorID,PaymentID)
                             Values  (@MemberID,@RankID,@Result,@Date,@TestedByInstructorID,@PaymentID)
                           select SCOPE_IDENTITY()    ";

            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@RankID", RankID);
            command.Parameters.AddWithValue("@Result", Result);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@TestedByInstructorID", TestedByInstructorID);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            int TestID = -1;

            try
            {
                connection.Open();

                object Reslut = command.ExecuteScalar();

                if (Reslut != null && int.TryParse(Reslut.ToString(),out int Insertid))
                {
                    TestID = Insertid;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return TestID;  
        }
    
        public static DataTable GetAllTestforBeltRank(int MemberID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"select TestID,MemberName ,RankName,TestFees,InstructorName,Result,Date from BeltTest_View 
                            Where MembersIID =@MemberID  order by Date Desc ";

           
            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);

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
    

        public static bool IsMemberTastAnyTest(int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = "select top 1 found = 1 from  BeltTests WHERE MemberID = @MemberID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);

            int Found = 0;

            try
            {
                connection.Open();
                object Reslut = command.ExecuteScalar();

                if (Reslut != null && int.TryParse(Reslut.ToString(), out int isFound))
                {
                    Found = isFound;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return Found > 0;
        }
    }
}
