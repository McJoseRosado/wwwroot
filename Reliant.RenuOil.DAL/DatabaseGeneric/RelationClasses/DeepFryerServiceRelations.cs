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
	/// <summary>Implements the static Relations variant for the entity: DeepFryerService. </summary>
	public partial class DeepFryerServiceRelations
	{
		/// <summary>CTor</summary>
		public DeepFryerServiceRelations()
		{
		}

		/// <summary>Gets all relations of the DeepFryerServiceEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId);

			toReturn.Add(this.DeepFryerEntityUsingDeepFryerId);
			toReturn.Add(this.EmployeeEntityUsingServicedby);
			toReturn.Add(this.ServiceLocationEntityUsingRelocatedToServiceLocationId);
			toReturn.Add(this.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);
			toReturn.Add(this.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceEntity and DeepFryerServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// DeepFryerService.DeepFryerServiceId - DeepFryerServiceChangeLog.DeepFryerServiceId
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerServiceChangeLog" , true);
				relation.AddEntityFieldPair(DeepFryerServiceFields.DeepFryerServiceId, DeepFryerServiceChangeLogFields.DeepFryerServiceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceChangeLogEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceEntity and DeepFryerEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryerService.DeepFryerId - DeepFryer.DeepFryerId
		/// </summary>
		public virtual IEntityRelation DeepFryerEntityUsingDeepFryerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "DeepFryer", false);
				relation.AddEntityFieldPair(DeepFryerFields.DeepFryerId, DeepFryerServiceFields.DeepFryerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryerService.Servicedby - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingServicedby
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, DeepFryerServiceFields.Servicedby);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceEntity and ServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryerService.RelocatedToServiceLocationId - ServiceLocation.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEntityUsingRelocatedToServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceLocation", false);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, DeepFryerServiceFields.RelocatedToServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceEntity and WorkOrderEmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryerService.WorkOrderServiceLocationId - WorkOrderEmployee.WorkOrderEmployeeId
		/// </summary>
		public virtual IEntityRelation WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WorkOrderEmployee", false);
				relation.AddEntityFieldPair(WorkOrderEmployeeFields.WorkOrderEmployeeId, DeepFryerServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceEntity and WorkOrderServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryerService.WorkOrderServiceLocationId - WorkOrderServiceLocation.WorkOrderServiceLocationId
		/// </summary>
		public virtual IEntityRelation WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WorkOrderServiceLocation", false);
				relation.AddEntityFieldPair(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, DeepFryerServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", true);
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
