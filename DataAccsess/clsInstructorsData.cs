using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessKarateClubPreojact
{
    public class clsInstructorsData
    {
        public static int AddNewInstructors(int PersonID,string Qualification)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string qurey = @"Insert Into Instructors (PersonID,Qualification)  Values (@PersonID,@Qualification) 
             
             select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(qurey, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Qualification", Qualification);

            int AddRow = -1;

            try
            {
                connection.Open();
                object Add = command.ExecuteScalar();

                if(Add != null && int.TryParse(Add.ToString(),out int AddInstructors))
                {
                    AddRow = AddInstructors;
                }
            }
            catch (Exception ex) 
                {

                }
            finally
            {
                connection.Close();
            }
            return AddRow;
                
        }
       
        public static bool UpdateInstructors(int InstructorsID, int PersonID,  string Qualification)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Update Instructors Set PersonID = @PersonID,Qualification = @Qualification
                            Where InstructorsID =@InstructorsID";

            SqlCommand command = new SqlCommand(@Qurey, connection);
            command.Parameters.AddWithValue("@Qualification", Qualification);
            command.Parameters.AddWithValue("@InstructorsID", InstructorsID);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            int RowAffect = 0;
            try
            {
                connection.Open();

                RowAffect = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return RowAffect > 0;
        }
        public static bool FindByID(int InstructorsID,ref int PersonID,ref string Qualification)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);

            string Qurey = "Select *  from Instructors Where InstructorsID = @InstructorsID";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@InstructorsID", InstructorsID);

            bool ISFound =false;

            try
            {
                connection .Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    ISFound = true;
                    PersonID = (int)reader["PersonID"];
                    Qualification = (string)reader["Qualification"];
                }
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
        public static bool FindByPersonID( int PersonID, ref int InstructorsID, ref string Qualification)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);

            string Qurey = "Select *  from Instructors Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            bool ISFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ISFound = true;
                    InstructorsID = (int)reader["InstructorsID"];
                    Qualification = (string)reader["Qualification"];
                }
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
        public static bool IsInstructorsExistByID(int InstructorsID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "select Found  =1 from Instructors where InstructorsID =@InstructorsID";

            SqlCommand command = new SqlCommand(Qurey,  connection);
            command.Parameters.AddWithValue("@InstructorsID", InstructorsID);

            bool Found = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Found = true;
                }
                else
                    Found = false;
                reader.Close();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Found;

        }
        public static bool IsInstructorsExistByPersonID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "select Found  =1 from Instructors where PersonID =@PersonID";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            bool Found = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Found = true;
                }
                else
                    Found = false;
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Found;

        }
        public static bool DeleteInstructors(int InstructorsID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Delete Instructors Where InstructorsID = @InstructorsID";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@InstructorsID", InstructorsID);
            int RowAffect =0;

            try
            {
                connection.Open();

                RowAffect = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return RowAffect > 0;
        }

        public static DataTable GetAllIntructor()
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"SELECT Instructors.InstructorsID,Fullname =( People2.FirestName + ' ' +People2.SecoundName +' '+ People2.ThirdName+ ' '+ People2.LastName)
                            ,Instructors.Qualification,Case When People2.Gander =0 then 'Male'
                            Else 'Female'End as Gender, People2.DateBirth,People2.Phone
                            FROM  Instructors INNER JOIN
                           People2 ON Instructors.PersonID = People2.PresonID";

            SqlCommand command = new SqlCommand(Qurey,connection);

            DataTable dt =  new DataTable();

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
                connection.Close() ;
            }
            return dt;

        }
    }
}

