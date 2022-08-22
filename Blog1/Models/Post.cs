﻿using Blog1.Models.Comments;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blog1.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public string Image { get; set; } = "";

        public string Descriptions { get; set; } = "";
        public string Tags { get; set; } = "";
        public string Category { get; set; } = "";

        public DateTime Created { get; set; } = DateTime.Now;

        public List<MainComment> MainComments { get; set; }
    }
}
