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
	/// Entity class which represents the entity 'DeepFryerChangeLog'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DeepFryerChangeLogEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private ChangeLogEntity _changeLog;
		private bool	_alwaysFetchChangeLog, _alreadyFetchedChangeLog, _changeLogReturnsNewIfNotFound;
		private DeepFryerEntity _deepFryer;
		private bool	_alwaysFetchDeepFryer, _alreadyFetchedDeepFryer, _deepFryerReturnsNewIfNotFound;

		
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
			/// <summary>Member name DeepFryer</summary>
			public static readonly string DeepFryer = "DeepFryer";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DeepFryerChangeLogEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public DeepFryerChangeLogEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="deepFryerChangeLogId">PK value for DeepFryerChangeLog which data should be fetched into this DeepFryerChangeLog object</param>
		public DeepFryerChangeLogEntity(System.Int32 deepFryerChangeLogId)
		{
			InitClassFetch(deepFryerChangeLogId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="deepFryerChangeLogId">PK value for DeepFryerChangeLog which data should be fetched into this DeepFryerChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public DeepFryerChangeLogEntity(System.Int32 deepFryerChangeLogId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(deepFryerChangeLogId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="deepFryerChangeLogId">PK value for DeepFryerChangeLog which data should be fetched into this DeepFryerChangeLog object</param>
		/// <param name="validator">The custom validator object for this DeepFryerChangeLogEntity</param>
		public DeepFryerChangeLogEntity(System.Int32 deepFryerChangeLogId, IValidator validator)
		{
			InitClassFetch(deepFryerChangeLogId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DeepFryerChangeLogEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_changeLog = (ChangeLogEntity)info.GetValue("_changeLog", typeof(ChangeLogEntity));
			if(_changeLog!=null)
			{
				_changeLog.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_changeLogReturnsNewIfNotFound = info.GetBoolean("_changeLogReturnsNewIfNotFound");
			_alwaysFetchChangeLog = info.GetBoolean("_alwaysFetchChangeLog");
			_alreadyFetchedChangeLog = info.GetBoolean("_alreadyFetchedChangeLog");
			_deepFryer = (DeepFryerEntity)info.GetValue("_deepFryer", typeof(DeepFryerEntity));
			if(_deepFryer!=null)
			{
				_deepFryer.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_deepFryerReturnsNewIfNotFound = info.GetBoolean("_deepFryerReturnsNewIfNotFound");
			_alwaysFetchDeepFryer = info.GetBoolean("_alwaysFetchDeepFryer");
			_alreadyFetchedDeepFryer = info.GetBoolean("_alreadyFetchedDeepFryer");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((DeepFryerChangeLogFieldIndex)fieldIndex)
			{
				case DeepFryerChangeLogFieldIndex.DeepFryerId:
					DesetupSyncDeepFryer(true, false);
					_alreadyFetchedDeepFryer = false;
					break;
				case DeepFryerChangeLogFieldIndex.ChangeLogId:
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
			_alreadyFetchedDeepFryer = (_deepFryer != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return DeepFryerChangeLogEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(DeepFryerChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId);
					break;
				case "DeepFryer":
					toReturn.Add(DeepFryerChangeLogEntity.Relations.DeepFryerEntityUsingDeepFryerId);
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
			info.AddValue("_deepFryer", (!this.MarkedForDeletion?_deepFryer:null));
			info.AddValue("_deepFryerReturnsNewIfNotFound", _deepFryerReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchDeepFryer", _alwaysFetchDeepFryer);
			info.AddValue("_alreadyFetchedDeepFryer", _alreadyFetchedDeepFryer);

			
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
				case "DeepFryer":
					_alreadyFetchedDeepFryer = true;
					this.DeepFryer = (DeepFryerEntity)entity;
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
				case "DeepFryer":
					SetupSyncDeepFryer(relatedEntity);
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
				case "DeepFryer":
					DesetupSyncDeepFryer(false, true);
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
			if(_deepFryer!=null)
			{
				toReturn.Add(_deepFryer);
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
		/// <param name="deepFryerChangeLogId">PK value for DeepFryerChangeLog which data should be fetched into this DeepFryerChangeLog object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerChangeLogId)
		{
			return FetchUsingPK(deepFryerChangeLogId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerChangeLogId">PK value for DeepFryerChangeLog which data should be fetched into this DeepFryerChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerChangeLogId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(deepFryerChangeLogId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerChangeLogId">PK value for DeepFryerChangeLog which data should be fetched into this DeepFryerChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerChangeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(deepFryerChangeLogId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerChangeLogId">PK value for DeepFryerChangeLog which data should be fetched into this DeepFryerChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerChangeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(deepFryerChangeLogId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DeepFryerChangeLogId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DeepFryerChangeLogFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DeepFryerChangeLogFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DeepFryerChangeLogRelations().GetAllRelations();
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId);

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

		/// <summary> Retrieves the related entity of type 'DeepFryerEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'DeepFryerEntity' which is related to this entity.</returns>
		public DeepFryerEntity GetSingleDeepFryer()
		{
			return GetSingleDeepFryer(false);
		}

		/// <summary> Retrieves the related entity of type 'DeepFryerEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'DeepFryerEntity' which is related to this entity.</returns>
		public virtual DeepFryerEntity GetSingleDeepFryer(bool forceFetch)
		{
			if( ( !_alreadyFetchedDeepFryer || forceFetch || _alwaysFetchDeepFryer) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerChangeLogEntity.Relations.DeepFryerEntityUsingDeepFryerId);

				DeepFryerEntity newEntity = new DeepFryerEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.DeepFryerId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (DeepFryerEntity)base.ActiveContext.Get(newEntity);
					}
					this.DeepFryer = newEntity;
				}
				else
				{
					if(_deepFryerReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_deepFryer == null)))
						{
							this.DeepFryer = newEntity;
						}
					}
					else
					{
						this.DeepFryer = null;
					}
				}
				_alreadyFetchedDeepFryer = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _deepFryer;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			DeepFryerChangeLogDAO dao = (DeepFryerChangeLogDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_changeLog!=null)
			{
				_changeLog.ActiveContext = base.ActiveContext;
			}
			if(_deepFryer!=null)
			{
				_deepFryer.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			DeepFryerChangeLogDAO dao = (DeepFryerChangeLogDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			DeepFryerChangeLogDAO dao = (DeepFryerChangeLogDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity);
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
			toReturn.Add("DeepFryer", _deepFryer);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="deepFryerChangeLogId">PK value for DeepFryerChangeLog which data should be fetched into this DeepFryerChangeLog object</param>
		/// <param name="validator">The validator object for this DeepFryerChangeLogEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 deepFryerChangeLogId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(deepFryerChangeLogId, prefetchPathToUse, null, null);
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
			_deepFryer = null;
			_deepFryerReturnsNewIfNotFound = true;
			_alwaysFetchDeepFryer = false;
			_alreadyFetchedDeepFryer = false;


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

			_fieldsCustomProperties.Add("DeepFryerChangeLogId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DeepFryerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ChangeLogId", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _changeLog</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncChangeLog(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _changeLog, new PropertyChangedEventHandler( OnChangeLogPropertyChanged ), "ChangeLog", DeepFryerChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId, true, signalRelatedEntity, "DeepFryerChangeLog", resetFKFields, new int[] { (int)DeepFryerChangeLogFieldIndex.ChangeLogId } );		
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
				base.PerformSetupSyncRelatedEntity( _changeLog, new PropertyChangedEventHandler( OnChangeLogPropertyChanged ), "ChangeLog", DeepFryerChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId, true, ref _alreadyFetchedChangeLog, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _deepFryer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDeepFryer(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _deepFryer, new PropertyChangedEventHandler( OnDeepFryerPropertyChanged ), "DeepFryer", DeepFryerChangeLogEntity.Relations.DeepFryerEntityUsingDeepFryerId, true, signalRelatedEntity, "DeepFryerChangeLog", resetFKFields, new int[] { (int)DeepFryerChangeLogFieldIndex.DeepFryerId } );		
			_deepFryer = null;
		}
		
		/// <summary> setups the sync logic for member _deepFryer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDeepFryer(IEntity relatedEntity)
		{
			if(_deepFryer!=relatedEntity)
			{		
				DesetupSyncDeepFryer(true, true);
				_deepFryer = (DeepFryerEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _deepFryer, new PropertyChangedEventHandler( OnDeepFryerPropertyChanged ), "DeepFryer", DeepFryerChangeLogEntity.Relations.DeepFryerEntityUsingDeepFryerId, true, ref _alreadyFetchedDeepFryer, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDeepFryerPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="deepFryerChangeLogId">PK value for DeepFryerChangeLog which data should be fetched into this DeepFryerChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 deepFryerChangeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)DeepFryerChangeLogFieldIndex.DeepFryerChangeLogId].ForcedCurrentValueWrite(deepFryerChangeLogId);
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
			return DAOFactory.CreateDeepFryerChangeLogDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new DeepFryerChangeLogEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static DeepFryerChangeLogRelations Relations
		{
			get	{ return new DeepFryerChangeLogRelations(); }
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
					(IEntityRelation)GetRelationsForField("ChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, 0, null, null, null, "ChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryer
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(),
					(IEntityRelation)GetRelationsForField("DeepFryer")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, null, "DeepFryer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "DeepFryerChangeLogEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DeepFryerChangeLogEntity.CustomProperties;}
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
			get { return DeepFryerChangeLogEntity.FieldsCustomProperties;}
		}

		/// <summary> The DeepFryerChangeLogId property of the Entity DeepFryerChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerChangeLog"."DeepFryerChangeLogId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DeepFryerChangeLogId
		{
			get { return (System.Int32)GetValue((int)DeepFryerChangeLogFieldIndex.DeepFryerChangeLogId, true); }
			set	{ SetValue((int)DeepFryerChangeLogFieldIndex.DeepFryerChangeLogId, value, true); }
		}
		/// <summary> The DeepFryerId property of the Entity DeepFryerChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerChangeLog"."DeepFryerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DeepFryerId
		{
			get { return (System.Int32)GetValue((int)DeepFryerChangeLogFieldIndex.DeepFryerId, true); }
			set	{ SetValue((int)DeepFryerChangeLogFieldIndex.DeepFryerId, value, true); }
		}
		/// <summary> The ChangeLogId property of the Entity DeepFryerChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerChangeLog"."ChangeLogId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ChangeLogId
		{
			get { return (System.Int32)GetValue((int)DeepFryerChangeLogFieldIndex.ChangeLogId, true); }
			set	{ SetValue((int)DeepFryerChangeLogFieldIndex.ChangeLogId, value, true); }
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
							_changeLog.UnsetRelatedEntity(this, "DeepFryerChangeLog");
						}
					}
					else
					{
						if(_changeLog!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerChangeLog");
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
		/// <summary> Gets / sets related entity of type 'DeepFryerEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleDeepFryer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual DeepFryerEntity DeepFryer
		{
			get	{ return GetSingleDeepFryer(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncDeepFryer(value);
				}
				else
				{
					if(value==null)
					{
						if(_deepFryer != null)
						{
							_deepFryer.UnsetRelatedEntity(this, "DeepFryerChangeLog");
						}
					}
					else
					{
						if(_deepFryer!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerChangeLog");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryer. When set to true, DeepFryer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryer is accessed. You can always execute
		/// a forced fetch by calling GetSingleDeepFryer(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryer
		{
			get	{ return _alwaysFetchDeepFryer; }
			set	{ _alwaysFetchDeepFryer = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryer already has been fetched. Setting this property to false when DeepFryer has been fetched
		/// will set DeepFryer to null as well. Setting this property to true while DeepFryer hasn't been fetched disables lazy loading for DeepFryer</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryer
		{
			get { return _alreadyFetchedDeepFryer;}
			set 
			{
				if(_alreadyFetchedDeepFryer && !value)
				{
					this.DeepFryer = null;
				}
				_alreadyFetchedDeepFryer = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property DeepFryer is not found
		/// in the database. When set to true, DeepFryer will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool DeepFryerReturnsNewIfNotFound
		{
			get	{ return _deepFryerReturnsNewIfNotFound; }
			set { _deepFryerReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity; }
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
