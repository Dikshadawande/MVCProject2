﻿namespace MVCProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Product Product { get; set; }    
     }


}