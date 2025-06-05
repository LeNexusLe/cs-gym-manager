namespace GymManagement.Models
{
    public class WorkoutPlan
    {
        public int Id { get; set; }
        public string Exercise { get; set; } = string.Empty;
        public int Sets { get; set; }
        public int Reps { get; set; }
        public string DayOfWeek { get; set; } = string.Empty;
        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
    }
}