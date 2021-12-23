using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        [DisplayName("Image Name")]
        public string Photo { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
