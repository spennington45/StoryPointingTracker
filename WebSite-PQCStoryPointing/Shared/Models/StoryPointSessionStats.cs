namespace PQCStoryPointing.Shared.Models
{
    public class StoryPointSessionStats
    {
        public int StoryPointSessionStatsId { get; set; }

        public DateTime SessionDTM { get; set; }

        public int StoriesPointed => Data.Count;

        public int CorrectlyPointedStories => Data.Count(d => d.IsCorrect);

        public double CorrectlyPointedPercent => Math.Round((((double)CorrectlyPointedStories / (double)StoriesPointed) * 100), 2);

        public List<StoryPointData> Data { get; set; } = new List<StoryPointData>();

        public double AverageDistanceFromCorrect => Data.Average(d => d.OffBy);
    }
}
