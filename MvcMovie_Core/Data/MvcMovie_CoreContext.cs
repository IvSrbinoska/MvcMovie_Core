﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie_Core.Models;

namespace MvcMovie_Core.Models
{
    public class MvcMovie_CoreContext : DbContext
    {
        public MvcMovie_CoreContext (DbContextOptions<MvcMovie_CoreContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie_Core.Models.Movie> Movie { get; set; }
        public DbSet<MvcMovie_Core.Models.MovieSkoro> Film{ get; set; }

    }
}
