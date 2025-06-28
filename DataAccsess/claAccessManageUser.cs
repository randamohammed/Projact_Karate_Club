using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;

namespace AccessKarateClubPreojact
{
    public class claAccessManageUser
    {
        public static DataTable  AlluserFromSystem()
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "SELECT UserID as 'User ID',PresonID as 'Preson  ID', UserName as 'User Name',NatiionalNo as 'National No'," +
                "FirestName + ' ' + SecoundName + ' ' + ThirdName+  ' ' +  LastName as 'Full name',Gander as 'Gander', IsActive as 'IS Active'," +
                " Permissions, DateBirth as 'Date of Birth' FROM   Users INNER JOIN People2 ON Users.PersonID = People2.PresonID";
            SqlCommand command = new SqlCommand(Qurey, connection);

            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
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
            return dataTable;
        }

        public static DataTable FilterDate(string TypeFilter, string TextFilter)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = $"Select * from (SELECT Users.UserID as 'User ID',People2.PresonID as 'Preson ID', Users.UserName as 'User Name',NatiionalNo as 'National No' ,(FirestName + ' ' + SecoundName + ' ' + ThirdName+  ' ' +  LastName) as 'Full name',Gander as 'Gander', IsActive as 'IS Active', Permissions, DateBirth as 'Date of Birth' FROM   Users INNER JOIN People2 ON Users.PersonID = People2.PresonID) as UserInfo   Where  [{TypeFilter}] like '{TextFilter}%'";
            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@TextFilter", TextFilter);

            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }
            catch(Exception Ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static int AddUser(int PersonID ,int Permissions,bool IsActive,string Password,string UserName)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"INSERT INTO Users (PersonID,UserName,Password,IsActive,Permissions) VALUES (@PersonID,@UserName,@Password,@IsActive,@Permissions) 
                select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(Qurey, connection);

            int AddNumber = -1;
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            try
            {
                connection.Open();
                object Number = command.ExecuteScalar();
                if (Number != null && int.TryParse(Number.ToString(), out int CountNumberAdd))
                {
                    AddNumber = CountNumberAdd;
                }

            }
            catch (Exception Ex)
            {
               
            }
            finally

            {
                connection.Close();
            }
            return AddNumber;
        }
        public static bool UpdatUser(int UserID,int PersonID, int Permissions, bool IsActive, string Password, string UserName)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Update Users Set PersonID =@PersonID,UserName =@UserName,Password =@Password,IsActive =@IsActive,Permissions=@Permissions Where UserID=@UserID";
            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            int Number = 0;
            try
            {
                connection.Open();
                 Number = command.ExecuteNonQuery();
             

            }
            catch (Exception Ex)
            {

            }
            finally

            {
                connection.Close();
            }
            return Number > 0;
        }

        public static  bool FindByIID(int UserID, ref int PersonID,ref int Permissions,ref bool IsActive,ref string UserName,ref string Password)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "select * from Users where UserID =@UserID";
            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            bool ISFoound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    ISFoound = true;
                    PersonID = (int)reader["PersonID"];
                    Permissions = (int)reader["Permissions"];
                    IsActive =(bool)reader["IsActive"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    UserName = (string)reader["UserName"];
                 
                }
                reader.Close();

            }
            catch(Exception EX)
            {

            }
            finally
            {
                connection.Close();
            }
            return ISFoound;
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "Select Found =1 from Users Where PersonID =@PersonID";

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
                else
                {
                    ISFound = false;
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

        public static bool DoesPersonHaveUser44(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "Select Found =1 from Users Where PersonID =@PersonID";

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
                else
                {
                    ISFound = false;
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

        public static bool ChanagePassword(int UserID, string Password)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Update Users Set Password = @Password 
                   UserID = @UserID";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Password);

            int RowAffcet = 0;

            try
            {
                RowAffcet = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return RowAffcet > 0;

        }

        public static bool GetUserInfoByUsernameAndPassword(ref int UserID, ref int PersonID, ref int Permissions, ref bool IsActive,  string UserName, string Password)
        {

            SqlConnection connection = new SqlConnection(clsConnintionKarate.  ConntionSring);
            string Qurey = "select *from Users Where Password =@Password and UserName =@UserName";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            bool ISFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ISFound = true;
                    PersonID = (int)reader["PersonID"];
                    Permissions = (int)reader["Permissions"];
                    IsActive = (bool)reader["IsActive"];
                    UserName = (string)reader["UserName"];
                }
                else
                {
                    ISFound = false;
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

        public static bool DelectUser(int UserID)
        {
            string Qurey = @"DELETE  Users Where UserID = @UserID";

            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
           

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

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
    }
}
