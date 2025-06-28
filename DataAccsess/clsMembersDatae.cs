using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessKarateClubPreojact
{
    public class clsMembersDatae
    {
        public static int AddnewMembers(int PersonID,int LastBeltRank,string EmergencyContactInfo,bool IsActive, string Certificate)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Insert Into Members (PersonID,LastBeltRank,EmergencyContactInfo,IsActive,Certificate) Values 
                     (@PersonID,@LastBeltRank,@EmergencyContactInfo,@IsActive,@Certificate) 
                      select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LastBeltRank", LastBeltRank);
            command.Parameters.AddWithValue("@EmergencyContactInfo", EmergencyContactInfo);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            if(Certificate != "")
                command.Parameters.AddWithValue("@Certificate", Certificate);
            else
                command.Parameters.AddWithValue("@Certificate", System.DBNull.Value);

            int Addrow = -1;

            try
            {
                connection.Open();
                object Adding = command.ExecuteScalar();
                if(Adding != null && int.TryParse(Adding.ToString(),out int AddNew))
                {
                    Addrow = AddNew;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Addrow;
        }

        public static bool UpdateMembers(int MembersIID, int PersonID, int LastBeltRank, string EmergencyContactInfo, bool IsActive,string Certificate)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Update Members Set PersonID =@PersonID,LastBeltRank =@LastBeltRank,
                  IsActive =@IsActive,Certificate = @Certificate,EmergencyContactInfo =   @EmergencyContactInfo Where MembersIID =@MembersIID";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@MembersIID", MembersIID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LastBeltRank", LastBeltRank);
            command.Parameters.AddWithValue("@EmergencyContactInfo", EmergencyContactInfo);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            if(Certificate != "")
            command.Parameters.AddWithValue("@Certificate", Certificate);
            else
            command.Parameters.AddWithValue("@Certificate", System.DBNull.Value);

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
    
        public static DataTable GetAllMembers()
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"SELECT Members.MembersIID, Members.PersonID, fullname = (People2.FirestName + ' ' + People2.SecoundName+ ' '+ People2.ThirdName+''+ People2.LastName)
                            ,Members.IsActive ,Case when People2.Gander =0 then 'Male' else'Female' end as Gender,
                               BeltRanks.RankName, Members.EmergencyContactInfo
                              FROM  Members INNER JOIN People2 ON Members.PersonID = People2.PresonID INNER JOIN
                              BeltRanks ON Members.LastBeltRank = BeltRanks.RankID";

            SqlCommand command = new SqlCommand(Qurey,connection);
            
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dataTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static bool FineByID(int MembersIID,ref int PersonID,ref int LastBeltRank,ref string EmergencyContactInfo,ref bool IsActive,ref string Certificate)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "Select *  FROM  Members Where MembersIID =@MembersIID";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@MembersIID", MembersIID);

            bool ISFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    ISFound = true;
                    PersonID = (int)reader["PersonID"];
                    LastBeltRank = (int)reader["LastBeltRank"];
                    EmergencyContactInfo = (string)reader["EmergencyContactInfo"];

                    if (reader["Certificate"] != System.DBNull.Value)
                        Certificate = (string)reader["Certificate"];
                    else
                        Certificate = "";


                    IsActive = (bool) reader["IsActive"];
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

        public static bool FineByPersonID(ref int MembersIID,  int PersonID, ref int LastBeltRank, ref string EmergencyContactInfo, ref bool IsActive,ref string Certificate)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "Select * from FROM  Members Where PersonID =@PersonID";

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
                    MembersIID = (int)reader["MembersIID"];
                    LastBeltRank = (int)reader["LastBeltRank"];
                    EmergencyContactInfo = (string)reader["EmergencyContactInfo"];

                    if (reader["Certificate"] != System.DBNull.Value)
                        Certificate = (string)reader["Certificate"];
                    else
                        Certificate = "";

                    IsActive = (bool)reader["IsActive"];
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
   
        public static bool ISMemberExistByPerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "Select *  FROM  Members Where PersonID =@PersonID";

            SqlCommand command = new SqlCommand(Qurey,connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            bool ISFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ISFound = true;
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

        public static bool ISPersonHasBeltBalck(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "Select *  FROM  Members Where PersonID = @PersonID And LastBeltRank >7 ";

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

        public static bool ISMemberExistByPersonID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "Select * FROM  Members Where PersonID =@PersonID";

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
                }
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

        public static bool DeleteMember(int MembersIID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Delete  Members Where MembersIID = @MembersIID";

            SqlCommand command = new SqlCommand(Qurey,connection);
            command.Parameters.AddWithValue("@MembersIID", MembersIID); 

            int RowAffct = 0;
            try
            {
                connection.Open();
                RowAffct = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return RowAffct >0;
        }
    }
}
