using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace tsdtask.Models;

public class Recipy
{
    [Key]
    public int Id { get; set; }
    
    public int? NumOfLikes { get; set; } = 0;

    public DateTime? Time { get; set; } = DateTime.Now;

    [Required]
    public string? Name { get; set; }
    public string? Difficulty { get; set; }
    [Required]
    public string? Ingredients { get; set; }
    [Required]
    public string? Process { get; set; }
    public string? TipsAndTricks { get; set; }


}

