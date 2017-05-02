using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reliant.RenuOil.DAL.EntityClasses;

namespace Reliant.RenuOil.DAL.DataHelperClasses
{
    public class RecycleTypeEntityData
    {
        public int RecycleTypeId { get; set; }
        public string Name { get; set; }

        public static RecycleTypeEntityData RecycleTypeEntityToData(RecycleTypeEntity entity)
        {
            var data = new RecycleTypeEntityData();

            data.RecycleTypeId = entity.RecycleTypeId;
            data.Name = entity.Name;

            return data;
        }
    }
}
