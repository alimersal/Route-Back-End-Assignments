namespace GymG01.Entities
{
    public class Member : GymUser
    {
        public String? Photo { get; set; } // photo of the member 

        public ICollection<Membership> PlanSubscription { get; set; } = default!; 
    
    }   

}
