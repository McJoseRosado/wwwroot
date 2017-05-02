using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reliant.RenuOil.DAL.EntityClasses
{
    public partial class RecycleServiceActionEntity
    {
        public string RecycleTypeName
        {
            get
            {
                return RecycleType.Name;
            }
        }

        public string Action
        {
            get
            {
                switch (ActionType)
                {
                    case "A":
                        return "Actual";
                    case "O":
                        return "Observed";
                    case "D":
                        return "Facility Drop";
                    case "P":
                        return "Picked Up";
                    default:
                        return "Unknown";
                }
            }
        }
    }
}
