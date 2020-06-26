﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace National_Park_Blog.Models
{
    public class National_Parks
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Blog_Content> BlogContent { get; set; }

        public National_Parks()
        {

        }
        public National_Parks(string name, int id, string description, string image, string location)
        {
            Name = name;
            Id = id;
            Description = description;
            Image = image;
            Location = location;
        }
    }
}

