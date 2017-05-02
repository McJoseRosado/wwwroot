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
	/// <summary>Implements the static Relations variant for the entity: ServiceLocationAssetTypeChangeLog. </summary>
	public partial class ServiceLocationAssetTypeChangeLogRelations
	{
		/// <summary>CTor</summary>
		public ServiceLocationAssetTypeChangeLogRelations()
		{
		}

		/// <summary>Gets all relations of the ServiceLocationAssetTypeChangeLogEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.ChangeLogEntityUsingChangeLogId);
			toReturn.Add(this.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ServiceLocationAssetTypeChangeLogEntity and ChangeLogEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationAssetTypeChangeLog.ChangeLogId - ChangeLog.ChangeLogId
		/// </summary>
		public virtual IEntityRelation ChangeLogEntityUsingChangeLogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ChangeLog", false);
				relation.AddEntityFieldPair(ChangeLogFields.ChangeLogId, ServiceLocationAssetTypeChangeLogFields.ChangeLogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChangeLogEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeChangeLogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationAssetTypeChangeLogEntity and ServiceLocationAssetTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationAssetTypeChangeLog.ServiceLocationAssetTypeId - ServiceLocationAssetType.ServiceLocationAssetTypeId
		/// </summary>
		public virtual IEntityRelation ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceLocationAssetType", false);
				relation.AddEntityFieldPair(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, ServiceLocationAssetTypeChangeLogFields.ServiceLocationAssetTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeChangeLogEntity", true);
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
