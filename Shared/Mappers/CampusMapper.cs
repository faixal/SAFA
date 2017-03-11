using DataAccess;
using Shared.Models;

namespace Shared.Mappers
{
    public static class CampusMapper
    {
        public static CampusModel MapToModel(this Config_Campus source)
        {
            CampusModel model = new CampusModel();
            model.CampusId = source.CampusId;
            model.CampusName = source.CampusName;
            return model;
        }
    }
}
