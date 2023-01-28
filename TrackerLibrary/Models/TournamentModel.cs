using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TrackerLibrary.Models 
{
    /// <summary>
    /// Represents one tournament, with all of the rounds, matchups, prizes
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// the name given to this tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// the smount of money eatch team needs to put to enter
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// the set of teams that have entered
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// the list of prizes for the places
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// the matchups per round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();  
    }
}
