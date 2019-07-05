using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class SubCategoryDTO
    {
        public int subCategoryId { get; set; }
        public Nullable<int> categoryId { get; set; }
        public string subCategoyName { get; set; }              
    }
}
