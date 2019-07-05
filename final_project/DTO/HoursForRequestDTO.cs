using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoursForRequestDTO
    {
        public int id { get; set; }
        public Nullable<int> requestId { get; set; }
        public Nullable<System.TimeSpan> fromUTCHour { get; set; }
        public Nullable<System.TimeSpan> toUTCHour { get; set; }
        public Nullable<int> weekDay { get; set; }
    }
}
