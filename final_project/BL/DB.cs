using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    class DB
    {
        RivkiS_YaeliPEntities1 db = new RivkiS_YaeliPEntities1();
        public DB()
        { }
        private List<Category> categories = null;
        public List<Category> Categories
        {
            get
            {
                if (this.categories == null)
                    this.categories = db.Categories.ToList();
                return this.categories;
            }
        }


        private List<Language> languages = null;
        public List<Language> Languages
        {
            get
            {
                if (this.languages == null)
                    this.languages = db.Languages.ToList();
                return this.languages;
            }
        }


        private List<Partner> partners = null;
        public List<Partner> Partners
        {
            get
            {
                if (this.partners == null)
                    this.partners = db.Partners.ToList();
                return this.partners;
            }
        }


        private List<RequestParameter> requestParameters = null;
        public List<RequestParameter> RequestParameters
        {
            get
        
            {
                if (this.requestParameters == null)
                    this.requestParameters = db.RequestParameters.ToList();
                return this.requestParameters;
            }
        }


        private List<Status> statuses = null;
        public List<Status> Statuses
        {
            get
            {
                if (this.statuses == null)
                    this.statuses = db.Status.ToList();
                return this.statuses;
            }
        }


        private List<SubCategory> subCategories = null;
        public List<SubCategory> SubCategories
        {
            get
            {
                if (this.subCategories == null)
                    this.subCategories = db.SubCategories.ToList();
                return this.subCategories;
            }
        }


        private List<User> users = null;
        public List<User> Users
        {
            get
            {
                if (this.users == null)
                    this.users = db.Users.ToList();
                return this.users;
            }
        }


        private List<UserLanguage> userLanguages = null;
        public List<UserLanguage> UserLanguage
        {
            get
            {
                if (this.userLanguages == null)
                    this.userLanguages = db.UserLanguages.ToList();
                return this.userLanguages;
            }
        }


        private List<hoursForRequest> hoursForRequests = null;
        public List<hoursForRequest> HoursForRequests
        {
            get
            {
                if (this.hoursForRequests == null)
                    this.hoursForRequests = db.hoursForRequests.ToList();
                return this.hoursForRequests;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
