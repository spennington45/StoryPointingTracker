namespace PQCStoryPointing.Shared.Models
{
    public class OverallUserStats
    {
        public int OverallUserStatsId { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public List<StoryPointSessionStats> SessionStats { get; set; }

        public int PointingSessions => SessionStats.Count;

        public int TotalStoriesPointed => SessionStats.Sum(ss => ss.StoriesPointed);

        public int CorrectlyPointedStories => SessionStats.Sum(ss => ss.CorrectlyPointedStories);

        public double CorrectlyPointedPercent => Math.Round((((double)CorrectlyPointedStories / (double)TotalStoriesPointed) * 100), 2);

        public double AverageDistanceFromCorrect => SessionStats.Select(ss => ss.AverageDistanceFromCorrect).Average();
    }
}
