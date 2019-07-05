using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Casting
{
    public class RequestParameterCasting
    {
        DB db = new DB();
        public RequestParameterDTO CastToDTO(RequestParameter r)
        {
            return new RequestParameterDTO()
            {
                userId = r.userId,
                wayLearn = r.wayLearn,
                categoryId = r.categoryId,
                subCategoryId = r.subCategoryId,
                duration = r.duration,
                KindLearn = r.kindLearn,
                found = r.found,
                requestId = r.requestId,
                cancel = r.cancel,
                alertTime=r.alertTime
            };
        }
        public RequestParameter CastToDAL(RequestParameterDTO r)
        {
            return new RequestParameter()
            {
                userId = r.userId,
                wayLearn = r.wayLearn,
                categoryId = r.categoryId,
                subCategoryId = r.subCategoryId,
                duration = r.duration,
                kindLearn = r.KindLearn,
                found = r.found,
                requestId = r.requestId,
                cancel = r.cancel,
                SubCategory = db.SubCategories.Where(a => a.subCategoryId == r.subCategoryId).FirstOrDefault(),
                User = db.Users.Where(a => a.userId == r.userId).FirstOrDefault()
            };
        }
    }
}
