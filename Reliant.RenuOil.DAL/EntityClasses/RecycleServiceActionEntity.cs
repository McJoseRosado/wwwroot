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
	/// Entity class which represents the entity 'RecycleServiceAction'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class RecycleServiceActionEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private EmployeeEntity _employee_;
		private bool	_alwaysFetchEmployee_, _alreadyFetchedEmployee_, _employee_ReturnsNewIfNotFound;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee, _employeeReturnsNewIfNotFound;
		private RecycleServiceEntity _recycleService;
		private bool	_alwaysFetchRecycleService, _alreadyFetchedRecycleService, _recycleServiceReturnsNewIfNotFound;
		private RecycleTypeEntity _recycleType;
		private bool	_alwaysFetchRecycleType, _alreadyFetchedRecycleType, _recycleTypeReturnsNewIfNotFound;
		private UserEntity _user;
		private bool	_alwaysFetchUser, _alreadyFetchedUser, _userReturnsNewIfNotFound;
		private UserEntity _user_;
		private bool	_alwaysFetchUser_, _alreadyFetchedUser_, _user_ReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Employee_</summary>
			public static readonly string Employee_ = "Employee_";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name RecycleService</summary>
			public static readonly string RecycleService = "RecycleService";
			/// <summary>Member name RecycleType</summary>
			public static readonly string RecycleType = "RecycleType";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
			/// <summary>Member name User_</summary>
			public static readonly string User_ = "User_";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RecycleServiceActionEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public RecycleServiceActionEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		public RecycleServiceActionEntity(System.Int32 recycleServiceActionId)
		{
			InitClassFetch(recycleServiceActionId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public RecycleServiceActionEntity(System.Int32 recycleServiceActionId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(recycleServiceActionId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		/// <param name="validator">The custom validator object for this RecycleServiceActionEntity</param>
		public RecycleServiceActionEntity(System.Int32 recycleServiceActionId, IValidator validator)
		{
			InitClassFetch(recycleServiceActionId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RecycleServiceActionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_employee_ = (EmployeeEntity)info.GetValue("_employee_", typeof(EmployeeEntity));
			if(_employee_!=null)
			{
				_employee_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employee_ReturnsNewIfNotFound = info.GetBoolean("_employee_ReturnsNewIfNotFound");
			_alwaysFetchEmployee_ = info.GetBoolean("_alwaysFetchEmployee_");
			_alreadyFetchedEmployee_ = info.GetBoolean("_alreadyFetchedEmployee_");
			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeeReturnsNewIfNotFound = info.GetBoolean("_employeeReturnsNewIfNotFound");
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");
			_recycleService = (RecycleServiceEntity)info.GetValue("_recycleService", typeof(RecycleServiceEntity));
			if(_recycleService!=null)
			{
				_recycleService.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_recycleServiceReturnsNewIfNotFound = info.GetBoolean("_recycleServiceReturnsNewIfNotFound");
			_alwaysFetchRecycleService = info.GetBoolean("_alwaysFetchRecycleService");
			_alreadyFetchedRecycleService = info.GetBoolean("_alreadyFetchedRecycleService");
			_recycleType = (RecycleTypeEntity)info.GetValue("_recycleType", typeof(RecycleTypeEntity));
			if(_recycleType!=null)
			{
				_recycleType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_recycleTypeReturnsNewIfNotFound = info.GetBoolean("_recycleTypeReturnsNewIfNotFound");
			_alwaysFetchRecycleType = info.GetBoolean("_alwaysFetchRecycleType");
			_alreadyFetchedRecycleType = info.GetBoolean("_alreadyFetchedRecycleType");
			_user = (UserEntity)info.GetValue("_user", typeof(UserEntity));
			if(_user!=null)
			{
				_user.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_userReturnsNewIfNotFound = info.GetBoolean("_userReturnsNewIfNotFound");
			_alwaysFetchUser = info.GetBoolean("_alwaysFetchUser");
			_alreadyFetchedUser = info.GetBoolean("_alreadyFetchedUser");
			_user_ = (UserEntity)info.GetValue("_user_", typeof(UserEntity));
			if(_user_!=null)
			{
				_user_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_user_ReturnsNewIfNotFound = info.GetBoolean("_user_ReturnsNewIfNotFound");
			_alwaysFetchUser_ = info.GetBoolean("_alwaysFetchUser_");
			_alreadyFetchedUser_ = info.GetBoolean("_alreadyFetchedUser_");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((RecycleServiceActionFieldIndex)fieldIndex)
			{
				case RecycleServiceActionFieldIndex.RecycleServiceId:
					DesetupSyncRecycleService(true, false);
					_alreadyFetchedRecycleService = false;
					break;
				case RecycleServiceActionFieldIndex.RecycleTypeId:
					DesetupSyncRecycleType(true, false);
					_alreadyFetchedRecycleType = false;
					break;
				case RecycleServiceActionFieldIndex.ActionUserId:
					DesetupSyncUser(true, false);
					_alreadyFetchedUser = false;
					break;
				case RecycleServiceActionFieldIndex.LastChangedByUserId:
					DesetupSyncUser_(true, false);
					_alreadyFetchedUser_ = false;
					break;
				case RecycleServiceActionFieldIndex.ActionEmployeeId:
					DesetupSyncEmployee(true, false);
					_alreadyFetchedEmployee = false;
					break;
				case RecycleServiceActionFieldIndex.LastChangedByEmployeeId:
					DesetupSyncEmployee_(true, false);
					_alreadyFetchedEmployee_ = false;
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


			_alreadyFetchedEmployee_ = (_employee_ != null);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedRecycleService = (_recycleService != null);
			_alreadyFetchedRecycleType = (_recycleType != null);
			_alreadyFetchedUser = (_user != null);
			_alreadyFetchedUser_ = (_user_ != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return RecycleServiceActionEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Employee_":
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingLastChangedByEmployeeId);
					break;
				case "Employee":
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingActionEmployeeId);
					break;
				case "RecycleService":
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleServiceEntityUsingRecycleServiceId);
					break;
				case "RecycleType":
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId);
					break;
				case "User":
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingActionUserId);
					break;
				case "User_":
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingLastChangedByUserId);
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


			info.AddValue("_employee_", (!this.MarkedForDeletion?_employee_:null));
			info.AddValue("_employee_ReturnsNewIfNotFound", _employee_ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee_", _alwaysFetchEmployee_);
			info.AddValue("_alreadyFetchedEmployee_", _alreadyFetchedEmployee_);
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_employeeReturnsNewIfNotFound", _employeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_recycleService", (!this.MarkedForDeletion?_recycleService:null));
			info.AddValue("_recycleServiceReturnsNewIfNotFound", _recycleServiceReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchRecycleService", _alwaysFetchRecycleService);
			info.AddValue("_alreadyFetchedRecycleService", _alreadyFetchedRecycleService);
			info.AddValue("_recycleType", (!this.MarkedForDeletion?_recycleType:null));
			info.AddValue("_recycleTypeReturnsNewIfNotFound", _recycleTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchRecycleType", _alwaysFetchRecycleType);
			info.AddValue("_alreadyFetchedRecycleType", _alreadyFetchedRecycleType);
			info.AddValue("_user", (!this.MarkedForDeletion?_user:null));
			info.AddValue("_userReturnsNewIfNotFound", _userReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUser", _alwaysFetchUser);
			info.AddValue("_alreadyFetchedUser", _alreadyFetchedUser);
			info.AddValue("_user_", (!this.MarkedForDeletion?_user_:null));
			info.AddValue("_user_ReturnsNewIfNotFound", _user_ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUser_", _alwaysFetchUser_);
			info.AddValue("_alreadyFetchedUser_", _alreadyFetchedUser_);

			
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
				case "Employee_":
					_alreadyFetchedEmployee_ = true;
					this.Employee_ = (EmployeeEntity)entity;
					break;
				case "Employee":
					_alreadyFetchedEmployee = true;
					this.Employee = (EmployeeEntity)entity;
					break;
				case "RecycleService":
					_alreadyFetchedRecycleService = true;
					this.RecycleService = (RecycleServiceEntity)entity;
					break;
				case "RecycleType":
					_alreadyFetchedRecycleType = true;
					this.RecycleType = (RecycleTypeEntity)entity;
					break;
				case "User":
					_alreadyFetchedUser = true;
					this.User = (UserEntity)entity;
					break;
				case "User_":
					_alreadyFetchedUser_ = true;
					this.User_ = (UserEntity)entity;
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
				case "Employee_":
					SetupSyncEmployee_(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "RecycleService":
					SetupSyncRecycleService(relatedEntity);
					break;
				case "RecycleType":
					SetupSyncRecycleType(relatedEntity);
					break;
				case "User":
					SetupSyncUser(relatedEntity);
					break;
				case "User_":
					SetupSyncUser_(relatedEntity);
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
				case "Employee_":
					DesetupSyncEmployee_(false, true);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "RecycleService":
					DesetupSyncRecycleService(false, true);
					break;
				case "RecycleType":
					DesetupSyncRecycleType(false, true);
					break;
				case "User":
					DesetupSyncUser(false, true);
					break;
				case "User_":
					DesetupSyncUser_(false, true);
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
			if(_employee_!=null)
			{
				toReturn.Add(_employee_);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_recycleService!=null)
			{
				toReturn.Add(_recycleService);
			}
			if(_recycleType!=null)
			{
				toReturn.Add(_recycleType);
			}
			if(_user!=null)
			{
				toReturn.Add(_user);
			}
			if(_user_!=null)
			{
				toReturn.Add(_user_);
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
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleServiceActionId)
		{
			return FetchUsingPK(recycleServiceActionId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleServiceActionId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(recycleServiceActionId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleServiceActionId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(recycleServiceActionId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleServiceActionId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(recycleServiceActionId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.RecycleServiceActionId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(RecycleServiceActionFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(RecycleServiceActionFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new RecycleServiceActionRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee_()
		{
			return GetSingleEmployee_(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee_(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee_ || forceFetch || _alwaysFetchEmployee_) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleServiceActionEntity.Relations.EmployeeEntityUsingLastChangedByEmployeeId);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.LastChangedByEmployeeId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee_ = newEntity;
				}
				else
				{
					if(_employee_ReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee_ == null)))
						{
							this.Employee_ = newEntity;
						}
					}
					else
					{
						this.Employee_ = null;
					}
				}
				_alreadyFetchedEmployee_ = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _employee_;
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee()
		{
			return GetSingleEmployee(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleServiceActionEntity.Relations.EmployeeEntityUsingActionEmployeeId);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ActionEmployeeId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee = newEntity;
				}
				else
				{
					if(_employeeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee == null)))
						{
							this.Employee = newEntity;
						}
					}
					else
					{
						this.Employee = null;
					}
				}
				_alreadyFetchedEmployee = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _employee;
		}

		/// <summary> Retrieves the related entity of type 'RecycleServiceEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'RecycleServiceEntity' which is related to this entity.</returns>
		public RecycleServiceEntity GetSingleRecycleService()
		{
			return GetSingleRecycleService(false);
		}

		/// <summary> Retrieves the related entity of type 'RecycleServiceEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'RecycleServiceEntity' which is related to this entity.</returns>
		public virtual RecycleServiceEntity GetSingleRecycleService(bool forceFetch)
		{
			if( ( !_alreadyFetchedRecycleService || forceFetch || _alwaysFetchRecycleService) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleServiceActionEntity.Relations.RecycleServiceEntityUsingRecycleServiceId);

				RecycleServiceEntity newEntity = new RecycleServiceEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.RecycleServiceId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (RecycleServiceEntity)base.ActiveContext.Get(newEntity);
					}
					this.RecycleService = newEntity;
				}
				else
				{
					if(_recycleServiceReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_recycleService == null)))
						{
							this.RecycleService = newEntity;
						}
					}
					else
					{
						this.RecycleService = null;
					}
				}
				_alreadyFetchedRecycleService = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _recycleService;
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId);

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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleServiceActionEntity.Relations.UserEntityUsingActionUserId);

				UserEntity newEntity = new UserEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ActionUserId.GetValueOrDefault());
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

		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public UserEntity GetSingleUser_()
		{
			return GetSingleUser_(false);
		}

		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public virtual UserEntity GetSingleUser_(bool forceFetch)
		{
			if( ( !_alreadyFetchedUser_ || forceFetch || _alwaysFetchUser_) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleServiceActionEntity.Relations.UserEntityUsingLastChangedByUserId);

				UserEntity newEntity = new UserEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.LastChangedByUserId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (UserEntity)base.ActiveContext.Get(newEntity);
					}
					this.User_ = newEntity;
				}
				else
				{
					if(_user_ReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_user_ == null)))
						{
							this.User_ = newEntity;
						}
					}
					else
					{
						this.User_ = null;
					}
				}
				_alreadyFetchedUser_ = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _user_;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			RecycleServiceActionDAO dao = (RecycleServiceActionDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_employee_!=null)
			{
				_employee_.ActiveContext = base.ActiveContext;
			}
			if(_employee!=null)
			{
				_employee.ActiveContext = base.ActiveContext;
			}
			if(_recycleService!=null)
			{
				_recycleService.ActiveContext = base.ActiveContext;
			}
			if(_recycleType!=null)
			{
				_recycleType.ActiveContext = base.ActiveContext;
			}
			if(_user!=null)
			{
				_user.ActiveContext = base.ActiveContext;
			}
			if(_user_!=null)
			{
				_user_.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			RecycleServiceActionDAO dao = (RecycleServiceActionDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			RecycleServiceActionDAO dao = (RecycleServiceActionDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity);
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
			toReturn.Add("Employee_", _employee_);
			toReturn.Add("Employee", _employee);
			toReturn.Add("RecycleService", _recycleService);
			toReturn.Add("RecycleType", _recycleType);
			toReturn.Add("User", _user);
			toReturn.Add("User_", _user_);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		/// <param name="validator">The validator object for this RecycleServiceActionEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 recycleServiceActionId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(recycleServiceActionId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_employee_ = null;
			_employee_ReturnsNewIfNotFound = true;
			_alwaysFetchEmployee_ = false;
			_alreadyFetchedEmployee_ = false;
			_employee = null;
			_employeeReturnsNewIfNotFound = true;
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_recycleService = null;
			_recycleServiceReturnsNewIfNotFound = true;
			_alwaysFetchRecycleService = false;
			_alreadyFetchedRecycleService = false;
			_recycleType = null;
			_recycleTypeReturnsNewIfNotFound = true;
			_alwaysFetchRecycleType = false;
			_alreadyFetchedRecycleType = false;
			_user = null;
			_userReturnsNewIfNotFound = true;
			_alwaysFetchUser = false;
			_alreadyFetchedUser = false;
			_user_ = null;
			_user_ReturnsNewIfNotFound = true;
			_alwaysFetchUser_ = false;
			_alreadyFetchedUser_ = false;


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

			_fieldsCustomProperties.Add("RecycleServiceActionId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ActionTime", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NumberOfBales", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NumberOfBags", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("BalesWeight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("BagsWeight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RecycleServiceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RecycleTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ActionUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("LastChangedByUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("LastChangedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ActionType", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ActionEmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("LastChangedByEmployeeId", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _employee_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee_(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee_, new PropertyChangedEventHandler( OnEmployee_PropertyChanged ), "Employee_", RecycleServiceActionEntity.Relations.EmployeeEntityUsingLastChangedByEmployeeId, true, signalRelatedEntity, "RecycleServiceAction", resetFKFields, new int[] { (int)RecycleServiceActionFieldIndex.LastChangedByEmployeeId } );		
			_employee_ = null;
		}
		
		/// <summary> setups the sync logic for member _employee_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee_(IEntity relatedEntity)
		{
			if(_employee_!=relatedEntity)
			{		
				DesetupSyncEmployee_(true, true);
				_employee_ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee_, new PropertyChangedEventHandler( OnEmployee_PropertyChanged ), "Employee_", RecycleServiceActionEntity.Relations.EmployeeEntityUsingLastChangedByEmployeeId, true, ref _alreadyFetchedEmployee_, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", RecycleServiceActionEntity.Relations.EmployeeEntityUsingActionEmployeeId, true, signalRelatedEntity, "RecycleServiceAction_", resetFKFields, new int[] { (int)RecycleServiceActionFieldIndex.ActionEmployeeId } );		
			_employee = null;
		}
		
		/// <summary> setups the sync logic for member _employee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntity relatedEntity)
		{
			if(_employee!=relatedEntity)
			{		
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", RecycleServiceActionEntity.Relations.EmployeeEntityUsingActionEmployeeId, true, ref _alreadyFetchedEmployee, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _recycleService</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRecycleService(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _recycleService, new PropertyChangedEventHandler( OnRecycleServicePropertyChanged ), "RecycleService", RecycleServiceActionEntity.Relations.RecycleServiceEntityUsingRecycleServiceId, true, signalRelatedEntity, "RecycleServiceAction", resetFKFields, new int[] { (int)RecycleServiceActionFieldIndex.RecycleServiceId } );		
			_recycleService = null;
		}
		
		/// <summary> setups the sync logic for member _recycleService</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncRecycleService(IEntity relatedEntity)
		{
			if(_recycleService!=relatedEntity)
			{		
				DesetupSyncRecycleService(true, true);
				_recycleService = (RecycleServiceEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _recycleService, new PropertyChangedEventHandler( OnRecycleServicePropertyChanged ), "RecycleService", RecycleServiceActionEntity.Relations.RecycleServiceEntityUsingRecycleServiceId, true, ref _alreadyFetchedRecycleService, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRecycleServicePropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _recycleType, new PropertyChangedEventHandler( OnRecycleTypePropertyChanged ), "RecycleType", RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, true, signalRelatedEntity, "RecycleServiceAction", resetFKFields, new int[] { (int)RecycleServiceActionFieldIndex.RecycleTypeId } );		
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
				base.PerformSetupSyncRelatedEntity( _recycleType, new PropertyChangedEventHandler( OnRecycleTypePropertyChanged ), "RecycleType", RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, true, ref _alreadyFetchedRecycleType, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _user</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", RecycleServiceActionEntity.Relations.UserEntityUsingActionUserId, true, signalRelatedEntity, "RecycleServiceAction", resetFKFields, new int[] { (int)RecycleServiceActionFieldIndex.ActionUserId } );		
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
				base.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", RecycleServiceActionEntity.Relations.UserEntityUsingActionUserId, true, ref _alreadyFetchedUser, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _user_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser_(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _user_, new PropertyChangedEventHandler( OnUser_PropertyChanged ), "User_", RecycleServiceActionEntity.Relations.UserEntityUsingLastChangedByUserId, true, signalRelatedEntity, "RecycleServiceAction_", resetFKFields, new int[] { (int)RecycleServiceActionFieldIndex.LastChangedByUserId } );		
			_user_ = null;
		}
		
		/// <summary> setups the sync logic for member _user_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUser_(IEntity relatedEntity)
		{
			if(_user_!=relatedEntity)
			{		
				DesetupSyncUser_(true, true);
				_user_ = (UserEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _user_, new PropertyChangedEventHandler( OnUser_PropertyChanged ), "User_", RecycleServiceActionEntity.Relations.UserEntityUsingLastChangedByUserId, true, ref _alreadyFetchedUser_, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUser_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 recycleServiceActionId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)RecycleServiceActionFieldIndex.RecycleServiceActionId].ForcedCurrentValueWrite(recycleServiceActionId);
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
			return DAOFactory.CreateRecycleServiceActionDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new RecycleServiceActionEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static RecycleServiceActionRelations Relations
		{
			get	{ return new RecycleServiceActionRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee_
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee_")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleService
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(),
					(IEntityRelation)GetRelationsForField("RecycleService")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, null, "RecycleService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("RecycleType")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, null, "RecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("User")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUser_
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(),
					(IEntityRelation)GetRelationsForField("User_")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, null, "User_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "RecycleServiceActionEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return RecycleServiceActionEntity.CustomProperties;}
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
			get { return RecycleServiceActionEntity.FieldsCustomProperties;}
		}

		/// <summary> The RecycleServiceActionId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."RecycleServiceActionId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 RecycleServiceActionId
		{
			get { return (System.Int32)GetValue((int)RecycleServiceActionFieldIndex.RecycleServiceActionId, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.RecycleServiceActionId, value, true); }
		}
		/// <summary> The ActionTime property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."ActionTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ActionTime
		{
			get { return (System.DateTime)GetValue((int)RecycleServiceActionFieldIndex.ActionTime, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.ActionTime, value, true); }
		}
		/// <summary> The NumberOfBales property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."NumberOfBales"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> NumberOfBales
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.NumberOfBales, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.NumberOfBales, value, true); }
		}
		/// <summary> The NumberOfBags property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."NumberOfBags"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> NumberOfBags
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.NumberOfBags, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.NumberOfBags, value, true); }
		}
		/// <summary> The BalesWeight property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."BalesWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> BalesWeight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RecycleServiceActionFieldIndex.BalesWeight, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.BalesWeight, value, true); }
		}
		/// <summary> The BagsWeight property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."BagsWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> BagsWeight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RecycleServiceActionFieldIndex.BagsWeight, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.BagsWeight, value, true); }
		}
		/// <summary> The RecycleServiceId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."RecycleServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RecycleServiceId
		{
			get { return (System.Int32)GetValue((int)RecycleServiceActionFieldIndex.RecycleServiceId, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.RecycleServiceId, value, true); }
		}
		/// <summary> The RecycleTypeId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."RecycleTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RecycleTypeId
		{
			get { return (System.Int32)GetValue((int)RecycleServiceActionFieldIndex.RecycleTypeId, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.RecycleTypeId, value, true); }
		}
		/// <summary> The ActionUserId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."ActionUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ActionUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.ActionUserId, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.ActionUserId, value, true); }
		}
		/// <summary> The LastChangedByUserId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."LastChangedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> LastChangedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.LastChangedByUserId, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.LastChangedByUserId, value, true); }
		}
		/// <summary> The LastChangedDate property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."LastChangedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime LastChangedDate
		{
			get { return (System.DateTime)GetValue((int)RecycleServiceActionFieldIndex.LastChangedDate, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.LastChangedDate, value, true); }
		}
		/// <summary> The ActionType property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."ActionType"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ActionType
		{
			get { return (System.String)GetValue((int)RecycleServiceActionFieldIndex.ActionType, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.ActionType, value, true); }
		}
		/// <summary> The ActionEmployeeId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."ActionEmployeeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ActionEmployeeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.ActionEmployeeId, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.ActionEmployeeId, value, true); }
		}
		/// <summary> The LastChangedByEmployeeId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."LastChangedByEmployeeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> LastChangedByEmployeeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.LastChangedByEmployeeId, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.LastChangedByEmployeeId, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee_
		{
			get	{ return GetSingleEmployee_(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee_(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee_ != null)
						{
							_employee_.UnsetRelatedEntity(this, "RecycleServiceAction");
						}
					}
					else
					{
						if(_employee_!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleServiceAction");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee_. When set to true, Employee_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee_
		{
			get	{ return _alwaysFetchEmployee_; }
			set	{ _alwaysFetchEmployee_ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee_ already has been fetched. Setting this property to false when Employee_ has been fetched
		/// will set Employee_ to null as well. Setting this property to true while Employee_ hasn't been fetched disables lazy loading for Employee_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee_
		{
			get { return _alreadyFetchedEmployee_;}
			set 
			{
				if(_alreadyFetchedEmployee_ && !value)
				{
					this.Employee_ = null;
				}
				_alreadyFetchedEmployee_ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee_ is not found
		/// in the database. When set to true, Employee_ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Employee_ReturnsNewIfNotFound
		{
			get	{ return _employee_ReturnsNewIfNotFound; }
			set { _employee_ReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get	{ return GetSingleEmployee(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee != null)
						{
							_employee.UnsetRelatedEntity(this, "RecycleServiceAction_");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleServiceAction_");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee
		{
			get	{ return _alwaysFetchEmployee; }
			set	{ _alwaysFetchEmployee = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee already has been fetched. Setting this property to false when Employee has been fetched
		/// will set Employee to null as well. Setting this property to true while Employee hasn't been fetched disables lazy loading for Employee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee
		{
			get { return _alreadyFetchedEmployee;}
			set 
			{
				if(_alreadyFetchedEmployee && !value)
				{
					this.Employee = null;
				}
				_alreadyFetchedEmployee = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee is not found
		/// in the database. When set to true, Employee will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool EmployeeReturnsNewIfNotFound
		{
			get	{ return _employeeReturnsNewIfNotFound; }
			set { _employeeReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'RecycleServiceEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleRecycleService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual RecycleServiceEntity RecycleService
		{
			get	{ return GetSingleRecycleService(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncRecycleService(value);
				}
				else
				{
					if(value==null)
					{
						if(_recycleService != null)
						{
							_recycleService.UnsetRelatedEntity(this, "RecycleServiceAction");
						}
					}
					else
					{
						if(_recycleService!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleServiceAction");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleService. When set to true, RecycleService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleService is accessed. You can always execute
		/// a forced fetch by calling GetSingleRecycleService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleService
		{
			get	{ return _alwaysFetchRecycleService; }
			set	{ _alwaysFetchRecycleService = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleService already has been fetched. Setting this property to false when RecycleService has been fetched
		/// will set RecycleService to null as well. Setting this property to true while RecycleService hasn't been fetched disables lazy loading for RecycleService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleService
		{
			get { return _alreadyFetchedRecycleService;}
			set 
			{
				if(_alreadyFetchedRecycleService && !value)
				{
					this.RecycleService = null;
				}
				_alreadyFetchedRecycleService = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property RecycleService is not found
		/// in the database. When set to true, RecycleService will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool RecycleServiceReturnsNewIfNotFound
		{
			get	{ return _recycleServiceReturnsNewIfNotFound; }
			set { _recycleServiceReturnsNewIfNotFound = value; }	
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
							_recycleType.UnsetRelatedEntity(this, "RecycleServiceAction");
						}
					}
					else
					{
						if(_recycleType!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleServiceAction");
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
							_user.UnsetRelatedEntity(this, "RecycleServiceAction");
						}
					}
					else
					{
						if(_user!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleServiceAction");
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
		/// <summary> Gets / sets related entity of type 'UserEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUser_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UserEntity User_
		{
			get	{ return GetSingleUser_(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUser_(value);
				}
				else
				{
					if(value==null)
					{
						if(_user_ != null)
						{
							_user_.UnsetRelatedEntity(this, "RecycleServiceAction_");
						}
					}
					else
					{
						if(_user_!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleServiceAction_");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for User_. When set to true, User_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time User_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleUser_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUser_
		{
			get	{ return _alwaysFetchUser_; }
			set	{ _alwaysFetchUser_ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property User_ already has been fetched. Setting this property to false when User_ has been fetched
		/// will set User_ to null as well. Setting this property to true while User_ hasn't been fetched disables lazy loading for User_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUser_
		{
			get { return _alreadyFetchedUser_;}
			set 
			{
				if(_alreadyFetchedUser_ && !value)
				{
					this.User_ = null;
				}
				_alreadyFetchedUser_ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property User_ is not found
		/// in the database. When set to true, User_ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool User_ReturnsNewIfNotFound
		{
			get	{ return _user_ReturnsNewIfNotFound; }
			set { _user_ReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity; }
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
