using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportSolution.Domain.Entities;

namespace SportSolution.Domain.Concrete
{
    public class SportsSolutionContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
