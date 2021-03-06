﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie_Core.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Naslov")]
        [Required]
        public string Title { get; set; }

        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum na Izdavanje")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Rating { get; set; }
    }
}