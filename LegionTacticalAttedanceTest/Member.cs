using System;

namespace LegionTacticalAttendance {
    
    public class Member
    {
        private string memberName;
        private System.DateTime memberLastAttended;
        private int totalMatchesAttended;
        private string rank;

        public string MemberName 
        {
            get { return this.memberName; }
            set { this.memberName = value; }
        }

        public int TotalMatchesAttended
        {
            get { return this.totalMatchesAttended; }
            set { this.totalMatchesAttended = value; }
        }

        public System.DateTime MemberLastAttended
        {
            get { return this.memberLastAttended; }
            set { this.memberLastAttended = value; }
        }

        public string Rank
        {
            get { return this.rank; }
            set { this.rank = value; }
        }
        
    }

}
