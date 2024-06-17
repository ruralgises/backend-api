using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ISetUpRuralPropertyFieldService
    {
        void Handle(ref RuralProperty ruralProperty);
    }
}
