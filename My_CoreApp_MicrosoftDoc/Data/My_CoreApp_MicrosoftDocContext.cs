using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using My_CoreApp_MicrosoftDoc.Models;

namespace My_CoreApp_MicrosoftDoc.Data
{
    public class My_CoreApp_MicrosoftDocContext : DbContext
    {
        public My_CoreApp_MicrosoftDocContext (DbContextOptions<My_CoreApp_MicrosoftDocContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
