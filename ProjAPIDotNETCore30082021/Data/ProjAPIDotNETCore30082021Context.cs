using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAPIDotNETCore30082021.Model;

namespace ProjAPIDotNETCore30082021.Data
{
    public class ProjAPIDotNETCore30082021Context : DbContext
    {
        public ProjAPIDotNETCore30082021Context (DbContextOptions<ProjAPIDotNETCore30082021Context> options)
            : base(options)
        {
        }

        public DbSet<ProjAPIDotNETCore30082021.Model.Person> Person { get; set; }
    }
}
