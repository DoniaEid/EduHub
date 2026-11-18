
namespace EduHub.ApplicationDBContext.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.DiscountPrice)
                .HasComputedColumnSql(
                    "[BasePrice] * (100 - ISNULL([DiscountPercentage], 0)) / 100",
                    stored: true
                );


            //RelationShip
            builder.HasOne(c => c.Category)
                   .WithMany(ca => ca.Courses)
                   .HasForeignKey(x => x.CategoryId);

            builder.HasMany(c => c.LearningOutcome)
                   .WithOne(L => L.Course)
                   .HasForeignKey(x => x.CourseId);

            builder.HasMany(c => c.Coupons)
                   .WithOne(Cu => Cu.Course)
                   .HasForeignKey(x => x.CourseId);

            builder.HasOne(c => c.Subcategory)
                   .WithMany(S => S.Courses)
                   .HasForeignKey(x => x.SubcategoryId);



        }




    }
}