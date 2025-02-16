using Application.DTOs.Response;
using Domain.Entities;

namespace Application.Mappers
{
    public static class InformationDatabaseMapper
    {
        public static InformationDatabaseResponse? ToResponse(InformationDatabase information)
        {
            if(information == null) return null;

            return new InformationDatabaseResponse()
            {
                LastUpdate = information.LastUpdate,
                DatabaseName = information.DatabaseName,
                IsGovernmental = information.IsGovernmental,
            };
        }
    }
}
