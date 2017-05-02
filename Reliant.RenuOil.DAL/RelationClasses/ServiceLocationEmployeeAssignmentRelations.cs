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
	/// <summary>Implements the static Relations variant for the entity: ServiceLocationEmployeeAssignment. </summary>
	public partial class ServiceLocationEmployeeAssignmentRelations
	{
		/// <summary>CTor</summary>
		public ServiceLocationEmployeeAssignmentRelations()
		{
		}

		/// <summary>Gets all relations of the ServiceLocationEmployeeAssignmentEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.EmployeeEntityUsingFriday);
			toReturn.Add(this.EmployeeEntityUsingSaturday);
			toReturn.Add(this.EmployeeEntityUsingSunday);
			toReturn.Add(this.EmployeeEntityUsingThursday);
			toReturn.Add(this.EmployeeEntityUsingMonday);
			toReturn.Add(this.EmployeeEntityUsingTuesday);
			toReturn.Add(this.EmployeeEntityUsingWednesday);
			toReturn.Add(this.ServiceLocationEntityUsingServiceLocationId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationEmployeeAssignment.Friday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingFriday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee____", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Friday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationEmployeeAssignment.Saturday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingSaturday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee_____", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Saturday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationEmployeeAssignment.Sunday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingSunday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee______", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Sunday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationEmployeeAssignment.Thursday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingThursday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee___", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Thursday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationEmployeeAssignment.Monday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingMonday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Monday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationEmployeeAssignment.Tuesday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingTuesday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee_", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Tuesday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEmployeeAssignmentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationEmployeeAssignment.Wednesday - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingWednesday
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee__", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, ServiceLocationEmployeeAssignmentFields.Wednesday);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationEmployeeAssignmentEntity and ServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationEmployeeAssignment.ServiceLocationId - ServiceLocation.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEntityUsingServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceLocation", false);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, ServiceLocationEmployeeAssignmentFields.ServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEmployeeAssignmentEntity", true);
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
