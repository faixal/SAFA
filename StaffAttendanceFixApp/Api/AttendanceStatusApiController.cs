using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DataAccess;
using Shared.Mappers;
using Shared.Models;

namespace StaffAttendanceFixApp.Api
{
    public class AttendanceStatusApiController : ApiController
    {
        private readonly StaffAttendanceEntities _db;

        public AttendanceStatusApiController()
        {
            _db = new StaffAttendanceEntities();
        }

        public IEnumerable<AttendanceStatusModel> Get()
        {
            var allAttendanceStatus = _db.SYS_Attendance_Status.ToList();

            var mappedAttendanceStatus = allAttendanceStatus.Select(x => x.MapToModel());

            return mappedAttendanceStatus;
        }
    }
}
