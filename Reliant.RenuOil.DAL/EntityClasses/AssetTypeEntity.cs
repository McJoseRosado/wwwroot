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
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.DaoClasses;
using Reliant.RenuOil.DAL.RelationClasses;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'AssetType'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AssetTypeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection	_serviceLocationAssetTypeId;
		private bool	_alwaysFetchServiceLocationAssetTypeId, _alreadyFetchedServiceLocationAssetTypeId;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaServiceLocationAssetTypeId;
		private bool	_alwaysFetchServiceLocationCollectionViaServiceLocationAssetTypeId, _alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId;
		private AssetCategoryEntity _assetCategory;
		private bool	_alwaysFetchAssetCategory, _alreadyFetchedAssetCategory, _assetCategoryReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name AssetCategory</summary>
			public static readonly string AssetCategory = "AssetCategory";
			/// <summary>Member name ServiceLocationAssetTypeId</summary>
			public static readonly string ServiceLocationAssetTypeId = "ServiceLocationAssetTypeId";
			/// <summary>Member name ServiceLocationCollectionViaServiceLocationAssetTypeId</summary>
			public static readonly string ServiceLocationCollectionViaServiceLocationAssetTypeId = "ServiceLocationCollectionViaServiceLocationAssetTypeId";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AssetTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AssetTypeEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		public AssetTypeEntity(System.Int32 assetTypeId)
		{
			InitClassFetch(assetTypeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AssetTypeEntity(System.Int32 assetTypeId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(assetTypeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		/// <param name="validator">The custom validator object for this AssetTypeEntity</param>
		public AssetTypeEntity(System.Int32 assetTypeId, IValidator validator)
		{
			InitClassFetch(assetTypeId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AssetTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_serviceLocationAssetTypeId = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection)info.GetValue("_serviceLocationAssetTypeId", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection));
			_alwaysFetchServiceLocationAssetTypeId = info.GetBoolean("_alwaysFetchServiceLocationAssetTypeId");
			_alreadyFetchedServiceLocationAssetTypeId = info.GetBoolean("_alreadyFetchedServiceLocationAssetTypeId");
			_serviceLocationCollectionViaServiceLocationAssetTypeId = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaServiceLocationAssetTypeId", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaServiceLocationAssetTypeId = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaServiceLocationAssetTypeId");
			_alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId");
			_assetCategory = (AssetCategoryEntity)info.GetValue("_assetCategory", typeof(AssetCategoryEntity));
			if(_assetCategory!=null)
			{
				_assetCategory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_assetCategoryReturnsNewIfNotFound = info.GetBoolean("_assetCategoryReturnsNewIfNotFound");
			_alwaysFetchAssetCategory = info.GetBoolean("_alwaysFetchAssetCategory");
			_alreadyFetchedAssetCategory = info.GetBoolean("_alreadyFetchedAssetCategory");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AssetTypeFieldIndex)fieldIndex)
			{
				case AssetTypeFieldIndex.AssetCategoryId:
					DesetupSyncAssetCategory(true, false);
					_alreadyFetchedAssetCategory = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
		
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedServiceLocationAssetTypeId = (_serviceLocationAssetTypeId.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId = (_serviceLocationCollectionViaServiceLocationAssetTypeId.Count > 0);
			_alreadyFetchedAssetCategory = (_assetCategory != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return AssetTypeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "AssetCategory":
					toReturn.Add(AssetTypeEntity.Relations.AssetCategoryEntityUsingAssetCategoryId);
					break;
				case "ServiceLocationAssetTypeId":
					toReturn.Add(AssetTypeEntity.Relations.ServiceLocationAssetTypeEntityUsingAssetTypeId);
					break;
				case "ServiceLocationCollectionViaServiceLocationAssetTypeId":
					toReturn.Add(AssetTypeEntity.Relations.ServiceLocationAssetTypeEntityUsingAssetTypeId, "AssetTypeEntity__", "ServiceLocationAssetType_", JoinHint.None);
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "ServiceLocationAssetType_", string.Empty, JoinHint.None);
					break;

				default:

					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_serviceLocationAssetTypeId", (!this.MarkedForDeletion?_serviceLocationAssetTypeId:null));
			info.AddValue("_alwaysFetchServiceLocationAssetTypeId", _alwaysFetchServiceLocationAssetTypeId);
			info.AddValue("_alreadyFetchedServiceLocationAssetTypeId", _alreadyFetchedServiceLocationAssetTypeId);
			info.AddValue("_serviceLocationCollectionViaServiceLocationAssetTypeId", (!this.MarkedForDeletion?_serviceLocationCollectionViaServiceLocationAssetTypeId:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaServiceLocationAssetTypeId", _alwaysFetchServiceLocationCollectionViaServiceLocationAssetTypeId);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId", _alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId);
			info.AddValue("_assetCategory", (!this.MarkedForDeletion?_assetCategory:null));
			info.AddValue("_assetCategoryReturnsNewIfNotFound", _assetCategoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAssetCategory", _alwaysFetchAssetCategory);
			info.AddValue("_alreadyFetchedAssetCategory", _alreadyFetchedAssetCategory);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "AssetCategory":
					_alreadyFetchedAssetCategory = true;
					this.AssetCategory = (AssetCategoryEntity)entity;
					break;
				case "ServiceLocationAssetTypeId":
					_alreadyFetchedServiceLocationAssetTypeId = true;
					if(entity!=null)
					{
						this.ServiceLocationAssetTypeId.Add((ServiceLocationAssetTypeEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaServiceLocationAssetTypeId":
					_alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaServiceLocationAssetTypeId.Add((ServiceLocationEntity)entity);
					}
					break;

				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "AssetCategory":
					SetupSyncAssetCategory(relatedEntity);
					break;
				case "ServiceLocationAssetTypeId":
					_serviceLocationAssetTypeId.Add((ServiceLocationAssetTypeEntity)relatedEntity);
					break;

				default:

					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "AssetCategory":
					DesetupSyncAssetCategory(false, true);
					break;
				case "ServiceLocationAssetTypeId":
					base.PerformRelatedEntityRemoval(_serviceLocationAssetTypeId, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_assetCategory!=null)
			{
				toReturn.Add(_assetCategory);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_serviceLocationAssetTypeId);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 assetTypeId)
		{
			return FetchUsingPK(assetTypeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 assetTypeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(assetTypeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 assetTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(assetTypeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 assetTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(assetTypeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AssetTypeId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(AssetTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(AssetTypeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new AssetTypeRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationAssetTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetTypeId(bool forceFetch)
		{
			return GetMultiServiceLocationAssetTypeId(forceFetch, _serviceLocationAssetTypeId.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationAssetTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetTypeId(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationAssetTypeId(forceFetch, _serviceLocationAssetTypeId.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetTypeId(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationAssetTypeId(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetTypeId(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationAssetTypeId || forceFetch || _alwaysFetchServiceLocationAssetTypeId) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationAssetTypeId.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationAssetTypeId);
					}
				}
				_serviceLocationAssetTypeId.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationAssetTypeId.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationAssetTypeId.GetMultiManyToOne(this, null, filter);
				_serviceLocationAssetTypeId.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationAssetTypeId = true;
			}
			return _serviceLocationAssetTypeId;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationAssetTypeId'. These settings will be taken into account
		/// when the property ServiceLocationAssetTypeId is requested or GetMultiServiceLocationAssetTypeId is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationAssetTypeId(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationAssetTypeId.SortClauses=sortClauses;
			_serviceLocationAssetTypeId.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationAssetTypeId(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaServiceLocationAssetTypeId(forceFetch, _serviceLocationCollectionViaServiceLocationAssetTypeId.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationAssetTypeId(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId || forceFetch || _alwaysFetchServiceLocationCollectionViaServiceLocationAssetTypeId) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaServiceLocationAssetTypeId.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaServiceLocationAssetTypeId);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AssetTypeFields.AssetTypeId, ComparisonOperator.Equal, this.AssetTypeId, "AssetTypeEntity__"));
				_serviceLocationCollectionViaServiceLocationAssetTypeId.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaServiceLocationAssetTypeId.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaServiceLocationAssetTypeId.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaServiceLocationAssetTypeId"));
				_serviceLocationCollectionViaServiceLocationAssetTypeId.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId = true;
			}
			return _serviceLocationCollectionViaServiceLocationAssetTypeId;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaServiceLocationAssetTypeId'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaServiceLocationAssetTypeId is requested or GetMultiServiceLocationCollectionViaServiceLocationAssetTypeId is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaServiceLocationAssetTypeId(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaServiceLocationAssetTypeId.SortClauses=sortClauses;
			_serviceLocationCollectionViaServiceLocationAssetTypeId.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'AssetCategoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AssetCategoryEntity' which is related to this entity.</returns>
		public AssetCategoryEntity GetSingleAssetCategory()
		{
			return GetSingleAssetCategory(false);
		}

		/// <summary> Retrieves the related entity of type 'AssetCategoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AssetCategoryEntity' which is related to this entity.</returns>
		public virtual AssetCategoryEntity GetSingleAssetCategory(bool forceFetch)
		{
			if( ( !_alreadyFetchedAssetCategory || forceFetch || _alwaysFetchAssetCategory) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AssetTypeEntity.Relations.AssetCategoryEntityUsingAssetCategoryId);

				AssetCategoryEntity newEntity = new AssetCategoryEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.AssetCategoryId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (AssetCategoryEntity)base.ActiveContext.Get(newEntity);
					}
					this.AssetCategory = newEntity;
				}
				else
				{
					if(_assetCategoryReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_assetCategory == null)))
						{
							this.AssetCategory = newEntity;
						}
					}
					else
					{
						this.AssetCategory = null;
					}
				}
				_alreadyFetchedAssetCategory = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _assetCategory;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			AssetTypeDAO dao = (AssetTypeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_serviceLocationAssetTypeId.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaServiceLocationAssetTypeId.ActiveContext = base.ActiveContext;
			if(_assetCategory!=null)
			{
				_assetCategory.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			AssetTypeDAO dao = (AssetTypeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			AssetTypeDAO dao = (AssetTypeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.AssetTypeEntity);
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AssetCategory", _assetCategory);
			toReturn.Add("ServiceLocationAssetTypeId", _serviceLocationAssetTypeId);
			toReturn.Add("ServiceLocationCollectionViaServiceLocationAssetTypeId", _serviceLocationCollectionViaServiceLocationAssetTypeId);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		/// <param name="validator">The validator object for this AssetTypeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 assetTypeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(assetTypeId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_serviceLocationAssetTypeId = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection(new ServiceLocationAssetTypeEntityFactory());
			_serviceLocationAssetTypeId.SetContainingEntityInfo(this, "AssetType");
			_alwaysFetchServiceLocationAssetTypeId = false;
			_alreadyFetchedServiceLocationAssetTypeId = false;
			_serviceLocationCollectionViaServiceLocationAssetTypeId = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaServiceLocationAssetTypeId = false;
			_alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId = false;
			_assetCategory = null;
			_assetCategoryReturnsNewIfNotFound = true;
			_alwaysFetchAssetCategory = false;
			_alreadyFetchedAssetCategory = false;


			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AssetTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AssetCategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("SpanishLabel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _assetCategory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAssetCategory(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _assetCategory, new PropertyChangedEventHandler( OnAssetCategoryPropertyChanged ), "AssetCategory", AssetTypeEntity.Relations.AssetCategoryEntityUsingAssetCategoryId, true, signalRelatedEntity, "AssetType", resetFKFields, new int[] { (int)AssetTypeFieldIndex.AssetCategoryId } );		
			_assetCategory = null;
		}
		
		/// <summary> setups the sync logic for member _assetCategory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAssetCategory(IEntity relatedEntity)
		{
			if(_assetCategory!=relatedEntity)
			{		
				DesetupSyncAssetCategory(true, true);
				_assetCategory = (AssetCategoryEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _assetCategory, new PropertyChangedEventHandler( OnAssetCategoryPropertyChanged ), "AssetCategory", AssetTypeEntity.Relations.AssetCategoryEntityUsingAssetCategoryId, true, ref _alreadyFetchedAssetCategory, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAssetCategoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 assetTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)AssetTypeFieldIndex.AssetTypeId].ForcedCurrentValueWrite(assetTypeId);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (base.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateAssetTypeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AssetTypeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AssetTypeRelations Relations
		{
			get	{ return new AssetTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationAssetTypeId
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetTypeId")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, null, "ServiceLocationAssetTypeId", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaServiceLocationAssetTypeId
		{
			get
			{
				IEntityRelation intermediateRelation = AssetTypeEntity.Relations.ServiceLocationAssetTypeEntityUsingAssetTypeId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationAssetType_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationAssetTypeId"), "ServiceLocationCollectionViaServiceLocationAssetTypeId", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AssetCategory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAssetCategory
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AssetCategoryCollection(),
					(IEntityRelation)GetRelationsForField("AssetCategory")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetCategoryEntity, 0, null, null, null, "AssetCategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "AssetTypeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return AssetTypeEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return AssetTypeEntity.FieldsCustomProperties;}
		}

		/// <summary> The AssetTypeId property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."AssetTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AssetTypeId
		{
			get { return (System.Int32)GetValue((int)AssetTypeFieldIndex.AssetTypeId, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.AssetTypeId, value, true); }
		}
		/// <summary> The AssetCategoryId property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."AssetCategoryId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AssetCategoryId
		{
			get { return (System.Int32)GetValue((int)AssetTypeFieldIndex.AssetCategoryId, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.AssetCategoryId, value, true); }
		}
		/// <summary> The Name property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AssetTypeFieldIndex.Name, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.Name, value, true); }
		}
		/// <summary> The Description property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)AssetTypeFieldIndex.Description, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.Description, value, true); }
		}
		/// <summary> The SpanishLabel property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."SpanishLabel"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String SpanishLabel
		{
			get { return (System.String)GetValue((int)AssetTypeFieldIndex.SpanishLabel, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.SpanishLabel, value, true); }
		}
		/// <summary> The IsActive property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)AssetTypeFieldIndex.IsActive, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.IsActive, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationAssetTypeId()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection ServiceLocationAssetTypeId
		{
			get	{ return GetMultiServiceLocationAssetTypeId(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationAssetTypeId. When set to true, ServiceLocationAssetTypeId is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationAssetTypeId is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationAssetTypeId(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationAssetTypeId
		{
			get	{ return _alwaysFetchServiceLocationAssetTypeId; }
			set	{ _alwaysFetchServiceLocationAssetTypeId = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationAssetTypeId already has been fetched. Setting this property to false when ServiceLocationAssetTypeId has been fetched
		/// will clear the ServiceLocationAssetTypeId collection well. Setting this property to true while ServiceLocationAssetTypeId hasn't been fetched disables lazy loading for ServiceLocationAssetTypeId</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationAssetTypeId
		{
			get { return _alreadyFetchedServiceLocationAssetTypeId;}
			set 
			{
				if(_alreadyFetchedServiceLocationAssetTypeId && !value && (_serviceLocationAssetTypeId != null))
				{
					_serviceLocationAssetTypeId.Clear();
				}
				_alreadyFetchedServiceLocationAssetTypeId = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaServiceLocationAssetTypeId()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaServiceLocationAssetTypeId
		{
			get { return GetMultiServiceLocationCollectionViaServiceLocationAssetTypeId(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaServiceLocationAssetTypeId. When set to true, ServiceLocationCollectionViaServiceLocationAssetTypeId is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaServiceLocationAssetTypeId is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaServiceLocationAssetTypeId(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaServiceLocationAssetTypeId
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaServiceLocationAssetTypeId; }
			set	{ _alwaysFetchServiceLocationCollectionViaServiceLocationAssetTypeId = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaServiceLocationAssetTypeId already has been fetched. Setting this property to false when ServiceLocationCollectionViaServiceLocationAssetTypeId has been fetched
		/// will clear the ServiceLocationCollectionViaServiceLocationAssetTypeId collection well. Setting this property to true while ServiceLocationCollectionViaServiceLocationAssetTypeId hasn't been fetched disables lazy loading for ServiceLocationCollectionViaServiceLocationAssetTypeId</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId
		{
			get { return _alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId && !value && (_serviceLocationCollectionViaServiceLocationAssetTypeId != null))
				{
					_serviceLocationCollectionViaServiceLocationAssetTypeId.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaServiceLocationAssetTypeId = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'AssetCategoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAssetCategory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AssetCategoryEntity AssetCategory
		{
			get	{ return GetSingleAssetCategory(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAssetCategory(value);
				}
				else
				{
					if(value==null)
					{
						if(_assetCategory != null)
						{
							_assetCategory.UnsetRelatedEntity(this, "AssetType");
						}
					}
					else
					{
						if(_assetCategory!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AssetType");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for AssetCategory. When set to true, AssetCategory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AssetCategory is accessed. You can always execute
		/// a forced fetch by calling GetSingleAssetCategory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAssetCategory
		{
			get	{ return _alwaysFetchAssetCategory; }
			set	{ _alwaysFetchAssetCategory = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AssetCategory already has been fetched. Setting this property to false when AssetCategory has been fetched
		/// will set AssetCategory to null as well. Setting this property to true while AssetCategory hasn't been fetched disables lazy loading for AssetCategory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAssetCategory
		{
			get { return _alreadyFetchedAssetCategory;}
			set 
			{
				if(_alreadyFetchedAssetCategory && !value)
				{
					this.AssetCategory = null;
				}
				_alreadyFetchedAssetCategory = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property AssetCategory is not found
		/// in the database. When set to true, AssetCategory will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool AssetCategoryReturnsNewIfNotFound
		{
			get	{ return _assetCategoryReturnsNewIfNotFound; }
			set { _assetCategoryReturnsNewIfNotFound = value; }	
		}



		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the Reliant.RenuOil.DAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity; }
		}
		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
