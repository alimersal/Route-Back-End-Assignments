namespace GymG01.Entities
{
    public class Session : BaseEntity
    {
        public String Description { get; set; } = default!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int capacity { get; set; }

        public Trainer Trainer { get; set; } = default!;
        public int TrainerId { get; set; } // Foreign key to the Trainer entity 


    }
}
