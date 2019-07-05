using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Casting
{
    public class SubCategoryCasting
    {
        DB db = new DB();
        public SubCategoryDTO CastToDTO(SubCategory s)
        {
            return new SubCategoryDTO()
            {
                subCategoryId = s.subCategoryId,
                subCategoyName = s.subCategoyName,
                categoryId = s.categoryId
            };
        }
        public SubCategory CastToDAL(SubCategoryDTO s)
        {
            return new SubCategory()
            {
                subCategoryId = s.subCategoryId,
                subCategoyName = s.subCategoyName,
                Category = db.Categories.Where(a => a.categoryId == s.categoryId).FirstOrDefault(),
            };
        }
    }
}
