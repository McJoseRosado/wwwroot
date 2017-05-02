///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the static Relations variant for the entity: ServiceLocationAssetType. </summary>
	public partial class ServiceLocationAssetTypeRelations
	{
		/// <summary>CTor</summary>
		public ServiceLocationAssetTypeRelations()
		{
		}

		/// <summary>Gets all relations of the ServiceLocationAssetTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId);
			toReturn.Add(this.ServiceLocationAssetTypeChangeLogEntityUsingServiceLocationAssetTypeId);

			toReturn.Add(this.AssetTypeEntityUsingAssetTypeId);
			toReturn.Add(this.ServiceLocationEntityUsingServiceLocationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ServiceLocationAssetTypeEntity and AssetReclamationServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceLocationAssetType.ServiceLocationAssetTypeId - AssetReclamationService.ServiceLocationAssetTypeId
		/// </summary>
		public virtual IEntityRelation AssetReclamationServiceEntityUsingServiceLocationAssetTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AssetReclamationService" , true);
				relation.AddEntityFieldPair(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, AssetReclamationServiceFields.ServiceLocationAssetTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ServiceLocationAssetTypeEntity and ServiceLocationAssetTypeChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceLocationAssetType.ServiceLocationAssetTypeId - ServiceLocationAssetTypeChangeLog.ServiceLocationAssetTypeId
		/// </summary>
		public virtual IEntityRelation ServiceLocationAssetTypeChangeLogEntityUsingServiceLocationAssetTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationAssetTypeChangeLog" , true);
				relation.AddEntityFieldPair(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, ServiceLocationAssetTypeChangeLogFields.ServiceLocationAssetTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeChangeLogEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ServiceLocationAssetTypeEntity and AssetTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationAssetType.AssetTypeId - AssetType.AssetTypeId
		/// </summary>
		public virtual IEntityRelation AssetTypeEntityUsingAssetTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AssetType", false);
				relation.AddEntityFieldPair(AssetTypeFields.AssetTypeId, ServiceLocationAssetTypeFields.AssetTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationAssetTypeEntity and ServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationAssetType.ServiceLocationId - ServiceLocation.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEntityUsingServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceLocation", false);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, ServiceLocationAssetTypeFields.ServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeEntity", true);
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
