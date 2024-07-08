using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntry
    {
        public TeamModel TeamCompiting {  get; set; }
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }

    }
}
