using DataAccess;
using Shared.Models;

namespace Shared.Mappers
{
    public static class StatusReasonMapper
    {
        public static StatusReasonModel MapToModel(this SYS_Attendance_Status_Reason source)
        {
            StatusReasonModel model = new StatusReasonModel();
            model.ReasonId = source.ReasonId;
            model.ReasonName = source.ReasonName;
            return model;
        }
    }
}
