using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnbhoardingTask.Models;

public partial class Customer
{
    public int Id { get; set; }
    [Required]
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
