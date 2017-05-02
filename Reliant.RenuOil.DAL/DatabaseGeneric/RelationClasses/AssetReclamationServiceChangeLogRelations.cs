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
	/// <summary>Implements the static Relations variant for the entity: AssetReclamationServiceChangeLog. </summary>
	public partial class AssetReclamationServiceChangeLogRelations
	{
		/// <summary>CTor</summary>
		public AssetReclamationServiceChangeLogRelations()
		{
		}

		/// <summary>Gets all relations of the AssetReclamationServiceChangeLogEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.AssetReclamationServiceEntityUsingAssetReclamationServiceId);
			toReturn.Add(this.EmployeeEntityUsingEnteredByEmployeeId);
			toReturn.Add(this.UserEntityUsingEnteredByUserId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between AssetReclamationServiceChangeLogEntity and AssetReclamationServiceEntity over the m:1 relation they have, using the relation between the fields:
		/// AssetReclamationServiceChangeLog.AssetReclamationServiceId - AssetReclamationService.AssetReclamationServiceId
		/// </summary>
		public virtual IEntityRelation AssetReclamationServiceEntityUsingAssetReclamationServiceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AssetReclamationService", false);
				relation.AddEntityFieldPair(AssetReclamationServiceFields.AssetReclamationServiceId, AssetReclamationServiceChangeLogFields.AssetReclamationServiceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceChangeLogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AssetReclamationServiceChangeLogEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// AssetReclamationServiceChangeLog.EnteredByEmployeeId - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEnteredByEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, AssetReclamationServiceChangeLogFields.EnteredByEmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceChangeLogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between AssetReclamationServiceChangeLogEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// AssetReclamationServiceChangeLog.EnteredByUserId - User.UserId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingEnteredByUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.UserId, AssetReclamationServiceChangeLogFields.EnteredByUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetReclamationServiceChangeLogEntity", true);
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
