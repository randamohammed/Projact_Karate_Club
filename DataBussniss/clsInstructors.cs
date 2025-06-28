using AccessKarateClubPreojact;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinsKarateClubProjacjat
{
    public class clsInstructors
    {
        public int InstructorsID {  get; set; }
        public int PersonID { get; set; }
        public  string Qualification {  get; set; }

        public string fullName { get { return PersonInfo.FullName; } }
        enum _Mode { AddNew = 0, Update = 1 };
        _Mode Mode;

        public clsBussinesManagePeople PersonInfo;

        
        public  clsInstructors()
        {
            InstructorsID = 0;
            PersonID = 0;
            Qualification = "";
            Mode = _Mode.AddNew;
      
      }

        public clsInstructors(int InstructorsID,int PersonID,string Qualification)
        {
            this.InstructorsID = InstructorsID;
            this.PersonID = PersonID;
            this.Qualification = Qualification;
            Mode = _Mode.Update;
        }
   
       private bool  _AddNewInstructors()
       {
           this.InstructorsID = clsInstructorsData.AddNewInstructors(this.PersonID,this.Qualification);

            return (this.InstructorsID != -1);
       }

       private bool _UpdateIntructor()
        {
            return clsInstructorsData.UpdateInstructors(this.InstructorsID, this.PersonID, this.Qualification);
        }
       
        public static clsInstructors FindByID(int InstructorsID)
        {
            int PersonID = 0;
            string Qualification = "";

            bool ISFound = clsInstructorsData.FindByID(InstructorsID,ref PersonID,ref Qualification);

            if (ISFound)
            {
                return new clsInstructors(InstructorsID, PersonID, Qualification);
            }
            else
                return null;
        }

        public static clsInstructors FindByPersonID(int PersonID)
        {
            int InstructorsID = 0;
            string Qualification = "";

            bool ISFound = clsInstructorsData.FindByPersonID( PersonID,ref InstructorsID, ref Qualification);

            if (ISFound)
            {
                return new clsInstructors(InstructorsID, PersonID, Qualification);
            }
            else
                return null;
        }

        public static bool ISInteructorExist(int InstructorsID)
        {
            return clsInstructorsData.IsInstructorsExistByID(InstructorsID);
        }

        public static bool ISInteructorExistByPersonID(int PersonID)
        {
            return clsInstructorsData.IsInstructorsExistByPersonID(PersonID);
        }
        
        public static bool DeleteInstructors(int InstructorsID)
        {
            return clsInstructorsData.DeleteInstructors(InstructorsID); ;
        }

        public static DataTable GetAllInteructor()
        {
            return clsInstructorsData.GetAllIntructor(); 
        }
        public bool Save()
        {
            switch(Mode)
            {
                case _Mode.AddNew:
                    {
                        if(_AddNewInstructors())
                        {
                            Mode = _Mode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                 case _Mode.Update:
                    return _UpdateIntructor();
            }
            return false;
        }

    }
}
