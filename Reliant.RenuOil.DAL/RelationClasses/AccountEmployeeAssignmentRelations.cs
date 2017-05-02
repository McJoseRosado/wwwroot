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
	/// <summary>Implements the static Relations variant for the entity: AccountEmployeeAssignment. </summary>
	public partial class AccountEmployeeAssignmentRelations
	{
		/// <summary>CTor</summary>
		public AccountEmployeeAssignmentRelations()
		{
		}

		/// <summary>Gets all relations of the AccountEmployeeAssignmentEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.AccountEntityUsingAccountId);
			toReturn.Add(this.EmployeeEntityUsingThursday);
			toReturn.Add(this.EmployeeEntityUsingTuesday);
			toReturn.Add(this.EmployeeEntityUsingWednesday);
			toReturn.Add(this.EmployeeEntityUsingSunday);
			toReturn.Add(this.EmployeeEntityUsingFriday);
			toReturn.Add(this.EmployeeEntityUsingMonday);
			toReturn.Add(this.EmployeeEntityUsingSaturday);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between AccountEmployeeAssignmentEntity and AccountEntity over the m:1 relation they have, using the relation between the fields:
		/// AccountEmployeeAssignment.AccountId - Account.AccountId
		/// </summary>
		public virtual IEntityRelation AccountEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Account", false);
				relation.AddEntityFieldPair(AccountFields.AccountId, AccountEmployeeAssignmentFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AccountEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// AccountEmployeeAssignment.Thursday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingThursday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee____", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Thursday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AccountEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// AccountEmployeeAssignment.Tuesday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingTuesday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee_____", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Tuesday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AccountEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// AccountEmployeeAssignment.Wednesday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingWednesday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee______", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Wednesday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AccountEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// AccountEmployeeAssignment.Sunday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingSunday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee___", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Sunday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AccountEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// AccountEmployeeAssignment.Friday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingFriday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Friday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AccountEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// AccountEmployeeAssignment.Monday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingMonday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee_", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Monday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AccountEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// AccountEmployeeAssignment.Saturday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingSaturday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee__", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AccountEmployeeAssignmentFields.Saturday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", true);
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
