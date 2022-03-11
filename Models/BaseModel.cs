﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VideoTravel.Models;

[Index(nameof(Slug), IsUnique = true)]
public abstract class BaseModel
{
    [Key] public virtual long Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(255)")]
    public string Slug { get; set; } = null!;

    [Required]
    [Column(TypeName = "varchar(255)")]
    public string Name { get; set; } = null!;


    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}