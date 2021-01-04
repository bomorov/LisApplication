using Application.Common.DTOs;
using Domain.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IAccessRightService
    {
        Task<List<DictEntityDto>> GetAccessRightsName();

        Task<bool> IsAllowed(string accessName, AccessRigthsType accessRigth);
    }
}