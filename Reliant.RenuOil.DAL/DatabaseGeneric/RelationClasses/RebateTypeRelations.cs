﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: RebateType. </summary>
	public partial class RebateTypeRelations
	{
		/// <summary>CTor</summary>
		public RebateTypeRelations()
		{
		}

		/// <summary>Gets all relations of the RebateTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.RebateEntityUsingRebateTypeId);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RebateTypeEntity and RebateEntity over the 1:n relation they have, using the relation between the fields:
		/// RebateType.RebateTypeId - Rebate.RebateTypeId
		/// </summary>
		public virtual IEntityRelation RebateEntityUsingRebateTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Rebate" , true);
				relation.AddEntityFieldPair(RebateTypeFields.RebateTypeId, RebateFields.RebateTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RebateTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RebateEntity", false);
				return relation;
			}
		}



		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}

		#endregion

		#region Included Code

		#endregion
	}
}
