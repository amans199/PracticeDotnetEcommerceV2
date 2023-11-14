using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

public interface IProductRepository
{
    Task<List<Product>> GetProductAsync(int productId);
}