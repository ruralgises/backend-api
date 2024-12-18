﻿using Application.DTOs.Response;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Enumerations;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class InformationDatabaseService : IInformationDatabaseService
    {
        private IInformationDatabaseRepository _repository { get; init; }

        public InformationDatabaseService(IInformationDatabaseRepository repository)
        {
            _repository = repository;
        }

        public async Task<InformationDatabaseResponse> GetByNameAsync(InformationDatabaseType entity, CancellationToken cancellationToken)
        {
            var result =  await _repository.GetInfo(entity, cancellationToken);

            return InformationDatabaseMapper.ToResponse(result);
        }
    }
}
