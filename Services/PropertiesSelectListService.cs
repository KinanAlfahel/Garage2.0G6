using Garage2._0G6.Data;
using Garage2._0G6.Models;
using Garage2._0G6.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Garage2._0G6.Services
{
    public class PropertiesSelectListService
    {
        private readonly Garage2_0G6Context db;

        public PropertiesSelectListService(Garage2_0G6Context db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<SelectListItem>> GetColumnsAsync()
        {
           // typeof(Vehicle).GetProperties().Where(p => p.GetCustomAttribute(typeof(DisplayNameAttribute)) != null)
 
            var t =  typeof(VehicleViewModel).GetProperties()//.Select(c => c.Name)
                .Select(n => new SelectListItem 
                { 
                   Text =    n.GetCustomAttribute<DisplayNameAttribute>() is null ? n.Name : n.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName,
                   Value =   n.Name.ToString()
                });

            return t;
            // should be names of columns

            //SelectList yearSelectList = new SelectList(props, "Id", "Description");

            //return yearSelectList; // todo await... 


        }

    }
}
