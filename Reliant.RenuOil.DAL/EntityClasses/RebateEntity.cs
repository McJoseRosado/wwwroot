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
	/// Entity class which represents the entity 'Rebate'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class RebateEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private AccountEntity _account;
		private bool	_alwaysFetchAccount, _alreadyFetchedAccount, _accountReturnsNewIfNotFound;
		private RebateTypeEntity _rebateType;
		private bool	_alwaysFetchRebateType, _alreadyFetchedRebateType, _rebateTypeReturnsNewIfNotFound;
		private UserEntity _user;
		private bool	_alwaysFetchUser, _alreadyFetchedUser, _userReturnsNewIfNotFound;

		
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
			/// <summary>Member name RebateType</summary>
			public static readonly string RebateType = "RebateType";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RebateEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public RebateEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="rebateId">PK value for Rebate which data should be fetched into this Rebate object</param>
		public RebateEntity(System.Int32 rebateId)
		{
			InitClassFetch(rebateId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="rebateId">PK value for Rebate which data should be fetched into this Rebate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public RebateEntity(System.Int32 rebateId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(rebateId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="rebateId">PK value for Rebate which data should be fetched into this Rebate object</param>
		/// <param name="validator">The custom validator object for this RebateEntity</param>
		public RebateEntity(System.Int32 rebateId, IValidator validator)
		{
			InitClassFetch(rebateId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RebateEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_account = (AccountEntity)info.GetValue("_account", typeof(AccountEntity));
			if(_account!=null)
			{
				_account.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_accountReturnsNewIfNotFound = info.GetBoolean("_accountReturnsNewIfNotFound");
			_alwaysFetchAccount = info.GetBoolean("_alwaysFetchAccount");
			_alreadyFetchedAccount = info.GetBoolean("_alreadyFetchedAccount");
			_rebateType = (RebateTypeEntity)info.GetValue("_rebateType", typeof(RebateTypeEntity));
			if(_rebateType!=null)
			{
				_rebateType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_rebateTypeReturnsNewIfNotFound = info.GetBoolean("_rebateTypeReturnsNewIfNotFound");
			_alwaysFetchRebateType = info.GetBoolean("_alwaysFetchRebateType");
			_alreadyFetchedRebateType = info.GetBoolean("_alreadyFetchedRebateType");
			_user = (UserEntity)info.GetValue("_user", typeof(UserEntity));
			if(_user!=null)
			{
				_user.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_userReturnsNewIfNotFound = info.GetBoolean("_userReturnsNewIfNotFound");
			_alwaysFetchUser = info.GetBoolean("_alwaysFetchUser");
			_alreadyFetchedUser = info.GetBoolean("_alreadyFetchedUser");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((RebateFieldIndex)fieldIndex)
			{
				case RebateFieldIndex.RebateTypeId:
					DesetupSyncRebateType(true, false);
					_alreadyFetchedRebateType = false;
					break;
				case RebateFieldIndex.AccountId:
					DesetupSyncAccount(true, false);
					_alreadyFetchedAccount = false;
					break;
				case RebateFieldIndex.EnteredByUserId:
					DesetupSyncUser(true, false);
					_alreadyFetchedUser = false;
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
			_alreadyFetchedRebateType = (_rebateType != null);
			_alreadyFetchedUser = (_user != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return RebateEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(RebateEntity.Relations.AccountEntityUsingAccountId);
					break;
				case "RebateType":
					toReturn.Add(RebateEntity.Relations.RebateTypeEntityUsingRebateTypeId);
					break;
				case "User":
					toReturn.Add(RebateEntity.Relations.UserEntityUsingEnteredByUserId);
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
			info.AddValue("_rebateType", (!this.MarkedForDeletion?_rebateType:null));
			info.AddValue("_rebateTypeReturnsNewIfNotFound", _rebateTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchRebateType", _alwaysFetchRebateType);
			info.AddValue("_alreadyFetchedRebateType", _alreadyFetchedRebateType);
			info.AddValue("_user", (!this.MarkedForDeletion?_user:null));
			info.AddValue("_userReturnsNewIfNotFound", _userReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUser", _alwaysFetchUser);
			info.AddValue("_alreadyFetchedUser", _alreadyFetchedUser);

			
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
				case "RebateType":
					_alreadyFetchedRebateType = true;
					this.RebateType = (RebateTypeEntity)entity;
					break;
				case "User":
					_alreadyFetchedUser = true;
					this.User = (UserEntity)entity;
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
				case "RebateType":
					SetupSyncRebateType(relatedEntity);
					break;
				case "User":
					SetupSyncUser(relatedEntity);
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
				case "RebateType":
					DesetupSyncRebateType(false, true);
					break;
				case "User":
					DesetupSyncUser(false, true);
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
			if(_rebateType!=null)
			{
				toReturn.Add(_rebateType);
			}
			if(_user!=null)
			{
				toReturn.Add(_user);
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
		/// <param name="rebateId">PK value for Rebate which data should be fetched into this Rebate object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 rebateId)
		{
			return FetchUsingPK(rebateId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="rebateId">PK value for Rebate which data should be fetched into this Rebate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 rebateId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(rebateId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="rebateId">PK value for Rebate which data should be fetched into this Rebate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 rebateId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(rebateId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="rebateId">PK value for Rebate which data should be fetched into this Rebate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 rebateId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(rebateId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.RebateId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(RebateFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(RebateFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new RebateRelations().GetAllRelations();
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RebateEntity.Relations.AccountEntityUsingAccountId);

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

		/// <summary> Retrieves the related entity of type 'RebateTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'RebateTypeEntity' which is related to this entity.</returns>
		public RebateTypeEntity GetSingleRebateType()
		{
			return GetSingleRebateType(false);
		}

		/// <summary> Retrieves the related entity of type 'RebateTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'RebateTypeEntity' which is related to this entity.</returns>
		public virtual RebateTypeEntity GetSingleRebateType(bool forceFetch)
		{
			if( ( !_alreadyFetchedRebateType || forceFetch || _alwaysFetchRebateType) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RebateEntity.Relations.RebateTypeEntityUsingRebateTypeId);

				RebateTypeEntity newEntity = new RebateTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.RebateTypeId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (RebateTypeEntity)base.ActiveContext.Get(newEntity);
					}
					this.RebateType = newEntity;
				}
				else
				{
					if(_rebateTypeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_rebateType == null)))
						{
							this.RebateType = newEntity;
						}
					}
					else
					{
						this.RebateType = null;
					}
				}
				_alreadyFetchedRebateType = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _rebateType;
		}

		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public UserEntity GetSingleUser()
		{
			return GetSingleUser(false);
		}

		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public virtual UserEntity GetSingleUser(bool forceFetch)
		{
			if( ( !_alreadyFetchedUser || forceFetch || _alwaysFetchUser) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RebateEntity.Relations.UserEntityUsingEnteredByUserId);

				UserEntity newEntity = new UserEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.EnteredByUserId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (UserEntity)base.ActiveContext.Get(newEntity);
					}
					this.User = newEntity;
				}
				else
				{
					if(_userReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_user == null)))
						{
							this.User = newEntity;
						}
					}
					else
					{
						this.User = null;
					}
				}
				_alreadyFetchedUser = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _user;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			RebateDAO dao = (RebateDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_account!=null)
			{
				_account.ActiveContext = base.ActiveContext;
			}
			if(_rebateType!=null)
			{
				_rebateType.ActiveContext = base.ActiveContext;
			}
			if(_user!=null)
			{
				_user.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			RebateDAO dao = (RebateDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			RebateDAO dao = (RebateDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.RebateEntity);
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
			toReturn.Add("RebateType", _rebateType);
			toReturn.Add("User", _user);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="rebateId">PK value for Rebate which data should be fetched into this Rebate object</param>
		/// <param name="validator">The validator object for this RebateEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 rebateId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(rebateId, prefetchPathToUse, null, null);
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
			_rebateType = null;
			_rebateTypeReturnsNewIfNotFound = true;
			_alwaysFetchRebateType = false;
			_alreadyFetchedRebateType = false;
			_user = null;
			_userReturnsNewIfNotFound = true;
			_alwaysFetchUser = false;
			_alreadyFetchedUser = false;


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

			_fieldsCustomProperties.Add("RebateId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RebateTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RebateDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Amount", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EnteredByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EnteredDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _account</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAccount(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", RebateEntity.Relations.AccountEntityUsingAccountId, true, signalRelatedEntity, "Rebate", resetFKFields, new int[] { (int)RebateFieldIndex.AccountId } );		
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
				base.PerformSetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", RebateEntity.Relations.AccountEntityUsingAccountId, true, ref _alreadyFetchedAccount, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _rebateType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRebateType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _rebateType, new PropertyChangedEventHandler( OnRebateTypePropertyChanged ), "RebateType", RebateEntity.Relations.RebateTypeEntityUsingRebateTypeId, true, signalRelatedEntity, "Rebate", resetFKFields, new int[] { (int)RebateFieldIndex.RebateTypeId } );		
			_rebateType = null;
		}
		
		/// <summary> setups the sync logic for member _rebateType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncRebateType(IEntity relatedEntity)
		{
			if(_rebateType!=relatedEntity)
			{		
				DesetupSyncRebateType(true, true);
				_rebateType = (RebateTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _rebateType, new PropertyChangedEventHandler( OnRebateTypePropertyChanged ), "RebateType", RebateEntity.Relations.RebateTypeEntityUsingRebateTypeId, true, ref _alreadyFetchedRebateType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRebateTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _user</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", RebateEntity.Relations.UserEntityUsingEnteredByUserId, true, signalRelatedEntity, "Rebate", resetFKFields, new int[] { (int)RebateFieldIndex.EnteredByUserId } );		
			_user = null;
		}
		
		/// <summary> setups the sync logic for member _user</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUser(IEntity relatedEntity)
		{
			if(_user!=relatedEntity)
			{		
				DesetupSyncUser(true, true);
				_user = (UserEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", RebateEntity.Relations.UserEntityUsingEnteredByUserId, true, ref _alreadyFetchedUser, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="rebateId">PK value for Rebate which data should be fetched into this Rebate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 rebateId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)RebateFieldIndex.RebateId].ForcedCurrentValueWrite(rebateId);
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
			return DAOFactory.CreateRebateDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new RebateEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static RebateRelations Relations
		{
			get	{ return new RebateRelations(); }
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
					(IEntityRelation)GetRelationsForField("Account")[0], (int)Reliant.RenuOil.DAL.EntityType.RebateEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, null, "Account", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RebateType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRebateType
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection(),
					(IEntityRelation)GetRelationsForField("RebateType")[0], (int)Reliant.RenuOil.DAL.EntityType.RebateEntity, (int)Reliant.RenuOil.DAL.EntityType.RebateTypeEntity, 0, null, null, null, "RebateType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUser
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(),
					(IEntityRelation)GetRelationsForField("User")[0], (int)Reliant.RenuOil.DAL.EntityType.RebateEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "RebateEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return RebateEntity.CustomProperties;}
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
			get { return RebateEntity.FieldsCustomProperties;}
		}

		/// <summary> The RebateId property of the Entity Rebate<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Rebate"."RebateId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 RebateId
		{
			get { return (System.Int32)GetValue((int)RebateFieldIndex.RebateId, true); }
			set	{ SetValue((int)RebateFieldIndex.RebateId, value, true); }
		}
		/// <summary> The RebateTypeId property of the Entity Rebate<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Rebate"."RebateTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RebateTypeId
		{
			get { return (System.Int32)GetValue((int)RebateFieldIndex.RebateTypeId, true); }
			set	{ SetValue((int)RebateFieldIndex.RebateTypeId, value, true); }
		}
		/// <summary> The RebateDate property of the Entity Rebate<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Rebate"."RebateDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime RebateDate
		{
			get { return (System.DateTime)GetValue((int)RebateFieldIndex.RebateDate, true); }
			set	{ SetValue((int)RebateFieldIndex.RebateDate, value, true); }
		}
		/// <summary> The AccountId property of the Entity Rebate<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Rebate"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)RebateFieldIndex.AccountId, true); }
			set	{ SetValue((int)RebateFieldIndex.AccountId, value, true); }
		}
		/// <summary> The Amount property of the Entity Rebate<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Rebate"."Amount"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Amount
		{
			get { return (System.Decimal)GetValue((int)RebateFieldIndex.Amount, true); }
			set	{ SetValue((int)RebateFieldIndex.Amount, value, true); }
		}
		/// <summary> The EnteredByUserId property of the Entity Rebate<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Rebate"."EnteredByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 EnteredByUserId
		{
			get { return (System.Int32)GetValue((int)RebateFieldIndex.EnteredByUserId, true); }
			set	{ SetValue((int)RebateFieldIndex.EnteredByUserId, value, true); }
		}
		/// <summary> The EnteredDate property of the Entity Rebate<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Rebate"."EnteredDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime EnteredDate
		{
			get { return (System.DateTime)GetValue((int)RebateFieldIndex.EnteredDate, true); }
			set	{ SetValue((int)RebateFieldIndex.EnteredDate, value, true); }
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
							_account.UnsetRelatedEntity(this, "Rebate");
						}
					}
					else
					{
						if(_account!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Rebate");
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
		/// <summary> Gets / sets related entity of type 'RebateTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleRebateType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual RebateTypeEntity RebateType
		{
			get	{ return GetSingleRebateType(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncRebateType(value);
				}
				else
				{
					if(value==null)
					{
						if(_rebateType != null)
						{
							_rebateType.UnsetRelatedEntity(this, "Rebate");
						}
					}
					else
					{
						if(_rebateType!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Rebate");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for RebateType. When set to true, RebateType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RebateType is accessed. You can always execute
		/// a forced fetch by calling GetSingleRebateType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRebateType
		{
			get	{ return _alwaysFetchRebateType; }
			set	{ _alwaysFetchRebateType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RebateType already has been fetched. Setting this property to false when RebateType has been fetched
		/// will set RebateType to null as well. Setting this property to true while RebateType hasn't been fetched disables lazy loading for RebateType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRebateType
		{
			get { return _alreadyFetchedRebateType;}
			set 
			{
				if(_alreadyFetchedRebateType && !value)
				{
					this.RebateType = null;
				}
				_alreadyFetchedRebateType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property RebateType is not found
		/// in the database. When set to true, RebateType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool RebateTypeReturnsNewIfNotFound
		{
			get	{ return _rebateTypeReturnsNewIfNotFound; }
			set { _rebateTypeReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'UserEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUser()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UserEntity User
		{
			get	{ return GetSingleUser(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUser(value);
				}
				else
				{
					if(value==null)
					{
						if(_user != null)
						{
							_user.UnsetRelatedEntity(this, "Rebate");
						}
					}
					else
					{
						if(_user!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Rebate");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for User. When set to true, User is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time User is accessed. You can always execute
		/// a forced fetch by calling GetSingleUser(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUser
		{
			get	{ return _alwaysFetchUser; }
			set	{ _alwaysFetchUser = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property User already has been fetched. Setting this property to false when User has been fetched
		/// will set User to null as well. Setting this property to true while User hasn't been fetched disables lazy loading for User</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUser
		{
			get { return _alreadyFetchedUser;}
			set 
			{
				if(_alreadyFetchedUser && !value)
				{
					this.User = null;
				}
				_alreadyFetchedUser = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property User is not found
		/// in the database. When set to true, User will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool UserReturnsNewIfNotFound
		{
			get	{ return _userReturnsNewIfNotFound; }
			set { _userReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.RebateEntity; }
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
