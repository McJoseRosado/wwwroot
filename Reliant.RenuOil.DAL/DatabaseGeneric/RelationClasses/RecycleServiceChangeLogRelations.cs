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
	/// <summary>Implements the static Relations variant for the entity: RecycleServiceChangeLog. </summary>
	public partial class RecycleServiceChangeLogRelations
	{
		/// <summary>CTor</summary>
		public RecycleServiceChangeLogRelations()
		{
		}

		/// <summary>Gets all relations of the RecycleServiceChangeLogEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.EmployeeEntityUsingEnteredByEmployeeId);
			toReturn.Add(this.RecycleServiceEntityUsingRecycleServiceId);
			toReturn.Add(this.UserEntityUsingEnteredByUserId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between RecycleServiceChangeLogEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleServiceChangeLog.EnteredByEmployeeId - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEnteredByEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, RecycleServiceChangeLogFields.EnteredByEmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceChangeLogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RecycleServiceChangeLogEntity and RecycleServiceEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleServiceChangeLog.RecycleServiceId - RecycleService.RecycleServiceId
		/// </summary>
		public virtual IEntityRelation RecycleServiceEntityUsingRecycleServiceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RecycleService", false);
				relation.AddEntityFieldPair(RecycleServiceFields.RecycleServiceId, RecycleServiceChangeLogFields.RecycleServiceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceChangeLogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RecycleServiceChangeLogEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleServiceChangeLog.EnteredByUserId - User.UserId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingEnteredByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.UserId, RecycleServiceChangeLogFields.EnteredByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceChangeLogEntity", true);
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
