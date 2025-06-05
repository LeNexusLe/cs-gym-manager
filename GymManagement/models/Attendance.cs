namespace GymManagement.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
    }
}