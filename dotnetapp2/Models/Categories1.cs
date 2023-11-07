using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp2.Models
{
    public class Category1
    {
        [Key]
        public int Id{get;set;}

        [Required]
        [DisplayName("Category Name")]
        public string Name {get;set;} 

        [DisplayName("Display Order")]
        public int DisplayOrder{get;set;}

    }
}