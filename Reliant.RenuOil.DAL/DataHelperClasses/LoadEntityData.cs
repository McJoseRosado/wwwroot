using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using Reliant.RenuOil.DAL.EntityClasses;

namespace Reliant.RenuOil.DAL.DataHelperClasses
{
    public class LoadEntityData
    {
        public int LoadId { get; set; }

        public string Date { get; set; }

        public int? LoadNumber { get; set; }

        public string EmployeeName { get; set; }

        public bool IsActive { get; set; }

        public int EmployeeId { get; set; }

        public static LoadEntityData LoadEntityToData(LoadEntity entity)
        {
            var data = new LoadEntityData();

            data.LoadId = entity.LoadId;
            data.LoadNumber = entity.LoadNumber;
            data.EmployeeId = entity.EmployeeId;
            data.EmployeeName = entity.Employee.FullName;
            data.Date = entity.Date.ToString("MM/dd/yyyy");
            data.IsActive = entity.IsActive;

            return data;
        }
    }
}
