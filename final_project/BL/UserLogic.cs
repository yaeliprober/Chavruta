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
   public class UserLogic
    {
        public RequestResult CheckPass(string mail, string pass)//בדיקת סיסמא ראשונית
        {
            try
            {
                DB db = new DB();
                User u = db.Users.Where(a => a.userPassword == pass && a.userMail == mail).FirstOrDefault();
                if (u != null)
                    return new RequestResult { Data = true, Status = true };
                else
                {
                    u = db.Users.Where(a => a.userMail == mail).FirstOrDefault();
                    if (u != null)
                        return new RequestResult { Data = false, Status = true, Message = "!הסיסמא שגויה" };
                }
                return new RequestResult { Data = false, Status = true, Message = "?שם משתמש זה עדיין לא רשום במערכת. האם ברצונך להירשם" };
            }
            catch (Exception ex)
            {
                return new RequestResult { Data = false, Status = false, Message = "שגיאה זמנית בכניסה, אנא נסו מאוחר יותר." };
            }
        }
        public RequestResult ForgotPass(string email)//מקבל סיסמא לפי מייל
        {
            try
            {
                DB db = new DB();
                User u = db.Users.Where(a => a.userMail == email).FirstOrDefault();
                if (u != null)
                {
                    return new RequestResult { Data = u.userPassword, Status = true, Message = "הסיסמא תשלח אליך באמצעות הדואר האלקטרוני בהקדם" };
                    #region(forgot password)
                    //try
                    //{
                    //    //configuring webmail class to send emails  
                    //    //gmail smtp server  
                    //    WebMail.SmtpServer = "smtp.gmail.com";
                    //    //gmail port to send emails  
                    //    WebMail.SmtpPort = 587;
                    //    WebMail.SmtpUseDefaultCredentials = true;
                    //    //sending emails with secure protocol  
                    //    WebMail.EnableSsl = true;
                    //    WebMail.UserName = "secondhandwolfst@gmail.com";
                    //    WebMail.Password = "wolfst4569";
                    //    //sender email address.  
                    //    WebMail.From = "secondhandwolfst@gmail.com";
                    //    //send email 
                    //    users u = DB.users.First(o => o.Neme == user_name);
                    //    string current_user_password = u.PW;
                    //    WebMail.Send(to: "secondhandwolfst@gmail.com", subject: "רבקי ויעלי", body: current_user_password, /*cc: obj.emailcc, bcc: obj.emailbcc*/ isBodyHtml: false);
                    //    ViewBag.status = "email sent successfully.";
                    //}
                    //catch (Exception)
                    //{
                    //    ViewBag.status = "problem while sending email, please check details.";
                    //}
                    //return null;
                    //send u.password
                    #endregion
                }
                return new RequestResult { Data = null, Status = true, Message = "שם משתמש זה לא קיים במערכת" };
            }
            catch (Exception ex)
            {
                return new RequestResult { Data = false, Status = false, Message = "שגיאה זמנית בכניסה, אנא נסו מאוחר יותר." };
            }
        }
        public RequestResult AddUser(UserDTO u)//הוספת משתמש חדש
        {
            try
            {
                DB db = new DB();
                db.Users.Add(new UserCasting().CastToDAL(u));
                db.Save();
                return new RequestResult { Data = true, Status = true };
            }
            catch
            {
                return new RequestResult { Data = false, Status = false, Message = "שגיאה זמנית בכניסה, אנא נסו מאוחר יותר." };
            }
        }
        public RequestResult UpdateUser(UserDTO u)//עדכון משתמש קיים
        {
            try
            {
                DB db = new DB();
                User user = db.Users.Where(a => a.userMail == u.userMail).FirstOrDefault();
                new UserCasting().CastToDAL(u);
                user.userName = u.userName;
                user.userCity = u.userCity;
                user.userCountry = u.userCountry;
                user.userSt = u.userSt;
                db.Save();
                return new RequestResult { Data = true, Status = false, Message = "הפרטים עודכנו בהצלחה" };
            }
            catch
            {
                return new RequestResult { Data = false, Status = false, Message = "שגיאה זמנית בכניסה, אנא נסו מאוחר יותר." };
            }
        }
    }
}
