﻿namespace Estigo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // Navigation property
        public ICollection<Course> Courses { get; set; }


    }
}
