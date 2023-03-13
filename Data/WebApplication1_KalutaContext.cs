using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Kaluta.Models;

namespace WebApplication1_Kaluta.Data
{
    public class WebApplication1_KalutaContext : DbContext
    {
        public WebApplication1_KalutaContext(DbContextOptions<WebApplication1_KalutaContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
        //ghghghghghgh

       public DbSet<subjects> Subjects { get; set; }
        public DbSet<teachers> Teachers { get; set; }
    }
}
