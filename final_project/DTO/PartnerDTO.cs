using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class PartnerDTO
    {
        public int partnerId { get; set; }
        public Nullable<int> req1 { get; set; }
        public Nullable<int> req2 { get; set; }
        public Nullable<int> statusId { get; set; }
    }
}
