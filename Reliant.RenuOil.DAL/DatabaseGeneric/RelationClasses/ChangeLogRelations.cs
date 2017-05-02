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
	/// <summary>Implements the static Relations variant for the entity: ChangeLog. </summary>
	public partial class ChangeLogRelations
	{
		/// <summary>CTor</summary>
		public ChangeLogRelations()
		{
		}

		/// <summary>Gets all relations of the ChangeLogEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.DeepFryerChangeLogEntityUsingChangeLogId);
			toReturn.Add(this.ServiceLocationAssetTypeChangeLogEntityUsingChangeLogId);

			toReturn.Add(this.ChangeTypeEntityUsingChangeTypeId);
			toReturn.Add(this.UserEntityUsingUserId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ChangeLogEntity and DeepFryerChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// ChangeLog.ChangeLogId - DeepFryerChangeLog.ChangeLogId
		/// </summary>
		public virtual IEntityRelation DeepFryerChangeLogEntityUsingChangeLogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerChangeLog" , true);
				relation.AddEntityFieldPair(ChangeLogFields.ChangeLogId, DeepFryerChangeLogFields.ChangeLogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChangeLogEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ChangeLogEntity and ServiceLocationAssetTypeChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// ChangeLog.ChangeLogId - ServiceLocationAssetTypeChangeLog.ChangeLogId
		/// </summary>
		public virtual IEntityRelation ServiceLocationAssetTypeChangeLogEntityUsingChangeLogId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationAssetTypeChangeLog" , true);
				relation.AddEntityFieldPair(ChangeLogFields.ChangeLogId, ServiceLocationAssetTypeChangeLogFields.ChangeLogId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChangeLogEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeChangeLogEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ChangeLogEntity and ChangeTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// ChangeLog.ChangeTypeId - ChangeType.ChangeTypeId
		/// </summary>
		public virtual IEntityRelation ChangeTypeEntityUsingChangeTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ChangeType", false);
				relation.AddEntityFieldPair(ChangeTypeFields.ChangeTypeId, ChangeLogFields.ChangeTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChangeTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChangeLogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ChangeLogEntity and UserEntity over the m:1 relation they have, using the relation between the fields:
		/// ChangeLog.UserId - User.UserId
		/// </summary>
		public virtual IEntityRelation UserEntityUsingUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "User", false);
				relation.AddEntityFieldPair(UserFields.UserId, ChangeLogFields.UserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChangeLogEntity", true);
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
