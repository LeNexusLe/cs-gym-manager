namespace GymManagement.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive => DateTime.Now <= EndDate;
        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
    }
}