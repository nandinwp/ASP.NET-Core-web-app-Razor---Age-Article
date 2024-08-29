using Microsoft.EntityFrameworkCore;

namespace AgeArticle.Models
{
    public class SurveyContext : DbContext
    {
        public DbSet<SurveyResponse> surveyResponses { get; set; }
        public SurveyContext(DbContextOptions<SurveyContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure other entities if necessary
        }
    }
}
