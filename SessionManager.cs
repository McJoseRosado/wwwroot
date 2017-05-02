using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.Linq;

namespace RenuOil
{
    [Serializable()]
    public class SessionManager
    {
        #region Properties
        public UserEntity AuthenticatedUser { get; set; }
        public int? RecActId { get; set; }
        // used to hold miscellaneous stuff
        public Dictionary<string, object> UserObjects { get; private set; }
        public int TargetWorkOrderId {get; set;}
        #endregion

        #region Constructor
        public SessionManager()
        {
            AuthenticatedUser = null;
            LinqMetaData metaData = new LinqMetaData();
            UserObjects = new Dictionary<string, object>();
        }
        #endregion

        #region Methods
        public void Login(UserEntity user)
        {
            AuthenticatedUser = user;
        }
        #endregion

        #region Elmah
        public static void LogException(Exception ex)
        {
            Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
        }
        #endregion

    }


}
