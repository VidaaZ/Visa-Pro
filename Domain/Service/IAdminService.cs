using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public interface IAdminService
    {
        Task<bool> CreateAdminAsync(AdminRequestDto dto);
    }
}
