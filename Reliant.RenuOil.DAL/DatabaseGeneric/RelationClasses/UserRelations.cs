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
	/// <summary>Implements the static Relations variant for the entity: User. </summary>
	public partial class UserRelations
	{
		/// <summary>CTor</summary>
		public UserRelations()
		{
		}

		/// <summary>Gets all relations of the UserEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AssetReclamationServiceChangeLogEntityUsingEnteredByUserId);
			toReturn.Add(this.ChangeLogEntityUsingUserId);
			toReturn.Add(this.DeepFryerServiceChangeLogEntityUsingEnteredByUserId);
			toReturn.Add(this.RebateEntityUsingEnteredByUserId);
			toReturn.Add(this.RecycleServiceActionEntityUsingLastChangedByUserId);
			toReturn.Add(this.RecycleServiceActionEntityUsingActionUserId);
			toReturn.Add(this.RecycleServiceChangeLogEntityUsingEnteredByUserId);
			toReturn.Add(this.UserAccountEntityUsingUserId);

			toReturn.Add(this.UserTypeEntityUsingUserTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between UserEntity and AssetReclamationServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// User.UserId - AssetReclamationServiceChangeLog.EnteredByUserId
		/// </summary>
		public virtual IEntityRelation AssetReclamationServiceChangeLogEntityUsingEnteredByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AssetReclamationServiceChangeLog" , true);
				relation.AddEntityFieldPair(UserFields.UserId, AssetReclamationServiceChangeLogFields.EnteredByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and ChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// User.UserId - ChangeLog.UserId
		/// </summary>
		public virtual IEntityRelation ChangeLogEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ChangeLog" , true);
				relation.AddEntityFieldPair(UserFields.UserId, ChangeLogFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and DeepFryerServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// User.UserId - DeepFryerServiceChangeLog.EnteredByUserId
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceChangeLogEntityUsingEnteredByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerServiceChangeLog" , true);
				relation.AddEntityFieldPair(UserFields.UserId, DeepFryerServiceChangeLogFields.EnteredByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and RebateEntity over the 1:n relation they have, using the relation between the fields:
		/// User.UserId - Rebate.EnteredByUserId
		/// </summary>
		public virtual IEntityRelation RebateEntityUsingEnteredByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Rebate" , true);
				relation.AddEntityFieldPair(UserFields.UserId, RebateFields.EnteredByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RebateEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and RecycleServiceActionEntity over the 1:n relation they have, using the relation between the fields:
		/// User.UserId - RecycleServiceAction.LastChangedByUserId
		/// </summary>
		public virtual IEntityRelation RecycleServiceActionEntityUsingLastChangedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleServiceAction_" , true);
				relation.AddEntityFieldPair(UserFields.UserId, RecycleServiceActionFields.LastChangedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and RecycleServiceActionEntity over the 1:n relation they have, using the relation between the fields:
		/// User.UserId - RecycleServiceAction.ActionUserId
		/// </summary>
		public virtual IEntityRelation RecycleServiceActionEntityUsingActionUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleServiceAction" , true);
				relation.AddEntityFieldPair(UserFields.UserId, RecycleServiceActionFields.ActionUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and RecycleServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// User.UserId - RecycleServiceChangeLog.EnteredByUserId
		/// </summary>
		public virtual IEntityRelation RecycleServiceChangeLogEntityUsingEnteredByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleServiceChangeLog" , true);
				relation.AddEntityFieldPair(UserFields.UserId, RecycleServiceChangeLogFields.EnteredByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UserEntity and UserAccountEntity over the 1:n relation they have, using the relation between the fields:
		/// User.UserId - UserAccount.UserId
		/// </summary>
		public virtual IEntityRelation UserAccountEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "UserAccount" , true);
				relation.AddEntityFieldPair(UserFields.UserId, UserAccountFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserAccountEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between UserEntity and UserTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// User.UserTypeId - UserType.UserTypeId
		/// </summary>
		public virtual IEntityRelation UserTypeEntityUsingUserTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "UserType", false);
				relation.AddEntityFieldPair(UserTypeFields.UserTypeId, UserFields.UserTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", true);
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
