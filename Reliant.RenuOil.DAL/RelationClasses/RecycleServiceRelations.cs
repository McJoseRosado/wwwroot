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
	/// <summary>Implements the static Relations variant for the entity: RecycleService. </summary>
	public partial class RecycleServiceRelations
	{
		/// <summary>CTor</summary>
		public RecycleServiceRelations()
		{
		}

		/// <summary>Gets all relations of the RecycleServiceEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.RecycleServiceActionEntityUsingRecycleServiceId);
			toReturn.Add(this.RecycleServiceChangeLogEntityUsingRecycleServiceId);

			toReturn.Add(this.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);
			toReturn.Add(this.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RecycleServiceEntity and RecycleServiceActionEntity over the 1:n relation they have, using the relation between the fields:
		/// RecycleService.RecycleServiceId - RecycleServiceAction.RecycleServiceId
		/// </summary>
		public virtual IEntityRelation RecycleServiceActionEntityUsingRecycleServiceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleServiceAction" , true);
				relation.AddEntityFieldPair(RecycleServiceFields.RecycleServiceId, RecycleServiceActionFields.RecycleServiceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between RecycleServiceEntity and RecycleServiceChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// RecycleService.RecycleServiceId - RecycleServiceChangeLog.RecycleServiceId
		/// </summary>
		public virtual IEntityRelation RecycleServiceChangeLogEntityUsingRecycleServiceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleServiceChangeLog" , true);
				relation.AddEntityFieldPair(RecycleServiceFields.RecycleServiceId, RecycleServiceChangeLogFields.RecycleServiceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceChangeLogEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between RecycleServiceEntity and WorkOrderEmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleService.WorkOrderServiceLocationId - WorkOrderEmployee.WorkOrderEmployeeId
		/// </summary>
		public virtual IEntityRelation WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WorkOrderEmployee", false);
				relation.AddEntityFieldPair(WorkOrderEmployeeFields.WorkOrderEmployeeId, RecycleServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RecycleServiceEntity and WorkOrderServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleService.WorkOrderServiceLocationId - WorkOrderServiceLocation.WorkOrderServiceLocationId
		/// </summary>
		public virtual IEntityRelation WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WorkOrderServiceLocation", false);
				relation.AddEntityFieldPair(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, RecycleServiceFields.WorkOrderServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceEntity", true);
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
