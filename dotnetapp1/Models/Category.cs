using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp1.Models
{
    public class Category
    {
        [Key]
        public int Id{get;set;}

        [Required]
        public string Name{get;set;}

        public int DisplayOrder{get;set;}

    }
}