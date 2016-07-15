namespace Strzelnica
{
    public class Player : Person
    {
        public string Nick { get; set; }
        public int[] Month { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int TotalScore { get; set; } = 0;
        public int TotalScorePercentage { get; set; } = 0;
    }
}
