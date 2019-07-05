using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL.Casting
{
    class HoursForRequestCasting
    {
        DB db = new DB();
        public HoursForRequestDTO CastToDTO(hoursForRequest h)
        {
            return new HoursForRequestDTO()
            {
                id=h.id,
                requestId=h.requestId,
                fromUTCHour=h.fromUTCHour,
                toUTCHour=h.toUTCHour,
                weekDay=h.weekDay
            };
        }
        public hoursForRequest CastToDAL(HoursForRequestDTO h)
        {
            return new hoursForRequest()
            {
                id = h.id,
                requestId = h.requestId,
                fromUTCHour = h.fromUTCHour,
                toUTCHour = h.toUTCHour,
                weekDay = h.weekDay,
                RequestParameter = db.RequestParameters.Where(a => a.requestId == h.requestId).FirstOrDefault()
            };
        }
    }
}
