using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface ICategoryRepository
    {
        Task<BaseEntityResponse<Category>> ListCategories(BaseFiltersRequest filters);
        Task<IEnumerable<Category>> ListSelectCategories();
        Task<Category> CategoryById(int CategoryId);
        Task<bool> RegisterCategory(Category category);
        Task<bool> EditCategory(Category category);
        Task<bool> RemoveCategory(int CategoryId);
    }
}
