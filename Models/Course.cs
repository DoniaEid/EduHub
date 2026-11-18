namespace EduHub.Models
{
    public enum CourseStatus
    {
        Draft,
        Published,
        UnderReview,
        Archived
    }
    public class Course
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public string Language { get; set; }

        public string Level { get; set; }

        public string ImageUrl { get; set; }

        public decimal BasePrice { get; set; }

        public decimal? DiscountPercentage { get; set; }

        public decimal? DiscountPrice { get; set; }

        public string Currency { get; set; }

        public bool IsFree{ get; set; }

        public int CategoryId { get; set; }

        public int SubcategoryId { get; set; }

        public CourseStatus Status { get; set; } = CourseStatus.UnderReview;


        //Navigation Property
        public Category Category { get; set; }

        public Subcategory Subcategory { get; set; }

        public List<LearningOutcome> LearningOutcome { get; set; }

        public List<Coupon> Coupons { get; set; }
    }

}
