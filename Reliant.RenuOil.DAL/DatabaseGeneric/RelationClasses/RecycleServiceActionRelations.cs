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
	/// <summary>Implements the static Relations variant for the entity: RecycleServiceAction. </summary>
	public partial class RecycleServiceActionRelations
	{
		/// <summary>CTor</summary>
		public RecycleServiceActionRelations()
		{
		}

		/// <summary>Gets all relations of the RecycleServiceActionEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.EmployeeEntityUsingLastChangedByEmployeeId);
			toReturn.Add(this.EmployeeEntityUsingActionEmployeeId);
			toReturn.Add(this.RecycleServiceEntityUsingRecycleServiceId);
			toReturn.Add(this.RecycleTypeEntityUsingRecycleTypeId);
			toReturn.Add(this.UserEntityUsingActionUserId);
			toReturn.Add(this.UserEntityUsingLastChangedByUserId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between RecycleServiceActionEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleServiceAction.LastChangedByEmployeeId - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingLastChangedByEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee_", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, RecycleServiceActionFields.LastChangedByEmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RecycleServiceActionEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleServiceAction.ActionEmployeeId - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingActionEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, RecycleServiceActionFields.ActionEmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RecycleServiceActionEntity and RecycleServiceEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleServiceAction.RecycleServiceId - RecycleService.RecycleServiceId
		/// </summary>
		public virtual IEntityRelation RecycleServiceEntityUsingRecycleServiceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RecycleService", false);
				relation.AddEntityFieldPair(RecycleServiceFields.RecycleServiceId, RecycleServiceActionFields.RecycleServiceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RecycleServiceActionEntity and RecycleTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleServiceAction.RecycleTypeId - RecycleType.RecycleTypeId
		/// </summary>
		public virtual IEntityRelation RecycleTypeEntityUsingRecycleTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RecycleType", false);
				relation.AddEntityFieldPair(RecycleTypeFields.RecycleTypeId, RecycleServiceActionFields.RecycleTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RecycleServiceActionEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleServiceAction.ActionUserId - User.UserId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingActionUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.UserId, RecycleServiceActionFields.ActionUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RecycleServiceActionEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleServiceAction.LastChangedByUserId - User.UserId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingLastChangedByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User_", false);
				relation.AddEntityFieldPair(UserFields.UserId, RecycleServiceActionFields.LastChangedByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", true);
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
