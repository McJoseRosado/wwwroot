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
	/// <summary>Implements the static Relations variant for the entity: ServiceLocation. </summary>
	public partial class ServiceLocationRelations
	{
		/// <summary>CTor</summary>
		public ServiceLocationRelations()
		{
		}

		/// <summary>Gets all relations of the ServiceLocationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.DeepFryerEntityUsingServiceLocationId);
			toReturn.Add(this.DeepFryerServiceEntityUsingRelocatedToServiceLocationId);
			toReturn.Add(this.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId);
			toReturn.Add(this.ServiceLocationAssetTypeEntityUsingServiceLocationId);
			toReturn.Add(this.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId);
			toReturn.Add(this.ServiceLocationRecycleTypeEntityUsingServiceLocationId);
			toReturn.Add(this.WorkOrderEmployeeEntityUsingEmployeeId);
			toReturn.Add(this.WorkOrderServiceLocationEntityUsingServiceLocationId);

			toReturn.Add(this.AccountEntityUsingAccountId);
			toReturn.Add(this.ServiceTypeEntityUsingServiceTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEntity and DeepFryerEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceLocation.ServiceLocationId - DeepFryer.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation DeepFryerEntityUsingServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryer" , true);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, DeepFryerFields.ServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEntity and DeepFryerServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceLocation.ServiceLocationId - DeepFryerService.RelocatedToServiceLocationId
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceEntityUsingRelocatedToServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerService" , true);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, DeepFryerServiceFields.RelocatedToServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEntity and DeepFryerServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceLocation.ServiceLocationId - DeepFryerServiceChangeLog.RelocatedToServiceLocationId
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerServiceChangeLog" , true);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, DeepFryerServiceChangeLogFields.RelocatedToServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEntity and ServiceLocationAssetTypeEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceLocation.ServiceLocationId - ServiceLocationAssetType.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationAssetTypeEntityUsingServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationAssetType" , true);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, ServiceLocationAssetTypeFields.ServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEntity and ServiceLocationEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceLocation.ServiceLocationId - ServiceLocationEmployeeAssignment.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationEmployeeAssignment" , true);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, ServiceLocationEmployeeAssignmentFields.ServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEntity and ServiceLocationRecycleTypeEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceLocation.ServiceLocationId - ServiceLocationRecycleType.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationRecycleTypeEntityUsingServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationRecycleType" , true);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, ServiceLocationRecycleTypeFields.ServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationRecycleTypeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEntity and WorkOrderEmployeeEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceLocation.ServiceLocationId - WorkOrderEmployee.EmployeeId
		/// </summary>
		public virtual IEntityRelation WorkOrderEmployeeEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrderEmployee" , true);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, WorkOrderEmployeeFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEntity and WorkOrderServiceLocationEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceLocation.ServiceLocationId - WorkOrderServiceLocation.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation WorkOrderServiceLocationEntityUsingServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrderServiceLocation" , true);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, WorkOrderServiceLocationFields.ServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderServiceLocationEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEntity and AccountEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocation.AccountId - Account.AccountId
		/// </summary>
		public virtual IEntityRelation AccountEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Account", false);
				relation.AddEntityFieldPair(AccountFields.AccountId, ServiceLocationFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEntity and ServiceTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocation.ServiceTypeId - ServiceType.ServiceTypeId
		/// </summary>
		public virtual IEntityRelation ServiceTypeEntityUsingServiceTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceType", false);
				relation.AddEntityFieldPair(ServiceTypeFields.ServiceTypeId, ServiceLocationFields.ServiceTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", true);
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
