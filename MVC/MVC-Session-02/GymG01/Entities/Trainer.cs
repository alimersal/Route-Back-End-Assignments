using GymG01.Entities.Enums;

namespace GymG01.Entities
{
    public class Trainer : GymUser
    {
        public Specialties Specialty { get; set; } 

        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
