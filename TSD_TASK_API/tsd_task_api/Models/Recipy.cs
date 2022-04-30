namespace tsd_task_api;
using System.ComponentModel.DataAnnotations;

public class Recipy
{
    [Key]
    public int Id { get; set; }
    
    public int? NumOfLikes { get; set; } = 0;

    public DateTime? Time { get; set; } = DateTime.Now;

    [Required]
    public string? Name { get; set; }
    public string? Difficulty { get; set; } = "Easy";
    [Required]
    public string? Ingredients { get; set; } = "";
    [Required]
    public string? Process { get; set; } = "";
    public string? TipsAndTricks { get; set; }

}

