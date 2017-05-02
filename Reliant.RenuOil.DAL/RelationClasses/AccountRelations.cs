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
	/// <summary>Implements the static Relations variant for the entity: Account. </summary>
	public partial class AccountRelations
	{
		/// <summary>CTor</summary>
		public AccountRelations()
		{
		}

		/// <summary>Gets all relations of the AccountEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AccountEmployeeAssignmentEntityUsingAccountId);
			toReturn.Add(this.BaleEntityUsingAccountId);
			toReturn.Add(this.RebateEntityUsingAccountId);
			toReturn.Add(this.RecycleVendorServiceEntityUsingAccountId);
			toReturn.Add(this.ServiceLocationEntityUsingAccountId);
			toReturn.Add(this.UserAccountEntityUsingAccountId);
			toReturn.Add(this.WorkOrderEntityUsingAccountId);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AccountEntity and AccountEmployeeAssignmentEntity over the 1:n relation they have, using the relation between the fields:
		/// Account.AccountId - AccountEmployeeAssignment.AccountId
		/// </summary>
		public virtual IEntityRelation AccountEmployeeAssignmentEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AccountEmployeeAssignment" , true);
				relation.AddEntityFieldPair(AccountFields.AccountId, AccountEmployeeAssignmentFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEmployeeAssignmentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AccountEntity and BaleEntity over the 1:n relation they have, using the relation between the fields:
		/// Account.AccountId - Bale.AccountId
		/// </summary>
		public virtual IEntityRelation BaleEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Bale" , true);
				relation.AddEntityFieldPair(AccountFields.AccountId, BaleFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BaleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AccountEntity and RebateEntity over the 1:n relation they have, using the relation between the fields:
		/// Account.AccountId - Rebate.AccountId
		/// </summary>
		public virtual IEntityRelation RebateEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Rebate" , true);
				relation.AddEntityFieldPair(AccountFields.AccountId, RebateFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RebateEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AccountEntity and RecycleVendorServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// Account.AccountId - RecycleVendorService.AccountId
		/// </summary>
		public virtual IEntityRelation RecycleVendorServiceEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleVendorService" , true);
				relation.AddEntityFieldPair(AccountFields.AccountId, RecycleVendorServiceFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleVendorServiceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AccountEntity and ServiceLocationEntity over the 1:n relation they have, using the relation between the fields:
		/// Account.AccountId - ServiceLocation.AccountId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocation" , true);
				relation.AddEntityFieldPair(AccountFields.AccountId, ServiceLocationFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AccountEntity and UserAccountEntity over the 1:n relation they have, using the relation between the fields:
		/// Account.AccountId - UserAccount.AccountId
		/// </summary>
		public virtual IEntityRelation UserAccountEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "UserAccount" , true);
				relation.AddEntityFieldPair(AccountFields.AccountId, UserAccountFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserAccountEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AccountEntity and WorkOrderEntity over the 1:n relation they have, using the relation between the fields:
		/// Account.AccountId - WorkOrder.AccountId
		/// </summary>
		public virtual IEntityRelation WorkOrderEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrder" , true);
				relation.AddEntityFieldPair(AccountFields.AccountId, WorkOrderFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", true);
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
