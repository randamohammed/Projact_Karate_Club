using AccessKarateClubPreojact;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinsKarateClubProjacjat
{
    public class clsBeltTests
    {
       public int TestID {  get; set; }
       public int MemberID {  get; set; }
       public clsBeltRanks.enBeltRank RankID { get; set; }
        public bool Result {  get; set; }
       public DateTime Date {  get; set; }
       public int TestedByInstructorID {  get; set; }
       public int PaymentID {  get; set; }

        public clsPayments MemberPaymentsInfo;
        public clsInstructors SelectInstructor;
        public clsMembers SelectMember;

        enum enMode { AddNow =0, UpdateNow = 1 }
        enMode Mode = enMode.AddNow;
        public clsBeltTests()
        {
            TestID = -1;
            MemberID = -1;
            RankID = 0;
            Result = false;
            Date = DateTime.Now;
            TestedByInstructorID = -1;
            PaymentID =-1;
            Mode = enMode.AddNow;
        }

        public clsBeltTests(int TestID, int MemberID, clsBeltRanks.enBeltRank RankID, bool Result, int TestedByInstructorID, int PaymentID, DateTime Date)
        {
           this.TestID = TestID;
           this.MemberID = MemberID;
           this.RankID = RankID;
           this.Result = Result;
           this.Date =Date;
           this.TestedByInstructorID =TestedByInstructorID;
            this.PaymentID = PaymentID;       
            Mode = enMode.UpdateNow;
        }
  
        private bool _AddNewBeltTests()
        {
            this.TestID = clsBeltTestsDate.AddNewselectBeltTest(this.MemberID,(int)this.RankID,this.Result,this.TestedByInstructorID,this.PaymentID,this.Date);

            return this.TestID != -1;
        }
    
        public static DataTable GetAllBeltTests()
        {
            return clsBeltTestsDate.GetAllBeltTests();
        }

        public static DataTable GetAllTestforBeltRank(int MemberID)
        {
            return clsBeltTestsDate.GetAllTestforBeltRank(MemberID);
        }

        public  DataTable GetAllTestforBeltRank()
        {
            return clsBeltTestsDate.GetAllTestforBeltRank(this.MemberID);
        }

        public bool TakeTest(float Fees)
        {
            MemberPaymentsInfo = new clsPayments();
            MemberPaymentsInfo.Amount = Fees;
            MemberPaymentsInfo.MemberID = this.MemberID;

            if (!MemberPaymentsInfo.Save())
            {
                return false;
            }
            this.PaymentID = MemberPaymentsInfo.PaymentID;

           if(!_AddNewBeltTests())
           {
                return false;
           }
           else
            {
                return true;
            }
        }

        public static bool IsMemberTakeAnyTest(int MemberID)
        {
            return clsBeltTestsDate.IsMemberTastAnyTest(MemberID);
        }
    }
}
