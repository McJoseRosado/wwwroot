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
	/// <summary>Implements the static Relations variant for the entity: RecycleVendorService. </summary>
	public partial class RecycleVendorServiceRelations
	{
		/// <summary>CTor</summary>
		public RecycleVendorServiceRelations()
		{
		}

		/// <summary>Gets all relations of the RecycleVendorServiceEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.AccountEntityUsingAccountId);
			toReturn.Add(this.RecycleTypeEntityUsingRecycleTypeId);
			toReturn.Add(this.RecycleVendorEntityUsingRecycleVendorId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between RecycleVendorServiceEntity and AccountEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleVendorService.AccountId - Account.AccountId
		/// </summary>
		public virtual IEntityRelation AccountEntityUsingAccountId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Account", false);
				relation.AddEntityFieldPair(AccountFields.AccountId, RecycleVendorServiceFields.AccountId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AccountEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleVendorServiceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RecycleVendorServiceEntity and RecycleTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleVendorService.RecycleTypeId - RecycleType.RecycleTypeId
		/// </summary>
		public virtual IEntityRelation RecycleTypeEntityUsingRecycleTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RecycleType", false);
				relation.AddEntityFieldPair(RecycleTypeFields.RecycleTypeId, RecycleVendorServiceFields.RecycleTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleVendorServiceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between RecycleVendorServiceEntity and RecycleVendorEntity over the m:1 relation they have, using the relation between the fields:
		/// RecycleVendorService.RecycleVendorId - RecycleVendor.RecycleVendorId
		/// </summary>
		public virtual IEntityRelation RecycleVendorEntityUsingRecycleVendorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RecycleVendor", false);
				relation.AddEntityFieldPair(RecycleVendorFields.RecycleVendorId, RecycleVendorServiceFields.RecycleVendorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleVendorEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RecycleVendorServiceEntity", true);
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
