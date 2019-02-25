using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public enum Gender { Male, Female };
    public class ClubMember : IComparable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} ({Gender}, {Age} years)";
        }

        public int CompareTo(object obj)
        {
            ClubMember clubmember = (ClubMember)(obj);
            return this.FirstName.CompareTo(clubmember.FirstName);
        }
    }

}

// hej morten, xd. Hilsen Pjæk-tor
//kom i morgen xdxd
// okay x)
//*/ victor du fucker koden over xxxxxxxxxxxdDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
// jeg skal nok gå nu. GL HF ses i morgen