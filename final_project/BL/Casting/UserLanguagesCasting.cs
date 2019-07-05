using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Casting
{
    public class UserLanguagesCasting
    {
        DB db = new DB();
        public UserLanguagesDTO  CastToDTO(UserLanguage u)
        {
            return new UserLanguagesDTO()
            {
                userId=u.userId,
                ULId=u.ULId,
                languageId=u.languageId
            };
        }
        public UserLanguage CastToDAL(UserLanguagesDTO u)
        {
            return new UserLanguage()
            {
                userId = u.userId,
                ULId = u.ULId,
                languageId = u.languageId,
                Language = db.Languages.Where(p => p.languageId == u.languageId).FirstOrDefault(),
                User = db.Users.Where(p => p.userId == u.userId).FirstOrDefault()
            };
        }
    }

}
