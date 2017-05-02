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
	/// <summary>Implements the static Relations variant for the entity: Employee. </summary>
	public partial class EmployeeRelations
	{
		/// <summary>CTor</summary>
		public EmployeeRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AccountEmployeeAssignmentEntityUsingThursday);
			toReturn.Add(this.AccountEmployeeAssignmentEntityUsingTuesday);
			toReturn.Add(this.AccountEmployeeAssignmentEntityUsingWednesday);
			toReturn.Add(this.AccountEmployeeAssignmentEntityUsingSunday);
			toReturn.Add(this.AccountEmployeeAssignmentEntityUsingFriday);
			toReturn.Add(this.AccountEmployeeAssignmentEntityUsingMonday);
			toReturn.Add(this.AccountEmployeeAssignmentEntityUsingSaturday);
			toReturn.Add(this.AssetReclamationServiceChangeLogEntityUsingEnteredByEmployeeId);
			toReturn.Add(this.DeepFryerServiceEntityUsingServicedby);
			toReturn.Add(this.DeepFryerServiceChangeLogEntityUsingServicedBy);
			toReturn.Add(this.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId);
			toReturn.Add(this.LoadEntityUsingEmployeeId);
			toReturn.Add(this.RecycleServiceActionEntityUsingActionEmployeeId);
			toReturn.Add(this.RecycleServiceActionEntityUsingLastChangedByEmployeeId);
			toReturn.Add(this.RecycleServiceChangeLogEntityUsingEnteredByEmployeeId);
			toReturn.Add(this.ServiceLocationEmployeeAssignmentEntityUsingFriday);
			toReturn.Add(this.ServiceLocationEmployeeAssignmentEntityUsingSaturday);
			toReturn.Add(this.ServiceLocationEmployeeAssignmentEntityUsingSunday);
			toReturn.Add(this.ServiceLocationEmployeeAssignmentEntityUsingThursday);
			toReturn.Add(this.ServiceLocationEmployeeAssignmentEntityUsingMonday);
			toReturn.Add(this.ServiceLocationEmployeeAssignmentEntityUsingTuesday);
			toReturn.Add(this.ServiceLocationEmployeeAssignmentEntityUsingWednesday);
			toReturn.Add(this.WorkOrderEntityUsingTechnicianId);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and AccountEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - AccountEmployeeAssignment.Thursday
		/// </summary>
		public virtual IEntityRelation AccountEmployeeAssignmentEntityUsingThursday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AccountEmployeeAssignment____" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Thursday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and AccountEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - AccountEmployeeAssignment.Tuesday
		/// </summary>
		public virtual IEntityRelation AccountEmployeeAssignmentEntityUsingTuesday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AccountEmployeeAssignment_____" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Tuesday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and AccountEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - AccountEmployeeAssignment.Wednesday
		/// </summary>
		public virtual IEntityRelation AccountEmployeeAssignmentEntityUsingWednesday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AccountEmployeeAssignment______" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Wednesday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and AccountEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - AccountEmployeeAssignment.Sunday
		/// </summary>
		public virtual IEntityRelation AccountEmployeeAssignmentEntityUsingSunday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AccountEmployeeAssignment___" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Sunday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and AccountEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - AccountEmployeeAssignment.Friday
		/// </summary>
		public virtual IEntityRelation AccountEmployeeAssignmentEntityUsingFriday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AccountEmployeeAssignment" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Friday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and AccountEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - AccountEmployeeAssignment.Monday
		/// </summary>
		public virtual IEntityRelation AccountEmployeeAssignmentEntityUsingMonday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AccountEmployeeAssignment_" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Monday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and AccountEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - AccountEmployeeAssignment.Saturday
		/// </summary>
		public virtual IEntityRelation AccountEmployeeAssignmentEntityUsingSaturday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AccountEmployeeAssignment__" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Saturday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and AssetReclamationServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - AssetReclamationServiceChangeLog.EnteredByEmployeeId
		/// </summary>
		public virtual IEntityRelation AssetReclamationServiceChangeLogEntityUsingEnteredByEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AssetReclamationServiceChangeLog" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AssetReclamationServiceChangeLogFields.EnteredByEmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and DeepFryerServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - DeepFryerService.Servicedby
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceEntityUsingServicedby
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerService" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, DeepFryerServiceFields.Servicedby);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and DeepFryerServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - DeepFryerServiceChangeLog.ServicedBy
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceChangeLogEntityUsingServicedBy
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerServiceChangeLog_" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, DeepFryerServiceChangeLogFields.ServicedBy);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and DeepFryerServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - DeepFryerServiceChangeLog.EnteredByEmployeeId
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerServiceChangeLog" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, DeepFryerServiceChangeLogFields.EnteredByEmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and LoadEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - Load.EmployeeId
		/// </summary>
		public virtual IEntityRelation LoadEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Load" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, LoadFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LoadEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and RecycleServiceActionEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - RecycleServiceAction.ActionEmployeeId
		/// </summary>
		public virtual IEntityRelation RecycleServiceActionEntityUsingActionEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleServiceAction_" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, RecycleServiceActionFields.ActionEmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and RecycleServiceActionEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - RecycleServiceAction.LastChangedByEmployeeId
		/// </summary>
		public virtual IEntityRelation RecycleServiceActionEntityUsingLastChangedByEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleServiceAction" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, RecycleServiceActionFields.LastChangedByEmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and RecycleServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - RecycleServiceChangeLog.EnteredByEmployeeId
		/// </summary>
		public virtual IEntityRelation RecycleServiceChangeLogEntityUsingEnteredByEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleServiceChangeLog" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, RecycleServiceChangeLogFields.EnteredByEmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and ServiceLocationEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - ServiceLocationEmployeeAssignment.Friday
		/// </summary>
		public virtual IEntityRelation ServiceLocationEmployeeAssignmentEntityUsingFriday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationEmployeeAssignment____" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Friday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and ServiceLocationEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - ServiceLocationEmployeeAssignment.Saturday
		/// </summary>
		public virtual IEntityRelation ServiceLocationEmployeeAssignmentEntityUsingSaturday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationEmployeeAssignment_____" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Saturday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and ServiceLocationEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - ServiceLocationEmployeeAssignment.Sunday
		/// </summary>
		public virtual IEntityRelation ServiceLocationEmployeeAssignmentEntityUsingSunday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationEmployeeAssignment______" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Sunday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and ServiceLocationEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - ServiceLocationEmployeeAssignment.Thursday
		/// </summary>
		public virtual IEntityRelation ServiceLocationEmployeeAssignmentEntityUsingThursday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationEmployeeAssignment___" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Thursday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and ServiceLocationEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - ServiceLocationEmployeeAssignment.Monday
		/// </summary>
		public virtual IEntityRelation ServiceLocationEmployeeAssignmentEntityUsingMonday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationEmployeeAssignment" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Monday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and ServiceLocationEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - ServiceLocationEmployeeAssignment.Tuesday
		/// </summary>
		public virtual IEntityRelation ServiceLocationEmployeeAssignmentEntityUsingTuesday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationEmployeeAssignment_" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Tuesday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and ServiceLocationEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - ServiceLocationEmployeeAssignment.Wednesday
		/// </summary>
		public virtual IEntityRelation ServiceLocationEmployeeAssignmentEntityUsingWednesday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationEmployeeAssignment__" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Wednesday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and WorkOrderEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - WorkOrder.TechnicianId
		/// </summary>
		public virtual IEntityRelation WorkOrderEntityUsingTechnicianId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrder" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, WorkOrderFields.TechnicianId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", false);
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
