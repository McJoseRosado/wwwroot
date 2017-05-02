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
	/// <summary>Implements the static Relations variant for the entity: RecycleType. </summary>
	public partial class RecycleTypeRelations
	{
		/// <summary>CTor</summary>
		public RecycleTypeRelations()
		{
		}

		/// <summary>Gets all relations of the RecycleTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BaleEntityUsingRecycleTypeId);
			toReturn.Add(this.RecycleServiceActionEntityUsingRecycleTypeId);
			toReturn.Add(this.RecycleVendorServiceEntityUsingRecycleTypeId);
			toReturn.Add(this.ServiceLocationRecycleTypeEntityUsingRecycleTypeId);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RecycleTypeEntity and BaleEntity over the 1:n relation they have, using the relation between the fields:
		/// RecycleType.RecycleTypeId - Bale.RecycleTypeId
		/// </summary>
		public virtual IEntityRelation BaleEntityUsingRecycleTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Bale" , true);
				relation.AddEntityFieldPair(RecycleTypeFields.RecycleTypeId, BaleFields.RecycleTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BaleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between RecycleTypeEntity and RecycleServiceActionEntity over the 1:n relation they have, using the relation between the fields:
		/// RecycleType.RecycleTypeId - RecycleServiceAction.RecycleTypeId
		/// </summary>
		public virtual IEntityRelation RecycleServiceActionEntityUsingRecycleTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleServiceAction" , true);
				relation.AddEntityFieldPair(RecycleTypeFields.RecycleTypeId, RecycleServiceActionFields.RecycleTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleServiceActionEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between RecycleTypeEntity and RecycleVendorServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// RecycleType.RecycleTypeId - RecycleVendorService.RecycleTypeId
		/// </summary>
		public virtual IEntityRelation RecycleVendorServiceEntityUsingRecycleTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RecycleVendorService" , true);
				relation.AddEntityFieldPair(RecycleTypeFields.RecycleTypeId, RecycleVendorServiceFields.RecycleTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleVendorServiceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between RecycleTypeEntity and ServiceLocationRecycleTypeEntity over the 1:n relation they have, using the relation between the fields:
		/// RecycleType.RecycleTypeId - ServiceLocationRecycleType.RecycleTypeId
		/// </summary>
		public virtual IEntityRelation ServiceLocationRecycleTypeEntityUsingRecycleTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationRecycleType" , true);
				relation.AddEntityFieldPair(RecycleTypeFields.RecycleTypeId, ServiceLocationRecycleTypeFields.RecycleTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationRecycleTypeEntity", false);
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
