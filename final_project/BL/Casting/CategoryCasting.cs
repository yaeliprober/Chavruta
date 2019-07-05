using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Casting
{
    public class CategoryCasting
    {
        public CategoryDTO CastToDTO(Category c)
        {
            return new CategoryDTO()
            {
                categoryId = c.categoryId,
                categoryName = c.categoryName
            };
        }
        public Category CastToDAL(CategoryDTO c)
        {
            return new Category()
            {
                categoryId = c.categoryId,
                categoryName = c.categoryName
            };
        }
    }
}
