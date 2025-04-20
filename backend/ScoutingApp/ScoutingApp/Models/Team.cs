namespace ScoutingApp.Models
{
    public class Team
    {
        public required String Name { get; set; }

        public int Id { get; set; }

        public bool IsPick {  get; set; }

        public int AvgAutoScore { get; set; }

        public required String PrefSide { get; set; }
    }
}
