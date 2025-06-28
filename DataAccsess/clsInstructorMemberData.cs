using AccessKarateClubPreojact;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace clsBussinsKarateClubProjacjat
{
    public class clsInstructorMemberData
    {
        public static int AddNewMemberInstructor(int InstructorID, int MemberID, DateTime AssignDate,DateTime TrainedEndDate)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Insert Into MemberInstructors (InstructorID ,MemberID,AssignDate,TrainedEndDate) 
                            Values (@InstructorID,@MemberID,@AssignDate,@TrainedEndDate) select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@InstructorID", InstructorID);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@AssignDate", AssignDate);
            command.Parameters.AddWithValue("@TrainedEndDate", TrainedEndDate);

            int AddNewRow = -1;

            try
            {
                connection.Open();
                object AddNew = command.ExecuteScalar();
                if (AddNew != null && int.TryParse(AddNew.ToString(), out int AddNewACount))
                {
                    AddNewRow = AddNewACount;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return AddNewRow;

        }
        public static bool UpdateMemberInstructors(int MemberInstructorID, int InstructorID, int MemberID, DateTime TrainedEndDate)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Update MemberInstructors Set InstructorID =@InstructorID,MemberID =@MemberID,
                            TrainedEndDate =@TrainedEndDate Where MemberInstructorID =@MemberInstructorID;";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);
            command.Parameters.AddWithValue("@InstructorID", InstructorID);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@TrainedEndDate", TrainedEndDate);


            int RowAffected = 0;

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return RowAffected > 0;
        }

        public static DataTable GetAllMemberInstructorByInstructorID(int InstructorID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"
                           SELECT   InstructorID, MemberID,Membername =  (FirestName + ' ' + People2.SecoundName + ' ' +  People2.ThirdName + ' ' + People2.LastName)
                         , BeltRanks.RankName ,IsActive
                          FROM            MemberInstructors INNER JOIN
                         Members ON MemberInstructors.MemberID = Members.MembersIID INNER JOIN
                         BeltRanks ON Members.LastBeltRank = BeltRanks.RankID INNER JOIN
                         People2 ON Members.PersonID = People2.PresonID 

                         WHERE InstructorID = @InstructorID order by MemberID  desc";


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@InstructorID", InstructorID);
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

        public static bool GetInstructorMemberDataInfo(int MemberInstructorID, ref int InstructorID, ref int MemberID, ref DateTime AssignDate,ref DateTime TrainedEndDate)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = "SELECT * FROM MemberInstructors  WHERE MemberInstructorID =@MemberInstructorID";

            SqlCommand command = new SqlCommand(@Query, connection);
            command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);

            bool ISFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ISFound = true;
                    InstructorID = (int)reader["InstructorID"];
                    MemberID = (int)reader["MemberID"];
                    AssignDate = Convert.ToDateTime(reader["AssignDate"]);
                    TrainedEndDate = Convert.ToDateTime(reader["TrainedEndDate"]);
                }
                else
                    ISFound = false;
                reader.Close();
            }
            catch (Exception ex)
            {
                ISFound = false;
            }
            finally
            {
                connection.Close();
            }
            return ISFound;
        }
        public static bool ISInstructorMemberExsit(int InstructorID, int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "SELECT Found =1 FROM MemberInstructors WHERE InstructorID =@InstructorID AND MemberID =@MemberID";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@InstructorID", InstructorID);

            bool ISFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ISFound = true;
                }
                else
                    ISFound = false;

                reader.Close();
            }
            catch (Exception ex)
            {
                ISFound = false;
            }
            finally
            {
                connection.Close();
            }

            return ISFound;
        }

        public static bool DeleteInstructor(int MemberInstructorID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"DELETE MemberInstructors WHERE MemberInstructorID = @MemberInstructorID";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@MemberInstructorID", MemberInstructorID);

            int RowAffected = 0;

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return RowAffected > 0;

        }

        public static DataTable GetAllMemberInstructor()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"select *  from MemberInstructor_Views order by MemberName";


            SqlCommand command = new SqlCommand(Qurey, connection);

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
    }
}