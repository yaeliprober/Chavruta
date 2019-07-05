using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class RequestParameterDTO
    {
        public int requestId { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<bool> wayLearn { get; set; }
        public Nullable<int> categoryId { get; set; }
        public Nullable<int> subCategoryId { get; set; }
        public Nullable<int> duration { get; set; }
        public Nullable<bool> KindLearn { get; set; }
        public Nullable<bool> found { get; set; }
        public Nullable<bool> cancel { get; set; }
        public string alertTime { get; set; }
    }
}
