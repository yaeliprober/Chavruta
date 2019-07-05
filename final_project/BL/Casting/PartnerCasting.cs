using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Casting
{
    public class PartnerCasting
    {
        DB db = new DB();
        public PartnerDTO CastToDTO(Partner a)
        {
            return new PartnerDTO()
            {
                partnerId = a.partnerId,
                req2 = a.req2,
                statusId = a.statusId,
                req1 = a.req1
            };
        }
        public Partner CastToDAL(PartnerDTO a)
        {
            return new Partner()
            {
                partnerId = a.partnerId,
                req2 = a.req2,
                statusId = a.statusId,
                req1 = a.req1,
                RequestParameter = db.RequestParameters.Where(p => p.requestId == a.req1).FirstOrDefault(),
                RequestParameter1 = db.RequestParameters.Where(p => p.requestId == a.req2).FirstOrDefault(),
                Status = db.Status.Where(p => p.statusId == a.statusId).FirstOrDefault()
            };
        }
    }
}
