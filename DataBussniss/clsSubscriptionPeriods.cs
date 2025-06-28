using AccessKarateClubPreojact;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinsKarateClubProjacjat
{
    public class clsSubscriptionPeriods
    {
        public int PeriodID { get; set; }
        public int PaymentID { get; set; }
        public int MemberID { get; set; }
        public float Fees { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool isPaid { get; set; }

        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;


       public clsMembers MemberInfo;
        public clsPayments MemberPaymentsInfo;

        public clsSubscriptionPeriods()
        {
            PeriodID = -1;
            PaymentID = -1;
            MemberID = -1;
            Fees = 0;
            EndDate = DateTime.Now;
            StartDate = DateTime.Now;
            isPaid = false;
            Mode = enMode.AddNew;
        }

        public clsSubscriptionPeriods(int PeriodID, int MemberID, int PaymentID, float Fees, DateTime StartDate, DateTime EndDate, bool isPaid)
        {
            this.PeriodID = PeriodID;
            this.PaymentID = PaymentID;
            this.MemberID = MemberID;
            this.Fees = Fees;
            this.EndDate = EndDate;
            this.StartDate = StartDate;
            this.isPaid = isPaid;
            MemberPaymentsInfo = clsPayments.Find(PaymentID);
            MemberInfo = clsMembers.FindByID(MemberID);

            Mode = enMode.Update;
        }

        public static clsSubscriptionPeriods Find(int PeriodID)
        {
            int PaymentID = -1, MemberID = -1;
            float Fees = 0;
            bool ispaid = false;
            DateTime StartDate = DateTime.Now, EndDate = DateTime.Now;

            bool IsFound = clsSubscriptionPeriodsDate.GetMemberSubscriptionPeriodInfoBy(PeriodID, ref MemberID, ref PaymentID,
                ref EndDate, ref StartDate, ref Fees, ref ispaid);


            if (IsFound)
            {
                return new clsSubscriptionPeriods(PeriodID, MemberID, PaymentID, Fees, StartDate, EndDate, ispaid);
            }
            else
                return null;

        }

        public static clsSubscriptionPeriods FindbtyMemberID(int MemberID)
        {
            int PaymentID = -1, PeriodID = -1;
            float Fees = 0;
            bool ispaid = false;
            DateTime StartDate = DateTime.Now, EndDate = DateTime.Now;

            bool IsFound = clsSubscriptionPeriodsDate.GetMemberSubscriptionPeriodInfoByMemberID( MemberID,ref PeriodID, ref PaymentID,
                ref EndDate, ref StartDate, ref Fees, ref ispaid);


            if (IsFound)
            {
                return new clsSubscriptionPeriods(PeriodID, MemberID, PaymentID, Fees, StartDate, EndDate, ispaid);
            }
            else
                return null;

        }

        private bool _AddNewSubscriptionPeriod()
        {
            MemberPaymentsInfo =new clsPayments();
            MemberPaymentsInfo.Amount = this.Fees;
            MemberPaymentsInfo.MemberID = this.MemberID;

            if (!MemberPaymentsInfo.Save())
            {
                return false;
            }
            this.PaymentID = MemberPaymentsInfo.PaymentID;
            this.PeriodID = clsSubscriptionPeriodsDate.AddNewSubscriptionPeriod(this.MemberID, this.PaymentID,
                this.EndDate, this.StartDate, this.Fees, this.isPaid);

            return this.PeriodID != -1;
        }

        private bool _UpdateSubscriptionPeriod()
        {
         
            return clsSubscriptionPeriodsDate.UpdateSubscriptionPeriod(this.PeriodID,this.MemberID, this.PaymentID, this.EndDate, this.StartDate, this.Fees,this.isPaid);
        }

        public static DataTable GetAllSubscriptionPeriods()
        {
            return clsSubscriptionPeriodsDate.GetAllSubscriptionPeriod();
        }


        public static DataTable GetAllMemberSubscriptionPeriods(int MemberID)
        {
            return clsSubscriptionPeriodsDate.GetAllMemberSubscriptionPeriod(MemberID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    {
                        if(_AddNewSubscriptionPeriod())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                    case enMode.Update:
                    return _UpdateSubscriptionPeriod();

            }
            return false;
        }

        public static bool DeleteSubscriptionPeriod(int PeriodID)
        {
            return clsSubscriptionPeriodsDate.DeleteSubscriptionPeriod(PeriodID);
        }

        public static bool IsMemberPaaid(int PeriodID)
        {
            return clsSubscriptionPeriodsDate.IsMemberPaid(PeriodID);
        }
    }
}
