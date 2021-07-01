using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB456.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecture { get; set; }
        [Required]
        public String LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public String Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
        
    }
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}