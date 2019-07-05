using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL.Casting
{
   public class LanguagesCasting
    {
        public LanguagesDTO CastToDTO(Language l)
        {
            return new LanguagesDTO()
            {
                languageId = l.languageId,
                name = l.name
            };
        }
        public Language CastToDAL(LanguagesDTO l)
        {
            return new Language()
            {
                languageId = l.languageId,
                name = l.name
            };
        }
    }
}
