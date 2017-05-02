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
	/// Entity class which represents the entity 'Bale'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class BaleEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private AccountEntity _account;
		private bool	_alwaysFetchAccount, _alreadyFetchedAccount, _accountReturnsNewIfNotFound;
		private DockEntity _dock;
		private bool	_alwaysFetchDock, _alreadyFetchedDock, _dockReturnsNewIfNotFound;
		private RecycleTypeEntity _recycleType;
		private bool	_alwaysFetchRecycleType, _alreadyFetchedRecycleType, _recycleTypeReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Account</summary>
			public static readonly string Account = "Account";
			/// <summary>Member name Dock</summary>
			public static readonly string Dock = "Dock";
			/// <summary>Member name RecycleType</summary>
			public static readonly string RecycleType = "RecycleType";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static BaleEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public BaleEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="baleId">PK value for Bale which data should be fetched into this Bale object</param>
		public BaleEntity(System.Int32 baleId)
		{
			InitClassFetch(baleId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="baleId">PK value for Bale which data should be fetched into this Bale object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public BaleEntity(System.Int32 baleId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(baleId, null, prefetchPathToUse);
		}

        internal void Save()
        {
            throw new NotImplementedException();
        }

        /// <summary>CTor</summary>
        /// <param name="baleId">PK value for Bale which data should be fetched into this Bale object</param>
        /// <param name="validator">The custom validator object for this BaleEntity</param>
        public BaleEntity(System.Int32 baleId, IValidator validator)
		{
			InitClassFetch(baleId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected BaleEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_account = (AccountEntity)info.GetValue("_account", typeof(AccountEntity));
			if(_account!=null)
			{
				_account.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_accountReturnsNewIfNotFound = info.GetBoolean("_accountReturnsNewIfNotFound");
			_alwaysFetchAccount = info.GetBoolean("_alwaysFetchAccount");
			_alreadyFetchedAccount = info.GetBoolean("_alreadyFetchedAccount");
			_dock = (DockEntity)info.GetValue("_dock", typeof(DockEntity));
			if(_dock!=null)
			{
				_dock.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_dockReturnsNewIfNotFound = info.GetBoolean("_dockReturnsNewIfNotFound");
			_alwaysFetchDock = info.GetBoolean("_alwaysFetchDock");
			_alreadyFetchedDock = info.GetBoolean("_alreadyFetchedDock");
			_recycleType = (RecycleTypeEntity)info.GetValue("_recycleType", typeof(RecycleTypeEntity));
			if(_recycleType!=null)
			{
				_recycleType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_recycleTypeReturnsNewIfNotFound = info.GetBoolean("_recycleTypeReturnsNewIfNotFound");
			_alwaysFetchRecycleType = info.GetBoolean("_alwaysFetchRecycleType");
			_alreadyFetchedRecycleType = info.GetBoolean("_alreadyFetchedRecycleType");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((BaleFieldIndex)fieldIndex)
			{
				case BaleFieldIndex.AccountId:
					DesetupSyncAccount(true, false);
					_alreadyFetchedAccount = false;
					break;
				case BaleFieldIndex.DockId:
					DesetupSyncDock(true, false);
					_alreadyFetchedDock = false;
					break;
				case BaleFieldIndex.RecycleTypeId:
					DesetupSyncRecycleType(true, false);
					_alreadyFetchedRecycleType = false;
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


			_alreadyFetchedAccount = (_account != null);
			_alreadyFetchedDock = (_dock != null);
			_alreadyFetchedRecycleType = (_recycleType != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return BaleEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Account":
					toReturn.Add(BaleEntity.Relations.AccountEntityUsingAccountId);
					break;
				case "Dock":
					toReturn.Add(BaleEntity.Relations.DockEntityUsingDockId);
					break;
				case "RecycleType":
					toReturn.Add(BaleEntity.Relations.RecycleTypeEntityUsingRecycleTypeId);
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


			info.AddValue("_account", (!this.MarkedForDeletion?_account:null));
			info.AddValue("_accountReturnsNewIfNotFound", _accountReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAccount", _alwaysFetchAccount);
			info.AddValue("_alreadyFetchedAccount", _alreadyFetchedAccount);
			info.AddValue("_dock", (!this.MarkedForDeletion?_dock:null));
			info.AddValue("_dockReturnsNewIfNotFound", _dockReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchDock", _alwaysFetchDock);
			info.AddValue("_alreadyFetchedDock", _alreadyFetchedDock);
			info.AddValue("_recycleType", (!this.MarkedForDeletion?_recycleType:null));
			info.AddValue("_recycleTypeReturnsNewIfNotFound", _recycleTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchRecycleType", _alwaysFetchRecycleType);
			info.AddValue("_alreadyFetchedRecycleType", _alreadyFetchedRecycleType);

			
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
				case "Account":
					_alreadyFetchedAccount = true;
					this.Account = (AccountEntity)entity;
					break;
				case "Dock":
					_alreadyFetchedDock = true;
					this.Dock = (DockEntity)entity;
					break;
				case "RecycleType":
					_alreadyFetchedRecycleType = true;
					this.RecycleType = (RecycleTypeEntity)entity;
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
				case "Account":
					SetupSyncAccount(relatedEntity);
					break;
				case "Dock":
					SetupSyncDock(relatedEntity);
					break;
				case "RecycleType":
					SetupSyncRecycleType(relatedEntity);
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
				case "Account":
					DesetupSyncAccount(false, true);
					break;
				case "Dock":
					DesetupSyncDock(false, true);
					break;
				case "RecycleType":
					DesetupSyncRecycleType(false, true);
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
			if(_account!=null)
			{
				toReturn.Add(_account);
			}
			if(_dock!=null)
			{
				toReturn.Add(_dock);
			}
			if(_recycleType!=null)
			{
				toReturn.Add(_recycleType);
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
		/// <param name="baleId">PK value for Bale which data should be fetched into this Bale object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 baleId)
		{
			return FetchUsingPK(baleId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="baleId">PK value for Bale which data should be fetched into this Bale object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 baleId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(baleId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="baleId">PK value for Bale which data should be fetched into this Bale object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 baleId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(baleId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="baleId">PK value for Bale which data should be fetched into this Bale object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 baleId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(baleId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.BaleId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(BaleFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(BaleFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new BaleRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'AccountEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AccountEntity' which is related to this entity.</returns>
		public AccountEntity GetSingleAccount()
		{
			return GetSingleAccount(false);
		}

		/// <summary> Retrieves the related entity of type 'AccountEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AccountEntity' which is related to this entity.</returns>
		public virtual AccountEntity GetSingleAccount(bool forceFetch)
		{
			if( ( !_alreadyFetchedAccount || forceFetch || _alwaysFetchAccount) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(BaleEntity.Relations.AccountEntityUsingAccountId);

				AccountEntity newEntity = new AccountEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.AccountId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (AccountEntity)base.ActiveContext.Get(newEntity);
					}
					this.Account = newEntity;
				}
				else
				{
					if(_accountReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_account == null)))
						{
							this.Account = newEntity;
						}
					}
					else
					{
						this.Account = null;
					}
				}
				_alreadyFetchedAccount = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _account;
		}

		/// <summary> Retrieves the related entity of type 'DockEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'DockEntity' which is related to this entity.</returns>
		public DockEntity GetSingleDock()
		{
			return GetSingleDock(false);
		}

		/// <summary> Retrieves the related entity of type 'DockEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'DockEntity' which is related to this entity.</returns>
		public virtual DockEntity GetSingleDock(bool forceFetch)
		{
			if( ( !_alreadyFetchedDock || forceFetch || _alwaysFetchDock) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(BaleEntity.Relations.DockEntityUsingDockId);

				DockEntity newEntity = new DockEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.DockId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (DockEntity)base.ActiveContext.Get(newEntity);
					}
					this.Dock = newEntity;
				}
				else
				{
					if(_dockReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_dock == null)))
						{
							this.Dock = newEntity;
						}
					}
					else
					{
						this.Dock = null;
					}
				}
				_alreadyFetchedDock = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _dock;
		}

		/// <summary> Retrieves the related entity of type 'RecycleTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'RecycleTypeEntity' which is related to this entity.</returns>
		public RecycleTypeEntity GetSingleRecycleType()
		{
			return GetSingleRecycleType(false);
		}

		/// <summary> Retrieves the related entity of type 'RecycleTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'RecycleTypeEntity' which is related to this entity.</returns>
		public virtual RecycleTypeEntity GetSingleRecycleType(bool forceFetch)
		{
			if( ( !_alreadyFetchedRecycleType || forceFetch || _alwaysFetchRecycleType) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(BaleEntity.Relations.RecycleTypeEntityUsingRecycleTypeId);

				RecycleTypeEntity newEntity = new RecycleTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.RecycleTypeId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (RecycleTypeEntity)base.ActiveContext.Get(newEntity);
					}
					this.RecycleType = newEntity;
				}
				else
				{
					if(_recycleTypeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_recycleType == null)))
						{
							this.RecycleType = newEntity;
						}
					}
					else
					{
						this.RecycleType = null;
					}
				}
				_alreadyFetchedRecycleType = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _recycleType;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			BaleDAO dao = (BaleDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_account!=null)
			{
				_account.ActiveContext = base.ActiveContext;
			}
			if(_dock!=null)
			{
				_dock.ActiveContext = base.ActiveContext;
			}
			if(_recycleType!=null)
			{
				_recycleType.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			BaleDAO dao = (BaleDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			BaleDAO dao = (BaleDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.BaleEntity);
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
			toReturn.Add("Account", _account);
			toReturn.Add("Dock", _dock);
			toReturn.Add("RecycleType", _recycleType);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="baleId">PK value for Bale which data should be fetched into this Bale object</param>
		/// <param name="validator">The validator object for this BaleEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 baleId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(baleId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_account = null;
			_accountReturnsNewIfNotFound = true;
			_alwaysFetchAccount = false;
			_alreadyFetchedAccount = false;
			_dock = null;
			_dockReturnsNewIfNotFound = true;
			_alwaysFetchDock = false;
			_alreadyFetchedDock = false;
			_recycleType = null;
			_recycleTypeReturnsNewIfNotFound = true;
			_alwaysFetchRecycleType = false;
			_alreadyFetchedRecycleType = false;


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

			_fieldsCustomProperties.Add("BaleId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DockId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RecycleTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("InitWeight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CreatedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("WarehouseWeight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FinalWeight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Notes", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("LoadId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("BaleNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _account</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAccount(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", BaleEntity.Relations.AccountEntityUsingAccountId, true, signalRelatedEntity, "Bale", resetFKFields, new int[] { (int)BaleFieldIndex.AccountId } );		
			_account = null;
		}
		
		/// <summary> setups the sync logic for member _account</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAccount(IEntity relatedEntity)
		{
			if(_account!=relatedEntity)
			{		
				DesetupSyncAccount(true, true);
				_account = (AccountEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", BaleEntity.Relations.AccountEntityUsingAccountId, true, ref _alreadyFetchedAccount, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAccountPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _dock</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDock(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _dock, new PropertyChangedEventHandler( OnDockPropertyChanged ), "Dock", BaleEntity.Relations.DockEntityUsingDockId, true, signalRelatedEntity, "Bale", resetFKFields, new int[] { (int)BaleFieldIndex.DockId } );		
			_dock = null;
		}
		
		/// <summary> setups the sync logic for member _dock</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDock(IEntity relatedEntity)
		{
			if(_dock!=relatedEntity)
			{		
				DesetupSyncDock(true, true);
				_dock = (DockEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _dock, new PropertyChangedEventHandler( OnDockPropertyChanged ), "Dock", BaleEntity.Relations.DockEntityUsingDockId, true, ref _alreadyFetchedDock, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDockPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _recycleType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRecycleType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _recycleType, new PropertyChangedEventHandler( OnRecycleTypePropertyChanged ), "RecycleType", BaleEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, true, signalRelatedEntity, "Bale", resetFKFields, new int[] { (int)BaleFieldIndex.RecycleTypeId } );		
			_recycleType = null;
		}
		
		/// <summary> setups the sync logic for member _recycleType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncRecycleType(IEntity relatedEntity)
		{
			if(_recycleType!=relatedEntity)
			{		
				DesetupSyncRecycleType(true, true);
				_recycleType = (RecycleTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _recycleType, new PropertyChangedEventHandler( OnRecycleTypePropertyChanged ), "RecycleType", BaleEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, true, ref _alreadyFetchedRecycleType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRecycleTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="baleId">PK value for Bale which data should be fetched into this Bale object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 baleId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)BaleFieldIndex.BaleId].ForcedCurrentValueWrite(baleId);
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
			return DAOFactory.CreateBaleDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new BaleEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static BaleRelations Relations
		{
			get	{ return new BaleRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccount
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(),
					(IEntityRelation)GetRelationsForField("Account")[0], (int)Reliant.RenuOil.DAL.EntityType.BaleEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, null, "Account", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Dock' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDock
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DockCollection(),
					(IEntityRelation)GetRelationsForField("Dock")[0], (int)Reliant.RenuOil.DAL.EntityType.BaleEntity, (int)Reliant.RenuOil.DAL.EntityType.DockEntity, 0, null, null, null, "Dock", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleType
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(),
					(IEntityRelation)GetRelationsForField("RecycleType")[0], (int)Reliant.RenuOil.DAL.EntityType.BaleEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, null, "RecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "BaleEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return BaleEntity.CustomProperties;}
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
			get { return BaleEntity.FieldsCustomProperties;}
		}

		/// <summary> The BaleId property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."BaleId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 BaleId
		{
			get { return (System.Int32)GetValue((int)BaleFieldIndex.BaleId, true); }
			set	{ SetValue((int)BaleFieldIndex.BaleId, value, true); }
		}
		/// <summary> The AccountId property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)BaleFieldIndex.AccountId, true); }
			set	{ SetValue((int)BaleFieldIndex.AccountId, value, true); }
		}
		/// <summary> The DockId property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."DockId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DockId
		{
			get { return (System.Int32)GetValue((int)BaleFieldIndex.DockId, true); }
			set	{ SetValue((int)BaleFieldIndex.DockId, value, true); }
		}
		/// <summary> The RecycleTypeId property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."RecycleTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RecycleTypeId
		{
			get { return (System.Int32)GetValue((int)BaleFieldIndex.RecycleTypeId, true); }
			set	{ SetValue((int)BaleFieldIndex.RecycleTypeId, value, true); }
		}
		/// <summary> The InitWeight property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."InitWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> InitWeight
		{
			get { return (Nullable<System.Int32>)GetValue((int)BaleFieldIndex.InitWeight, false); }
			set	{ SetValue((int)BaleFieldIndex.InitWeight, value, true); }
		}
		/// <summary> The CreatedDate property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."CreatedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreatedDate
		{
			get { return (System.DateTime)GetValue((int)BaleFieldIndex.CreatedDate, true); }
			set	{ SetValue((int)BaleFieldIndex.CreatedDate, value, true); }
		}
		/// <summary> The WarehouseWeight property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."WarehouseWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> WarehouseWeight
		{
			get { return (Nullable<System.Int32>)GetValue((int)BaleFieldIndex.WarehouseWeight, false); }
			set	{ SetValue((int)BaleFieldIndex.WarehouseWeight, value, true); }
		}
		/// <summary> The FinalWeight property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."FinalWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> FinalWeight
		{
			get { return (Nullable<System.Int32>)GetValue((int)BaleFieldIndex.FinalWeight, false); }
			set	{ SetValue((int)BaleFieldIndex.FinalWeight, value, true); }
		}
		/// <summary> The Notes property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)BaleFieldIndex.Notes, true); }
			set	{ SetValue((int)BaleFieldIndex.Notes, value, true); }
		}
		/// <summary> The LoadId property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."LoadId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> LoadId
		{
			get { return (Nullable<System.Int32>)GetValue((int)BaleFieldIndex.LoadId, false); }
			set	{ SetValue((int)BaleFieldIndex.LoadId, value, true); }
		}
		/// <summary> The BaleNumber property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."BaleNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> BaleNumber
		{
			get { return (Nullable<System.Int32>)GetValue((int)BaleFieldIndex.BaleNumber, false); }
			set	{ SetValue((int)BaleFieldIndex.BaleNumber, value, true); }
		}
		/// <summary> The IsActive property of the Entity Bale<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Bale"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)BaleFieldIndex.IsActive, true); }
			set	{ SetValue((int)BaleFieldIndex.IsActive, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'AccountEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAccount()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AccountEntity Account
		{
			get	{ return GetSingleAccount(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAccount(value);
				}
				else
				{
					if(value==null)
					{
						if(_account != null)
						{
							_account.UnsetRelatedEntity(this, "Bale");
						}
					}
					else
					{
						if(_account!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Bale");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Account. When set to true, Account is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Account is accessed. You can always execute
		/// a forced fetch by calling GetSingleAccount(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccount
		{
			get	{ return _alwaysFetchAccount; }
			set	{ _alwaysFetchAccount = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Account already has been fetched. Setting this property to false when Account has been fetched
		/// will set Account to null as well. Setting this property to true while Account hasn't been fetched disables lazy loading for Account</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccount
		{
			get { return _alreadyFetchedAccount;}
			set 
			{
				if(_alreadyFetchedAccount && !value)
				{
					this.Account = null;
				}
				_alreadyFetchedAccount = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Account is not found
		/// in the database. When set to true, Account will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool AccountReturnsNewIfNotFound
		{
			get	{ return _accountReturnsNewIfNotFound; }
			set { _accountReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'DockEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleDock()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual DockEntity Dock
		{
			get	{ return GetSingleDock(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncDock(value);
				}
				else
				{
					if(value==null)
					{
						if(_dock != null)
						{
							_dock.UnsetRelatedEntity(this, "Bale");
						}
					}
					else
					{
						if(_dock!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Bale");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Dock. When set to true, Dock is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Dock is accessed. You can always execute
		/// a forced fetch by calling GetSingleDock(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDock
		{
			get	{ return _alwaysFetchDock; }
			set	{ _alwaysFetchDock = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Dock already has been fetched. Setting this property to false when Dock has been fetched
		/// will set Dock to null as well. Setting this property to true while Dock hasn't been fetched disables lazy loading for Dock</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDock
		{
			get { return _alreadyFetchedDock;}
			set 
			{
				if(_alreadyFetchedDock && !value)
				{
					this.Dock = null;
				}
				_alreadyFetchedDock = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Dock is not found
		/// in the database. When set to true, Dock will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool DockReturnsNewIfNotFound
		{
			get	{ return _dockReturnsNewIfNotFound; }
			set { _dockReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'RecycleTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleRecycleType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual RecycleTypeEntity RecycleType
		{
			get	{ return GetSingleRecycleType(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncRecycleType(value);
				}
				else
				{
					if(value==null)
					{
						if(_recycleType != null)
						{
							_recycleType.UnsetRelatedEntity(this, "Bale");
						}
					}
					else
					{
						if(_recycleType!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Bale");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleType. When set to true, RecycleType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleType is accessed. You can always execute
		/// a forced fetch by calling GetSingleRecycleType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleType
		{
			get	{ return _alwaysFetchRecycleType; }
			set	{ _alwaysFetchRecycleType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleType already has been fetched. Setting this property to false when RecycleType has been fetched
		/// will set RecycleType to null as well. Setting this property to true while RecycleType hasn't been fetched disables lazy loading for RecycleType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleType
		{
			get { return _alreadyFetchedRecycleType;}
			set 
			{
				if(_alreadyFetchedRecycleType && !value)
				{
					this.RecycleType = null;
				}
				_alreadyFetchedRecycleType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property RecycleType is not found
		/// in the database. When set to true, RecycleType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool RecycleTypeReturnsNewIfNotFound
		{
			get	{ return _recycleTypeReturnsNewIfNotFound; }
			set { _recycleTypeReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.BaleEntity; }
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
