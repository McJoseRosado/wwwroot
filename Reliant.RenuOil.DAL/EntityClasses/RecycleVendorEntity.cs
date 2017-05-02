﻿///////////////////////////////////////////////////////////////
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
	/// Entity class which represents the entity 'RecycleVendor'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class RecycleVendorEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection	_recycleVendorService;
		private bool	_alwaysFetchRecycleVendorService, _alreadyFetchedRecycleVendorService;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaRecycleVendorService;
		private bool	_alwaysFetchAccountCollectionViaRecycleVendorService, _alreadyFetchedAccountCollectionViaRecycleVendorService;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection _recycleTypeCollectionViaRecycleVendorService;
		private bool	_alwaysFetchRecycleTypeCollectionViaRecycleVendorService, _alreadyFetchedRecycleTypeCollectionViaRecycleVendorService;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name RecycleVendorService</summary>
			public static readonly string RecycleVendorService = "RecycleVendorService";
			/// <summary>Member name AccountCollectionViaRecycleVendorService</summary>
			public static readonly string AccountCollectionViaRecycleVendorService = "AccountCollectionViaRecycleVendorService";
			/// <summary>Member name RecycleTypeCollectionViaRecycleVendorService</summary>
			public static readonly string RecycleTypeCollectionViaRecycleVendorService = "RecycleTypeCollectionViaRecycleVendorService";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RecycleVendorEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public RecycleVendorEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="recycleVendorId">PK value for RecycleVendor which data should be fetched into this RecycleVendor object</param>
		public RecycleVendorEntity(System.Int32 recycleVendorId)
		{
			InitClassFetch(recycleVendorId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="recycleVendorId">PK value for RecycleVendor which data should be fetched into this RecycleVendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public RecycleVendorEntity(System.Int32 recycleVendorId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(recycleVendorId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="recycleVendorId">PK value for RecycleVendor which data should be fetched into this RecycleVendor object</param>
		/// <param name="validator">The custom validator object for this RecycleVendorEntity</param>
		public RecycleVendorEntity(System.Int32 recycleVendorId, IValidator validator)
		{
			InitClassFetch(recycleVendorId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RecycleVendorEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_recycleVendorService = (Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection)info.GetValue("_recycleVendorService", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection));
			_alwaysFetchRecycleVendorService = info.GetBoolean("_alwaysFetchRecycleVendorService");
			_alreadyFetchedRecycleVendorService = info.GetBoolean("_alreadyFetchedRecycleVendorService");
			_accountCollectionViaRecycleVendorService = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaRecycleVendorService", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaRecycleVendorService = info.GetBoolean("_alwaysFetchAccountCollectionViaRecycleVendorService");
			_alreadyFetchedAccountCollectionViaRecycleVendorService = info.GetBoolean("_alreadyFetchedAccountCollectionViaRecycleVendorService");
			_recycleTypeCollectionViaRecycleVendorService = (Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection)info.GetValue("_recycleTypeCollectionViaRecycleVendorService", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection));
			_alwaysFetchRecycleTypeCollectionViaRecycleVendorService = info.GetBoolean("_alwaysFetchRecycleTypeCollectionViaRecycleVendorService");
			_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = info.GetBoolean("_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((RecycleVendorFieldIndex)fieldIndex)
			{
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
			_alreadyFetchedRecycleVendorService = (_recycleVendorService.Count > 0);
			_alreadyFetchedAccountCollectionViaRecycleVendorService = (_accountCollectionViaRecycleVendorService.Count > 0);
			_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = (_recycleTypeCollectionViaRecycleVendorService.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return RecycleVendorEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "RecycleVendorService":
					toReturn.Add(RecycleVendorEntity.Relations.RecycleVendorServiceEntityUsingRecycleVendorId);
					break;
				case "AccountCollectionViaRecycleVendorService":
					toReturn.Add(RecycleVendorEntity.Relations.RecycleVendorServiceEntityUsingRecycleVendorId, "RecycleVendorEntity__", "RecycleVendorService_", JoinHint.None);
					toReturn.Add(RecycleVendorServiceEntity.Relations.AccountEntityUsingAccountId, "RecycleVendorService_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaRecycleVendorService":
					toReturn.Add(RecycleVendorEntity.Relations.RecycleVendorServiceEntityUsingRecycleVendorId, "RecycleVendorEntity__", "RecycleVendorService_", JoinHint.None);
					toReturn.Add(RecycleVendorServiceEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "RecycleVendorService_", string.Empty, JoinHint.None);
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
			info.AddValue("_recycleVendorService", (!this.MarkedForDeletion?_recycleVendorService:null));
			info.AddValue("_alwaysFetchRecycleVendorService", _alwaysFetchRecycleVendorService);
			info.AddValue("_alreadyFetchedRecycleVendorService", _alreadyFetchedRecycleVendorService);
			info.AddValue("_accountCollectionViaRecycleVendorService", (!this.MarkedForDeletion?_accountCollectionViaRecycleVendorService:null));
			info.AddValue("_alwaysFetchAccountCollectionViaRecycleVendorService", _alwaysFetchAccountCollectionViaRecycleVendorService);
			info.AddValue("_alreadyFetchedAccountCollectionViaRecycleVendorService", _alreadyFetchedAccountCollectionViaRecycleVendorService);
			info.AddValue("_recycleTypeCollectionViaRecycleVendorService", (!this.MarkedForDeletion?_recycleTypeCollectionViaRecycleVendorService:null));
			info.AddValue("_alwaysFetchRecycleTypeCollectionViaRecycleVendorService", _alwaysFetchRecycleTypeCollectionViaRecycleVendorService);
			info.AddValue("_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService", _alreadyFetchedRecycleTypeCollectionViaRecycleVendorService);


			
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

				case "RecycleVendorService":
					_alreadyFetchedRecycleVendorService = true;
					if(entity!=null)
					{
						this.RecycleVendorService.Add((RecycleVendorServiceEntity)entity);
					}
					break;
				case "AccountCollectionViaRecycleVendorService":
					_alreadyFetchedAccountCollectionViaRecycleVendorService = true;
					if(entity!=null)
					{
						this.AccountCollectionViaRecycleVendorService.Add((AccountEntity)entity);
					}
					break;
				case "RecycleTypeCollectionViaRecycleVendorService":
					_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = true;
					if(entity!=null)
					{
						this.RecycleTypeCollectionViaRecycleVendorService.Add((RecycleTypeEntity)entity);
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

				case "RecycleVendorService":
					_recycleVendorService.Add((RecycleVendorServiceEntity)relatedEntity);
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

				case "RecycleVendorService":
					base.PerformRelatedEntityRemoval(_recycleVendorService, relatedEntity, signalRelatedEntityManyToOne);
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



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_recycleVendorService);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleVendorId">PK value for RecycleVendor which data should be fetched into this RecycleVendor object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleVendorId)
		{
			return FetchUsingPK(recycleVendorId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleVendorId">PK value for RecycleVendor which data should be fetched into this RecycleVendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleVendorId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(recycleVendorId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleVendorId">PK value for RecycleVendor which data should be fetched into this RecycleVendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleVendorId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(recycleVendorId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleVendorId">PK value for RecycleVendor which data should be fetched into this RecycleVendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleVendorId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(recycleVendorId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.RecycleVendorId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(RecycleVendorFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(RecycleVendorFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new RecycleVendorRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'RecycleVendorServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleVendorServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection GetMultiRecycleVendorService(bool forceFetch)
		{
			return GetMultiRecycleVendorService(forceFetch, _recycleVendorService.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleVendorServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'RecycleVendorServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection GetMultiRecycleVendorService(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiRecycleVendorService(forceFetch, _recycleVendorService.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'RecycleVendorServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection GetMultiRecycleVendorService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiRecycleVendorService(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleVendorServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection GetMultiRecycleVendorService(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedRecycleVendorService || forceFetch || _alwaysFetchRecycleVendorService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleVendorService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleVendorService);
					}
				}
				_recycleVendorService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleVendorService.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleVendorService.GetMultiManyToOne(null, null, this, filter);
				_recycleVendorService.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleVendorService = true;
			}
			return _recycleVendorService;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleVendorService'. These settings will be taken into account
		/// when the property RecycleVendorService is requested or GetMultiRecycleVendorService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleVendorService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleVendorService.SortClauses=sortClauses;
			_recycleVendorService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaRecycleVendorService(bool forceFetch)
		{
			return GetMultiAccountCollectionViaRecycleVendorService(forceFetch, _accountCollectionViaRecycleVendorService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaRecycleVendorService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaRecycleVendorService || forceFetch || _alwaysFetchAccountCollectionViaRecycleVendorService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaRecycleVendorService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaRecycleVendorService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(RecycleVendorFields.RecycleVendorId, ComparisonOperator.Equal, this.RecycleVendorId, "RecycleVendorEntity__"));
				_accountCollectionViaRecycleVendorService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaRecycleVendorService.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaRecycleVendorService.GetMulti(filter, GetRelationsForField("AccountCollectionViaRecycleVendorService"));
				_accountCollectionViaRecycleVendorService.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaRecycleVendorService = true;
			}
			return _accountCollectionViaRecycleVendorService;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaRecycleVendorService'. These settings will be taken into account
		/// when the property AccountCollectionViaRecycleVendorService is requested or GetMultiAccountCollectionViaRecycleVendorService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaRecycleVendorService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaRecycleVendorService.SortClauses=sortClauses;
			_accountCollectionViaRecycleVendorService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaRecycleVendorService(bool forceFetch)
		{
			return GetMultiRecycleTypeCollectionViaRecycleVendorService(forceFetch, _recycleTypeCollectionViaRecycleVendorService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaRecycleVendorService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService || forceFetch || _alwaysFetchRecycleTypeCollectionViaRecycleVendorService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleTypeCollectionViaRecycleVendorService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleTypeCollectionViaRecycleVendorService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(RecycleVendorFields.RecycleVendorId, ComparisonOperator.Equal, this.RecycleVendorId, "RecycleVendorEntity__"));
				_recycleTypeCollectionViaRecycleVendorService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleTypeCollectionViaRecycleVendorService.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleTypeCollectionViaRecycleVendorService.GetMulti(filter, GetRelationsForField("RecycleTypeCollectionViaRecycleVendorService"));
				_recycleTypeCollectionViaRecycleVendorService.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = true;
			}
			return _recycleTypeCollectionViaRecycleVendorService;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleTypeCollectionViaRecycleVendorService'. These settings will be taken into account
		/// when the property RecycleTypeCollectionViaRecycleVendorService is requested or GetMultiRecycleTypeCollectionViaRecycleVendorService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleTypeCollectionViaRecycleVendorService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleTypeCollectionViaRecycleVendorService.SortClauses=sortClauses;
			_recycleTypeCollectionViaRecycleVendorService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			RecycleVendorDAO dao = (RecycleVendorDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_recycleVendorService.ActiveContext = base.ActiveContext;
			_accountCollectionViaRecycleVendorService.ActiveContext = base.ActiveContext;
			_recycleTypeCollectionViaRecycleVendorService.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			RecycleVendorDAO dao = (RecycleVendorDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			RecycleVendorDAO dao = (RecycleVendorDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity);
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

			toReturn.Add("RecycleVendorService", _recycleVendorService);
			toReturn.Add("AccountCollectionViaRecycleVendorService", _accountCollectionViaRecycleVendorService);
			toReturn.Add("RecycleTypeCollectionViaRecycleVendorService", _recycleTypeCollectionViaRecycleVendorService);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="recycleVendorId">PK value for RecycleVendor which data should be fetched into this RecycleVendor object</param>
		/// <param name="validator">The validator object for this RecycleVendorEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 recycleVendorId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(recycleVendorId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_recycleVendorService = new Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection(new RecycleVendorServiceEntityFactory());
			_recycleVendorService.SetContainingEntityInfo(this, "RecycleVendor");
			_alwaysFetchRecycleVendorService = false;
			_alreadyFetchedRecycleVendorService = false;
			_accountCollectionViaRecycleVendorService = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaRecycleVendorService = false;
			_alreadyFetchedAccountCollectionViaRecycleVendorService = false;
			_recycleTypeCollectionViaRecycleVendorService = new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(new RecycleTypeEntityFactory());
			_alwaysFetchRecycleTypeCollectionViaRecycleVendorService = false;
			_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = false;



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

			_fieldsCustomProperties.Add("RecycleVendorId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Type", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="recycleVendorId">PK value for RecycleVendor which data should be fetched into this RecycleVendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 recycleVendorId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)RecycleVendorFieldIndex.RecycleVendorId].ForcedCurrentValueWrite(recycleVendorId);
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
			return DAOFactory.CreateRecycleVendorDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new RecycleVendorEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static RecycleVendorRelations Relations
		{
			get	{ return new RecycleVendorRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleVendorService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleVendorService
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection(),
					(IEntityRelation)GetRelationsForField("RecycleVendorService")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity, 0, null, null, null, "RecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaRecycleVendorService
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleVendorEntity.Relations.RecycleVendorServiceEntityUsingRecycleVendorId;
				intermediateRelation.SetAliases(string.Empty, "RecycleVendorService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaRecycleVendorService"), "AccountCollectionViaRecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleTypeCollectionViaRecycleVendorService
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleVendorEntity.Relations.RecycleVendorServiceEntityUsingRecycleVendorId;
				intermediateRelation.SetAliases(string.Empty, "RecycleVendorService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleVendorService"), "RecycleTypeCollectionViaRecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "RecycleVendorEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return RecycleVendorEntity.CustomProperties;}
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
			get { return RecycleVendorEntity.FieldsCustomProperties;}
		}

		/// <summary> The RecycleVendorId property of the Entity RecycleVendor<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendor"."RecycleVendorId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 RecycleVendorId
		{
			get { return (System.Int32)GetValue((int)RecycleVendorFieldIndex.RecycleVendorId, true); }
			set	{ SetValue((int)RecycleVendorFieldIndex.RecycleVendorId, value, true); }
		}
		/// <summary> The Type property of the Entity RecycleVendor<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendor"."Type"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Type
		{
			get { return (System.String)GetValue((int)RecycleVendorFieldIndex.Type, true); }
			set	{ SetValue((int)RecycleVendorFieldIndex.Type, value, true); }
		}
		/// <summary> The Name property of the Entity RecycleVendor<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendor"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)RecycleVendorFieldIndex.Name, true); }
			set	{ SetValue((int)RecycleVendorFieldIndex.Name, value, true); }
		}
		/// <summary> The IsActive property of the Entity RecycleVendor<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendor"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)RecycleVendorFieldIndex.IsActive, true); }
			set	{ SetValue((int)RecycleVendorFieldIndex.IsActive, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'RecycleVendorServiceEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleVendorService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection RecycleVendorService
		{
			get	{ return GetMultiRecycleVendorService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleVendorService. When set to true, RecycleVendorService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleVendorService is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleVendorService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleVendorService
		{
			get	{ return _alwaysFetchRecycleVendorService; }
			set	{ _alwaysFetchRecycleVendorService = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleVendorService already has been fetched. Setting this property to false when RecycleVendorService has been fetched
		/// will clear the RecycleVendorService collection well. Setting this property to true while RecycleVendorService hasn't been fetched disables lazy loading for RecycleVendorService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleVendorService
		{
			get { return _alreadyFetchedRecycleVendorService;}
			set 
			{
				if(_alreadyFetchedRecycleVendorService && !value && (_recycleVendorService != null))
				{
					_recycleVendorService.Clear();
				}
				_alreadyFetchedRecycleVendorService = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaRecycleVendorService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaRecycleVendorService
		{
			get { return GetMultiAccountCollectionViaRecycleVendorService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaRecycleVendorService. When set to true, AccountCollectionViaRecycleVendorService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaRecycleVendorService is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaRecycleVendorService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaRecycleVendorService
		{
			get	{ return _alwaysFetchAccountCollectionViaRecycleVendorService; }
			set	{ _alwaysFetchAccountCollectionViaRecycleVendorService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaRecycleVendorService already has been fetched. Setting this property to false when AccountCollectionViaRecycleVendorService has been fetched
		/// will clear the AccountCollectionViaRecycleVendorService collection well. Setting this property to true while AccountCollectionViaRecycleVendorService hasn't been fetched disables lazy loading for AccountCollectionViaRecycleVendorService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaRecycleVendorService
		{
			get { return _alreadyFetchedAccountCollectionViaRecycleVendorService;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaRecycleVendorService && !value && (_accountCollectionViaRecycleVendorService != null))
				{
					_accountCollectionViaRecycleVendorService.Clear();
				}
				_alreadyFetchedAccountCollectionViaRecycleVendorService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleTypeCollectionViaRecycleVendorService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection RecycleTypeCollectionViaRecycleVendorService
		{
			get { return GetMultiRecycleTypeCollectionViaRecycleVendorService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleTypeCollectionViaRecycleVendorService. When set to true, RecycleTypeCollectionViaRecycleVendorService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleTypeCollectionViaRecycleVendorService is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleTypeCollectionViaRecycleVendorService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleTypeCollectionViaRecycleVendorService
		{
			get	{ return _alwaysFetchRecycleTypeCollectionViaRecycleVendorService; }
			set	{ _alwaysFetchRecycleTypeCollectionViaRecycleVendorService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleTypeCollectionViaRecycleVendorService already has been fetched. Setting this property to false when RecycleTypeCollectionViaRecycleVendorService has been fetched
		/// will clear the RecycleTypeCollectionViaRecycleVendorService collection well. Setting this property to true while RecycleTypeCollectionViaRecycleVendorService hasn't been fetched disables lazy loading for RecycleTypeCollectionViaRecycleVendorService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleTypeCollectionViaRecycleVendorService
		{
			get { return _alreadyFetchedRecycleTypeCollectionViaRecycleVendorService;}
			set 
			{
				if(_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService && !value && (_recycleTypeCollectionViaRecycleVendorService != null))
				{
					_recycleTypeCollectionViaRecycleVendorService.Clear();
				}
				_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = value;
			}
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity; }
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
