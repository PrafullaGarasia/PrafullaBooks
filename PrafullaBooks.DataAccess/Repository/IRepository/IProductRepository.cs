using PrafullaBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PrafullaBooks.DataAccess.Repository.IRepository
{
   public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
