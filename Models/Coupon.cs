namespace EduHub.Models
{
    public class Coupon
    {

        public int Id { get; set; }

        public string Code { get; set; }

        public decimal DiscountPercentage { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public DateTime ExpiryDate { get; set; }

        public bool IsActive { get; set; }


    }
}
