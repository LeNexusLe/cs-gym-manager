namespace GymManagement.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public List<Membership> Memberships { get; set; } = new();
        public List<Attendance> Attendances { get; set; } = new();
        public List<WorkoutPlan> WorkoutPlans { get; set; } = new();
    }
    
}