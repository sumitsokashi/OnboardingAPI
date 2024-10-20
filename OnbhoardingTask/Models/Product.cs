using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnbhoardingTask.Models;

public partial class Product
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    [Required]
    public decimal? Price { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
