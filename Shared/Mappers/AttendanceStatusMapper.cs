using DataAccess;
using Shared.Models;

namespace Shared.Mappers
{
    public static class AttendanceStatusMapper
    {
        public static AttendanceStatusModel MapToModel(this SYS_Attendance_Status source)
        {
            AttendanceStatusModel model = new AttendanceStatusModel();
            model.AttendanceStatusId = source.AttendanceStatusId;
            model.Name = source.Name;
            return model;
        }
    }
}
