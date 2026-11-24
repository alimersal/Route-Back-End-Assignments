namespace GymG01.Entities
{
    public class GymUser : BaseEntity
    {
        public string Name { get; set; } = default!;
        public int Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; }

        public string Gender { get; set; } 

        public Address Address { get; set; } = default!; // street, country, building number




    }
}
