using AccessKarateClubPreojact;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBussinsKarateClubProjacjat
{
    public class clsBeltRanks
    {
      //  public int RankID { get; set; }
        public string RankName { get; set; }
        public int TestFees { get; set; }

        public enum enMode { Add=0,Update =1};
       public enMode Mode;

        public enum enBeltRank
        {
            WhiteBelt = 1, BlueBelt = 2, YellowBelt = 3, OrangeBelt = 4, GreenBelt = 5, PurpleBelt = 6,
            BrownBelt = 7, BlackBelt1stDan = 8, BlackBelt2sDan = 9, BlackBel3stDan = 10, BlackBelt4stDan = 11,
            BlackBelt5stDan = 12, BlackBelt6stDan = 13, BlackBelt7stDan = 14, BlackBelt8stDan = 15, BlackBelt9stDan = 16, BlackBelt10stDan = 17
        };
        public clsBeltRanks.enBeltRank RankID
        {
            get; set;
        }
        public clsBeltRanks(clsBeltRanks.enBeltRank RankID, string RankName,int TestFees)
        {
            this.RankID = RankID;
            this.RankName = RankName;
            this.TestFees = TestFees;
            Mode = enMode.Update;
        }

        public clsBeltRanks()
        {
            this.RankID = 0;
            this.RankName = "";
            this.TestFees = 0;
            Mode = enMode.Add;
        }

        public static clsBeltRanks Find(clsBeltRanks.enBeltRank RankID)
        {
            string RankName= "";
            int TestFees = 0;

            bool ISFound = false;

            ISFound = clsBeltRanksData.FindBtID((int)RankID,ref RankName,ref TestFees);
            if(ISFound)
                return new clsBeltRanks(RankID,RankName,TestFees);
            else
                return null;
        }

        public static clsBeltRanks FindByName(string RankName)
        {
            int RankID = 0;
            int TestFees = 0;

            bool ISFound = false;

            ISFound = clsBeltRanksData.FindBtByName(ref RankID,  RankName, ref TestFees);
            if (ISFound)
                return new clsBeltRanks((clsBeltRanks.enBeltRank)RankID, RankName, TestFees);
            else
                return null;

        }

        private bool _AddRank()
        {
            this.RankID =(clsBeltRanks.enBeltRank) clsBeltRanksData.AddNewRank(this.RankName, this.TestFees);
            return this.TestFees != 0;
        }

        private bool _UpdateRank() 
            {
                return clsBeltRanksData.UpdateRank((int)this.RankID, this.RankName, this.TestFees);
            }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    {
                        if(_AddRank())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                    case enMode.Update:
                    return _UpdateRank();
            }
            return false;
        }
            public static DataTable GetAllRank()
            {
                return clsBeltRanksData.GetAllBeltRanks();
            }
        
    }
}
