using NewsApp.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsApp.Articles
{
    public class CreateUpdateArticleDto
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(600)]
        public string Description { get; set; }
        
        [Required]
        public string Content { get; set; }

        [Required]
        [StringLength(100)]
        public string Url { get; set; }

        [Required]
        [StringLength(100)]
        public string UrlToImage { get; set; }

        [Required]
        public IdiomEnum Idiom { get; set; }

    }
}
