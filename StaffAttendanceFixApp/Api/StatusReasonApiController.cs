using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DataAccess;
using Shared.Mappers;
using Shared.Models;

namespace StaffAttendanceFixApp.Api
{
    public class StatusReasonApiController : ApiController
    {
        private readonly StaffAttendanceEntities _db;

        public StatusReasonApiController()
        {
            _db = new StaffAttendanceEntities();
        }

        public IEnumerable<StatusReasonModel> Get()
        {
            var allReasons = _db.SYS_Attendance_Status_Reason.ToList();

            var mappedReasons = allReasons.Select(x => x.MapToModel()).Where(x => !string.IsNullOrEmpty(x.ReasonName));

            return mappedReasons;
        }
    }
}
