namespace EduHub.Models
{
    public class Subcategory
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        //Navigation Property
        public Category category { get; set; }
        public List<Course> Courses { get; set; }
    }
}
