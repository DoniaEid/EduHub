
namespace EduHub.ApplicationDBContext.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            //RelationShip
            builder.HasMany(C => C.Subcategories)
                   .WithOne(S => S.category)
                   .HasForeignKey(x => x.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
