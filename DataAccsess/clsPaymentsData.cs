using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AccessKarateClubPreojact
{
    public class clsPaymentsData
    {
        public static bool GetMemberPaymentinfoByID(int PaymentID, ref int MemberID, ref float Amount, ref DateTime Date, ref DateTime Lastmodified)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"select * from Payments WHERE PaymentID = @PaymentID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            bool ISfound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ISfound = true;
                    MemberID = (int)reader["MemberID"];
                    Amount = Convert.ToSingle(reader["Amount"]);
                    Date = (DateTime)reader["PaymentDate"];
                    Lastmodified = (DateTime)reader["Lastmodified"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                ISfound = false;
            }
            finally
            {
                connection.Close();
            }
            return ISfound;


        }

        public static bool GetMemberPaymentinfoByMemberID(int MemberID, ref int PaymentID, ref float Amount, ref DateTime Date, ref DateTime Lastmodified)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"select * from Payments WHERE MemberID = @MemberID order by PaymentID desc";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);


            bool ISfound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ISfound = true;
                    PaymentID = (int)reader["PaymentID"];
                    Amount = Convert.ToSingle(reader["Amount"]);
                    Date = (DateTime)reader["Date"];
                    Lastmodified = (DateTime)reader["Lastmodified"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                ISfound = false;
            }
            finally
            {
                connection.Close();
            }
            return ISfound;


        }

        public static DataTable GetAllMemberPaymentMemberID(int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"select top 1 Payments.PaymentID,FullName =( People2.FirestName+ ' ' + People2.SecoundName+ ' '+ People2.ThirdName+ ' '+ People2.LastName)
                               ,Payments.Amount, Payments.PaymentDate, Payments.Lastmodified
                               FROM   Payments INNER JOIN
                                Members ON Payments.MemberID = Members.MembersIID INNER JOIN
                               People2 ON Members.PersonID = People2.PresonID
                                WHERE MemberID = @MemberID order by PaymentID desc";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);

            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
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
            return dt;

        }

        public static DataTable GetAllMemberPayments()
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"select Payments.PaymentID,FullName =(FirestName+ ' ' + SecoundName+ ' '+ThirdName+ ' '+LastName)
                               ,Payments.Amount, Payments.PaymentDate, Payments.Lastmodified
                               FROM   Payments INNER JOIN
                                Members ON Payments.MemberID = Members.MembersIID INNER JOIN
                               People2 ON Members.PersonID = People2.PresonID order by PaymentID ";

            SqlCommand command = new SqlCommand(Query, connection);

            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
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
            return dt;

        }
        public static int AddNewPayment(int MemberID, float Amount)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"Insert Into Payments (MemberID,PaymentDate,Amount,Lastmodified) 
                              Values  (@MemberID,@PaymentDate,@Amount,@Lastmodified)
                               select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Lastmodified", DateTime.Now);

            int PaymentID = -1;

            try
            {
                connection.Open();
                object Reslut = command.ExecuteScalar();

                if (Reslut != null && int.TryParse(Reslut.ToString(), out int Insertid))
                {
                    PaymentID = Insertid;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return PaymentID;
        }

        public static bool UpdatePayment(int PaymentID, float Amount)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"Update Payments Set Amount = @Amount ,Lastmodified= @Lastmodified
                            WHERE PaymentID = @PaymentID";


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Lastmodified", DateTime.Now);

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


        public static bool DeletePayment(int PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string query = @"DELETE Payments WHERE PaymentID = @PaymentID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public static bool IsMemberBayAnyFees(int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"select top 1 Found = 1 from Payments WHERE MemberID = @MemberID";

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
    

        public static float CountMemberBayInTest(int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"SELECT        SUM(Payments.Amount) AS CountFees
                             FROM            Payments INNER JOIN
                                                      BeltTests ON Payments.PaymentID = BeltTests.PaymentID
                             WHERE        (Payments.MemberID = @MemberID)";

            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);

            int CountPayment = 0;

            try
            {
                connection.Open();
                object Reslut = command.ExecuteScalar();

                if (Reslut != null && int.TryParse(Reslut.ToString(), out int Count))
                {
                    CountPayment = Count;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return CountPayment;
        }

        public static float CountMemberBayInSubscriptionPeriods(int MemberID)
        {
            SqlConnection connection = new SqlConnection(clsConnintionKarate.ConntionSring);
            string Query = @"SELECT        SUM(Payments.Amount) AS CountFees
                             FROM            Payments INNER JOIN
                                                      SubscriptionPeriods ON Payments.PaymentID = SubscriptionPeriods.PaymentID
                             WHERE        (Payments.MemberID = @MemberID)";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);

            int CountPayment = 0;

            try
            {
                connection.Open();
                object Reslut = command.ExecuteScalar();

                if (Reslut != null && int.TryParse(Reslut.ToString(), out int Count))
                {
                    CountPayment = Count;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return CountPayment;
        }

    }
}
