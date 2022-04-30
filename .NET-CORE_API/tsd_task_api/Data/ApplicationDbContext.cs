using Microsoft.EntityFrameworkCore;
using tsd_task_api;

public class ApplicationDbContext:DbContext 
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
	{
	}
	public DbSet<Recipy> Recipy { get; set; }


}



