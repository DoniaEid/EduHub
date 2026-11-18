namespace EduHub.Models
{
    public class LearningOutcome
    {


        public int Id { get; set; }

        public string Description { get; set; }

        public int CourseId { get; set; }

        //Navigation Property
        public Course Course { get; set; }

    }
}
