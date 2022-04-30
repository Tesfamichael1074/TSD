using Microsoft.EntityFrameworkCore;
using tsdtask.Models;

public class ApplicationDbContext:DbContext 
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
	{
	}
	public DbSet<tsdtask.Models.Recipy> Recipy { get; set; }


}



