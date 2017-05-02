using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reliant.RenuOil.DAL.EntityClasses
{
    partial class AccountEntity
    {
        public string LastServiceDate
        {
            get
            {
                if (this.WorkOrder.Count() > 0)
                {
                    return this.WorkOrder.Max(w => w.AppointmentDate).ToString("MM/dd/yyyy");
                }
                return "None";
            }
        }
    }
}
