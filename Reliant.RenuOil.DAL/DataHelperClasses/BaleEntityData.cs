using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reliant.RenuOil.DAL.EntityClasses;

namespace Reliant.RenuOil.DAL.DataHelperClasses
{
    public class BaleEntityData
    {
        public int? BaleId { get; set; }
        public int? BaleNumber { get; set; }
        public int? DockId { get; set; }
        public int? LoadId { get; set; }
        public int? AccountId { get; set; }
        public int? InitWeight { get; set; }
        public int? RecycleTypeId { get; set; }
        public int? WarehouseWeight { get; set; }
        public int? FinalWeight { get; set; }
        public string Notes { get; set; }

        public string Property { get; set; }
        public string Dock { get; set; }
        public string RecycleType { get; set; }


        public static BaleEntityData BaleEntityToData(BaleEntity entity)
        {
            var data = new BaleEntityData()
            {
                BaleId = entity.BaleId,
                BaleNumber = entity.BaleNumber,
                AccountId = entity.AccountId,
                DockId = entity.DockId,
                LoadId = entity.LoadId,
                WarehouseWeight = entity.WarehouseWeight,
                InitWeight = entity.InitWeight,
                FinalWeight = entity.FinalWeight,
                RecycleTypeId = entity.RecycleTypeId,
                Notes = entity.Notes,
                Property = entity.Account.Name,
                Dock = entity.Dock.DockName,
                RecycleType = entity.RecycleType.Name
            };
            return data;
        }
    }
}
