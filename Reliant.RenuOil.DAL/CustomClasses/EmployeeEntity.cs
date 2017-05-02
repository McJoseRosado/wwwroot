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
    public partial class EmployeeEntity
    {
        public string FullName
        {
            get
            {
                return string.Concat(LastName, ", ", FirstName);
            }
        }

        public static EmployeeEntity Login(string username, string password)
        {
            LinqMetaData metaData = new LinqMetaData();

            var employee = metaData.Employee.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (employee != null && Hashing.VerifyHash(password, HashType.MD5, employee.Password))
            {
                return employee;
            }

            if (employee != null)
                return employee;

            return null;
        }

        public static EmployeeEntity LoginWithHash(string username, string password)
        {
            if (username.Length == 0 || password.Length == 0)
                return null;

            LinqMetaData metaData = new LinqMetaData();

            var employee = metaData.Employee.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (employee != null)
            {
                string hash = string.Join("", employee.Password.Select(b => string.Format("{0:X2}", b)).ToArray());
                if (string.Compare(hash, password, true) == 0)
                    return employee;
            }

            return null;
        }
    }
}
