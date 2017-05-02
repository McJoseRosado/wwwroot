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
	/// Entity class which represents the entity 'ChangeLog'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ChangeLogEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection	_deepFryerChangeLog;
		private bool	_alwaysFetchDeepFryerChangeLog, _alreadyFetchedDeepFryerChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection	_serviceLocationAssetTypeChangeLog;
		private bool	_alwaysFetchServiceLocationAssetTypeChangeLog, _alreadyFetchedServiceLocationAssetTypeChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection _deepFryerCollectionViaDeepFryerChangeLog;
		private bool	_alwaysFetchDeepFryerCollectionViaDeepFryerChangeLog, _alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection _serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog;
		private bool	_alwaysFetchServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog, _alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog;
		private ChangeTypeEntity _changeType;
		private bool	_alwaysFetchChangeType, _alreadyFetchedChangeType, _changeTypeReturnsNewIfNotFound;
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
			/// <summary>Member name ChangeType</summary>
			public static readonly string ChangeType = "ChangeType";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
			/// <summary>Member name DeepFryerChangeLog</summary>
			public static readonly string DeepFryerChangeLog = "DeepFryerChangeLog";
			/// <summary>Member name ServiceLocationAssetTypeChangeLog</summary>
			public static readonly string ServiceLocationAssetTypeChangeLog = "ServiceLocationAssetTypeChangeLog";
			/// <summary>Member name DeepFryerCollectionViaDeepFryerChangeLog</summary>
			public static readonly string DeepFryerCollectionViaDeepFryerChangeLog = "DeepFryerCollectionViaDeepFryerChangeLog";
			/// <summary>Member name ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog</summary>
			public static readonly string ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = "ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ChangeLogEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ChangeLogEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		public ChangeLogEntity(System.Int32 changeLogId)
		{
			InitClassFetch(changeLogId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ChangeLogEntity(System.Int32 changeLogId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(changeLogId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		/// <param name="validator">The custom validator object for this ChangeLogEntity</param>
		public ChangeLogEntity(System.Int32 changeLogId, IValidator validator)
		{
			InitClassFetch(changeLogId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ChangeLogEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_deepFryerChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection)info.GetValue("_deepFryerChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection));
			_alwaysFetchDeepFryerChangeLog = info.GetBoolean("_alwaysFetchDeepFryerChangeLog");
			_alreadyFetchedDeepFryerChangeLog = info.GetBoolean("_alreadyFetchedDeepFryerChangeLog");
			_serviceLocationAssetTypeChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection)info.GetValue("_serviceLocationAssetTypeChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection));
			_alwaysFetchServiceLocationAssetTypeChangeLog = info.GetBoolean("_alwaysFetchServiceLocationAssetTypeChangeLog");
			_alreadyFetchedServiceLocationAssetTypeChangeLog = info.GetBoolean("_alreadyFetchedServiceLocationAssetTypeChangeLog");
			_deepFryerCollectionViaDeepFryerChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection)info.GetValue("_deepFryerCollectionViaDeepFryerChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection));
			_alwaysFetchDeepFryerCollectionViaDeepFryerChangeLog = info.GetBoolean("_alwaysFetchDeepFryerCollectionViaDeepFryerChangeLog");
			_alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog = info.GetBoolean("_alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog");
			_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection)info.GetValue("_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection));
			_alwaysFetchServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = info.GetBoolean("_alwaysFetchServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog");
			_alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = info.GetBoolean("_alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog");
			_changeType = (ChangeTypeEntity)info.GetValue("_changeType", typeof(ChangeTypeEntity));
			if(_changeType!=null)
			{
				_changeType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_changeTypeReturnsNewIfNotFound = info.GetBoolean("_changeTypeReturnsNewIfNotFound");
			_alwaysFetchChangeType = info.GetBoolean("_alwaysFetchChangeType");
			_alreadyFetchedChangeType = info.GetBoolean("_alreadyFetchedChangeType");
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
			switch((ChangeLogFieldIndex)fieldIndex)
			{
				case ChangeLogFieldIndex.ChangeTypeId:
					DesetupSyncChangeType(true, false);
					_alreadyFetchedChangeType = false;
					break;
				case ChangeLogFieldIndex.UserId:
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
			_alreadyFetchedDeepFryerChangeLog = (_deepFryerChangeLog.Count > 0);
			_alreadyFetchedServiceLocationAssetTypeChangeLog = (_serviceLocationAssetTypeChangeLog.Count > 0);
			_alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog = (_deepFryerCollectionViaDeepFryerChangeLog.Count > 0);
			_alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = (_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.Count > 0);
			_alreadyFetchedChangeType = (_changeType != null);
			_alreadyFetchedUser = (_user != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ChangeLogEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ChangeType":
					toReturn.Add(ChangeLogEntity.Relations.ChangeTypeEntityUsingChangeTypeId);
					break;
				case "User":
					toReturn.Add(ChangeLogEntity.Relations.UserEntityUsingUserId);
					break;
				case "DeepFryerChangeLog":
					toReturn.Add(ChangeLogEntity.Relations.DeepFryerChangeLogEntityUsingChangeLogId);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					toReturn.Add(ChangeLogEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingChangeLogId);
					break;
				case "DeepFryerCollectionViaDeepFryerChangeLog":
					toReturn.Add(ChangeLogEntity.Relations.DeepFryerChangeLogEntityUsingChangeLogId, "ChangeLogEntity__", "DeepFryerChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerChangeLogEntity.Relations.DeepFryerEntityUsingDeepFryerId, "DeepFryerChangeLog_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog":
					toReturn.Add(ChangeLogEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingChangeLogId, "ChangeLogEntity__", "ServiceLocationAssetTypeChangeLog_", JoinHint.None);
					toReturn.Add(ServiceLocationAssetTypeChangeLogEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, "ServiceLocationAssetTypeChangeLog_", string.Empty, JoinHint.None);
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
			info.AddValue("_deepFryerChangeLog", (!this.MarkedForDeletion?_deepFryerChangeLog:null));
			info.AddValue("_alwaysFetchDeepFryerChangeLog", _alwaysFetchDeepFryerChangeLog);
			info.AddValue("_alreadyFetchedDeepFryerChangeLog", _alreadyFetchedDeepFryerChangeLog);
			info.AddValue("_serviceLocationAssetTypeChangeLog", (!this.MarkedForDeletion?_serviceLocationAssetTypeChangeLog:null));
			info.AddValue("_alwaysFetchServiceLocationAssetTypeChangeLog", _alwaysFetchServiceLocationAssetTypeChangeLog);
			info.AddValue("_alreadyFetchedServiceLocationAssetTypeChangeLog", _alreadyFetchedServiceLocationAssetTypeChangeLog);
			info.AddValue("_deepFryerCollectionViaDeepFryerChangeLog", (!this.MarkedForDeletion?_deepFryerCollectionViaDeepFryerChangeLog:null));
			info.AddValue("_alwaysFetchDeepFryerCollectionViaDeepFryerChangeLog", _alwaysFetchDeepFryerCollectionViaDeepFryerChangeLog);
			info.AddValue("_alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog", _alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog);
			info.AddValue("_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog", (!this.MarkedForDeletion?_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog:null));
			info.AddValue("_alwaysFetchServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog", _alwaysFetchServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog);
			info.AddValue("_alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog", _alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog);
			info.AddValue("_changeType", (!this.MarkedForDeletion?_changeType:null));
			info.AddValue("_changeTypeReturnsNewIfNotFound", _changeTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchChangeType", _alwaysFetchChangeType);
			info.AddValue("_alreadyFetchedChangeType", _alreadyFetchedChangeType);
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
				case "ChangeType":
					_alreadyFetchedChangeType = true;
					this.ChangeType = (ChangeTypeEntity)entity;
					break;
				case "User":
					_alreadyFetchedUser = true;
					this.User = (UserEntity)entity;
					break;
				case "DeepFryerChangeLog":
					_alreadyFetchedDeepFryerChangeLog = true;
					if(entity!=null)
					{
						this.DeepFryerChangeLog.Add((DeepFryerChangeLogEntity)entity);
					}
					break;
				case "ServiceLocationAssetTypeChangeLog":
					_alreadyFetchedServiceLocationAssetTypeChangeLog = true;
					if(entity!=null)
					{
						this.ServiceLocationAssetTypeChangeLog.Add((ServiceLocationAssetTypeChangeLogEntity)entity);
					}
					break;
				case "DeepFryerCollectionViaDeepFryerChangeLog":
					_alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog = true;
					if(entity!=null)
					{
						this.DeepFryerCollectionViaDeepFryerChangeLog.Add((DeepFryerEntity)entity);
					}
					break;
				case "ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog":
					_alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = true;
					if(entity!=null)
					{
						this.ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.Add((ServiceLocationAssetTypeEntity)entity);
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
				case "ChangeType":
					SetupSyncChangeType(relatedEntity);
					break;
				case "User":
					SetupSyncUser(relatedEntity);
					break;
				case "DeepFryerChangeLog":
					_deepFryerChangeLog.Add((DeepFryerChangeLogEntity)relatedEntity);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					_serviceLocationAssetTypeChangeLog.Add((ServiceLocationAssetTypeChangeLogEntity)relatedEntity);
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
				case "ChangeType":
					DesetupSyncChangeType(false, true);
					break;
				case "User":
					DesetupSyncUser(false, true);
					break;
				case "DeepFryerChangeLog":
					base.PerformRelatedEntityRemoval(_deepFryerChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					base.PerformRelatedEntityRemoval(_serviceLocationAssetTypeChangeLog, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_changeType!=null)
			{
				toReturn.Add(_changeType);
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
			toReturn.Add(_deepFryerChangeLog);
			toReturn.Add(_serviceLocationAssetTypeChangeLog);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 changeLogId)
		{
			return FetchUsingPK(changeLogId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 changeLogId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(changeLogId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 changeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(changeLogId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 changeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(changeLogId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ChangeLogId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ChangeLogFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ChangeLogFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ChangeLogRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'DeepFryerChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection GetMultiDeepFryerChangeLog(bool forceFetch)
		{
			return GetMultiDeepFryerChangeLog(forceFetch, _deepFryerChangeLog.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection GetMultiDeepFryerChangeLog(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiDeepFryerChangeLog(forceFetch, _deepFryerChangeLog.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection GetMultiDeepFryerChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiDeepFryerChangeLog(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection GetMultiDeepFryerChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedDeepFryerChangeLog || forceFetch || _alwaysFetchDeepFryerChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryerChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryerChangeLog);
					}
				}
				_deepFryerChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryerChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryerChangeLog.GetMultiManyToOne(this, null, filter);
				_deepFryerChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryerChangeLog = true;
			}
			return _deepFryerChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryerChangeLog'. These settings will be taken into account
		/// when the property DeepFryerChangeLog is requested or GetMultiDeepFryerChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryerChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryerChangeLog.SortClauses=sortClauses;
			_deepFryerChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationAssetTypeChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection GetMultiServiceLocationAssetTypeChangeLog(bool forceFetch)
		{
			return GetMultiServiceLocationAssetTypeChangeLog(forceFetch, _serviceLocationAssetTypeChangeLog.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationAssetTypeChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection GetMultiServiceLocationAssetTypeChangeLog(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationAssetTypeChangeLog(forceFetch, _serviceLocationAssetTypeChangeLog.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection GetMultiServiceLocationAssetTypeChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationAssetTypeChangeLog(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection GetMultiServiceLocationAssetTypeChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationAssetTypeChangeLog || forceFetch || _alwaysFetchServiceLocationAssetTypeChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationAssetTypeChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationAssetTypeChangeLog);
					}
				}
				_serviceLocationAssetTypeChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationAssetTypeChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationAssetTypeChangeLog.GetMultiManyToOne(this, null, filter);
				_serviceLocationAssetTypeChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationAssetTypeChangeLog = true;
			}
			return _serviceLocationAssetTypeChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationAssetTypeChangeLog'. These settings will be taken into account
		/// when the property ServiceLocationAssetTypeChangeLog is requested or GetMultiServiceLocationAssetTypeChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationAssetTypeChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationAssetTypeChangeLog.SortClauses=sortClauses;
			_serviceLocationAssetTypeChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection GetMultiDeepFryerCollectionViaDeepFryerChangeLog(bool forceFetch)
		{
			return GetMultiDeepFryerCollectionViaDeepFryerChangeLog(forceFetch, _deepFryerCollectionViaDeepFryerChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection GetMultiDeepFryerCollectionViaDeepFryerChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog || forceFetch || _alwaysFetchDeepFryerCollectionViaDeepFryerChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryerCollectionViaDeepFryerChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryerCollectionViaDeepFryerChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ChangeLogFields.ChangeLogId, ComparisonOperator.Equal, this.ChangeLogId, "ChangeLogEntity__"));
				_deepFryerCollectionViaDeepFryerChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryerCollectionViaDeepFryerChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryerCollectionViaDeepFryerChangeLog.GetMulti(filter, GetRelationsForField("DeepFryerCollectionViaDeepFryerChangeLog"));
				_deepFryerCollectionViaDeepFryerChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog = true;
			}
			return _deepFryerCollectionViaDeepFryerChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryerCollectionViaDeepFryerChangeLog'. These settings will be taken into account
		/// when the property DeepFryerCollectionViaDeepFryerChangeLog is requested or GetMultiDeepFryerCollectionViaDeepFryerChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryerCollectionViaDeepFryerChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryerCollectionViaDeepFryerChangeLog.SortClauses=sortClauses;
			_deepFryerCollectionViaDeepFryerChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationAssetTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog(bool forceFetch)
		{
			return GetMultiServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog(forceFetch, _serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog || forceFetch || _alwaysFetchServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ChangeLogFields.ChangeLogId, ComparisonOperator.Equal, this.ChangeLogId, "ChangeLogEntity__"));
				_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.GetMulti(filter, GetRelationsForField("ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog"));
				_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = true;
			}
			return _serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog'. These settings will be taken into account
		/// when the property ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog is requested or GetMultiServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.SortClauses=sortClauses;
			_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'ChangeTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ChangeTypeEntity' which is related to this entity.</returns>
		public ChangeTypeEntity GetSingleChangeType()
		{
			return GetSingleChangeType(false);
		}

		/// <summary> Retrieves the related entity of type 'ChangeTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ChangeTypeEntity' which is related to this entity.</returns>
		public virtual ChangeTypeEntity GetSingleChangeType(bool forceFetch)
		{
			if( ( !_alreadyFetchedChangeType || forceFetch || _alwaysFetchChangeType) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ChangeLogEntity.Relations.ChangeTypeEntityUsingChangeTypeId);

				ChangeTypeEntity newEntity = new ChangeTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ChangeTypeId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ChangeTypeEntity)base.ActiveContext.Get(newEntity);
					}
					this.ChangeType = newEntity;
				}
				else
				{
					if(_changeTypeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_changeType == null)))
						{
							this.ChangeType = newEntity;
						}
					}
					else
					{
						this.ChangeType = null;
					}
				}
				_alreadyFetchedChangeType = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _changeType;
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ChangeLogEntity.Relations.UserEntityUsingUserId);

				UserEntity newEntity = new UserEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.UserId);
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
			ChangeLogDAO dao = (ChangeLogDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_deepFryerChangeLog.ActiveContext = base.ActiveContext;
			_serviceLocationAssetTypeChangeLog.ActiveContext = base.ActiveContext;
			_deepFryerCollectionViaDeepFryerChangeLog.ActiveContext = base.ActiveContext;
			_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.ActiveContext = base.ActiveContext;
			if(_changeType!=null)
			{
				_changeType.ActiveContext = base.ActiveContext;
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
			ChangeLogDAO dao = (ChangeLogDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ChangeLogDAO dao = (ChangeLogDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ChangeLogEntity);
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
			toReturn.Add("ChangeType", _changeType);
			toReturn.Add("User", _user);
			toReturn.Add("DeepFryerChangeLog", _deepFryerChangeLog);
			toReturn.Add("ServiceLocationAssetTypeChangeLog", _serviceLocationAssetTypeChangeLog);
			toReturn.Add("DeepFryerCollectionViaDeepFryerChangeLog", _deepFryerCollectionViaDeepFryerChangeLog);
			toReturn.Add("ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog", _serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		/// <param name="validator">The validator object for this ChangeLogEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 changeLogId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(changeLogId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_deepFryerChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection(new DeepFryerChangeLogEntityFactory());
			_deepFryerChangeLog.SetContainingEntityInfo(this, "ChangeLog");
			_alwaysFetchDeepFryerChangeLog = false;
			_alreadyFetchedDeepFryerChangeLog = false;
			_serviceLocationAssetTypeChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection(new ServiceLocationAssetTypeChangeLogEntityFactory());
			_serviceLocationAssetTypeChangeLog.SetContainingEntityInfo(this, "ChangeLog");
			_alwaysFetchServiceLocationAssetTypeChangeLog = false;
			_alreadyFetchedServiceLocationAssetTypeChangeLog = false;
			_deepFryerCollectionViaDeepFryerChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(new DeepFryerEntityFactory());
			_alwaysFetchDeepFryerCollectionViaDeepFryerChangeLog = false;
			_alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog = false;
			_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection(new ServiceLocationAssetTypeEntityFactory());
			_alwaysFetchServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = false;
			_alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = false;
			_changeType = null;
			_changeTypeReturnsNewIfNotFound = true;
			_alwaysFetchChangeType = false;
			_alreadyFetchedChangeType = false;
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

			_fieldsCustomProperties.Add("ChangeLogId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ChangeTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ChangeDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _changeType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncChangeType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _changeType, new PropertyChangedEventHandler( OnChangeTypePropertyChanged ), "ChangeType", ChangeLogEntity.Relations.ChangeTypeEntityUsingChangeTypeId, true, signalRelatedEntity, "ChangeLog", resetFKFields, new int[] { (int)ChangeLogFieldIndex.ChangeTypeId } );		
			_changeType = null;
		}
		
		/// <summary> setups the sync logic for member _changeType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncChangeType(IEntity relatedEntity)
		{
			if(_changeType!=relatedEntity)
			{		
				DesetupSyncChangeType(true, true);
				_changeType = (ChangeTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _changeType, new PropertyChangedEventHandler( OnChangeTypePropertyChanged ), "ChangeType", ChangeLogEntity.Relations.ChangeTypeEntityUsingChangeTypeId, true, ref _alreadyFetchedChangeType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnChangeTypePropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", ChangeLogEntity.Relations.UserEntityUsingUserId, true, signalRelatedEntity, "ChangeLog", resetFKFields, new int[] { (int)ChangeLogFieldIndex.UserId } );		
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
				base.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", ChangeLogEntity.Relations.UserEntityUsingUserId, true, ref _alreadyFetchedUser, new string[] {  } );
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
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 changeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ChangeLogFieldIndex.ChangeLogId].ForcedCurrentValueWrite(changeLogId);
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
			return DAOFactory.CreateChangeLogDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ChangeLogEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ChangeLogRelations Relations
		{
			get	{ return new ChangeLogRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("DeepFryerChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity, 0, null, null, null, "DeepFryerChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetTypeChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationAssetTypeChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetTypeChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity, 0, null, null, null, "ServiceLocationAssetTypeChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerCollectionViaDeepFryerChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ChangeLogEntity.Relations.DeepFryerChangeLogEntityUsingChangeLogId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, GetRelationsForField("DeepFryerCollectionViaDeepFryerChangeLog"), "DeepFryerCollectionViaDeepFryerChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ChangeLogEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingChangeLogId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationAssetTypeChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, GetRelationsForField("ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog"), "ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChangeType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChangeType
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ChangeTypeCollection(),
					(IEntityRelation)GetRelationsForField("ChangeType")[0], (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity, 0, null, null, null, "ChangeType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("User")[0], (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ChangeLogEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ChangeLogEntity.CustomProperties;}
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
			get { return ChangeLogEntity.FieldsCustomProperties;}
		}

		/// <summary> The ChangeLogId property of the Entity ChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeLog"."ChangeLogId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ChangeLogId
		{
			get { return (System.Int32)GetValue((int)ChangeLogFieldIndex.ChangeLogId, true); }
			set	{ SetValue((int)ChangeLogFieldIndex.ChangeLogId, value, true); }
		}
		/// <summary> The ChangeTypeId property of the Entity ChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeLog"."ChangeTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ChangeTypeId
		{
			get { return (System.Int32)GetValue((int)ChangeLogFieldIndex.ChangeTypeId, true); }
			set	{ SetValue((int)ChangeLogFieldIndex.ChangeTypeId, value, true); }
		}
		/// <summary> The UserId property of the Entity ChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeLog"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 UserId
		{
			get { return (System.Int32)GetValue((int)ChangeLogFieldIndex.UserId, true); }
			set	{ SetValue((int)ChangeLogFieldIndex.UserId, value, true); }
		}
		/// <summary> The ChangeDate property of the Entity ChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeLog"."ChangeDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ChangeDate
		{
			get { return (System.DateTime)GetValue((int)ChangeLogFieldIndex.ChangeDate, true); }
			set	{ SetValue((int)ChangeLogFieldIndex.ChangeDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryerChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection DeepFryerChangeLog
		{
			get	{ return GetMultiDeepFryerChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerChangeLog. When set to true, DeepFryerChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryerChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerChangeLog
		{
			get	{ return _alwaysFetchDeepFryerChangeLog; }
			set	{ _alwaysFetchDeepFryerChangeLog = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerChangeLog already has been fetched. Setting this property to false when DeepFryerChangeLog has been fetched
		/// will clear the DeepFryerChangeLog collection well. Setting this property to true while DeepFryerChangeLog hasn't been fetched disables lazy loading for DeepFryerChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerChangeLog
		{
			get { return _alreadyFetchedDeepFryerChangeLog;}
			set 
			{
				if(_alreadyFetchedDeepFryerChangeLog && !value && (_deepFryerChangeLog != null))
				{
					_deepFryerChangeLog.Clear();
				}
				_alreadyFetchedDeepFryerChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationAssetTypeChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection ServiceLocationAssetTypeChangeLog
		{
			get	{ return GetMultiServiceLocationAssetTypeChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationAssetTypeChangeLog. When set to true, ServiceLocationAssetTypeChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationAssetTypeChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationAssetTypeChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationAssetTypeChangeLog
		{
			get	{ return _alwaysFetchServiceLocationAssetTypeChangeLog; }
			set	{ _alwaysFetchServiceLocationAssetTypeChangeLog = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationAssetTypeChangeLog already has been fetched. Setting this property to false when ServiceLocationAssetTypeChangeLog has been fetched
		/// will clear the ServiceLocationAssetTypeChangeLog collection well. Setting this property to true while ServiceLocationAssetTypeChangeLog hasn't been fetched disables lazy loading for ServiceLocationAssetTypeChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationAssetTypeChangeLog
		{
			get { return _alreadyFetchedServiceLocationAssetTypeChangeLog;}
			set 
			{
				if(_alreadyFetchedServiceLocationAssetTypeChangeLog && !value && (_serviceLocationAssetTypeChangeLog != null))
				{
					_serviceLocationAssetTypeChangeLog.Clear();
				}
				_alreadyFetchedServiceLocationAssetTypeChangeLog = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryerCollectionViaDeepFryerChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection DeepFryerCollectionViaDeepFryerChangeLog
		{
			get { return GetMultiDeepFryerCollectionViaDeepFryerChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerCollectionViaDeepFryerChangeLog. When set to true, DeepFryerCollectionViaDeepFryerChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerCollectionViaDeepFryerChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryerCollectionViaDeepFryerChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerCollectionViaDeepFryerChangeLog
		{
			get	{ return _alwaysFetchDeepFryerCollectionViaDeepFryerChangeLog; }
			set	{ _alwaysFetchDeepFryerCollectionViaDeepFryerChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerCollectionViaDeepFryerChangeLog already has been fetched. Setting this property to false when DeepFryerCollectionViaDeepFryerChangeLog has been fetched
		/// will clear the DeepFryerCollectionViaDeepFryerChangeLog collection well. Setting this property to true while DeepFryerCollectionViaDeepFryerChangeLog hasn't been fetched disables lazy loading for DeepFryerCollectionViaDeepFryerChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog
		{
			get { return _alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog;}
			set 
			{
				if(_alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog && !value && (_deepFryerCollectionViaDeepFryerChangeLog != null))
				{
					_deepFryerCollectionViaDeepFryerChangeLog.Clear();
				}
				_alreadyFetchedDeepFryerCollectionViaDeepFryerChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog
		{
			get { return GetMultiServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog. When set to true, ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog
		{
			get	{ return _alwaysFetchServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog; }
			set	{ _alwaysFetchServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog already has been fetched. Setting this property to false when ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog has been fetched
		/// will clear the ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog collection well. Setting this property to true while ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog hasn't been fetched disables lazy loading for ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog
		{
			get { return _alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog;}
			set 
			{
				if(_alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog && !value && (_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog != null))
				{
					_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.Clear();
				}
				_alreadyFetchedServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'ChangeTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleChangeType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ChangeTypeEntity ChangeType
		{
			get	{ return GetSingleChangeType(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncChangeType(value);
				}
				else
				{
					if(value==null)
					{
						if(_changeType != null)
						{
							_changeType.UnsetRelatedEntity(this, "ChangeLog");
						}
					}
					else
					{
						if(_changeType!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ChangeLog");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ChangeType. When set to true, ChangeType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChangeType is accessed. You can always execute
		/// a forced fetch by calling GetSingleChangeType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChangeType
		{
			get	{ return _alwaysFetchChangeType; }
			set	{ _alwaysFetchChangeType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChangeType already has been fetched. Setting this property to false when ChangeType has been fetched
		/// will set ChangeType to null as well. Setting this property to true while ChangeType hasn't been fetched disables lazy loading for ChangeType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChangeType
		{
			get { return _alreadyFetchedChangeType;}
			set 
			{
				if(_alreadyFetchedChangeType && !value)
				{
					this.ChangeType = null;
				}
				_alreadyFetchedChangeType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ChangeType is not found
		/// in the database. When set to true, ChangeType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ChangeTypeReturnsNewIfNotFound
		{
			get	{ return _changeTypeReturnsNewIfNotFound; }
			set { _changeTypeReturnsNewIfNotFound = value; }	
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
							_user.UnsetRelatedEntity(this, "ChangeLog");
						}
					}
					else
					{
						if(_user!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ChangeLog");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity; }
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
