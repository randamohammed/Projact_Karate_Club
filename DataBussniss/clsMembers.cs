using AccessKarateClubPreojact;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinsKarateClubProjacjat
{
    public class clsMembers
    {

        public int PersonID {  get; set; }
        public int MembersID { get; set; }
        public int LastBeltRank { get; set; }
        public bool IsActive { get; set; }
        public string EmergencyContactInfo { get; set; }
        public string Certificate { get; set; }

        public string Membername { get { return SelectpersonInfo.FirestName; } } 

        public clsBussinesManagePeople SelectpersonInfo;
        enum _Mode { AddNew =0,Update = 1 }
        _Mode Mode;
        public clsMembers()
        {
            PersonID = 0;
            MembersID = -1;
            LastBeltRank = 0;
            IsActive = true;
            EmergencyContactInfo = "";
            Certificate = "";
            Mode = _Mode.AddNew;
        }

        public clsMembers(int MemberID,int PersonID,int LastBeltRank,string  EmergencyContactInfo,bool ISActive,string Certificate)
        {
            this.PersonID = PersonID;
            this.Certificate = Certificate;
            this.MembersID = MemberID;
            this.LastBeltRank = LastBeltRank;
            this.EmergencyContactInfo = EmergencyContactInfo;
            this.IsActive = ISActive;
            this.IsActive = ISActive;
            SelectpersonInfo = clsBussinesManagePeople.Find(PersonID);
            Mode = _Mode.Update;
        }
  
        private bool _AddNewMember()
        {
            this.MembersID = clsMembersDatae.AddnewMembers(this.PersonID,this.LastBeltRank,this.EmergencyContactInfo,this.IsActive, this.Certificate);
            return this.MembersID != -1;
        }
    
        private bool _UpdateMember()
        {
            return clsMembersDatae.UpdateMembers(this.MembersID, this.PersonID, this.LastBeltRank,this.EmergencyContactInfo, this.IsActive,this.Certificate);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case _Mode.AddNew:
                    {
                        if(_AddNewMember())
                        {
                            Mode = _Mode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                    case _Mode.Update:
                    return _UpdateMember();
            }
            return false;
        }

        public static clsMembers FindByID(int MembersID)
        {
            int PersonID = 0, LastBeltRank = 0;
            bool IsActive = false;
            string EmergencyContactInfo = "", Certificate ="";

            bool ISFound = clsMembersDatae.FineByID(MembersID,ref PersonID,ref LastBeltRank,ref EmergencyContactInfo,ref IsActive,ref Certificate);
            if(ISFound)
            {
                return new clsMembers(MembersID, PersonID,LastBeltRank,EmergencyContactInfo,IsActive, Certificate);
            }
            else
                return null;    
        }

        public static clsMembers FindByPersonID(int PersonID)
        {
            int MembersID = 0, LastBeltRank = 0;
            bool IsActive = false;
            string EmergencyContactInfo = "", Certificate ="";

            bool ISFound = clsMembersDatae.FineByPersonID(ref MembersID, PersonID, ref LastBeltRank, ref EmergencyContactInfo, ref IsActive,ref Certificate);
            if (ISFound)
            {
                return new clsMembers(MembersID, PersonID, LastBeltRank, EmergencyContactInfo, IsActive, Certificate);
            }
            else
                return null;
        }
       
        public static bool ISMemberExist(int MembersID)
        {
            return clsMembersDatae.ISMemberExistByPerson(MembersID);
        }

        public static bool ISMemberexistByPersonID(int PersonID)
        {
            return clsMembersDatae.ISMemberExistByPersonID(PersonID);
        }

        public static DataTable GetAllMembers()
        {
            return clsMembersDatae.GetAllMembers();
        }

        public static bool DetelteMember(int  MemberID)
        {
            return clsMembersDatae.DeleteMember(MemberID);
        }

        public static bool IsPersonHasBeltBlack(int PersonID)
        {
            return clsMembersDatae.ISPersonHasBeltBalck(PersonID);
        }
    }
}
