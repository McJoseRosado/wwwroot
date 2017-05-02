using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reliant.RenuOil.DAL.Linq;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.CollectionClasses;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.RelationClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ReliantUtilityLibrary;

namespace Reliant.RenuOil.DAL.EntityClasses
{
    public partial class ChangeTypeEntity
    {
        public enum ChangeTypes
        {
            FryerAdded = 1,
            FryerRemoved = 2,
            FryerSizeIncrease = 3,
            FryerSizeDecrease = 4,
            AssetTypePriceChange = 5,
            WorkOrderModified = 6
        }
    }
}
