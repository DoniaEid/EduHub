namespace EduHub.Models
{
    public class Category
    {

        public int Id { get; set; }

        public string Name { get; set; }


        //Navigation Property

        public List<Course> Courses { get; set; }

        public List<Subcategory> Subcategories{ get; set; }
    }
}
