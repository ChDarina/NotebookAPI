using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NotebookAPI.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }

}