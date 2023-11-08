namespace PQCStoryPointing.Shared.Models
{
    public class StoryPointData
    {
        public int StoryPointDataId { get; set; }

        public DateTime Date { get; set; }

        public int StoryId { get; set; }

        public double Estimated { get; set; }

        public double Actual { get; set; }

        public bool IsCorrect => Estimated == Actual;

        public double OffBy => Math.Abs(Estimated - Actual);
    }
}
