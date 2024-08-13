﻿using System.ComponentModel.DataAnnotations;

namespace _20240722_AspNetCoreDB.Models
{
    public class Note
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
