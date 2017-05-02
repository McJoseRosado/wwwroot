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
	/// <summary>Implements the static Relations variant for the entity: ServiceType. </summary>
	public partial class ServiceTypeRelations
	{
		/// <summary>CTor</summary>
		public ServiceTypeRelations()
		{
		}

		/// <summary>Gets all relations of the ServiceTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ServiceLocationEntityUsingServiceTypeId);
			toReturn.Add(this.WorkOrderEntityUsingServiceTypeId);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ServiceTypeEntity and ServiceLocationEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceType.ServiceTypeId - ServiceLocation.ServiceTypeId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEntityUsingServiceTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocation" , true);
				relation.AddEntityFieldPair(ServiceTypeFields.ServiceTypeId, ServiceLocationFields.ServiceTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ServiceTypeEntity and WorkOrderEntity over the 1:n relation they have, using the relation between the fields:
		/// ServiceType.ServiceTypeId - WorkOrder.ServiceTypeId
		/// </summary>
		public virtual IEntityRelation WorkOrderEntityUsingServiceTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrder" , true);
				relation.AddEntityFieldPair(ServiceTypeFields.ServiceTypeId, WorkOrderFields.ServiceTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceTypeEntity", true);
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
