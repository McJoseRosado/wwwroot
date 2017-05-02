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
    public partial class UserEntity
    {
        public static UserEntity Login(string username, string password)
        {
            LinqMetaData metaData = new LinqMetaData();

            var user = metaData.User.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user != null && Hashing.VerifyHash(password, HashType.MD5, user.Password))
            {
                return user;
            }

            return null;
        }

        public static UserEntity LoginWithHash(string username, string password)
        {
            if (username.Length == 0 || password.Length == 0)
                return null;

            LinqMetaData metaData = new LinqMetaData();

            var user = metaData.User.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user != null)
            {
                string hash = string.Join("", user.Password.Select(b => string.Format("{0:X2}", b)).ToArray());
                if (string.Compare(hash, password, true) == 0)
                    return user;
            }

            return null;
        }
    }

}