using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Garage2._0G6.Services
{
    public interface IPropertiesSelectListService
    {
        Task<IEnumerable<SelectListItem>> GetColumnsAsync();
    }
}