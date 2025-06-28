using AccessKarateClubPreojact;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace clsBussinsKarateClubProjacjat
{
    public class clsUser
    {
       public int UserID { get; set; }
       public int PersonID { get; set; }
       public int Permissions { get; set; }
       public string Password { get; set; }
       public bool IsActive { get; set; }
        public string UserName { get; set; }

        enum _Mode { AddUser=0,UpdateUser=1};
        _Mode Mode;
        public clsUser()
        {
            this.Permissions = 0;
            this.IsActive = false;
            this.UserID = 0;
            this.PersonID = 0;
            this.Password = "";
            this.UserName = "";
            Mode = _Mode.AddUser;
        }

        public clsUser(int UserID, int PersonID, int Permissions, bool IsActive, string UserName,string Password)
        {
            this.Password = Password;
            this.Permissions = Permissions;
            this.IsActive = IsActive;
            this.UserID =UserID;
            this.PersonID = PersonID;
            this.UserName =UserName;
            Mode = _Mode.UpdateUser;
        }

        private bool _AddUser()
        {
            this.UserID = claAccessManageUser.AddUser(this.PersonID, this.Permissions, this.IsActive, this.Password, this.UserName);
            return this.UserID > -1;
        }
        private bool UpdateDate()
        {
            return claAccessManageUser.UpdatUser(this.UserID,this.PersonID, this.Permissions, this.IsActive, this.Password, this.UserName);
        }
        public static DataTable GetAllUser()
        {
            return claAccessManageUser.AlluserFromSystem();
        }

        public static bool DelectUser(int UserId)
        {
            return claAccessManageUser.DelectUser(UserId);
        }
        public static DataTable  GetFilterDate(string TypeFiltr,string TextFilter)
        {
            return claAccessManageUser.FilterDate(TypeFiltr, TextFilter);
        }

        public static clsUser FindByUsernameAndPassword(string UserName,string Password)
        {
            int UserId =0, PersonID =0,Permasiossion =0;
            bool IsActive = false; 
            bool IsFound =  claAccessManageUser.GetUserInfoByUsernameAndPassword(ref UserId,ref PersonID,ref Permasiossion, ref IsActive,UserName,Password);

            if(IsFound)
            {
                return new clsUser(UserId, PersonID, Permasiossion, IsActive, UserName, Password);
            }
            else
                return null;
        }
        public static clsUser Find(int UserID)
        {
            int PersonID = 0, Permissions = 0;
                bool IsActive = false;
            string Password = "", UserName = "";

            if (claAccessManageUser.FindByIID(UserID, ref PersonID, ref Permissions, ref IsActive, ref UserName,ref Password))
            {
                return new clsUser(UserID, PersonID, Permissions, IsActive, UserName, Password);
            }
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case _Mode.AddUser:
                    {
                        if (_AddUser())
                        {
                            Mode = _Mode.UpdateUser;
                            return true;
                        }
                        else
                            return false;
                    }
                case _Mode.UpdateUser:
                    return UpdateDate();
            }
            return false;
        }
    }
}
