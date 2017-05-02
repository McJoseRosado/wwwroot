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
	/// Entity class which represents the entity 'DeepFryerServiceChangeLog'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DeepFryerServiceChangeLogEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private DeepFryerServiceEntity _deepFryerService;
		private bool	_alwaysFetchDeepFryerService, _alreadyFetchedDeepFryerService, _deepFryerServiceReturnsNewIfNotFound;
		private EmployeeEntity _employee_;
		private bool	_alwaysFetchEmployee_, _alreadyFetchedEmployee_, _employee_ReturnsNewIfNotFound;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee, _employeeReturnsNewIfNotFound;
		private ServiceLocationEntity _serviceLocation;
		private bool	_alwaysFetchServiceLocation, _alreadyFetchedServiceLocation, _serviceLocationReturnsNewIfNotFound;
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
			/// <summary>Member name DeepFryerService</summary>
			public static readonly string DeepFryerService = "DeepFryerService";
			/// <summary>Member name Employee_</summary>
			public static readonly string Employee_ = "Employee_";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DeepFryerServiceChangeLogEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public DeepFryerServiceChangeLogEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		public DeepFryerServiceChangeLogEntity(System.Int32 deepFryerServiceChangeLogId)
		{
			InitClassFetch(deepFryerServiceChangeLogId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public DeepFryerServiceChangeLogEntity(System.Int32 deepFryerServiceChangeLogId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(deepFryerServiceChangeLogId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		/// <param name="validator">The custom validator object for this DeepFryerServiceChangeLogEntity</param>
		public DeepFryerServiceChangeLogEntity(System.Int32 deepFryerServiceChangeLogId, IValidator validator)
		{
			InitClassFetch(deepFryerServiceChangeLogId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DeepFryerServiceChangeLogEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_deepFryerService = (DeepFryerServiceEntity)info.GetValue("_deepFryerService", typeof(DeepFryerServiceEntity));
			if(_deepFryerService!=null)
			{
				_deepFryerService.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_deepFryerServiceReturnsNewIfNotFound = info.GetBoolean("_deepFryerServiceReturnsNewIfNotFound");
			_alwaysFetchDeepFryerService = info.GetBoolean("_alwaysFetchDeepFryerService");
			_alreadyFetchedDeepFryerService = info.GetBoolean("_alreadyFetchedDeepFryerService");
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
			_serviceLocation = (ServiceLocationEntity)info.GetValue("_serviceLocation", typeof(ServiceLocationEntity));
			if(_serviceLocation!=null)
			{
				_serviceLocation.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_serviceLocationReturnsNewIfNotFound = info.GetBoolean("_serviceLocationReturnsNewIfNotFound");
			_alwaysFetchServiceLocation = info.GetBoolean("_alwaysFetchServiceLocation");
			_alreadyFetchedServiceLocation = info.GetBoolean("_alreadyFetchedServiceLocation");
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
			switch((DeepFryerServiceChangeLogFieldIndex)fieldIndex)
			{
				case DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceId:
					DesetupSyncDeepFryerService(true, false);
					_alreadyFetchedDeepFryerService = false;
					break;
				case DeepFryerServiceChangeLogFieldIndex.RelocatedToServiceLocationId:
					DesetupSyncServiceLocation(true, false);
					_alreadyFetchedServiceLocation = false;
					break;
				case DeepFryerServiceChangeLogFieldIndex.ServicedBy:
					DesetupSyncEmployee_(true, false);
					_alreadyFetchedEmployee_ = false;
					break;
				case DeepFryerServiceChangeLogFieldIndex.EnteredByEmployeeId:
					DesetupSyncEmployee(true, false);
					_alreadyFetchedEmployee = false;
					break;
				case DeepFryerServiceChangeLogFieldIndex.EnteredByUserId:
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


			_alreadyFetchedDeepFryerService = (_deepFryerService != null);
			_alreadyFetchedEmployee_ = (_employee_ != null);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedServiceLocation = (_serviceLocation != null);
			_alreadyFetchedUser = (_user != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return DeepFryerServiceChangeLogEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "DeepFryerService":
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.DeepFryerServiceEntityUsingDeepFryerServiceId);
					break;
				case "Employee_":
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingServicedBy);
					break;
				case "Employee":
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId);
					break;
				case "ServiceLocation":
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId);
					break;
				case "User":
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId);
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


			info.AddValue("_deepFryerService", (!this.MarkedForDeletion?_deepFryerService:null));
			info.AddValue("_deepFryerServiceReturnsNewIfNotFound", _deepFryerServiceReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchDeepFryerService", _alwaysFetchDeepFryerService);
			info.AddValue("_alreadyFetchedDeepFryerService", _alreadyFetchedDeepFryerService);
			info.AddValue("_employee_", (!this.MarkedForDeletion?_employee_:null));
			info.AddValue("_employee_ReturnsNewIfNotFound", _employee_ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee_", _alwaysFetchEmployee_);
			info.AddValue("_alreadyFetchedEmployee_", _alreadyFetchedEmployee_);
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_employeeReturnsNewIfNotFound", _employeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_serviceLocation", (!this.MarkedForDeletion?_serviceLocation:null));
			info.AddValue("_serviceLocationReturnsNewIfNotFound", _serviceLocationReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchServiceLocation", _alwaysFetchServiceLocation);
			info.AddValue("_alreadyFetchedServiceLocation", _alreadyFetchedServiceLocation);
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
				case "DeepFryerService":
					_alreadyFetchedDeepFryerService = true;
					this.DeepFryerService = (DeepFryerServiceEntity)entity;
					break;
				case "Employee_":
					_alreadyFetchedEmployee_ = true;
					this.Employee_ = (EmployeeEntity)entity;
					break;
				case "Employee":
					_alreadyFetchedEmployee = true;
					this.Employee = (EmployeeEntity)entity;
					break;
				case "ServiceLocation":
					_alreadyFetchedServiceLocation = true;
					this.ServiceLocation = (ServiceLocationEntity)entity;
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
				case "DeepFryerService":
					SetupSyncDeepFryerService(relatedEntity);
					break;
				case "Employee_":
					SetupSyncEmployee_(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "ServiceLocation":
					SetupSyncServiceLocation(relatedEntity);
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
				case "DeepFryerService":
					DesetupSyncDeepFryerService(false, true);
					break;
				case "Employee_":
					DesetupSyncEmployee_(false, true);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "ServiceLocation":
					DesetupSyncServiceLocation(false, true);
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
			if(_deepFryerService!=null)
			{
				toReturn.Add(_deepFryerService);
			}
			if(_employee_!=null)
			{
				toReturn.Add(_employee_);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_serviceLocation!=null)
			{
				toReturn.Add(_serviceLocation);
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
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerServiceChangeLogId)
		{
			return FetchUsingPK(deepFryerServiceChangeLogId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerServiceChangeLogId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(deepFryerServiceChangeLogId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerServiceChangeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(deepFryerServiceChangeLogId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerServiceChangeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(deepFryerServiceChangeLogId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DeepFryerServiceChangeLogId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DeepFryerServiceChangeLogFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DeepFryerServiceChangeLogFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DeepFryerServiceChangeLogRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'DeepFryerServiceEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'DeepFryerServiceEntity' which is related to this entity.</returns>
		public DeepFryerServiceEntity GetSingleDeepFryerService()
		{
			return GetSingleDeepFryerService(false);
		}

		/// <summary> Retrieves the related entity of type 'DeepFryerServiceEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'DeepFryerServiceEntity' which is related to this entity.</returns>
		public virtual DeepFryerServiceEntity GetSingleDeepFryerService(bool forceFetch)
		{
			if( ( !_alreadyFetchedDeepFryerService || forceFetch || _alwaysFetchDeepFryerService) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerServiceChangeLogEntity.Relations.DeepFryerServiceEntityUsingDeepFryerServiceId);

				DeepFryerServiceEntity newEntity = new DeepFryerServiceEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.DeepFryerServiceId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (DeepFryerServiceEntity)base.ActiveContext.Get(newEntity);
					}
					this.DeepFryerService = newEntity;
				}
				else
				{
					if(_deepFryerServiceReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_deepFryerService == null)))
						{
							this.DeepFryerService = newEntity;
						}
					}
					else
					{
						this.DeepFryerService = null;
					}
				}
				_alreadyFetchedDeepFryerService = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _deepFryerService;
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingServicedBy);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ServicedBy.GetValueOrDefault());
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.EnteredByEmployeeId.GetValueOrDefault());
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

		/// <summary> Retrieves the related entity of type 'ServiceLocationEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ServiceLocationEntity' which is related to this entity.</returns>
		public ServiceLocationEntity GetSingleServiceLocation()
		{
			return GetSingleServiceLocation(false);
		}

		/// <summary> Retrieves the related entity of type 'ServiceLocationEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ServiceLocationEntity' which is related to this entity.</returns>
		public virtual ServiceLocationEntity GetSingleServiceLocation(bool forceFetch)
		{
			if( ( !_alreadyFetchedServiceLocation || forceFetch || _alwaysFetchServiceLocation) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerServiceChangeLogEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId);

				ServiceLocationEntity newEntity = new ServiceLocationEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.RelocatedToServiceLocationId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ServiceLocationEntity)base.ActiveContext.Get(newEntity);
					}
					this.ServiceLocation = newEntity;
				}
				else
				{
					if(_serviceLocationReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_serviceLocation == null)))
						{
							this.ServiceLocation = newEntity;
						}
					}
					else
					{
						this.ServiceLocation = null;
					}
				}
				_alreadyFetchedServiceLocation = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _serviceLocation;
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId);

				UserEntity newEntity = new UserEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.EnteredByUserId.GetValueOrDefault());
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
			DeepFryerServiceChangeLogDAO dao = (DeepFryerServiceChangeLogDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_deepFryerService!=null)
			{
				_deepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_employee_!=null)
			{
				_employee_.ActiveContext = base.ActiveContext;
			}
			if(_employee!=null)
			{
				_employee.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
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
			DeepFryerServiceChangeLogDAO dao = (DeepFryerServiceChangeLogDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			DeepFryerServiceChangeLogDAO dao = (DeepFryerServiceChangeLogDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity);
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
			toReturn.Add("DeepFryerService", _deepFryerService);
			toReturn.Add("Employee_", _employee_);
			toReturn.Add("Employee", _employee);
			toReturn.Add("ServiceLocation", _serviceLocation);
			toReturn.Add("User", _user);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		/// <param name="validator">The validator object for this DeepFryerServiceChangeLogEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 deepFryerServiceChangeLogId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(deepFryerServiceChangeLogId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_deepFryerService = null;
			_deepFryerServiceReturnsNewIfNotFound = true;
			_alwaysFetchDeepFryerService = false;
			_alreadyFetchedDeepFryerService = false;
			_employee_ = null;
			_employee_ReturnsNewIfNotFound = true;
			_alwaysFetchEmployee_ = false;
			_alreadyFetchedEmployee_ = false;
			_employee = null;
			_employeeReturnsNewIfNotFound = true;
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_serviceLocation = null;
			_serviceLocationReturnsNewIfNotFound = true;
			_alwaysFetchServiceLocation = false;
			_alreadyFetchedServiceLocation = false;
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

			_fieldsCustomProperties.Add("DeepFryerServiceChangeLogId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DeepFryerServiceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ChangeDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Filtered", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Discarded", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Relocated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Cleaned", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RelocatedToFryerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RelocatedToServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RelocatedToOther", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AssignedTo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServicedBy", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EnteredByEmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EnteredByUserId", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _deepFryerService</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDeepFryerService(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _deepFryerService, new PropertyChangedEventHandler( OnDeepFryerServicePropertyChanged ), "DeepFryerService", DeepFryerServiceChangeLogEntity.Relations.DeepFryerServiceEntityUsingDeepFryerServiceId, true, signalRelatedEntity, "DeepFryerServiceChangeLog", resetFKFields, new int[] { (int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceId } );		
			_deepFryerService = null;
		}
		
		/// <summary> setups the sync logic for member _deepFryerService</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDeepFryerService(IEntity relatedEntity)
		{
			if(_deepFryerService!=relatedEntity)
			{		
				DesetupSyncDeepFryerService(true, true);
				_deepFryerService = (DeepFryerServiceEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _deepFryerService, new PropertyChangedEventHandler( OnDeepFryerServicePropertyChanged ), "DeepFryerService", DeepFryerServiceChangeLogEntity.Relations.DeepFryerServiceEntityUsingDeepFryerServiceId, true, ref _alreadyFetchedDeepFryerService, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDeepFryerServicePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee_(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee_, new PropertyChangedEventHandler( OnEmployee_PropertyChanged ), "Employee_", DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingServicedBy, true, signalRelatedEntity, "DeepFryerServiceChangeLog_", resetFKFields, new int[] { (int)DeepFryerServiceChangeLogFieldIndex.ServicedBy } );		
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
				base.PerformSetupSyncRelatedEntity( _employee_, new PropertyChangedEventHandler( OnEmployee_PropertyChanged ), "Employee_", DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingServicedBy, true, ref _alreadyFetchedEmployee_, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, true, signalRelatedEntity, "DeepFryerServiceChangeLog", resetFKFields, new int[] { (int)DeepFryerServiceChangeLogFieldIndex.EnteredByEmployeeId } );		
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
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, true, ref _alreadyFetchedEmployee, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _serviceLocation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerServiceChangeLogEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, true, signalRelatedEntity, "DeepFryerServiceChangeLog", resetFKFields, new int[] { (int)DeepFryerServiceChangeLogFieldIndex.RelocatedToServiceLocationId } );		
			_serviceLocation = null;
		}
		
		/// <summary> setups the sync logic for member _serviceLocation</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncServiceLocation(IEntity relatedEntity)
		{
			if(_serviceLocation!=relatedEntity)
			{		
				DesetupSyncServiceLocation(true, true);
				_serviceLocation = (ServiceLocationEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerServiceChangeLogEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, true, ref _alreadyFetchedServiceLocation, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnServiceLocationPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", DeepFryerServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, true, signalRelatedEntity, "DeepFryerServiceChangeLog", resetFKFields, new int[] { (int)DeepFryerServiceChangeLogFieldIndex.EnteredByUserId } );		
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
				base.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", DeepFryerServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, true, ref _alreadyFetchedUser, new string[] {  } );
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
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 deepFryerServiceChangeLogId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceChangeLogId].ForcedCurrentValueWrite(deepFryerServiceChangeLogId);
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
			return DAOFactory.CreateDeepFryerServiceChangeLogDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new DeepFryerServiceChangeLogEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static DeepFryerServiceChangeLogRelations Relations
		{
			get	{ return new DeepFryerServiceChangeLogRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerService
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(),
					(IEntityRelation)GetRelationsForField("DeepFryerService")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, null, "DeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee_
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee_")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocation
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("User")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "DeepFryerServiceChangeLogEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DeepFryerServiceChangeLogEntity.CustomProperties;}
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
			get { return DeepFryerServiceChangeLogEntity.FieldsCustomProperties;}
		}

		/// <summary> The DeepFryerServiceChangeLogId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."DeepFryerServiceChangeLogId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DeepFryerServiceChangeLogId
		{
			get { return (System.Int32)GetValue((int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceChangeLogId, true); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceChangeLogId, value, true); }
		}
		/// <summary> The DeepFryerServiceId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."DeepFryerServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DeepFryerServiceId
		{
			get { return (System.Int32)GetValue((int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceId, true); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceId, value, true); }
		}
		/// <summary> The ChangeDate property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."ChangeDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ChangeDate
		{
			get { return (System.DateTime)GetValue((int)DeepFryerServiceChangeLogFieldIndex.ChangeDate, true); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.ChangeDate, value, true); }
		}
		/// <summary> The Filtered property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."Filtered"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Filtered
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.Filtered, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.Filtered, value, true); }
		}
		/// <summary> The Discarded property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."Discarded"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Discarded
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.Discarded, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.Discarded, value, true); }
		}
		/// <summary> The Relocated property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."Relocated"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Relocated
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.Relocated, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.Relocated, value, true); }
		}
		/// <summary> The Cleaned property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."Cleaned"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Cleaned
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.Cleaned, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.Cleaned, value, true); }
		}
		/// <summary> The RelocatedToFryerId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."RelocatedToFryerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> RelocatedToFryerId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToFryerId, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToFryerId, value, true); }
		}
		/// <summary> The RelocatedToServiceLocationId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."RelocatedToServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> RelocatedToServiceLocationId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToServiceLocationId, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToServiceLocationId, value, true); }
		}
		/// <summary> The RelocatedToOther property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."RelocatedToOther"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RelocatedToOther
		{
			get { return (System.String)GetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToOther, true); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToOther, value, true); }
		}
		/// <summary> The AssignedTo property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."AssignedTo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> AssignedTo
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.AssignedTo, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.AssignedTo, value, true); }
		}
		/// <summary> The ServicedBy property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."ServicedBy"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ServicedBy
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.ServicedBy, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.ServicedBy, value, true); }
		}
		/// <summary> The EnteredByEmployeeId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."EnteredByEmployeeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> EnteredByEmployeeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.EnteredByEmployeeId, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.EnteredByEmployeeId, value, true); }
		}
		/// <summary> The EnteredByUserId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."EnteredByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> EnteredByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.EnteredByUserId, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.EnteredByUserId, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'DeepFryerServiceEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleDeepFryerService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual DeepFryerServiceEntity DeepFryerService
		{
			get	{ return GetSingleDeepFryerService(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncDeepFryerService(value);
				}
				else
				{
					if(value==null)
					{
						if(_deepFryerService != null)
						{
							_deepFryerService.UnsetRelatedEntity(this, "DeepFryerServiceChangeLog");
						}
					}
					else
					{
						if(_deepFryerService!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerServiceChangeLog");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerService. When set to true, DeepFryerService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerService is accessed. You can always execute
		/// a forced fetch by calling GetSingleDeepFryerService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerService
		{
			get	{ return _alwaysFetchDeepFryerService; }
			set	{ _alwaysFetchDeepFryerService = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerService already has been fetched. Setting this property to false when DeepFryerService has been fetched
		/// will set DeepFryerService to null as well. Setting this property to true while DeepFryerService hasn't been fetched disables lazy loading for DeepFryerService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerService
		{
			get { return _alreadyFetchedDeepFryerService;}
			set 
			{
				if(_alreadyFetchedDeepFryerService && !value)
				{
					this.DeepFryerService = null;
				}
				_alreadyFetchedDeepFryerService = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property DeepFryerService is not found
		/// in the database. When set to true, DeepFryerService will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool DeepFryerServiceReturnsNewIfNotFound
		{
			get	{ return _deepFryerServiceReturnsNewIfNotFound; }
			set { _deepFryerServiceReturnsNewIfNotFound = value; }	
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
							_employee_.UnsetRelatedEntity(this, "DeepFryerServiceChangeLog_");
						}
					}
					else
					{
						if(_employee_!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerServiceChangeLog_");
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
							_employee.UnsetRelatedEntity(this, "DeepFryerServiceChangeLog");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerServiceChangeLog");
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
		/// <summary> Gets / sets related entity of type 'ServiceLocationEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ServiceLocationEntity ServiceLocation
		{
			get	{ return GetSingleServiceLocation(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncServiceLocation(value);
				}
				else
				{
					if(value==null)
					{
						if(_serviceLocation != null)
						{
							_serviceLocation.UnsetRelatedEntity(this, "DeepFryerServiceChangeLog");
						}
					}
					else
					{
						if(_serviceLocation!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerServiceChangeLog");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocation. When set to true, ServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetSingleServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocation
		{
			get	{ return _alwaysFetchServiceLocation; }
			set	{ _alwaysFetchServiceLocation = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocation already has been fetched. Setting this property to false when ServiceLocation has been fetched
		/// will set ServiceLocation to null as well. Setting this property to true while ServiceLocation hasn't been fetched disables lazy loading for ServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocation
		{
			get { return _alreadyFetchedServiceLocation;}
			set 
			{
				if(_alreadyFetchedServiceLocation && !value)
				{
					this.ServiceLocation = null;
				}
				_alreadyFetchedServiceLocation = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ServiceLocation is not found
		/// in the database. When set to true, ServiceLocation will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ServiceLocationReturnsNewIfNotFound
		{
			get	{ return _serviceLocationReturnsNewIfNotFound; }
			set { _serviceLocationReturnsNewIfNotFound = value; }	
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
							_user.UnsetRelatedEntity(this, "DeepFryerServiceChangeLog");
						}
					}
					else
					{
						if(_user!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerServiceChangeLog");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity; }
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
