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
using System.Collections.Generic;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2 : EntityFactoryCore2
	{
		private string _entityName;
		private Reliant.RenuOil.DAL.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase2(string entityName, Reliant.RenuOil.DAL.EntityType typeOfEntity)
		{
			_entityName = entityName;
			_typeOfEntity = typeOfEntity;
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public override IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}
		
		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((Reliant.RenuOil.DAL.EntityType)entityTypeValue);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(_entityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			IEntityFactory2 toReturn = (IEntityFactory2)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(_entityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <param name="objectAlias">The object alias to use for the predicate(s).</param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);
		}
				
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public override string ForEntityName 
		{ 
			get { return _entityName; }
		}
	}
	
	/// <summary>Factory to create new, empty AccountEntity objects.</summary>
	[Serializable]
	public partial class AccountEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public AccountEntityFactory() : base("AccountEntity", Reliant.RenuOil.DAL.EntityType.AccountEntity) { }

		/// <summary>Creates a new, empty AccountEntity object.</summary>
		/// <returns>A new, empty AccountEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new AccountEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAccount
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new AccountEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AccountEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAccountUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<AccountEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty AccountEmployeeAssignmentEntity objects.</summary>
	[Serializable]
	public partial class AccountEmployeeAssignmentEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public AccountEmployeeAssignmentEntityFactory() : base("AccountEmployeeAssignmentEntity", Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity) { }

		/// <summary>Creates a new, empty AccountEmployeeAssignmentEntity object.</summary>
		/// <returns>A new, empty AccountEmployeeAssignmentEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new AccountEmployeeAssignmentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAccountEmployeeAssignment
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new AccountEmployeeAssignmentEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AccountEmployeeAssignmentEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAccountEmployeeAssignmentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<AccountEmployeeAssignmentEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty AssetCategoryEntity objects.</summary>
	[Serializable]
	public partial class AssetCategoryEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public AssetCategoryEntityFactory() : base("AssetCategoryEntity", Reliant.RenuOil.DAL.EntityType.AssetCategoryEntity) { }

		/// <summary>Creates a new, empty AssetCategoryEntity object.</summary>
		/// <returns>A new, empty AssetCategoryEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new AssetCategoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAssetCategory
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new AssetCategoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AssetCategoryEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAssetCategoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<AssetCategoryEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty AssetReclamationServiceEntity objects.</summary>
	[Serializable]
	public partial class AssetReclamationServiceEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public AssetReclamationServiceEntityFactory() : base("AssetReclamationServiceEntity", Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity) { }

		/// <summary>Creates a new, empty AssetReclamationServiceEntity object.</summary>
		/// <returns>A new, empty AssetReclamationServiceEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new AssetReclamationServiceEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAssetReclamationService
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new AssetReclamationServiceEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AssetReclamationServiceEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAssetReclamationServiceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<AssetReclamationServiceEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty AssetReclamationServiceChangeLogEntity objects.</summary>
	[Serializable]
	public partial class AssetReclamationServiceChangeLogEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public AssetReclamationServiceChangeLogEntityFactory() : base("AssetReclamationServiceChangeLogEntity", Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceChangeLogEntity) { }

		/// <summary>Creates a new, empty AssetReclamationServiceChangeLogEntity object.</summary>
		/// <returns>A new, empty AssetReclamationServiceChangeLogEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new AssetReclamationServiceChangeLogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAssetReclamationServiceChangeLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new AssetReclamationServiceChangeLogEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AssetReclamationServiceChangeLogEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAssetReclamationServiceChangeLogUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<AssetReclamationServiceChangeLogEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty AssetTypeEntity objects.</summary>
	[Serializable]
	public partial class AssetTypeEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public AssetTypeEntityFactory() : base("AssetTypeEntity", Reliant.RenuOil.DAL.EntityType.AssetTypeEntity) { }

		/// <summary>Creates a new, empty AssetTypeEntity object.</summary>
		/// <returns>A new, empty AssetTypeEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new AssetTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAssetType
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new AssetTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AssetTypeEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAssetTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<AssetTypeEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty BaleEntity objects.</summary>
	[Serializable]
	public partial class BaleEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public BaleEntityFactory() : base("BaleEntity", Reliant.RenuOil.DAL.EntityType.BaleEntity) { }

		/// <summary>Creates a new, empty BaleEntity object.</summary>
		/// <returns>A new, empty BaleEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new BaleEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBale
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new BaleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BaleEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBaleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<BaleEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ChangeLogEntity objects.</summary>
	[Serializable]
	public partial class ChangeLogEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ChangeLogEntityFactory() : base("ChangeLogEntity", Reliant.RenuOil.DAL.EntityType.ChangeLogEntity) { }

		/// <summary>Creates a new, empty ChangeLogEntity object.</summary>
		/// <returns>A new, empty ChangeLogEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ChangeLogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewChangeLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new ChangeLogEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ChangeLogEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewChangeLogUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ChangeLogEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ChangeTypeEntity objects.</summary>
	[Serializable]
	public partial class ChangeTypeEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ChangeTypeEntityFactory() : base("ChangeTypeEntity", Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity) { }

		/// <summary>Creates a new, empty ChangeTypeEntity object.</summary>
		/// <returns>A new, empty ChangeTypeEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ChangeTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewChangeType
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new ChangeTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ChangeTypeEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewChangeTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ChangeTypeEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DeepFryerEntity objects.</summary>
	[Serializable]
	public partial class DeepFryerEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DeepFryerEntityFactory() : base("DeepFryerEntity", Reliant.RenuOil.DAL.EntityType.DeepFryerEntity) { }

		/// <summary>Creates a new, empty DeepFryerEntity object.</summary>
		/// <returns>A new, empty DeepFryerEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DeepFryerEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDeepFryer
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new DeepFryerEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DeepFryerEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDeepFryerUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DeepFryerEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DeepFryerChangeLogEntity objects.</summary>
	[Serializable]
	public partial class DeepFryerChangeLogEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DeepFryerChangeLogEntityFactory() : base("DeepFryerChangeLogEntity", Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity) { }

		/// <summary>Creates a new, empty DeepFryerChangeLogEntity object.</summary>
		/// <returns>A new, empty DeepFryerChangeLogEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DeepFryerChangeLogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDeepFryerChangeLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new DeepFryerChangeLogEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DeepFryerChangeLogEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDeepFryerChangeLogUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DeepFryerChangeLogEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DeepFryerServiceEntity objects.</summary>
	[Serializable]
	public partial class DeepFryerServiceEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DeepFryerServiceEntityFactory() : base("DeepFryerServiceEntity", Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity) { }

		/// <summary>Creates a new, empty DeepFryerServiceEntity object.</summary>
		/// <returns>A new, empty DeepFryerServiceEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DeepFryerServiceEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDeepFryerService
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new DeepFryerServiceEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DeepFryerServiceEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDeepFryerServiceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DeepFryerServiceEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DeepFryerServiceChangeLogEntity objects.</summary>
	[Serializable]
	public partial class DeepFryerServiceChangeLogEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DeepFryerServiceChangeLogEntityFactory() : base("DeepFryerServiceChangeLogEntity", Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity) { }

		/// <summary>Creates a new, empty DeepFryerServiceChangeLogEntity object.</summary>
		/// <returns>A new, empty DeepFryerServiceChangeLogEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DeepFryerServiceChangeLogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDeepFryerServiceChangeLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new DeepFryerServiceChangeLogEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DeepFryerServiceChangeLogEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDeepFryerServiceChangeLogUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DeepFryerServiceChangeLogEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DockEntity objects.</summary>
	[Serializable]
	public partial class DockEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DockEntityFactory() : base("DockEntity", Reliant.RenuOil.DAL.EntityType.DockEntity) { }

		/// <summary>Creates a new, empty DockEntity object.</summary>
		/// <returns>A new, empty DockEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DockEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDock
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new DockEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DockEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDockUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DockEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty EmployeeEntity objects.</summary>
	[Serializable]
	public partial class EmployeeEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public EmployeeEntityFactory() : base("EmployeeEntity", Reliant.RenuOil.DAL.EntityType.EmployeeEntity) { }

		/// <summary>Creates a new, empty EmployeeEntity object.</summary>
		/// <returns>A new, empty EmployeeEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new EmployeeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployee
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new EmployeeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new EmployeeEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<EmployeeEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty LoadEntity objects.</summary>
	[Serializable]
	public partial class LoadEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public LoadEntityFactory() : base("LoadEntity", Reliant.RenuOil.DAL.EntityType.LoadEntity) { }

		/// <summary>Creates a new, empty LoadEntity object.</summary>
		/// <returns>A new, empty LoadEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new LoadEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLoad
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new LoadEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new LoadEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLoadUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<LoadEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty MobileDeviceEntity objects.</summary>
	[Serializable]
	public partial class MobileDeviceEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public MobileDeviceEntityFactory() : base("MobileDeviceEntity", Reliant.RenuOil.DAL.EntityType.MobileDeviceEntity) { }

		/// <summary>Creates a new, empty MobileDeviceEntity object.</summary>
		/// <returns>A new, empty MobileDeviceEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new MobileDeviceEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMobileDevice
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new MobileDeviceEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new MobileDeviceEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMobileDeviceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MobileDeviceEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RebateEntity objects.</summary>
	[Serializable]
	public partial class RebateEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public RebateEntityFactory() : base("RebateEntity", Reliant.RenuOil.DAL.EntityType.RebateEntity) { }

		/// <summary>Creates a new, empty RebateEntity object.</summary>
		/// <returns>A new, empty RebateEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new RebateEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRebate
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new RebateEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RebateEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRebateUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<RebateEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RebateTypeEntity objects.</summary>
	[Serializable]
	public partial class RebateTypeEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public RebateTypeEntityFactory() : base("RebateTypeEntity", Reliant.RenuOil.DAL.EntityType.RebateTypeEntity) { }

		/// <summary>Creates a new, empty RebateTypeEntity object.</summary>
		/// <returns>A new, empty RebateTypeEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new RebateTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRebateType
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new RebateTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RebateTypeEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRebateTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<RebateTypeEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RecycleServiceEntity objects.</summary>
	[Serializable]
	public partial class RecycleServiceEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public RecycleServiceEntityFactory() : base("RecycleServiceEntity", Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity) { }

		/// <summary>Creates a new, empty RecycleServiceEntity object.</summary>
		/// <returns>A new, empty RecycleServiceEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new RecycleServiceEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleService
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new RecycleServiceEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RecycleServiceEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleServiceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<RecycleServiceEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RecycleServiceActionEntity objects.</summary>
	[Serializable]
	public partial class RecycleServiceActionEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public RecycleServiceActionEntityFactory() : base("RecycleServiceActionEntity", Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity) { }

		/// <summary>Creates a new, empty RecycleServiceActionEntity object.</summary>
		/// <returns>A new, empty RecycleServiceActionEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new RecycleServiceActionEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleServiceAction
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new RecycleServiceActionEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RecycleServiceActionEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleServiceActionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<RecycleServiceActionEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RecycleServiceChangeLogEntity objects.</summary>
	[Serializable]
	public partial class RecycleServiceChangeLogEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public RecycleServiceChangeLogEntityFactory() : base("RecycleServiceChangeLogEntity", Reliant.RenuOil.DAL.EntityType.RecycleServiceChangeLogEntity) { }

		/// <summary>Creates a new, empty RecycleServiceChangeLogEntity object.</summary>
		/// <returns>A new, empty RecycleServiceChangeLogEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new RecycleServiceChangeLogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleServiceChangeLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new RecycleServiceChangeLogEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RecycleServiceChangeLogEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleServiceChangeLogUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<RecycleServiceChangeLogEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RecycleTypeEntity objects.</summary>
	[Serializable]
	public partial class RecycleTypeEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public RecycleTypeEntityFactory() : base("RecycleTypeEntity", Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity) { }

		/// <summary>Creates a new, empty RecycleTypeEntity object.</summary>
		/// <returns>A new, empty RecycleTypeEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new RecycleTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleType
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new RecycleTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RecycleTypeEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<RecycleTypeEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RecycleVendorEntity objects.</summary>
	[Serializable]
	public partial class RecycleVendorEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public RecycleVendorEntityFactory() : base("RecycleVendorEntity", Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity) { }

		/// <summary>Creates a new, empty RecycleVendorEntity object.</summary>
		/// <returns>A new, empty RecycleVendorEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new RecycleVendorEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleVendor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new RecycleVendorEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RecycleVendorEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleVendorUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<RecycleVendorEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RecycleVendorServiceEntity objects.</summary>
	[Serializable]
	public partial class RecycleVendorServiceEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public RecycleVendorServiceEntityFactory() : base("RecycleVendorServiceEntity", Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity) { }

		/// <summary>Creates a new, empty RecycleVendorServiceEntity object.</summary>
		/// <returns>A new, empty RecycleVendorServiceEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new RecycleVendorServiceEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleVendorService
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new RecycleVendorServiceEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RecycleVendorServiceEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRecycleVendorServiceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<RecycleVendorServiceEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ServiceLocationEntity objects.</summary>
	[Serializable]
	public partial class ServiceLocationEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ServiceLocationEntityFactory() : base("ServiceLocationEntity", Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity) { }

		/// <summary>Creates a new, empty ServiceLocationEntity object.</summary>
		/// <returns>A new, empty ServiceLocationEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ServiceLocationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceLocation
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new ServiceLocationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ServiceLocationEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceLocationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ServiceLocationEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ServiceLocationAssetTypeEntity objects.</summary>
	[Serializable]
	public partial class ServiceLocationAssetTypeEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ServiceLocationAssetTypeEntityFactory() : base("ServiceLocationAssetTypeEntity", Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity) { }

		/// <summary>Creates a new, empty ServiceLocationAssetTypeEntity object.</summary>
		/// <returns>A new, empty ServiceLocationAssetTypeEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ServiceLocationAssetTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceLocationAssetType
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new ServiceLocationAssetTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ServiceLocationAssetTypeEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceLocationAssetTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ServiceLocationAssetTypeEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ServiceLocationAssetTypeChangeLogEntity objects.</summary>
	[Serializable]
	public partial class ServiceLocationAssetTypeChangeLogEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ServiceLocationAssetTypeChangeLogEntityFactory() : base("ServiceLocationAssetTypeChangeLogEntity", Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity) { }

		/// <summary>Creates a new, empty ServiceLocationAssetTypeChangeLogEntity object.</summary>
		/// <returns>A new, empty ServiceLocationAssetTypeChangeLogEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ServiceLocationAssetTypeChangeLogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceLocationAssetTypeChangeLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new ServiceLocationAssetTypeChangeLogEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ServiceLocationAssetTypeChangeLogEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceLocationAssetTypeChangeLogUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ServiceLocationAssetTypeChangeLogEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ServiceLocationEmployeeAssignmentEntity objects.</summary>
	[Serializable]
	public partial class ServiceLocationEmployeeAssignmentEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ServiceLocationEmployeeAssignmentEntityFactory() : base("ServiceLocationEmployeeAssignmentEntity", Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity) { }

		/// <summary>Creates a new, empty ServiceLocationEmployeeAssignmentEntity object.</summary>
		/// <returns>A new, empty ServiceLocationEmployeeAssignmentEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ServiceLocationEmployeeAssignmentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceLocationEmployeeAssignment
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new ServiceLocationEmployeeAssignmentEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ServiceLocationEmployeeAssignmentEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceLocationEmployeeAssignmentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ServiceLocationRecycleTypeEntity objects.</summary>
	[Serializable]
	public partial class ServiceLocationRecycleTypeEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ServiceLocationRecycleTypeEntityFactory() : base("ServiceLocationRecycleTypeEntity", Reliant.RenuOil.DAL.EntityType.ServiceLocationRecycleTypeEntity) { }

		/// <summary>Creates a new, empty ServiceLocationRecycleTypeEntity object.</summary>
		/// <returns>A new, empty ServiceLocationRecycleTypeEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ServiceLocationRecycleTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceLocationRecycleType
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new ServiceLocationRecycleTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ServiceLocationRecycleTypeEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceLocationRecycleTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ServiceLocationRecycleTypeEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ServiceTypeEntity objects.</summary>
	[Serializable]
	public partial class ServiceTypeEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ServiceTypeEntityFactory() : base("ServiceTypeEntity", Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity) { }

		/// <summary>Creates a new, empty ServiceTypeEntity object.</summary>
		/// <returns>A new, empty ServiceTypeEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ServiceTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceType
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new ServiceTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ServiceTypeEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewServiceTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ServiceTypeEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty SettingEntity objects.</summary>
	[Serializable]
	public partial class SettingEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public SettingEntityFactory() : base("SettingEntity", Reliant.RenuOil.DAL.EntityType.SettingEntity) { }

		/// <summary>Creates a new, empty SettingEntity object.</summary>
		/// <returns>A new, empty SettingEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new SettingEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSetting
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new SettingEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SettingEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSettingUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<SettingEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty StatusEntity objects.</summary>
	[Serializable]
	public partial class StatusEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public StatusEntityFactory() : base("StatusEntity", Reliant.RenuOil.DAL.EntityType.StatusEntity) { }

		/// <summary>Creates a new, empty StatusEntity object.</summary>
		/// <returns>A new, empty StatusEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new StatusEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStatus
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new StatusEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new StatusEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStatusUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<StatusEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty UserEntity objects.</summary>
	[Serializable]
	public partial class UserEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public UserEntityFactory() : base("UserEntity", Reliant.RenuOil.DAL.EntityType.UserEntity) { }

		/// <summary>Creates a new, empty UserEntity object.</summary>
		/// <returns>A new, empty UserEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new UserEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUser
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new UserEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new UserEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<UserEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty UserAccountEntity objects.</summary>
	[Serializable]
	public partial class UserAccountEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public UserAccountEntityFactory() : base("UserAccountEntity", Reliant.RenuOil.DAL.EntityType.UserAccountEntity) { }

		/// <summary>Creates a new, empty UserAccountEntity object.</summary>
		/// <returns>A new, empty UserAccountEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new UserAccountEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserAccount
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new UserAccountEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new UserAccountEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserAccountUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<UserAccountEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty UserTypeEntity objects.</summary>
	[Serializable]
	public partial class UserTypeEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public UserTypeEntityFactory() : base("UserTypeEntity", Reliant.RenuOil.DAL.EntityType.UserTypeEntity) { }

		/// <summary>Creates a new, empty UserTypeEntity object.</summary>
		/// <returns>A new, empty UserTypeEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new UserTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserType
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new UserTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new UserTypeEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUserTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<UserTypeEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty WorkOrderEntity objects.</summary>
	[Serializable]
	public partial class WorkOrderEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public WorkOrderEntityFactory() : base("WorkOrderEntity", Reliant.RenuOil.DAL.EntityType.WorkOrderEntity) { }

		/// <summary>Creates a new, empty WorkOrderEntity object.</summary>
		/// <returns>A new, empty WorkOrderEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new WorkOrderEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrder
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new WorkOrderEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new WorkOrderEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrderUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<WorkOrderEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty WorkOrderEmployeeEntity objects.</summary>
	[Serializable]
	public partial class WorkOrderEmployeeEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public WorkOrderEmployeeEntityFactory() : base("WorkOrderEmployeeEntity", Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity) { }

		/// <summary>Creates a new, empty WorkOrderEmployeeEntity object.</summary>
		/// <returns>A new, empty WorkOrderEmployeeEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new WorkOrderEmployeeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrderEmployee
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new WorkOrderEmployeeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new WorkOrderEmployeeEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrderEmployeeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<WorkOrderEmployeeEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty WorkOrderServiceLocationEntity objects.</summary>
	[Serializable]
	public partial class WorkOrderServiceLocationEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public WorkOrderServiceLocationEntityFactory() : base("WorkOrderServiceLocationEntity", Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity) { }

		/// <summary>Creates a new, empty WorkOrderServiceLocationEntity object.</summary>
		/// <returns>A new, empty WorkOrderServiceLocationEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new WorkOrderServiceLocationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrderServiceLocation
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new WorkOrderServiceLocationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new WorkOrderServiceLocationEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrderServiceLocationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<WorkOrderServiceLocationEntity>(this);
		}
		

		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(Reliant.RenuOil.DAL.EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case Reliant.RenuOil.DAL.EntityType.AccountEntity:
					factoryToUse = new AccountEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity:
					factoryToUse = new AccountEmployeeAssignmentEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.AssetCategoryEntity:
					factoryToUse = new AssetCategoryEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity:
					factoryToUse = new AssetReclamationServiceEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceChangeLogEntity:
					factoryToUse = new AssetReclamationServiceChangeLogEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.AssetTypeEntity:
					factoryToUse = new AssetTypeEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.BaleEntity:
					factoryToUse = new BaleEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.ChangeLogEntity:
					factoryToUse = new ChangeLogEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity:
					factoryToUse = new ChangeTypeEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.DeepFryerEntity:
					factoryToUse = new DeepFryerEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity:
					factoryToUse = new DeepFryerChangeLogEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity:
					factoryToUse = new DeepFryerServiceEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity:
					factoryToUse = new DeepFryerServiceChangeLogEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.DockEntity:
					factoryToUse = new DockEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.EmployeeEntity:
					factoryToUse = new EmployeeEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.LoadEntity:
					factoryToUse = new LoadEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.MobileDeviceEntity:
					factoryToUse = new MobileDeviceEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.RebateEntity:
					factoryToUse = new RebateEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.RebateTypeEntity:
					factoryToUse = new RebateTypeEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity:
					factoryToUse = new RecycleServiceEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity:
					factoryToUse = new RecycleServiceActionEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleServiceChangeLogEntity:
					factoryToUse = new RecycleServiceChangeLogEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity:
					factoryToUse = new RecycleTypeEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity:
					factoryToUse = new RecycleVendorEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity:
					factoryToUse = new RecycleVendorServiceEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity:
					factoryToUse = new ServiceLocationEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity:
					factoryToUse = new ServiceLocationAssetTypeEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity:
					factoryToUse = new ServiceLocationAssetTypeChangeLogEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity:
					factoryToUse = new ServiceLocationEmployeeAssignmentEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceLocationRecycleTypeEntity:
					factoryToUse = new ServiceLocationRecycleTypeEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity:
					factoryToUse = new ServiceTypeEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.SettingEntity:
					factoryToUse = new SettingEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.StatusEntity:
					factoryToUse = new StatusEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.UserEntity:
					factoryToUse = new UserEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.UserAccountEntity:
					factoryToUse = new UserAccountEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.UserTypeEntity:
					factoryToUse = new UserTypeEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.WorkOrderEntity:
					factoryToUse = new WorkOrderEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity:
					factoryToUse = new WorkOrderEmployeeEntityFactory();
					break;
				case Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity:
					factoryToUse = new WorkOrderServiceLocationEntityFactory();
					break;
			}
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
		
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the Reliant.RenuOil.DAL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Reliant.RenuOil.DAL.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(Reliant.RenuOil.DAL.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity2 dummy = GeneralEntityFactory.Create((Reliant.RenuOil.DAL.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			IEntityFactory2 toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the Reliant.RenuOil.DAL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Reliant.RenuOil.DAL.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif		
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the Reliant.RenuOil.DAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue)
		{
			return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue);
		}
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (Reliant.RenuOil.DAL.EntityType)Enum.Parse(typeof(Reliant.RenuOil.DAL.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((Reliant.RenuOil.DAL.EntityType)Enum.Parse(typeof(Reliant.RenuOil.DAL.EntityType), leftOperandEntityName, false), joinType, (Reliant.RenuOil.DAL.EntityType)Enum.Parse(typeof(Reliant.RenuOil.DAL.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the Reliant.RenuOil.DAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((Reliant.RenuOil.DAL.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
