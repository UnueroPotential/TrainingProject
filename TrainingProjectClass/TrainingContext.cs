using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingProjectClass.ProjectModels;

namespace TrainingProjectClass
{
    public class TrainingContext : IdentityDbContext
    {
        public DbSet<BioDataTab> BioDataTab { get; set; }
        public DbSet<ApplicationTab> ApplicationTab { get; set; }
        //public DbSet<AccessTab> AccessTab { get; set; }
        public TrainingContext(DbContextOptions<TrainingContext> options)
            : base(options)
        {
        }
    }
}
