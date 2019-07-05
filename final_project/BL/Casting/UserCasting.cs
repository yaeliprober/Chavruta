using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Casting
{
    public class UserCasting
    {
        public UserDTO CastToDTO(User u)
        {
            return new UserDTO()
            {
                userId = u.userId,
                userCity = u.userCity,
                userCountry = u.userCountry,
                userSt = u.userSt,
                userName = u.userName,
                userMail = u.userMail,
                userPassword = u.userPassword,
                language = (int)u.language,
            };
        }
        public User CastToDAL(UserDTO u)
        {
            return new User()
            {
                userId = u.userId,
                language = u.language,
                userCity = u.userCity,
                userCountry = u.userCountry,
                userSt = u.userSt,
                userName = u.userName,
                userMail = u.userMail,
                userPassword = u.userPassword,
            };
        }

    }
}