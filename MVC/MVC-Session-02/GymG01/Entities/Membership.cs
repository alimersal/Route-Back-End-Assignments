using System.ComponentModel.DataAnnotations.Schema;

namespace GymG01.Entities
{
    public class Membership : BaseEntity
    {
        public int MemberId { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; } 
        public Member member { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [NotMapped]

        public string status => StartDate > DateTime.Now ? "Upcoming" 
                                : EndDate < DateTime.Now ? "Active"
                                : "Expired"; 

        public ICollection<Membership> memberships { get; set; }
    }
}
