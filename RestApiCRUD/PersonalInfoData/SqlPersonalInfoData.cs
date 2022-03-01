using RestApiCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiCRUD.PersonalInfoData
{
    public class SqlPersonalInfoData : IPersonalInfoData
    {
        private PersonalInfoContext _personalInfoContext;
        public SqlPersonalInfoData(PersonalInfoContext personalInfoContext)
        {
            _personalInfoContext = personalInfoContext;
        }
        public PersonalInfo AddPersonalInfo(PersonalInfo obj)
        {
            obj.Id = null;
            _personalInfoContext.PersonalInfoList.Add(obj);
            _personalInfoContext.SaveChanges();

            return obj;
        }

        public void DeletePersonalInfo(PersonalInfo obj)
        {
            _personalInfoContext.PersonalInfoList.Remove(obj);
            _personalInfoContext.SaveChanges();
        }

        public PersonalInfo EditPersonalInfo(PersonalInfo obj)
        {
            _personalInfoContext.PersonalInfoList.Update(obj);
            _personalInfoContext.SaveChanges();

            return obj;
        }

        public PersonalInfo GetPersonalInfo(int? id)
        {
            var personalInfo = _personalInfoContext.PersonalInfoList.Find(id);
            return personalInfo;
        }

        public List<PersonalInfo> GetPersonalInfoList()
        {
           return _personalInfoContext.PersonalInfoList.ToList();
        }
    }
}
