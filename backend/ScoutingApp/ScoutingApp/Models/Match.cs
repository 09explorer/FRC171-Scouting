using ScoutingApp.Models.MatchEnums;

namespace ScoutingApp.Models
{
    public class Match
    {
        public int Id { get; set; }

        public MatchEnums.MatchType Type { get; set; }

        public MatchEnums.MatchType Alliance { get; set; }
  
    }
}
