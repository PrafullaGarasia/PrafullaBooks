using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PrafullaBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }

        ISP_Call SP_Call { get; }
       

        void Save();
    }
}
