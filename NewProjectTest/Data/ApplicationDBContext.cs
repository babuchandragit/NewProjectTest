using Microsoft.EntityFrameworkCore;
using NewProjectTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewProjectTest.Data
{
    public class ApplicationDBContext :DbContext

    {
public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options): base(options)
        {

        }
        public DbSet<Item> CoConversion { get; set; }
    }
}
