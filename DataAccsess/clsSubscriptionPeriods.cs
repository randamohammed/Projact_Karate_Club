using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AccessKarateClubPreojact
{
    public class clsSubscriptionPeriodsDate
    {
        public static bool GetMemberSubscriptionPeriodInfoByMemberID(int MemberID, ref int PeriodID, ref int PaymentID,
            ref DateTime EndDate, ref DateTime StartDate, ref float Fees, ref bool isPaid)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = "SELECT top 1 * FROM SubscriptionPeriods WHRE MemberID = @MemberID order by PeriodID desc";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);

            bool IsFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    {
                        IsFound = true;
                        PeriodID = (int)reader["PeriodID"];
                        PaymentID = (int)reader["PaymentID"];
                        EndDate = (DateTime)reader["EndDate"];
                        StartDate = (DateTime)reader["StartDate"];
                        isPaid = (bool)reader["isPaid"];
                        Fees = Convert.ToSingle(reader["Fees"]); ;

                    }
                }
                else
                    IsFound = false;
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool GetMemberSubscriptionPeriodInfoBy(int PeriodID, ref int MemberID, ref int PaymentID, ref DateTime EndDate,
            ref DateTime StartDate, ref float Fees, ref bool isPaid)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = "SELECT * FROM SubscriptionPeriods WHERE PeriodID = @PeriodID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PeriodID", PeriodID);

            bool IsFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    {
                        IsFound = true;
                        MemberID = (int)reader["MemberID"];
                        PaymentID = (int)reader["PaymentID"];
                        isPaid = (bool)reader["isPaid"];
                        EndDate = (DateTime)reader["EndDate"];
                        StartDate = (DateTime)reader["StartDate"];
                        Fees = Convert.ToSingle(reader["Fees"]); ;

                    }
                }
                else
                    IsFound = false;
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static DataTable GetAllSubscriptionPeriod()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"SELECT SubscriptionPeriods.PeriodID,FullName =(FirestName+ ' ' + SecoundName+ ' '+ThirdName+ ' '+LastName), 
                                          Fees, isPaid,StartDate, EndDate
                                          FROM            SubscriptionPeriods INNER JOIN
                                           Members ON SubscriptionPeriods.MemberID = Members.MembersIID INNER JOIN
                                            People2 ON Members.PersonID = People2.PresonID order by PeriodID";
                                          
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
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

        public static DataTable GetAllMemberSubscriptionPeriod(int MemberID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"SELECT SubscriptionPeriods.PeriodID,FullName =(FirestName+ ' ' + SecoundName+ ' '+ThirdName+ ' '+LastName), 
                                          Fees, isPaid,StartDate, EndDate
                                          FROM            SubscriptionPeriods INNER JOIN
                                           Members ON SubscriptionPeriods.MemberID = Members.MembersIID INNER JOIN
                                            People2 ON Members.PersonID = People2.PresonID MemberID = @MemberID order by PeriodID desc";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
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

        public static int AddNewSubscriptionPeriod(int MemberID, int PaymentID, DateTime EndDate, DateTime StartDate, float Fees, bool isPaid)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);

            string Qurey = @"INSERT INTO SubscriptionPeriods (MemberID,PaymentID,Fees,EndDate,StartDate,isPaid)
               values (@MemberID,@PaymentID,@Fees,@EndDate,@StartDate,@isPaid)
                       select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Qurey, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@isPaid", isPaid);
            command.Parameters.AddWithValue("@StartDate", StartDate);

            int PeriodID = -1;

            try
            {
                connection.Open();

                object Reslut = command.ExecuteScalar();

                if (Reslut != null && int.TryParse(Reslut.ToString(), out int insertid))
                {
                    PeriodID = insertid;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return PeriodID;
        }

        public static bool UpdateSubscriptionPeriod(int PeriodID, int MemberID, int PaymentID, DateTime EndDate, DateTime StartDate, float Fees, bool isPaid)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);

            string Query = @"Update SubscriptionPeriods Set PaymentID = @PaymentID,MemberID = @MemberID,Fees = @Fees,
                            EndDate = @EndDate,StartDate = @StartDate,isPaid = @isPaid WHERE PeriodID = @PeriodID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@PeriodID", PeriodID);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@isPaid", isPaid);

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

        public static bool DeleteSubscriptionPeriod(int PeriodID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);

            string Query = @"DELETE SubscriptionPeriods WHERE PeriodID = @PeriodID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PeriodID", PeriodID);

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
            return RowAffceted >= 0;
        }
  
       public    static bool IsMemberPaid(int PeriodID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"Select Found = 1 from  SubscriptionPeriods
                               WHERE PeriodID = @PeriodID AND isPaid = 1";

            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@PeriodID", PeriodID);

            int IsPaid = 0;

            try
            {
                connection.Open();
                object Reslut = command.ExecuteScalar();

                if (Reslut != null && int.TryParse(Reslut.ToString(), out int isFound))
                {
                    IsPaid = isFound;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close ();
            }
            return IsPaid > 0;
        }
    
    }
}
