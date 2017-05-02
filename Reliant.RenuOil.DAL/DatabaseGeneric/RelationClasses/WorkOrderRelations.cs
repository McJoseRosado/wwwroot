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
	/// <summary>Implements the static Relations variant for the entity: WorkOrder. </summary>
	public partial class WorkOrderRelations
	{
		/// <summary>CTor</summary>
		public WorkOrderRelations()
		{
		}

		/// <summary>Gets all relations of the WorkOrderEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.WorkOrderEmployeeEntityUsingWorkOrderId);
			toReturn.Add(this.WorkOrderServiceLocationEntityUsingWorkOrderId);

			toReturn.Add(this.AccountEntityUsingAccountId);
			toReturn.Add(this.EmployeeEntityUsingTechnicianId);
			toReturn.Add(this.ServiceTypeEntityUsingServiceTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and WorkOrderEmployeeEntity over the 1:n relation they have, using the relation between the fields:
		/// WorkOrder.WorkOrderId - WorkOrderEmployee.WorkOrderId
		/// </summary>
		public virtual IEntityRelation WorkOrderEmployeeEntityUsingWorkOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrderEmployee" , true);
				relation.AddEntityFieldPair(WorkOrderFields.WorkOrderId, WorkOrderEmployeeFields.WorkOrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and WorkOrderServiceLocationEntity over the 1:n relation they have, using the relation between the fields:
		/// WorkOrder.WorkOrderId - WorkOrderServiceLocation.WorkOrderId
		/// </summary>
		public virtual IEntityRelation WorkOrderServiceLocationEntityUsingWorkOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrderServiceLocation" , true);
				relation.AddEntityFieldPair(WorkOrderFields.WorkOrderId, WorkOrderServiceLocationFields.WorkOrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderServiceLocationEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and AccountEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrder.AccountId - Account.AccountId
		/// </summary>
		public virtual IEntityRelation AccountEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Account", false);
				relation.AddEntityFieldPair(AccountFields.AccountId, WorkOrderFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrder.TechnicianId - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingTechnicianId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, WorkOrderFields.TechnicianId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and ServiceTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrder.ServiceTypeId - ServiceType.ServiceTypeId
		/// </summary>
		public virtual IEntityRelation ServiceTypeEntityUsingServiceTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceType", false);
				relation.AddEntityFieldPair(ServiceTypeFields.ServiceTypeId, WorkOrderFields.ServiceTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
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
