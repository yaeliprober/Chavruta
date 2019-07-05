using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL.Casting
{
    public class StatusCasting
    {
        public StatusDTO CastToDTO(Status s)
        {
            return new StatusDTO()
            {
                statusId=s.statusId,
                statusValue=s.statusValue
            };
        }
        public Status CastToDAL(StatusDTO s)
        {
            return new Status()
            {
                statusId = s.statusId,
                statusValue = s.statusValue,
            };
            
        }
    }
}
