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
	/// <summary>Implements the static Relations variant for the entity: DeepFryer. </summary>
	public partial class DeepFryerRelations
	{
		/// <summary>CTor</summary>
		public DeepFryerRelations()
		{
		}

		/// <summary>Gets all relations of the DeepFryerEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.DeepFryerChangeLogEntityUsingDeepFryerId);
			toReturn.Add(this.DeepFryerServiceEntityUsingDeepFryerId);

			toReturn.Add(this.ServiceLocationEntityUsingServiceLocationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between DeepFryerEntity and DeepFryerChangeLogEntity over the 1:n relation they have, using the relation between the fields:
		/// DeepFryer.DeepFryerId - DeepFryerChangeLog.DeepFryerId
		/// </summary>
		public virtual IEntityRelation DeepFryerChangeLogEntityUsingDeepFryerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerChangeLog" , true);
				relation.AddEntityFieldPair(DeepFryerFields.DeepFryerId, DeepFryerChangeLogFields.DeepFryerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerChangeLogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DeepFryerEntity and DeepFryerServiceEntity over the 1:n relation they have, using the relation between the fields:
		/// DeepFryer.DeepFryerId - DeepFryerService.DeepFryerId
		/// </summary>
		public virtual IEntityRelation DeepFryerServiceEntityUsingDeepFryerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DeepFryerService" , true);
				relation.AddEntityFieldPair(DeepFryerFields.DeepFryerId, DeepFryerServiceFields.DeepFryerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerServiceEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between DeepFryerEntity and ServiceLocationEntity over the m:1 relation they have, using the relation between the fields:
		/// DeepFryer.ServiceLocationId - ServiceLocation.ServiceLocationId
		/// </summary>
		public virtual IEntityRelation ServiceLocationEntityUsingServiceLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ServiceLocation", false);
				relation.AddEntityFieldPair(ServiceLocationFields.ServiceLocationId, DeepFryerFields.ServiceLocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ServiceLocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DeepFryerEntity", true);
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
