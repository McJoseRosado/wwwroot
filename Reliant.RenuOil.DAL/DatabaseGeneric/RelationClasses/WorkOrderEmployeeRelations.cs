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
	/// <summary>Implements the static Relations variant for the entity: WorkOrderEmployee. </summary>
	public partial class WorkOrderEmployeeRelations
	{
		/// <summary>CTor</summary>
		public WorkOrderEmployeeRelations()
		{
		}

		/// <summary>Gets all relations of the WorkOrderEmployeeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AssetReclamationServiceEntityUsingWorkOrderServiceLocationId);
			toReturn.Add(this.DeepFryerServiceEntityUsingWorkOrderServiceLocationId);
			toReturn.Add(this.RecycleServiceEntityUsingWorkOrderServiceLocationId);

			toReturn.Add(this.ServiceLocationEntityUsingEmployeeId);
			toReturn.Add(this.WorkOrderEntityUsingWorkOrderId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between WorkOrderEmployeeEntity and AssetReclamationServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// WorkOrderEmployee.WorkOrderEmployeeId - AssetReclamationService.WorkOrderServiceLocationId
		/// </summary>
		public virtual IEntityRelation AssetReclamationServiceEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AssetReclamationService" , true);
				relation.AddEntityFieldPair(WorkOrderEmployeeFields.WorkOrderEmployeeId, AssetReclamationServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between WorkOrderEmployeeEntity and DeepFryerServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// WorkOrderEmployee.WorkOrderEmployeeId - DeepFryerService.WorkOrderServiceLocationId
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerService" , true);
				relation.AddEntityFieldPair(WorkOrderEmployeeFields.WorkOrderEmployeeId, DeepFryerServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between WorkOrderEmployeeEntity and RecycleServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// WorkOrderEmployee.WorkOrderEmployeeId - RecycleService.WorkOrderServiceLocationId
		/// </summary>
		public virtual IEntityRelation RecycleServiceEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleService" , true);
				relation.AddEntityFieldPair(WorkOrderEmployeeFields.WorkOrderEmployeeId, RecycleServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between WorkOrderEmployeeEntity and ServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrderEmployee.EmployeeId - ServiceLocation.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceLocation", false);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, WorkOrderEmployeeFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEmployeeEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between WorkOrderEmployeeEntity and WorkOrderEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrderEmployee.WorkOrderId - WorkOrder.WorkOrderId
		/// </summary>
		public virtual IEntityRelation WorkOrderEntityUsingWorkOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WorkOrder", false);
				relation.AddEntityFieldPair(WorkOrderFields.WorkOrderId, WorkOrderEmployeeFields.WorkOrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEmployeeEntity", true);
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
