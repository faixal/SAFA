using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DataAccess;
using Shared.Mappers;
using Shared.Models;

namespace StaffAttendanceFixApp.Api
{
    public class CampusApiController : ApiController
    {
        private readonly StaffAttendanceEntities _db;

        public CampusApiController()
        {
            _db = new StaffAttendanceEntities();
        }

        public IEnumerable<CampusModel> Get()
        {
            var allCampuses = _db.Config_Campus.ToList();

            var mappedCampuses = allCampuses.Select(x => x.MapToModel());

            return mappedCampuses;
        }
    }
}
