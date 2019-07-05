using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Casting;
namespace BLL
{
    public class RequestLogic
    {
        DB db = new DB();
        private SubCategoryCasting subCategoryCasting = new SubCategoryCasting();
        private CategoryCasting categoryCasting = new CategoryCasting();
        private LanguagesCasting languagesCasting = new LanguagesCasting();
        private UserLanguagesCasting userLanguagesCasting = new UserLanguagesCasting();
        private HoursForRequestCasting hoursForRequestCasting = new HoursForRequestCasting();
        public RequestResult GetCategory()
        {
            try
            {
                return new RequestResult { Data = db.Categories.Select(Category => categoryCasting.CastToDTO(Category)).ToList(), Status = true };
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = false,
                    Status = false,
                    Message = "שגיאה זמנית במערכת, אנא נסו מאוחר יותר."
                };
            }
        }//מחזירה את רשימת הנושאים
        public RequestResult GetSub(int catId)//מחזירה רשימה של כל התת נושאים של הנושא שהתקבל
        {
            try
            {
                List<SubCategory> subs = new List<SubCategory>();
                subs = db.SubCategories.Where(a => a.categoryId == catId).ToList();
                return new RequestResult { Data = subs.Select(sub => subCategoryCasting.CastToDTO(sub)).ToList(), Status = true };
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = false,
                    Status = false,
                    Message = "שגיאה זמנית במערכת, אנא נסו מאוחר יותר."
                };
            }
        }
        public RequestResult GetLAngs()
        {
            try
            {
                return new RequestResult { Data = db.Languages.Select(Language => languagesCasting.CastToDTO(Language)).ToList(), Status = true };
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = false,
                    Status = false,
                    Message = "שגיאה זמנית במערכת, אנא נסו מאוחר יותר."
                };
            }
        }//מחזירה את רשימת השפות
        public RequestResult GetId(string email)//מחזירה את המספר המזהה של המשתמש לפי מייל
        {
            try
            {
                User u = db.Users.Where(a => a.userMail == email).FirstOrDefault();
                return new RequestResult { Data = u.userId, Status = true };
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = false,
                    Status = false,
                    Message = "שגיאה זמנית במערכת, אנא נסו מאוחר יותר."
                };
            }
        }
        public RequestResult AddRequest(RequestParameterDTO req)
        {
            try
            {
                db.RequestParameters.Add(new RequestParameterCasting().CastToDAL(req));
                db.Save();
                return new RequestResult { Data = true, Status = true };
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = false,
                    Status = false,
                    Message = "שגיאה זמנית במערכת, אנא נסו מאוחר יותר."
                };
            }
        }//מוסיפה בקשה לטבלת בקשות
        public RequestResult AddUL(List<UserLanguagesDTO> ules)
        {
            try
            {
                foreach (var item in ules)
                {
                    db.UserLanguage.Add(userLanguagesCasting.CastToDAL(item));
                }
                db.Save();
                return new RequestResult { Data = true, Status = true };
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = false,
                    Status = false,
                    Message = "שגיאה זמנית במערכת, אנא נסו מאוחר יותר."
                };
            }
        }//מוסיפה שורות לטבלת שפות למשתמש עפ"י רשימה מסוג שפות למשתמש שמקבלת
        public RequestResult AddHR(List<HoursForRequestDTO> hres)//מוסיפה שורות לטבלת שעות למשתמש עפ"י רשימה מסוג שעות למשתמש שמקבלת 
        {
            try
            {
                foreach (var item in hres)
                {
                    db.HoursForRequests.Add(hoursForRequestCasting.CastToDAL(item));
                }
                db.Save();
                return new RequestResult { Data = true, Status = true };
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = false,
                    Status = false,
                    Message = "שגיאה זמנית במערכת, אנא נסו מאוחר יותר."
                };
            }
        }

    }
}
