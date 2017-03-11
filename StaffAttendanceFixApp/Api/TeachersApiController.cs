using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DataAccess;
using Shared.Mappers;
using Shared.Models;

namespace StaffAttendanceFixApp.Api
{
    public class TeachersApiController : ApiController
    {
        private readonly StaffAttendanceEntities _db;

        public TeachersApiController()
        {
            _db = new StaffAttendanceEntities();
        }

        public IEnumerable<TeacherModel> Get(int campusId)
        {
            var allTeachers = _db.TR_Teachers.Where(x => x.CampusId == campusId && x.IsActive == true && (x.MobileNumber != "111" || x.MobileNumber == "")).ToList();

            var mappedTeachers = allTeachers.Select(x => x.MapToModel()).OrderBy(x=>x.TeacherName);

            return mappedTeachers;
        }
    }
}
