using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;

namespace AccessKarateClubPreojact
{
    public class clsAccessManagePeople
    {
        public static DataTable LastAllPeople()
        {
            DataTable dataTable =new DataTable();

            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string qurey = @"select PresonID ,NatiionalNo  ,FirestName 
             ,SecoundName ,ThirdName ,
              LastName ,DateBirth  ,Case WHEN Gander = 1 THEN  'Female'
              ELSE 'Male' END Gender,Phone, 
              Adress ,Emil ,FullName =(FirestName + ' '+SecoundName + ' '+ThirdName + ' ' +LastName ) from People2";
            SqlCommand command = new SqlCommand(qurey, connection);

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
        public static bool FindPopleByNatationNo(ref int PresonID,  string NatiionalNo, ref string FirestName, ref string SecoundName, ref string ThirdName,
         ref string LastName, ref string Phone, ref string Adress, ref int Gander, ref DateTime DateBirth, ref string PathImage, ref string Emil)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "select * from People2 Where NatiionalNo =@NationalNo";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@NationalNo", NatiionalNo);
            bool ISFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ISFound = true;
                    PresonID = (int)reader["PresonID"];
                    FirestName = (string)reader["FirestName"];
                    SecoundName = (string)reader["SecoundName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Adress = (string)reader["Adress"];
                    Gander = Convert.ToInt32(reader["Gander"]);
                    DateBirth = Convert.ToDateTime(reader["DateBirth"]);

                    if (reader["PathImage"] != System.DBNull.Value)
                        PathImage = (string)reader["PathImage"];
                    else
                        PathImage = "";

                    if (reader["Emil"] != System.DBNull.Value)
                        Emil = (string)reader["Emil"];
                    else
                        Emil = "";
                }
                reader.Close();
            }
            catch (Exception Ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ISFound;

        }

        
            public static bool FindPopleByID(int PresonID,ref string NationalNo,ref string FirestName,ref string SecoundName,ref string ThirdName,
         ref string LastName,ref string Phone,ref string Adress,ref int Gander,ref DateTime DateBirth,ref string PathImage,ref string Emil)
        {
            
            bool ISFound = true;
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = "select * from People2 Where PresonID =@PresonID";
            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@PresonID", PresonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    ISFound = true;
                    NationalNo = (string)reader["NatiionalNo"];
                    FirestName = (string)reader["FirestName"];
                    SecoundName = (string)reader["SecoundName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Adress = (string)reader["Adress"];
                    Gander =Convert.ToInt32(reader["Gander"]);
                    DateBirth =Convert.ToDateTime(reader["DateBirth"]);

                    if (reader["PathImage"] != System.DBNull.Value)
                        PathImage = (string)reader["PathImage"];
                    else
                        PathImage = "";

                    if (reader["Emil"] != System.DBNull.Value)
                        Emil = (string)reader["Emil"];
                    else
                        Emil = "";
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
            return ISFound;
        }

        public static bool DelectPeople(int PersonId)
        {
            string Qurey = @"DELETE  People2 Where PresonID =   @PersonId";

            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@PersonId", PersonId);

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
        public static bool Updatedate(int PresonID,string NatiionalNo, string FirestName, string SecoundName, string ThirdName,
         string LastName, string Phone, string Adress, int Gander, DateTime DateBirth, string PathImage, string Emil)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"UPDATE  People2  SET  NatiionalNo = @Natiional , FirestName =@FirestName,SecoundName = @SecoundName,ThirdName = @ThirdName,
             LastName = @LastName,Phone = @Phone,Adress =@Adress,Gander  =@Gander,DateBirth = @DateBirth,PathImage = @PathImage,Emil = @Emil
            Where PresonID = @PresonID ";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@Natiional", NatiionalNo);
            command.Parameters.AddWithValue("@FirestName", FirestName);
            command.Parameters.AddWithValue("@SecoundName", SecoundName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Adress", Adress);
            command.Parameters.AddWithValue("@Gander", Gander);
            command.Parameters.AddWithValue("@DateBirth", DateBirth);
            command.Parameters.AddWithValue("@PresonID", PresonID);

            if (PathImage != "")
                command.Parameters.AddWithValue("@PathImage", PathImage);
            else
                command.Parameters.AddWithValue("@PathImage", System.DBNull.Value);

            if (Emil != "")
                command.Parameters.AddWithValue("@Emil", Emil);
            else
                command.Parameters.AddWithValue("@Emil", System.DBNull.Value);

            int AddRow = 0;
            try
            {
                connection.Open();
                AddRow = command.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return AddRow >0;
        }

        public static int AddNewPeopleInSysetem(string NatiionalNo,string FirestName,string SecoundName,string ThirdName,
            string LastName,string Phone,string Adress,int Gander,DateTime DateBirth,string PathImage,string Emil)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Qurey = @"Insert Into People2 (NatiionalNo, FirestName,SecoundName,ThirdName,LastName,Phone,Adress,Gander,DateBirth,PathImage,Emil) 
            VALUES(@NationalNo,@FirestName,@SecoundName,@ThirdName,@LastName,@Phone,@Adress,@Gander,@DateBirth,@PathImage,@Emil)
             select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Qurey,connection);
            command.Parameters.AddWithValue("@NatiionalNo", NatiionalNo);
            command.Parameters.AddWithValue("@FirestName", FirestName);
            command.Parameters.AddWithValue("@SecoundName", SecoundName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Adress", Adress);
            command.Parameters.AddWithValue("@Gander", Gander);
            command.Parameters.AddWithValue("@DateBirth", DateBirth);

            if(PathImage != "")
               command.Parameters.AddWithValue("@PathImage", PathImage);
            else
               command.Parameters.AddWithValue("@PathImage", System.DBNull.Value);

            if (Emil != "")
                command.Parameters.AddWithValue("@Emil", Emil);
            else
                command.Parameters.AddWithValue("@Emil", System.DBNull.Value);

            int AddRow = -1;
            try
            {
                connection.Open();
                object Add = command.ExecuteScalar();

                if(Add != null && int.TryParse(Add.ToString(), out AddRow))
                {

                }
            }
            catch(Exception Ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return AddRow;
        }

        public static DataTable FilterDate(string TypeFilter,string  TextFilter)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string qurey = "select PresonID as 'People ID',NatiionalNo as 'NationalNo' ,FirestName as 'First Name',SecoundName as 'Secound Name',ThirdName as 'Third Name'," +
                " LastName as 'Laste Name',DateBirth as 'Date Birth' ,Gander as 'Gander',Phone as 'Phone',Adress as 'Adress',Emil as 'Email',PathImage as 'Path Image' from People2 Where " + TypeFilter + " Like + '' + @TextFilter +'%'";

            SqlCommand command = new SqlCommand(qurey, connection);
            command.Parameters.AddWithValue("@TextFilter", TextFilter); 

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
            catch (Exception Ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

    }
}
