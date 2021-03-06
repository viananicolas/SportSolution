﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportSolution.Domain.Entities;

namespace SportSolution.Domain.Abstract
{
    public interface IProductsRepository
    {
        IQueryable<Product> Products { get; }
    }
}
