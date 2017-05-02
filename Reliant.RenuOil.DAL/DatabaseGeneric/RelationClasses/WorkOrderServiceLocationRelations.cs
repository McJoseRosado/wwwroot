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
	/// <summary>Implements the static Relations variant for the entity: WorkOrderServiceLocation. </summary>
	public partial class WorkOrderServiceLocationRelations
	{
		/// <summary>CTor</summary>
		public WorkOrderServiceLocationRelations()
		{
		}

		/// <summary>Gets all relations of the WorkOrderServiceLocationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AssetReclamationServiceEntityUsingWorkOrderServiceLocationId);
			toReturn.Add(this.DeepFryerServiceEntityUsingWorkOrderServiceLocationId);
			toReturn.Add(this.RecycleServiceEntityUsingWorkOrderServiceLocationId);

			toReturn.Add(this.ServiceLocationEntityUsingServiceLocationId);
			toReturn.Add(this.WorkOrderEntityUsingWorkOrderId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between WorkOrderServiceLocationEntity and AssetReclamationServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// WorkOrderServiceLocation.WorkOrderServiceLocationId - AssetReclamationService.WorkOrderServiceLocationId
		/// </summary>
		public virtual IEntityRelation AssetReclamationServiceEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AssetReclamationService" , true);
				relation.AddEntityFieldPair(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, AssetReclamationServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between WorkOrderServiceLocationEntity and DeepFryerServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// WorkOrderServiceLocation.WorkOrderServiceLocationId - DeepFryerService.WorkOrderServiceLocationId
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerService" , true);
				relation.AddEntityFieldPair(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, DeepFryerServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between WorkOrderServiceLocationEntity and RecycleServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// WorkOrderServiceLocation.WorkOrderServiceLocationId - RecycleService.WorkOrderServiceLocationId
		/// </summary>
		public virtual IEntityRelation RecycleServiceEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleService" , true);
				relation.AddEntityFieldPair(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, RecycleServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between WorkOrderServiceLocationEntity and ServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrderServiceLocation.ServiceLocationId - ServiceLocation.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEntityUsingServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceLocation", false);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, WorkOrderServiceLocationFields.ServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderServiceLocationEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between WorkOrderServiceLocationEntity and WorkOrderEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrderServiceLocation.WorkOrderId - WorkOrder.WorkOrderId
		/// </summary>
		public virtual IEntityRelation WorkOrderEntityUsingWorkOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WorkOrder", false);
				relation.AddEntityFieldPair(WorkOrderFields.WorkOrderId, WorkOrderServiceLocationFields.WorkOrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderServiceLocationEntity", true);
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
