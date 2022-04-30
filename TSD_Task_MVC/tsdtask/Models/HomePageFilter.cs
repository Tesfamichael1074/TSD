using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace tsdtask.Models;

public class HomePageFilter
{
    
    public Recipy? Details { get; set; }
    public string? DetailsToView { get; set; }
    public List<Recipy>? Recipies { get; set; }
    public string? Search { get; set; }


}

