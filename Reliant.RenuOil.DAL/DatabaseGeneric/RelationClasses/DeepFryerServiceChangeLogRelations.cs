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
	/// <summary>Implements the static Relations variant for the entity: DeepFryerServiceChangeLog. </summary>
	public partial class DeepFryerServiceChangeLogRelations
	{
		/// <summary>CTor</summary>
		public DeepFryerServiceChangeLogRelations()
		{
		}

		/// <summary>Gets all relations of the DeepFryerServiceChangeLogEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.DeepFryerServiceEntityUsingDeepFryerServiceId);
			toReturn.Add(this.EmployeeEntityUsingServicedBy);
			toReturn.Add(this.EmployeeEntityUsingEnteredByEmployeeId);
			toReturn.Add(this.ServiceLocationEntityUsingRelocatedToServiceLocationId);
			toReturn.Add(this.UserEntityUsingEnteredByUserId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceChangeLogEntity and DeepFryerServiceEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryerServiceChangeLog.DeepFryerServiceId - DeepFryerService.DeepFryerServiceId
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceEntityUsingDeepFryerServiceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "DeepFryerService", false);
				relation.AddEntityFieldPair(DeepFryerServiceFields.DeepFryerServiceId, DeepFryerServiceChangeLogFields.DeepFryerServiceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceChangeLogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceChangeLogEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryerServiceChangeLog.ServicedBy - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingServicedBy
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee_", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, DeepFryerServiceChangeLogFields.ServicedBy);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceChangeLogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceChangeLogEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryerServiceChangeLog.EnteredByEmployeeId - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEnteredByEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, DeepFryerServiceChangeLogFields.EnteredByEmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceChangeLogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceChangeLogEntity and ServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryerServiceChangeLog.RelocatedToServiceLocationId - ServiceLocation.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEntityUsingRelocatedToServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceLocation", false);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, DeepFryerServiceChangeLogFields.RelocatedToServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceChangeLogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DeepFryerServiceChangeLogEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryerServiceChangeLog.EnteredByUserId - User.UserId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingEnteredByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.UserId, DeepFryerServiceChangeLogFields.EnteredByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceChangeLogEntity", true);
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
