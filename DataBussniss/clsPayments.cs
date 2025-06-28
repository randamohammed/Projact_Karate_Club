using AccessKarateClubPreojact;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinsKarateClubProjacjat
{
    public class clsPayments
    {
        public int PaymentID {  get; set; }
        public int MemberID {  get; set; }
        public float Amount {  get; set; }
        public DateTime PaymentDate {  get; set; }
        public DateTime Lastdatemodified {  get; set; }

        enum enMode { AddNew =0,UpdateNew = 1 }
        enMode Mode = enMode.AddNew;
        public clsPayments()
        {
            Amount = 0;
            PaymentDate = DateTime.Now;
            Lastdatemodified = DateTime.Now;
            PaymentID = -1;
            MemberID = -1;
            enMode Mode = enMode.AddNew;
        }

        public clsPayments(int PaymentID,int MemberID,float Amount,DateTime Date,DateTime Lastdatemodified)
        {
            this.Amount = Amount;
            this.PaymentDate = Date;
            this.PaymentID = PaymentID;
            this.MemberID = MemberID;
            this.Lastdatemodified = Lastdatemodified;
            enMode Mode = enMode.UpdateNew;
        }

        public static clsPayments Find(int PaymentID)
        {
            int MemberID = -1;
            float Amount = 0;
            DateTime Date   = DateTime.Now, Lastdatemodified = DateTime.Now;

            bool IsFound = clsPaymentsData.GetMemberPaymentinfoByID(PaymentID,ref MemberID,ref Amount,ref Date,ref Lastdatemodified);

            if(IsFound)
            {
                return new clsPayments(PaymentID, MemberID, Amount, Date,Lastdatemodified);
            }
            return null;
        }

        public static clsPayments FindByMemberID(int MemberID)
        {
            int PaymentID = -1;
            float Amount = 0;
            DateTime Date = DateTime.Now, Lastdatemodified = DateTime.Now;

            bool IsFound = clsPaymentsData.GetMemberPaymentinfoByMemberID(MemberID, ref PaymentID,ref Amount, ref Date,ref Lastdatemodified);

            if (IsFound)
            {
                return new clsPayments(PaymentID, MemberID, Amount, Date, Lastdatemodified);
            }
            return null;
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentsData.GetAllMemberPayments();
        }

        public static DataTable GetAllPaymentsbyMemberD(int MemberID)
        {
            return clsPaymentsData.GetAllMemberPaymentMemberID(MemberID);
        }

        private bool   _AddNewPayment()
        {
            this.PaymentID = clsPaymentsData.AddNewPayment(this.MemberID, this.Amount);

           return this.PaymentID != -1; 
        }

        private bool _UpdatePament()
        {
            return clsPaymentsData.UpdatePayment(this.PaymentID,this.Amount);
        }
    

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    {
                        if(_AddNewPayment())
                        {
                            Mode = enMode.UpdateNew;
                            return true;
                        }
                        else
                            return false;
                        
                    }

                    case enMode.UpdateNew:

                    return _UpdatePament();
            }
            return false;
        }

       public static bool Deletepayment(int PaymentID)
        {
            return clsPaymentsData.DeletePayment(PaymentID);
        }

        public static bool IsMemberBayAnyFees(int MemberID)
        {
            return clsPaymentsData.IsMemberBayAnyFees(MemberID);
        }

        public static float CountMemberBayInTest(int MemberID)
        {
            return clsPaymentsData.CountMemberBayInTest(MemberID);
        }

        public static float CountMemberBayInSubscriptionPeriods(int MemberID)
        {
            return clsPaymentsData.CountMemberBayInSubscriptionPeriods(MemberID);
        }
    }
}
