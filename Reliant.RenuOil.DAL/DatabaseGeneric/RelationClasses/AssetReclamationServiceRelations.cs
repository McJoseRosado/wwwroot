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
	/// <summary>Implements the static Relations variant for the entity: AssetReclamationService. </summary>
	public partial class AssetReclamationServiceRelations
	{
		/// <summary>CTor</summary>
		public AssetReclamationServiceRelations()
		{
		}

		/// <summary>Gets all relations of the AssetReclamationServiceEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId);

			toReturn.Add(this.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId);
			toReturn.Add(this.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);
			toReturn.Add(this.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AssetReclamationServiceEntity and AssetReclamationServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// AssetReclamationService.AssetReclamationServiceId - AssetReclamationServiceChangeLog.AssetReclamationServiceId
		/// </summary>
		public virtual IEntityRelation AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AssetReclamationServiceChangeLog" , true);
				relation.AddEntityFieldPair(AssetReclamationServiceFields.AssetReclamationServiceId, AssetReclamationServiceChangeLogFields.AssetReclamationServiceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceChangeLogEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between AssetReclamationServiceEntity and ServiceLocationAssetTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// AssetReclamationService.ServiceLocationAssetTypeId - ServiceLocationAssetType.ServiceLocationAssetTypeId
		/// </summary>
		public virtual IEntityRelation ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceLocationAssetType", false);
				relation.AddEntityFieldPair(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, AssetReclamationServiceFields.ServiceLocationAssetTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AssetReclamationServiceEntity and WorkOrderEmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// AssetReclamationService.WorkOrderServiceLocationId - WorkOrderEmployee.WorkOrderEmployeeId
		/// </summary>
		public virtual IEntityRelation WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WorkOrderEmployee", false);
				relation.AddEntityFieldPair(WorkOrderEmployeeFields.WorkOrderEmployeeId, AssetReclamationServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AssetReclamationServiceEntity and WorkOrderServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// AssetReclamationService.WorkOrderServiceLocationId - WorkOrderServiceLocation.WorkOrderServiceLocationId
		/// </summary>
		public virtual IEntityRelation WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WorkOrderServiceLocation", false);
				relation.AddEntityFieldPair(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, AssetReclamationServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceEntity", true);
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
