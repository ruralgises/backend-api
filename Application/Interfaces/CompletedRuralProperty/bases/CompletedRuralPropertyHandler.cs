using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Domain.Entities;

namespace Application.Interfaces.CompletedRuralProperty.bases
{
    public abstract class CompletedRuralPropertyHandler
    {
        public CompletedRuralPropertyHandler? _Next { protected get; set; }

        public abstract Task Handler(RuralPropertyResponse ruralPropertyResponse, RuralProperty ruralProperty, CancellationToken cancellationToken);
    }
}
