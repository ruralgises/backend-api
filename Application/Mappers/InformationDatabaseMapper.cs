using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                IsOfficial = information.IsOfficial,
            };
        }
    }
}
