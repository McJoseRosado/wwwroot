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
    public partial class UserTypeEntity
    {
        public enum UserTypes
        {
            Administrator = 1,
            Manager = 2,
            Loader_Driver = 3,
            CompanyUser = 4,
            FacilityUser = 5,
            Technician = 6
        }
    }
}
