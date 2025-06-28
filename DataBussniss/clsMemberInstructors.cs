using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinsKarateClubProjacjat
{
    public class clsMemberInstructors
    {

        public  int MemberInstructorID {  get; set; }
        public int MemberID { get; set; }
        public int InstructorID { get; set; }
        public DateTime AssignDate {  get; set; }
        public DateTime TrainedEndDate {  get; set; }

        clsInstructors SelectInstructorInfo;
        clsMembers SelectMemberInfo;

        enum enMode { AddNew =0,Update = 1 };
        enMode Mode = enMode.AddNew;

       public clsMemberInstructors()
        {
            MemberInstructorID = 0;
            MemberID = 0;
            InstructorID = 0;
            AssignDate = DateTime.Now;
            TrainedEndDate = DateTime.Now;
            Mode = enMode.AddNew;
        }

        public clsMemberInstructors(int MemberInstructorID,int InstructorID,int MemberID,DateTime AssignDate,DateTime TrainedEndDate)
        {
            this.MemberInstructorID = MemberInstructorID;
            this.MemberID = MemberID;
            this.InstructorID = InstructorID;
            this.AssignDate = AssignDate;
            this.TrainedEndDate = AssignDate;
          
            SelectInstructorInfo = clsInstructors.FindByID(InstructorID);
            SelectMemberInfo =clsMembers.FindByID(MemberID);


            Mode = enMode.Update;
        }

        private bool _AddNewMemberInstructor()
        {
            this.MemberInstructorID = clsInstructorMemberData.AddNewMemberInstructor(this.InstructorID,this.MemberID,this.AssignDate,this.TrainedEndDate);

            return (this.MemberInstructorID != -1);
        }

        private bool _UpdateMemberInstructor()
        {
            return clsInstructorMemberData.UpdateMemberInstructors(this.MemberInstructorID, this.InstructorID, this.MemberID, this.TrainedEndDate);
        }

        public static clsMemberInstructors Find(int MemberInstructorID)
        {
            int InstructorID =0,MemberID = 0;
            DateTime AssignDate =DateTime.Now, TrainedEndDate = DateTime.Now;

            if (clsInstructorMemberData.GetInstructorMemberDataInfo(MemberInstructorID, ref InstructorID, ref MemberID, ref AssignDate,ref TrainedEndDate))
            {
                return new clsMemberInstructors(MemberInstructorID, InstructorID, MemberID, AssignDate, TrainedEndDate);
            }
            else
              return  null;
        }
        public static DataTable GetAllMemberInstructor()
        {
            return clsInstructorMemberData.GetAllMemberInstructor();
        }

        public static DataTable GetAllMemberInstructorByInstructorID(int InstructorID)
        {
            return clsInstructorMemberData.GetAllMemberInstructorByInstructorID(InstructorID);
        }
        public static bool DeleteMemberInstructor(int MemberInstructorID)
        {
            return clsInstructorMemberData.DeleteInstructor(MemberInstructorID);
        }

        public static bool ISInstructorMemberExsit(int InstructorID,int MemberID)
        {
            return clsInstructorMemberData.ISInstructorMemberExsit(InstructorID, MemberID);
        }
        
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    {
                        if(_AddNewMemberInstructor())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                    case enMode.Update:
                    return _UpdateMemberInstructor();
            }
            return false;
        }
    
    }
}
