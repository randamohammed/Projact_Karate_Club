using AccessKarateClubPreojact;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinsKarateClubProjacjat
{
    public class clsBussinesManagePeople
    {
        public int PresonID { get; set; }
        public string FirestName { get; set; }
        public string SecoundName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirestName + ' '+SecoundName +' '+ ThirdName + ' '+ LastName; } }
        public string Adress { get; set; }
        public string Emil { get; set; }
        public string PathImage { get; set; }
        public string NatiionalNo { get; set; }
        public int Gander { get; set; }
        public DateTime DateBirth { get; set; }
        public string Phone { get; set; }

        enum _Mode { _AddDate=0,_UpdateDate =1};
        _Mode Mode;

        public clsBussinesManagePeople() 
        {
            this.PresonID = 0;
            this.NatiionalNo = "";
            this.FirestName = "";
            this.SecoundName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Gander = 0;
            this.Emil = "";
            this.Adress = "";
            this.Phone = "";
            this.PathImage = "";

            Mode = _Mode._AddDate;
        }

        public clsBussinesManagePeople(int PresonID,string NatiionalNo, string FirestName, string SecoundName, string ThirdName,
            string LastName, string Phone, string Adress, int Gander, DateTime DateBirth, string PathImage, string Emil)
        {
            this.PresonID = PresonID;
            this.NatiionalNo = NatiionalNo;
            this.FirestName = FirestName;
            this.SecoundName = SecoundName;
            this.ThirdName = ThirdName;
            this.LastName =LastName;
            this.Gander = Gander;
            this.Emil = Emil;
            this.Adress = Adress;
            this.Phone = Phone;
            this.PathImage = PathImage;
            this.DateBirth = DateBirth;
            Mode = _Mode._UpdateDate;
        }

        public static clsBussinesManagePeople Find(int PeopleID)
        {
            string NatiionalNo = "", FirestName = "", SecoundName = "", ThirdName = "", LastName = "",
                Phone = "", Adress = "", PathImage ="", Emil  ="";
            int Gender = 0;
            DateTime DateBirth = DateTime.Now;

            if (clsAccessManagePeople.FindPopleByID(PeopleID, ref NatiionalNo, ref FirestName, ref SecoundName, ref ThirdName,
              ref LastName, ref Phone, ref Adress, ref Gender,ref DateBirth,ref PathImage,ref Emil))
            {
                return new clsBussinesManagePeople(PeopleID, NatiionalNo, FirestName, SecoundName, ThirdName, LastName,
                    Phone, Adress, Gender, DateBirth, PathImage, Emil);
            }
            else
               return null;
        }


        public static clsBussinesManagePeople FindByNatonalNo(string NatiionalNo)
        {
            string   FirestName = "", SecoundName = "", ThirdName = "", LastName = "",
                Phone = "", Adress = "", PathImage = "", Emil = "";
            int Gender = 0, PeopleID =0;
            DateTime DateBirth = DateTime.Now;

            if (clsAccessManagePeople.FindPopleByNatationNo(ref PeopleID,  NatiionalNo, ref FirestName, ref SecoundName, ref ThirdName,
              ref LastName, ref Phone, ref Adress, ref Gender, ref DateBirth, ref PathImage, ref Emil))
            {
                return new clsBussinesManagePeople(PeopleID, NatiionalNo, FirestName, SecoundName, ThirdName, LastName,
                    Phone, Adress, Gender, DateBirth, PathImage, Emil);
            }
            else
                return null;
        }

        public static DataTable GetallPeopleInSystem()
        {
            return clsAccessManagePeople.LastAllPeople();
        }

        public static bool DelectPeople(int personid)
        {
            return clsAccessManagePeople.DelectPeople(personid);
        }
        private bool _AddNew()
        {
            this.PresonID = clsAccessManagePeople.AddNewPeopleInSysetem(this.NatiionalNo, this.FirestName, this.SecoundName,
                this.ThirdName, this.LastName, this.Phone, this.Adress,this.Gander, this.DateBirth, this.PathImage, this.Emil);

            return (this.PresonID > -1);
        }

        private bool _Update()
        {
          return  clsAccessManagePeople.Updatedate(this.PresonID,this.NatiionalNo, this.FirestName, this.SecoundName,
                this.ThirdName, this.LastName, this.Phone, this.Adress, this.Gander, this.DateBirth, this.PathImage, this.Emil);

        }
        public static DataTable GetFilterDate(string TypeFiilter,string TextFilter)
        {
            return clsAccessManagePeople.FilterDate(TypeFiilter, TextFilter);
        }

        public  bool Save()
        {
            switch(Mode)
            {
                case _Mode._AddDate:
                    {
                        if (_AddNew())
                        {
                            Mode = _Mode._UpdateDate;
                            return true;
                        }
                        else
                            return false;
                    }
                case _Mode._UpdateDate:
                    return _Update();
            }
            return false;
        }
       
    }
}
