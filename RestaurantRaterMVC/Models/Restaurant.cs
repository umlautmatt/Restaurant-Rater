using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRaterMVC.Models
{
    public class Restaurant
    {
        [Display(Name = "Restaurant ID")]
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }


    }

    public class RestaurantDBContext : DbContext //DbContext is a snapshot of database
    {
        public DbSet<Restaurant> Restaurants { get; set; } //DbSet creates the table for the database
    }

}