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
	/// <summary>Implements the static Relations variant for the entity: AssetType. </summary>
	public partial class AssetTypeRelations
	{
		/// <summary>CTor</summary>
		public AssetTypeRelations()
		{
		}

		/// <summary>Gets all relations of the AssetTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ServiceLocationAssetTypeEntityUsingAssetTypeId);

			toReturn.Add(this.AssetCategoryEntityUsingAssetCategoryId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AssetTypeEntity and ServiceLocationAssetTypeEntity over the 1:n relation they have, using the relation between the fields:
		/// AssetType.AssetTypeId - ServiceLocationAssetType.AssetTypeId
		/// </summary>
		public virtual IEntityRelation ServiceLocationAssetTypeEntityUsingAssetTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ServiceLocationAssetTypeId" , true);
				relation.AddEntityFieldPair(AssetTypeFields.AssetTypeId, ServiceLocationAssetTypeFields.AssetTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationAssetTypeEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between AssetTypeEntity and AssetCategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// AssetType.AssetCategoryId - AssetCategory.AssetCategoryId
		/// </summary>
		public virtual IEntityRelation AssetCategoryEntityUsingAssetCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AssetCategory", false);
				relation.AddEntityFieldPair(AssetCategoryFields.AssetCategoryId, AssetTypeFields.AssetCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetCategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AssetTypeEntity", true);
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
