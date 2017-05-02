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
    public partial class ServiceTypeEntity
    {
        public enum ServiceTypes
        {
            DeepFryerOnly = 1,
            AssetReclamationOnly = 2,
            RecycleOnly = 3
        }
    }
}
