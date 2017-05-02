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
	/// <summary>Implements the static Relations variant for the entity: ServiceLocationRecycleType. </summary>
	public partial class ServiceLocationRecycleTypeRelations
	{
		/// <summary>CTor</summary>
		public ServiceLocationRecycleTypeRelations()
		{
		}

		/// <summary>Gets all relations of the ServiceLocationRecycleTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.RecycleTypeEntityUsingRecycleTypeId);
			toReturn.Add(this.ServiceLocationEntityUsingServiceLocationId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ServiceLocationRecycleTypeEntity and RecycleTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationRecycleType.RecycleTypeId - RecycleType.RecycleTypeId
		/// </summary>
		public virtual IEntityRelation RecycleTypeEntityUsingRecycleTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RecycleType", false);
				relation.AddEntityFieldPair(RecycleTypeFields.RecycleTypeId, ServiceLocationRecycleTypeFields.RecycleTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationRecycleTypeEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ServiceLocationRecycleTypeEntity and ServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// ServiceLocationRecycleType.ServiceLocationId - ServiceLocation.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEntityUsingServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceLocation", false);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, ServiceLocationRecycleTypeFields.ServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationRecycleTypeEntity", true);
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
