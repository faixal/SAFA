using DataAccess;
using Shared.Models;

namespace Shared.Mappers
{
    public static class TeacherMapper
    {
        public static TeacherModel MapToModel(this TR_Teachers source)
        {
            TeacherModel teacherModel = new TeacherModel();
            teacherModel.TeacherId = source.TeacherId;
            teacherModel.TeacherName = source.FirstName + " " + source.LastName;
            return teacherModel;
        }
    }
}
