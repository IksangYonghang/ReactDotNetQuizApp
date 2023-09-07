using Microsoft.EntityFrameworkCore;
using QuizAPI.Models;

namespace QuizAPI
{
	public class QuizDbContext : DbContext
	{
		public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
		{
		}
        
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Question>()
				.ToTable("questions", schema: "quiz");
			modelBuilder.Entity<Participant>()
				.ToTable("participants", schema: "quiz");
		}
        
		public DbSet<QuizAPI.Models.Question> Question { get; set; } = default!;
        
		public DbSet<QuizAPI.Models.Participant> Participant { get; set; } = default!;
        
		
	}
}
