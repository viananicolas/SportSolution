using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportSolution.Domain.Abstract;
using SportSolution.Domain.Entities;

namespace SportSolution.Domain.Concrete
{
    public class SportSolutionProductRepository : IProductsRepository
    {
        private SportsSolutionContext context = new SportsSolutionContext();

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
