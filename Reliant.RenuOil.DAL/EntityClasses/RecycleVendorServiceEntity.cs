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
	/// Entity class which represents the entity 'RecycleVendorService'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class RecycleVendorServiceEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private AccountEntity _account;
		private bool	_alwaysFetchAccount, _alreadyFetchedAccount, _accountReturnsNewIfNotFound;
		private RecycleTypeEntity _recycleType;
		private bool	_alwaysFetchRecycleType, _alreadyFetchedRecycleType, _recycleTypeReturnsNewIfNotFound;
		private RecycleVendorEntity _recycleVendor;
		private bool	_alwaysFetchRecycleVendor, _alreadyFetchedRecycleVendor, _recycleVendorReturnsNewIfNotFound;

		
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
			/// <summary>Member name RecycleType</summary>
			public static readonly string RecycleType = "RecycleType";
			/// <summary>Member name RecycleVendor</summary>
			public static readonly string RecycleVendor = "RecycleVendor";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RecycleVendorServiceEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public RecycleVendorServiceEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="recycleVendorServiceId">PK value for RecycleVendorService which data should be fetched into this RecycleVendorService object</param>
		public RecycleVendorServiceEntity(System.Int32 recycleVendorServiceId)
		{
			InitClassFetch(recycleVendorServiceId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="recycleVendorServiceId">PK value for RecycleVendorService which data should be fetched into this RecycleVendorService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public RecycleVendorServiceEntity(System.Int32 recycleVendorServiceId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(recycleVendorServiceId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="recycleVendorServiceId">PK value for RecycleVendorService which data should be fetched into this RecycleVendorService object</param>
		/// <param name="validator">The custom validator object for this RecycleVendorServiceEntity</param>
		public RecycleVendorServiceEntity(System.Int32 recycleVendorServiceId, IValidator validator)
		{
			InitClassFetch(recycleVendorServiceId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RecycleVendorServiceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_account = (AccountEntity)info.GetValue("_account", typeof(AccountEntity));
			if(_account!=null)
			{
				_account.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_accountReturnsNewIfNotFound = info.GetBoolean("_accountReturnsNewIfNotFound");
			_alwaysFetchAccount = info.GetBoolean("_alwaysFetchAccount");
			_alreadyFetchedAccount = info.GetBoolean("_alreadyFetchedAccount");
			_recycleType = (RecycleTypeEntity)info.GetValue("_recycleType", typeof(RecycleTypeEntity));
			if(_recycleType!=null)
			{
				_recycleType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_recycleTypeReturnsNewIfNotFound = info.GetBoolean("_recycleTypeReturnsNewIfNotFound");
			_alwaysFetchRecycleType = info.GetBoolean("_alwaysFetchRecycleType");
			_alreadyFetchedRecycleType = info.GetBoolean("_alreadyFetchedRecycleType");
			_recycleVendor = (RecycleVendorEntity)info.GetValue("_recycleVendor", typeof(RecycleVendorEntity));
			if(_recycleVendor!=null)
			{
				_recycleVendor.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_recycleVendorReturnsNewIfNotFound = info.GetBoolean("_recycleVendorReturnsNewIfNotFound");
			_alwaysFetchRecycleVendor = info.GetBoolean("_alwaysFetchRecycleVendor");
			_alreadyFetchedRecycleVendor = info.GetBoolean("_alreadyFetchedRecycleVendor");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((RecycleVendorServiceFieldIndex)fieldIndex)
			{
				case RecycleVendorServiceFieldIndex.RecycleTypeId:
					DesetupSyncRecycleType(true, false);
					_alreadyFetchedRecycleType = false;
					break;
				case RecycleVendorServiceFieldIndex.RecycleVendorId:
					DesetupSyncRecycleVendor(true, false);
					_alreadyFetchedRecycleVendor = false;
					break;
				case RecycleVendorServiceFieldIndex.AccountId:
					DesetupSyncAccount(true, false);
					_alreadyFetchedAccount = false;
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
			_alreadyFetchedRecycleType = (_recycleType != null);
			_alreadyFetchedRecycleVendor = (_recycleVendor != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return RecycleVendorServiceEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(RecycleVendorServiceEntity.Relations.AccountEntityUsingAccountId);
					break;
				case "RecycleType":
					toReturn.Add(RecycleVendorServiceEntity.Relations.RecycleTypeEntityUsingRecycleTypeId);
					break;
				case "RecycleVendor":
					toReturn.Add(RecycleVendorServiceEntity.Relations.RecycleVendorEntityUsingRecycleVendorId);
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
			info.AddValue("_recycleType", (!this.MarkedForDeletion?_recycleType:null));
			info.AddValue("_recycleTypeReturnsNewIfNotFound", _recycleTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchRecycleType", _alwaysFetchRecycleType);
			info.AddValue("_alreadyFetchedRecycleType", _alreadyFetchedRecycleType);
			info.AddValue("_recycleVendor", (!this.MarkedForDeletion?_recycleVendor:null));
			info.AddValue("_recycleVendorReturnsNewIfNotFound", _recycleVendorReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchRecycleVendor", _alwaysFetchRecycleVendor);
			info.AddValue("_alreadyFetchedRecycleVendor", _alreadyFetchedRecycleVendor);

			
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
				case "RecycleType":
					_alreadyFetchedRecycleType = true;
					this.RecycleType = (RecycleTypeEntity)entity;
					break;
				case "RecycleVendor":
					_alreadyFetchedRecycleVendor = true;
					this.RecycleVendor = (RecycleVendorEntity)entity;
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
				case "RecycleType":
					SetupSyncRecycleType(relatedEntity);
					break;
				case "RecycleVendor":
					SetupSyncRecycleVendor(relatedEntity);
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
				case "RecycleType":
					DesetupSyncRecycleType(false, true);
					break;
				case "RecycleVendor":
					DesetupSyncRecycleVendor(false, true);
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
			if(_recycleType!=null)
			{
				toReturn.Add(_recycleType);
			}
			if(_recycleVendor!=null)
			{
				toReturn.Add(_recycleVendor);
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
		/// <param name="recycleVendorServiceId">PK value for RecycleVendorService which data should be fetched into this RecycleVendorService object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleVendorServiceId)
		{
			return FetchUsingPK(recycleVendorServiceId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleVendorServiceId">PK value for RecycleVendorService which data should be fetched into this RecycleVendorService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleVendorServiceId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(recycleVendorServiceId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleVendorServiceId">PK value for RecycleVendorService which data should be fetched into this RecycleVendorService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleVendorServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(recycleVendorServiceId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleVendorServiceId">PK value for RecycleVendorService which data should be fetched into this RecycleVendorService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleVendorServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(recycleVendorServiceId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.RecycleVendorServiceId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(RecycleVendorServiceFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(RecycleVendorServiceFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new RecycleVendorServiceRelations().GetAllRelations();
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleVendorServiceEntity.Relations.AccountEntityUsingAccountId);

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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleVendorServiceEntity.Relations.RecycleTypeEntityUsingRecycleTypeId);

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

		/// <summary> Retrieves the related entity of type 'RecycleVendorEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'RecycleVendorEntity' which is related to this entity.</returns>
		public RecycleVendorEntity GetSingleRecycleVendor()
		{
			return GetSingleRecycleVendor(false);
		}

		/// <summary> Retrieves the related entity of type 'RecycleVendorEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'RecycleVendorEntity' which is related to this entity.</returns>
		public virtual RecycleVendorEntity GetSingleRecycleVendor(bool forceFetch)
		{
			if( ( !_alreadyFetchedRecycleVendor || forceFetch || _alwaysFetchRecycleVendor) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleVendorServiceEntity.Relations.RecycleVendorEntityUsingRecycleVendorId);

				RecycleVendorEntity newEntity = new RecycleVendorEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.RecycleVendorId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (RecycleVendorEntity)base.ActiveContext.Get(newEntity);
					}
					this.RecycleVendor = newEntity;
				}
				else
				{
					if(_recycleVendorReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_recycleVendor == null)))
						{
							this.RecycleVendor = newEntity;
						}
					}
					else
					{
						this.RecycleVendor = null;
					}
				}
				_alreadyFetchedRecycleVendor = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _recycleVendor;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			RecycleVendorServiceDAO dao = (RecycleVendorServiceDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_account!=null)
			{
				_account.ActiveContext = base.ActiveContext;
			}
			if(_recycleType!=null)
			{
				_recycleType.ActiveContext = base.ActiveContext;
			}
			if(_recycleVendor!=null)
			{
				_recycleVendor.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			RecycleVendorServiceDAO dao = (RecycleVendorServiceDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			RecycleVendorServiceDAO dao = (RecycleVendorServiceDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity);
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
			toReturn.Add("RecycleType", _recycleType);
			toReturn.Add("RecycleVendor", _recycleVendor);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="recycleVendorServiceId">PK value for RecycleVendorService which data should be fetched into this RecycleVendorService object</param>
		/// <param name="validator">The validator object for this RecycleVendorServiceEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 recycleVendorServiceId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(recycleVendorServiceId, prefetchPathToUse, null, null);
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
			_recycleType = null;
			_recycleTypeReturnsNewIfNotFound = true;
			_alwaysFetchRecycleType = false;
			_alreadyFetchedRecycleType = false;
			_recycleVendor = null;
			_recycleVendorReturnsNewIfNotFound = true;
			_alwaysFetchRecycleVendor = false;
			_alreadyFetchedRecycleVendor = false;


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

			_fieldsCustomProperties.Add("RecycleVendorServiceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RecycleTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RecycleVendorId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Weight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("TotalMonthlyWeight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("TotalMonthlyPulls", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _account</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAccount(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", RecycleVendorServiceEntity.Relations.AccountEntityUsingAccountId, true, signalRelatedEntity, "RecycleVendorService", resetFKFields, new int[] { (int)RecycleVendorServiceFieldIndex.AccountId } );		
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
				base.PerformSetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", RecycleVendorServiceEntity.Relations.AccountEntityUsingAccountId, true, ref _alreadyFetchedAccount, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _recycleType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRecycleType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _recycleType, new PropertyChangedEventHandler( OnRecycleTypePropertyChanged ), "RecycleType", RecycleVendorServiceEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, true, signalRelatedEntity, "RecycleVendorService", resetFKFields, new int[] { (int)RecycleVendorServiceFieldIndex.RecycleTypeId } );		
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
				base.PerformSetupSyncRelatedEntity( _recycleType, new PropertyChangedEventHandler( OnRecycleTypePropertyChanged ), "RecycleType", RecycleVendorServiceEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, true, ref _alreadyFetchedRecycleType, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _recycleVendor</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRecycleVendor(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _recycleVendor, new PropertyChangedEventHandler( OnRecycleVendorPropertyChanged ), "RecycleVendor", RecycleVendorServiceEntity.Relations.RecycleVendorEntityUsingRecycleVendorId, true, signalRelatedEntity, "RecycleVendorService", resetFKFields, new int[] { (int)RecycleVendorServiceFieldIndex.RecycleVendorId } );		
			_recycleVendor = null;
		}
		
		/// <summary> setups the sync logic for member _recycleVendor</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncRecycleVendor(IEntity relatedEntity)
		{
			if(_recycleVendor!=relatedEntity)
			{		
				DesetupSyncRecycleVendor(true, true);
				_recycleVendor = (RecycleVendorEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _recycleVendor, new PropertyChangedEventHandler( OnRecycleVendorPropertyChanged ), "RecycleVendor", RecycleVendorServiceEntity.Relations.RecycleVendorEntityUsingRecycleVendorId, true, ref _alreadyFetchedRecycleVendor, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRecycleVendorPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="recycleVendorServiceId">PK value for RecycleVendorService which data should be fetched into this RecycleVendorService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 recycleVendorServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)RecycleVendorServiceFieldIndex.RecycleVendorServiceId].ForcedCurrentValueWrite(recycleVendorServiceId);
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
			return DAOFactory.CreateRecycleVendorServiceDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new RecycleVendorServiceEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static RecycleVendorServiceRelations Relations
		{
			get	{ return new RecycleVendorServiceRelations(); }
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
					(IEntityRelation)GetRelationsForField("Account")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, null, "Account", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("RecycleType")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, null, "RecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleVendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleVendor
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection(),
					(IEntityRelation)GetRelationsForField("RecycleVendor")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity, 0, null, null, null, "RecycleVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "RecycleVendorServiceEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return RecycleVendorServiceEntity.CustomProperties;}
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
			get { return RecycleVendorServiceEntity.FieldsCustomProperties;}
		}

		/// <summary> The RecycleVendorServiceId property of the Entity RecycleVendorService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendorService"."RecycleVendorServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 RecycleVendorServiceId
		{
			get { return (System.Int32)GetValue((int)RecycleVendorServiceFieldIndex.RecycleVendorServiceId, true); }
			set	{ SetValue((int)RecycleVendorServiceFieldIndex.RecycleVendorServiceId, value, true); }
		}
		/// <summary> The ServiceDate property of the Entity RecycleVendorService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendorService"."ServiceDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ServiceDate
		{
			get { return (System.DateTime)GetValue((int)RecycleVendorServiceFieldIndex.ServiceDate, true); }
			set	{ SetValue((int)RecycleVendorServiceFieldIndex.ServiceDate, value, true); }
		}
		/// <summary> The RecycleTypeId property of the Entity RecycleVendorService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendorService"."RecycleTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RecycleTypeId
		{
			get { return (System.Int32)GetValue((int)RecycleVendorServiceFieldIndex.RecycleTypeId, true); }
			set	{ SetValue((int)RecycleVendorServiceFieldIndex.RecycleTypeId, value, true); }
		}
		/// <summary> The RecycleVendorId property of the Entity RecycleVendorService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendorService"."RecycleVendorId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RecycleVendorId
		{
			get { return (System.Int32)GetValue((int)RecycleVendorServiceFieldIndex.RecycleVendorId, true); }
			set	{ SetValue((int)RecycleVendorServiceFieldIndex.RecycleVendorId, value, true); }
		}
		/// <summary> The Weight property of the Entity RecycleVendorService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendorService"."Weight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Weight
		{
			get { return (System.Decimal)GetValue((int)RecycleVendorServiceFieldIndex.Weight, true); }
			set	{ SetValue((int)RecycleVendorServiceFieldIndex.Weight, value, true); }
		}
		/// <summary> The AccountId property of the Entity RecycleVendorService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendorService"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)RecycleVendorServiceFieldIndex.AccountId, true); }
			set	{ SetValue((int)RecycleVendorServiceFieldIndex.AccountId, value, true); }
		}
		/// <summary> The TotalMonthlyWeight property of the Entity RecycleVendorService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendorService"."TotalMonthlyWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TotalMonthlyWeight
		{
			get { return (System.Decimal)GetValue((int)RecycleVendorServiceFieldIndex.TotalMonthlyWeight, true); }
			set	{ SetValue((int)RecycleVendorServiceFieldIndex.TotalMonthlyWeight, value, true); }
		}
		/// <summary> The TotalMonthlyPulls property of the Entity RecycleVendorService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleVendorService"."TotalMonthlyPulls"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 TotalMonthlyPulls
		{
			get { return (System.Int32)GetValue((int)RecycleVendorServiceFieldIndex.TotalMonthlyPulls, true); }
			set	{ SetValue((int)RecycleVendorServiceFieldIndex.TotalMonthlyPulls, value, true); }
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
							_account.UnsetRelatedEntity(this, "RecycleVendorService");
						}
					}
					else
					{
						if(_account!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleVendorService");
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
							_recycleType.UnsetRelatedEntity(this, "RecycleVendorService");
						}
					}
					else
					{
						if(_recycleType!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleVendorService");
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
		/// <summary> Gets / sets related entity of type 'RecycleVendorEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleRecycleVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual RecycleVendorEntity RecycleVendor
		{
			get	{ return GetSingleRecycleVendor(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncRecycleVendor(value);
				}
				else
				{
					if(value==null)
					{
						if(_recycleVendor != null)
						{
							_recycleVendor.UnsetRelatedEntity(this, "RecycleVendorService");
						}
					}
					else
					{
						if(_recycleVendor!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleVendorService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleVendor. When set to true, RecycleVendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleVendor is accessed. You can always execute
		/// a forced fetch by calling GetSingleRecycleVendor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleVendor
		{
			get	{ return _alwaysFetchRecycleVendor; }
			set	{ _alwaysFetchRecycleVendor = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleVendor already has been fetched. Setting this property to false when RecycleVendor has been fetched
		/// will set RecycleVendor to null as well. Setting this property to true while RecycleVendor hasn't been fetched disables lazy loading for RecycleVendor</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleVendor
		{
			get { return _alreadyFetchedRecycleVendor;}
			set 
			{
				if(_alreadyFetchedRecycleVendor && !value)
				{
					this.RecycleVendor = null;
				}
				_alreadyFetchedRecycleVendor = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property RecycleVendor is not found
		/// in the database. When set to true, RecycleVendor will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool RecycleVendorReturnsNewIfNotFound
		{
			get	{ return _recycleVendorReturnsNewIfNotFound; }
			set { _recycleVendorReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity; }
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
