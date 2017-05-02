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
	/// Entity class which represents the entity 'ServiceLocationAssetTypeChangeLog'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ServiceLocationAssetTypeChangeLogEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private ChangeLogEntity _changeLog;
		private bool	_alwaysFetchChangeLog, _alreadyFetchedChangeLog, _changeLogReturnsNewIfNotFound;
		private ServiceLocationAssetTypeEntity _serviceLocationAssetType;
		private bool	_alwaysFetchServiceLocationAssetType, _alreadyFetchedServiceLocationAssetType, _serviceLocationAssetTypeReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name ChangeLog</summary>
			public static readonly string ChangeLog = "ChangeLog";
			/// <summary>Member name ServiceLocationAssetType</summary>
			public static readonly string ServiceLocationAssetType = "ServiceLocationAssetType";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ServiceLocationAssetTypeChangeLogEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ServiceLocationAssetTypeChangeLogEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		public ServiceLocationAssetTypeChangeLogEntity(System.Int32 serviceLocationAssetTypeChangeLogId)
		{
			InitClassFetch(serviceLocationAssetTypeChangeLogId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ServiceLocationAssetTypeChangeLogEntity(System.Int32 serviceLocationAssetTypeChangeLogId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(serviceLocationAssetTypeChangeLogId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		/// <param name="validator">The custom validator object for this ServiceLocationAssetTypeChangeLogEntity</param>
		public ServiceLocationAssetTypeChangeLogEntity(System.Int32 serviceLocationAssetTypeChangeLogId, IValidator validator)
		{
			InitClassFetch(serviceLocationAssetTypeChangeLogId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ServiceLocationAssetTypeChangeLogEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_changeLog = (ChangeLogEntity)info.GetValue("_changeLog", typeof(ChangeLogEntity));
			if(_changeLog!=null)
			{
				_changeLog.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_changeLogReturnsNewIfNotFound = info.GetBoolean("_changeLogReturnsNewIfNotFound");
			_alwaysFetchChangeLog = info.GetBoolean("_alwaysFetchChangeLog");
			_alreadyFetchedChangeLog = info.GetBoolean("_alreadyFetchedChangeLog");
			_serviceLocationAssetType = (ServiceLocationAssetTypeEntity)info.GetValue("_serviceLocationAssetType", typeof(ServiceLocationAssetTypeEntity));
			if(_serviceLocationAssetType!=null)
			{
				_serviceLocationAssetType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_serviceLocationAssetTypeReturnsNewIfNotFound = info.GetBoolean("_serviceLocationAssetTypeReturnsNewIfNotFound");
			_alwaysFetchServiceLocationAssetType = info.GetBoolean("_alwaysFetchServiceLocationAssetType");
			_alreadyFetchedServiceLocationAssetType = info.GetBoolean("_alreadyFetchedServiceLocationAssetType");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ServiceLocationAssetTypeChangeLogFieldIndex)fieldIndex)
			{
				case ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeId:
					DesetupSyncServiceLocationAssetType(true, false);
					_alreadyFetchedServiceLocationAssetType = false;
					break;
				case ServiceLocationAssetTypeChangeLogFieldIndex.ChangeLogId:
					DesetupSyncChangeLog(true, false);
					_alreadyFetchedChangeLog = false;
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


			_alreadyFetchedChangeLog = (_changeLog != null);
			_alreadyFetchedServiceLocationAssetType = (_serviceLocationAssetType != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ServiceLocationAssetTypeChangeLogEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ChangeLog":
					toReturn.Add(ServiceLocationAssetTypeChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId);
					break;
				case "ServiceLocationAssetType":
					toReturn.Add(ServiceLocationAssetTypeChangeLogEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId);
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


			info.AddValue("_changeLog", (!this.MarkedForDeletion?_changeLog:null));
			info.AddValue("_changeLogReturnsNewIfNotFound", _changeLogReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchChangeLog", _alwaysFetchChangeLog);
			info.AddValue("_alreadyFetchedChangeLog", _alreadyFetchedChangeLog);
			info.AddValue("_serviceLocationAssetType", (!this.MarkedForDeletion?_serviceLocationAssetType:null));
			info.AddValue("_serviceLocationAssetTypeReturnsNewIfNotFound", _serviceLocationAssetTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchServiceLocationAssetType", _alwaysFetchServiceLocationAssetType);
			info.AddValue("_alreadyFetchedServiceLocationAssetType", _alreadyFetchedServiceLocationAssetType);

			
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
				case "ChangeLog":
					_alreadyFetchedChangeLog = true;
					this.ChangeLog = (ChangeLogEntity)entity;
					break;
				case "ServiceLocationAssetType":
					_alreadyFetchedServiceLocationAssetType = true;
					this.ServiceLocationAssetType = (ServiceLocationAssetTypeEntity)entity;
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
				case "ChangeLog":
					SetupSyncChangeLog(relatedEntity);
					break;
				case "ServiceLocationAssetType":
					SetupSyncServiceLocationAssetType(relatedEntity);
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
				case "ChangeLog":
					DesetupSyncChangeLog(false, true);
					break;
				case "ServiceLocationAssetType":
					DesetupSyncServiceLocationAssetType(false, true);
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
			if(_changeLog!=null)
			{
				toReturn.Add(_changeLog);
			}
			if(_serviceLocationAssetType!=null)
			{
				toReturn.Add(_serviceLocationAssetType);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationAssetTypeChangeLogId)
		{
			return FetchUsingPK(serviceLocationAssetTypeChangeLogId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationAssetTypeChangeLogId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(serviceLocationAssetTypeChangeLogId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationAssetTypeChangeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(serviceLocationAssetTypeChangeLogId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationAssetTypeChangeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(serviceLocationAssetTypeChangeLogId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ServiceLocationAssetTypeChangeLogId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ServiceLocationAssetTypeChangeLogFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ServiceLocationAssetTypeChangeLogFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ServiceLocationAssetTypeChangeLogRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'ChangeLogEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ChangeLogEntity' which is related to this entity.</returns>
		public ChangeLogEntity GetSingleChangeLog()
		{
			return GetSingleChangeLog(false);
		}

		/// <summary> Retrieves the related entity of type 'ChangeLogEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ChangeLogEntity' which is related to this entity.</returns>
		public virtual ChangeLogEntity GetSingleChangeLog(bool forceFetch)
		{
			if( ( !_alreadyFetchedChangeLog || forceFetch || _alwaysFetchChangeLog) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ServiceLocationAssetTypeChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId);

				ChangeLogEntity newEntity = new ChangeLogEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ChangeLogId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ChangeLogEntity)base.ActiveContext.Get(newEntity);
					}
					this.ChangeLog = newEntity;
				}
				else
				{
					if(_changeLogReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_changeLog == null)))
						{
							this.ChangeLog = newEntity;
						}
					}
					else
					{
						this.ChangeLog = null;
					}
				}
				_alreadyFetchedChangeLog = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _changeLog;
		}

		/// <summary> Retrieves the related entity of type 'ServiceLocationAssetTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ServiceLocationAssetTypeEntity' which is related to this entity.</returns>
		public ServiceLocationAssetTypeEntity GetSingleServiceLocationAssetType()
		{
			return GetSingleServiceLocationAssetType(false);
		}

		/// <summary> Retrieves the related entity of type 'ServiceLocationAssetTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ServiceLocationAssetTypeEntity' which is related to this entity.</returns>
		public virtual ServiceLocationAssetTypeEntity GetSingleServiceLocationAssetType(bool forceFetch)
		{
			if( ( !_alreadyFetchedServiceLocationAssetType || forceFetch || _alwaysFetchServiceLocationAssetType) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ServiceLocationAssetTypeChangeLogEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId);

				ServiceLocationAssetTypeEntity newEntity = new ServiceLocationAssetTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ServiceLocationAssetTypeId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ServiceLocationAssetTypeEntity)base.ActiveContext.Get(newEntity);
					}
					this.ServiceLocationAssetType = newEntity;
				}
				else
				{
					if(_serviceLocationAssetTypeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_serviceLocationAssetType == null)))
						{
							this.ServiceLocationAssetType = newEntity;
						}
					}
					else
					{
						this.ServiceLocationAssetType = null;
					}
				}
				_alreadyFetchedServiceLocationAssetType = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _serviceLocationAssetType;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ServiceLocationAssetTypeChangeLogDAO dao = (ServiceLocationAssetTypeChangeLogDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_changeLog!=null)
			{
				_changeLog.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationAssetType!=null)
			{
				_serviceLocationAssetType.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ServiceLocationAssetTypeChangeLogDAO dao = (ServiceLocationAssetTypeChangeLogDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ServiceLocationAssetTypeChangeLogDAO dao = (ServiceLocationAssetTypeChangeLogDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity);
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
			toReturn.Add("ChangeLog", _changeLog);
			toReturn.Add("ServiceLocationAssetType", _serviceLocationAssetType);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		/// <param name="validator">The validator object for this ServiceLocationAssetTypeChangeLogEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 serviceLocationAssetTypeChangeLogId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(serviceLocationAssetTypeChangeLogId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_changeLog = null;
			_changeLogReturnsNewIfNotFound = true;
			_alwaysFetchChangeLog = false;
			_alreadyFetchedChangeLog = false;
			_serviceLocationAssetType = null;
			_serviceLocationAssetTypeReturnsNewIfNotFound = true;
			_alwaysFetchServiceLocationAssetType = false;
			_alreadyFetchedServiceLocationAssetType = false;


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

			_fieldsCustomProperties.Add("ServiceLocationAssetTypeChangeLogId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceLocationAssetTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ChangeLogId", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _changeLog</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncChangeLog(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _changeLog, new PropertyChangedEventHandler( OnChangeLogPropertyChanged ), "ChangeLog", ServiceLocationAssetTypeChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId, true, signalRelatedEntity, "ServiceLocationAssetTypeChangeLog", resetFKFields, new int[] { (int)ServiceLocationAssetTypeChangeLogFieldIndex.ChangeLogId } );		
			_changeLog = null;
		}
		
		/// <summary> setups the sync logic for member _changeLog</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncChangeLog(IEntity relatedEntity)
		{
			if(_changeLog!=relatedEntity)
			{		
				DesetupSyncChangeLog(true, true);
				_changeLog = (ChangeLogEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _changeLog, new PropertyChangedEventHandler( OnChangeLogPropertyChanged ), "ChangeLog", ServiceLocationAssetTypeChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId, true, ref _alreadyFetchedChangeLog, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnChangeLogPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _serviceLocationAssetType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocationAssetType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocationAssetType, new PropertyChangedEventHandler( OnServiceLocationAssetTypePropertyChanged ), "ServiceLocationAssetType", ServiceLocationAssetTypeChangeLogEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, true, signalRelatedEntity, "ServiceLocationAssetTypeChangeLog", resetFKFields, new int[] { (int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeId } );		
			_serviceLocationAssetType = null;
		}
		
		/// <summary> setups the sync logic for member _serviceLocationAssetType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncServiceLocationAssetType(IEntity relatedEntity)
		{
			if(_serviceLocationAssetType!=relatedEntity)
			{		
				DesetupSyncServiceLocationAssetType(true, true);
				_serviceLocationAssetType = (ServiceLocationAssetTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceLocationAssetType, new PropertyChangedEventHandler( OnServiceLocationAssetTypePropertyChanged ), "ServiceLocationAssetType", ServiceLocationAssetTypeChangeLogEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, true, ref _alreadyFetchedServiceLocationAssetType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnServiceLocationAssetTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 serviceLocationAssetTypeChangeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeChangeLogId].ForcedCurrentValueWrite(serviceLocationAssetTypeChangeLogId);
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
			return DAOFactory.CreateServiceLocationAssetTypeChangeLogDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ServiceLocationAssetTypeChangeLogEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ServiceLocationAssetTypeChangeLogRelations Relations
		{
			get	{ return new ServiceLocationAssetTypeChangeLogRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("ChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, 0, null, null, null, "ChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationAssetType
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetType")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, null, "ServiceLocationAssetType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ServiceLocationAssetTypeChangeLogEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ServiceLocationAssetTypeChangeLogEntity.CustomProperties;}
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
			get { return ServiceLocationAssetTypeChangeLogEntity.FieldsCustomProperties;}
		}

		/// <summary> The ServiceLocationAssetTypeChangeLogId property of the Entity ServiceLocationAssetTypeChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetTypeChangeLog"."ServiceLocationAssetTypeChangeLogId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ServiceLocationAssetTypeChangeLogId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeChangeLogId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeChangeLogId, value, true); }
		}
		/// <summary> The ServiceLocationAssetTypeId property of the Entity ServiceLocationAssetTypeChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetTypeChangeLog"."ServiceLocationAssetTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceLocationAssetTypeId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeId, value, true); }
		}
		/// <summary> The ChangeLogId property of the Entity ServiceLocationAssetTypeChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetTypeChangeLog"."ChangeLogId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ChangeLogId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ChangeLogId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ChangeLogId, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'ChangeLogEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ChangeLogEntity ChangeLog
		{
			get	{ return GetSingleChangeLog(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncChangeLog(value);
				}
				else
				{
					if(value==null)
					{
						if(_changeLog != null)
						{
							_changeLog.UnsetRelatedEntity(this, "ServiceLocationAssetTypeChangeLog");
						}
					}
					else
					{
						if(_changeLog!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ServiceLocationAssetTypeChangeLog");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ChangeLog. When set to true, ChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetSingleChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChangeLog
		{
			get	{ return _alwaysFetchChangeLog; }
			set	{ _alwaysFetchChangeLog = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChangeLog already has been fetched. Setting this property to false when ChangeLog has been fetched
		/// will set ChangeLog to null as well. Setting this property to true while ChangeLog hasn't been fetched disables lazy loading for ChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChangeLog
		{
			get { return _alreadyFetchedChangeLog;}
			set 
			{
				if(_alreadyFetchedChangeLog && !value)
				{
					this.ChangeLog = null;
				}
				_alreadyFetchedChangeLog = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ChangeLog is not found
		/// in the database. When set to true, ChangeLog will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ChangeLogReturnsNewIfNotFound
		{
			get	{ return _changeLogReturnsNewIfNotFound; }
			set { _changeLogReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ServiceLocationAssetTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleServiceLocationAssetType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ServiceLocationAssetTypeEntity ServiceLocationAssetType
		{
			get	{ return GetSingleServiceLocationAssetType(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncServiceLocationAssetType(value);
				}
				else
				{
					if(value==null)
					{
						if(_serviceLocationAssetType != null)
						{
							_serviceLocationAssetType.UnsetRelatedEntity(this, "ServiceLocationAssetTypeChangeLog");
						}
					}
					else
					{
						if(_serviceLocationAssetType!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ServiceLocationAssetTypeChangeLog");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationAssetType. When set to true, ServiceLocationAssetType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationAssetType is accessed. You can always execute
		/// a forced fetch by calling GetSingleServiceLocationAssetType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationAssetType
		{
			get	{ return _alwaysFetchServiceLocationAssetType; }
			set	{ _alwaysFetchServiceLocationAssetType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationAssetType already has been fetched. Setting this property to false when ServiceLocationAssetType has been fetched
		/// will set ServiceLocationAssetType to null as well. Setting this property to true while ServiceLocationAssetType hasn't been fetched disables lazy loading for ServiceLocationAssetType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationAssetType
		{
			get { return _alreadyFetchedServiceLocationAssetType;}
			set 
			{
				if(_alreadyFetchedServiceLocationAssetType && !value)
				{
					this.ServiceLocationAssetType = null;
				}
				_alreadyFetchedServiceLocationAssetType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ServiceLocationAssetType is not found
		/// in the database. When set to true, ServiceLocationAssetType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ServiceLocationAssetTypeReturnsNewIfNotFound
		{
			get	{ return _serviceLocationAssetTypeReturnsNewIfNotFound; }
			set { _serviceLocationAssetTypeReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity; }
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
