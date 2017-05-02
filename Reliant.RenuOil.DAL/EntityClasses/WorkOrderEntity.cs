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
	/// Entity class which represents the entity 'WorkOrder'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class WorkOrderEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection	_workOrderEmployee;
		private bool	_alwaysFetchWorkOrderEmployee, _alreadyFetchedWorkOrderEmployee;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection	_workOrderServiceLocation;
		private bool	_alwaysFetchWorkOrderServiceLocation, _alreadyFetchedWorkOrderServiceLocation;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaWorkOrderServiceLocation;
		private bool	_alwaysFetchServiceLocationCollectionViaWorkOrderServiceLocation, _alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaWorkOrderEmployee;
		private bool	_alwaysFetchServiceLocationCollectionViaWorkOrderEmployee, _alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee;
		private AccountEntity _account;
		private bool	_alwaysFetchAccount, _alreadyFetchedAccount, _accountReturnsNewIfNotFound;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee, _employeeReturnsNewIfNotFound;
		private ServiceTypeEntity _serviceType;
		private bool	_alwaysFetchServiceType, _alreadyFetchedServiceType, _serviceTypeReturnsNewIfNotFound;

		
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
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name ServiceType</summary>
			public static readonly string ServiceType = "ServiceType";
			/// <summary>Member name WorkOrderEmployee</summary>
			public static readonly string WorkOrderEmployee = "WorkOrderEmployee";
			/// <summary>Member name WorkOrderServiceLocation</summary>
			public static readonly string WorkOrderServiceLocation = "WorkOrderServiceLocation";
			/// <summary>Member name ServiceLocationCollectionViaWorkOrderServiceLocation</summary>
			public static readonly string ServiceLocationCollectionViaWorkOrderServiceLocation = "ServiceLocationCollectionViaWorkOrderServiceLocation";
			/// <summary>Member name ServiceLocationCollectionViaWorkOrderEmployee</summary>
			public static readonly string ServiceLocationCollectionViaWorkOrderEmployee = "ServiceLocationCollectionViaWorkOrderEmployee";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static WorkOrderEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public WorkOrderEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		public WorkOrderEntity(System.Int32 workOrderId)
		{
			InitClassFetch(workOrderId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public WorkOrderEntity(System.Int32 workOrderId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(workOrderId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="validator">The custom validator object for this WorkOrderEntity</param>
		public WorkOrderEntity(System.Int32 workOrderId, IValidator validator)
		{
			InitClassFetch(workOrderId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected WorkOrderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_workOrderEmployee = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection)info.GetValue("_workOrderEmployee", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection));
			_alwaysFetchWorkOrderEmployee = info.GetBoolean("_alwaysFetchWorkOrderEmployee");
			_alreadyFetchedWorkOrderEmployee = info.GetBoolean("_alreadyFetchedWorkOrderEmployee");
			_workOrderServiceLocation = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection)info.GetValue("_workOrderServiceLocation", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection));
			_alwaysFetchWorkOrderServiceLocation = info.GetBoolean("_alwaysFetchWorkOrderServiceLocation");
			_alreadyFetchedWorkOrderServiceLocation = info.GetBoolean("_alreadyFetchedWorkOrderServiceLocation");
			_serviceLocationCollectionViaWorkOrderServiceLocation = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaWorkOrderServiceLocation", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaWorkOrderServiceLocation = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaWorkOrderServiceLocation");
			_alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation");
			_serviceLocationCollectionViaWorkOrderEmployee = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaWorkOrderEmployee", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaWorkOrderEmployee = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaWorkOrderEmployee");
			_alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee");
			_account = (AccountEntity)info.GetValue("_account", typeof(AccountEntity));
			if(_account!=null)
			{
				_account.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_accountReturnsNewIfNotFound = info.GetBoolean("_accountReturnsNewIfNotFound");
			_alwaysFetchAccount = info.GetBoolean("_alwaysFetchAccount");
			_alreadyFetchedAccount = info.GetBoolean("_alreadyFetchedAccount");
			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeeReturnsNewIfNotFound = info.GetBoolean("_employeeReturnsNewIfNotFound");
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");
			_serviceType = (ServiceTypeEntity)info.GetValue("_serviceType", typeof(ServiceTypeEntity));
			if(_serviceType!=null)
			{
				_serviceType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_serviceTypeReturnsNewIfNotFound = info.GetBoolean("_serviceTypeReturnsNewIfNotFound");
			_alwaysFetchServiceType = info.GetBoolean("_alwaysFetchServiceType");
			_alreadyFetchedServiceType = info.GetBoolean("_alreadyFetchedServiceType");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((WorkOrderFieldIndex)fieldIndex)
			{
				case WorkOrderFieldIndex.AccountId:
					DesetupSyncAccount(true, false);
					_alreadyFetchedAccount = false;
					break;
				case WorkOrderFieldIndex.ServiceTypeId:
					DesetupSyncServiceType(true, false);
					_alreadyFetchedServiceType = false;
					break;
				case WorkOrderFieldIndex.TechnicianId:
					DesetupSyncEmployee(true, false);
					_alreadyFetchedEmployee = false;
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
			_alreadyFetchedWorkOrderEmployee = (_workOrderEmployee.Count > 0);
			_alreadyFetchedWorkOrderServiceLocation = (_workOrderServiceLocation.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation = (_serviceLocationCollectionViaWorkOrderServiceLocation.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee = (_serviceLocationCollectionViaWorkOrderEmployee.Count > 0);
			_alreadyFetchedAccount = (_account != null);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedServiceType = (_serviceType != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return WorkOrderEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(WorkOrderEntity.Relations.AccountEntityUsingAccountId);
					break;
				case "Employee":
					toReturn.Add(WorkOrderEntity.Relations.EmployeeEntityUsingTechnicianId);
					break;
				case "ServiceType":
					toReturn.Add(WorkOrderEntity.Relations.ServiceTypeEntityUsingServiceTypeId);
					break;
				case "WorkOrderEmployee":
					toReturn.Add(WorkOrderEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderId);
					break;
				case "WorkOrderServiceLocation":
					toReturn.Add(WorkOrderEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderId);
					break;
				case "ServiceLocationCollectionViaWorkOrderServiceLocation":
					toReturn.Add(WorkOrderEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderId, "WorkOrderEntity__", "WorkOrderServiceLocation_", JoinHint.None);
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "WorkOrderServiceLocation_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaWorkOrderEmployee":
					toReturn.Add(WorkOrderEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderId, "WorkOrderEntity__", "WorkOrderEmployee_", JoinHint.None);
					toReturn.Add(WorkOrderEmployeeEntity.Relations.ServiceLocationEntityUsingEmployeeId, "WorkOrderEmployee_", string.Empty, JoinHint.None);
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
			info.AddValue("_workOrderEmployee", (!this.MarkedForDeletion?_workOrderEmployee:null));
			info.AddValue("_alwaysFetchWorkOrderEmployee", _alwaysFetchWorkOrderEmployee);
			info.AddValue("_alreadyFetchedWorkOrderEmployee", _alreadyFetchedWorkOrderEmployee);
			info.AddValue("_workOrderServiceLocation", (!this.MarkedForDeletion?_workOrderServiceLocation:null));
			info.AddValue("_alwaysFetchWorkOrderServiceLocation", _alwaysFetchWorkOrderServiceLocation);
			info.AddValue("_alreadyFetchedWorkOrderServiceLocation", _alreadyFetchedWorkOrderServiceLocation);
			info.AddValue("_serviceLocationCollectionViaWorkOrderServiceLocation", (!this.MarkedForDeletion?_serviceLocationCollectionViaWorkOrderServiceLocation:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaWorkOrderServiceLocation", _alwaysFetchServiceLocationCollectionViaWorkOrderServiceLocation);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation", _alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation);
			info.AddValue("_serviceLocationCollectionViaWorkOrderEmployee", (!this.MarkedForDeletion?_serviceLocationCollectionViaWorkOrderEmployee:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaWorkOrderEmployee", _alwaysFetchServiceLocationCollectionViaWorkOrderEmployee);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee", _alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee);
			info.AddValue("_account", (!this.MarkedForDeletion?_account:null));
			info.AddValue("_accountReturnsNewIfNotFound", _accountReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAccount", _alwaysFetchAccount);
			info.AddValue("_alreadyFetchedAccount", _alreadyFetchedAccount);
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_employeeReturnsNewIfNotFound", _employeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_serviceType", (!this.MarkedForDeletion?_serviceType:null));
			info.AddValue("_serviceTypeReturnsNewIfNotFound", _serviceTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchServiceType", _alwaysFetchServiceType);
			info.AddValue("_alreadyFetchedServiceType", _alreadyFetchedServiceType);

			
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
				case "Employee":
					_alreadyFetchedEmployee = true;
					this.Employee = (EmployeeEntity)entity;
					break;
				case "ServiceType":
					_alreadyFetchedServiceType = true;
					this.ServiceType = (ServiceTypeEntity)entity;
					break;
				case "WorkOrderEmployee":
					_alreadyFetchedWorkOrderEmployee = true;
					if(entity!=null)
					{
						this.WorkOrderEmployee.Add((WorkOrderEmployeeEntity)entity);
					}
					break;
				case "WorkOrderServiceLocation":
					_alreadyFetchedWorkOrderServiceLocation = true;
					if(entity!=null)
					{
						this.WorkOrderServiceLocation.Add((WorkOrderServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaWorkOrderServiceLocation":
					_alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaWorkOrderServiceLocation.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaWorkOrderEmployee":
					_alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaWorkOrderEmployee.Add((ServiceLocationEntity)entity);
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
				case "Account":
					SetupSyncAccount(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "ServiceType":
					SetupSyncServiceType(relatedEntity);
					break;
				case "WorkOrderEmployee":
					_workOrderEmployee.Add((WorkOrderEmployeeEntity)relatedEntity);
					break;
				case "WorkOrderServiceLocation":
					_workOrderServiceLocation.Add((WorkOrderServiceLocationEntity)relatedEntity);
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
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "ServiceType":
					DesetupSyncServiceType(false, true);
					break;
				case "WorkOrderEmployee":
					base.PerformRelatedEntityRemoval(_workOrderEmployee, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrderServiceLocation":
					base.PerformRelatedEntityRemoval(_workOrderServiceLocation, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_serviceType!=null)
			{
				toReturn.Add(_serviceType);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_workOrderEmployee);
			toReturn.Add(_workOrderServiceLocation);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderId)
		{
			return FetchUsingPK(workOrderId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(workOrderId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(workOrderId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(workOrderId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.WorkOrderId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(WorkOrderFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(WorkOrderFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new WorkOrderRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployee(bool forceFetch)
		{
			return GetMultiWorkOrderEmployee(forceFetch, _workOrderEmployee.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployee(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiWorkOrderEmployee(forceFetch, _workOrderEmployee.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployee(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiWorkOrderEmployee(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployee(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrderEmployee || forceFetch || _alwaysFetchWorkOrderEmployee) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderEmployee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderEmployee);
					}
				}
				_workOrderEmployee.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderEmployee.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderEmployee.GetMultiManyToOne(null, this, filter);
				_workOrderEmployee.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderEmployee = true;
			}
			return _workOrderEmployee;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderEmployee'. These settings will be taken into account
		/// when the property WorkOrderEmployee is requested or GetMultiWorkOrderEmployee is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderEmployee(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderEmployee.SortClauses=sortClauses;
			_workOrderEmployee.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocation(bool forceFetch)
		{
			return GetMultiWorkOrderServiceLocation(forceFetch, _workOrderServiceLocation.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocation(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiWorkOrderServiceLocation(forceFetch, _workOrderServiceLocation.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiWorkOrderServiceLocation(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrderServiceLocation || forceFetch || _alwaysFetchWorkOrderServiceLocation) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderServiceLocation.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderServiceLocation);
					}
				}
				_workOrderServiceLocation.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderServiceLocation.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderServiceLocation.GetMultiManyToOne(null, this, filter);
				_workOrderServiceLocation.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderServiceLocation = true;
			}
			return _workOrderServiceLocation;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderServiceLocation'. These settings will be taken into account
		/// when the property WorkOrderServiceLocation is requested or GetMultiWorkOrderServiceLocation is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderServiceLocation(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderServiceLocation.SortClauses=sortClauses;
			_workOrderServiceLocation.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaWorkOrderServiceLocation(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaWorkOrderServiceLocation(forceFetch, _serviceLocationCollectionViaWorkOrderServiceLocation.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaWorkOrderServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation || forceFetch || _alwaysFetchServiceLocationCollectionViaWorkOrderServiceLocation) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaWorkOrderServiceLocation.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaWorkOrderServiceLocation);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(WorkOrderFields.WorkOrderId, ComparisonOperator.Equal, this.WorkOrderId, "WorkOrderEntity__"));
				_serviceLocationCollectionViaWorkOrderServiceLocation.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaWorkOrderServiceLocation.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaWorkOrderServiceLocation.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaWorkOrderServiceLocation"));
				_serviceLocationCollectionViaWorkOrderServiceLocation.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation = true;
			}
			return _serviceLocationCollectionViaWorkOrderServiceLocation;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaWorkOrderServiceLocation'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaWorkOrderServiceLocation is requested or GetMultiServiceLocationCollectionViaWorkOrderServiceLocation is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaWorkOrderServiceLocation(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaWorkOrderServiceLocation.SortClauses=sortClauses;
			_serviceLocationCollectionViaWorkOrderServiceLocation.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaWorkOrderEmployee(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaWorkOrderEmployee(forceFetch, _serviceLocationCollectionViaWorkOrderEmployee.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaWorkOrderEmployee(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee || forceFetch || _alwaysFetchServiceLocationCollectionViaWorkOrderEmployee) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaWorkOrderEmployee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaWorkOrderEmployee);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(WorkOrderFields.WorkOrderId, ComparisonOperator.Equal, this.WorkOrderId, "WorkOrderEntity__"));
				_serviceLocationCollectionViaWorkOrderEmployee.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaWorkOrderEmployee.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaWorkOrderEmployee.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaWorkOrderEmployee"));
				_serviceLocationCollectionViaWorkOrderEmployee.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee = true;
			}
			return _serviceLocationCollectionViaWorkOrderEmployee;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaWorkOrderEmployee'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaWorkOrderEmployee is requested or GetMultiServiceLocationCollectionViaWorkOrderEmployee is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaWorkOrderEmployee(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaWorkOrderEmployee.SortClauses=sortClauses;
			_serviceLocationCollectionViaWorkOrderEmployee.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(WorkOrderEntity.Relations.AccountEntityUsingAccountId);

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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(WorkOrderEntity.Relations.EmployeeEntityUsingTechnicianId);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.TechnicianId.GetValueOrDefault());
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

		/// <summary> Retrieves the related entity of type 'ServiceTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ServiceTypeEntity' which is related to this entity.</returns>
		public ServiceTypeEntity GetSingleServiceType()
		{
			return GetSingleServiceType(false);
		}

		/// <summary> Retrieves the related entity of type 'ServiceTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ServiceTypeEntity' which is related to this entity.</returns>
		public virtual ServiceTypeEntity GetSingleServiceType(bool forceFetch)
		{
			if( ( !_alreadyFetchedServiceType || forceFetch || _alwaysFetchServiceType) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(WorkOrderEntity.Relations.ServiceTypeEntityUsingServiceTypeId);

				ServiceTypeEntity newEntity = new ServiceTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ServiceTypeId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ServiceTypeEntity)base.ActiveContext.Get(newEntity);
					}
					this.ServiceType = newEntity;
				}
				else
				{
					if(_serviceTypeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_serviceType == null)))
						{
							this.ServiceType = newEntity;
						}
					}
					else
					{
						this.ServiceType = null;
					}
				}
				_alreadyFetchedServiceType = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _serviceType;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			WorkOrderDAO dao = (WorkOrderDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_workOrderEmployee.ActiveContext = base.ActiveContext;
			_workOrderServiceLocation.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaWorkOrderServiceLocation.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaWorkOrderEmployee.ActiveContext = base.ActiveContext;
			if(_account!=null)
			{
				_account.ActiveContext = base.ActiveContext;
			}
			if(_employee!=null)
			{
				_employee.ActiveContext = base.ActiveContext;
			}
			if(_serviceType!=null)
			{
				_serviceType.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			WorkOrderDAO dao = (WorkOrderDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			WorkOrderDAO dao = (WorkOrderDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.WorkOrderEntity);
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
			toReturn.Add("Employee", _employee);
			toReturn.Add("ServiceType", _serviceType);
			toReturn.Add("WorkOrderEmployee", _workOrderEmployee);
			toReturn.Add("WorkOrderServiceLocation", _workOrderServiceLocation);
			toReturn.Add("ServiceLocationCollectionViaWorkOrderServiceLocation", _serviceLocationCollectionViaWorkOrderServiceLocation);
			toReturn.Add("ServiceLocationCollectionViaWorkOrderEmployee", _serviceLocationCollectionViaWorkOrderEmployee);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="validator">The validator object for this WorkOrderEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 workOrderId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(workOrderId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_workOrderEmployee = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(new WorkOrderEmployeeEntityFactory());
			_workOrderEmployee.SetContainingEntityInfo(this, "WorkOrder");
			_alwaysFetchWorkOrderEmployee = false;
			_alreadyFetchedWorkOrderEmployee = false;
			_workOrderServiceLocation = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(new WorkOrderServiceLocationEntityFactory());
			_workOrderServiceLocation.SetContainingEntityInfo(this, "WorkOrder");
			_alwaysFetchWorkOrderServiceLocation = false;
			_alreadyFetchedWorkOrderServiceLocation = false;
			_serviceLocationCollectionViaWorkOrderServiceLocation = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaWorkOrderServiceLocation = false;
			_alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation = false;
			_serviceLocationCollectionViaWorkOrderEmployee = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaWorkOrderEmployee = false;
			_alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee = false;
			_account = null;
			_accountReturnsNewIfNotFound = true;
			_alwaysFetchAccount = false;
			_alreadyFetchedAccount = false;
			_employee = null;
			_employeeReturnsNewIfNotFound = true;
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_serviceType = null;
			_serviceTypeReturnsNewIfNotFound = true;
			_alwaysFetchServiceType = false;
			_alreadyFetchedServiceType = false;


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

			_fieldsCustomProperties.Add("WorkOrderId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AppointmentDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AppointmentTime", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Notes", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsComplete", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Signature", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("TechnicianId", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _account</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAccount(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", WorkOrderEntity.Relations.AccountEntityUsingAccountId, true, signalRelatedEntity, "WorkOrder", resetFKFields, new int[] { (int)WorkOrderFieldIndex.AccountId } );		
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
				base.PerformSetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", WorkOrderEntity.Relations.AccountEntityUsingAccountId, true, ref _alreadyFetchedAccount, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", WorkOrderEntity.Relations.EmployeeEntityUsingTechnicianId, true, signalRelatedEntity, "WorkOrder", resetFKFields, new int[] { (int)WorkOrderFieldIndex.TechnicianId } );		
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
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", WorkOrderEntity.Relations.EmployeeEntityUsingTechnicianId, true, ref _alreadyFetchedEmployee, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _serviceType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceType, new PropertyChangedEventHandler( OnServiceTypePropertyChanged ), "ServiceType", WorkOrderEntity.Relations.ServiceTypeEntityUsingServiceTypeId, true, signalRelatedEntity, "WorkOrder", resetFKFields, new int[] { (int)WorkOrderFieldIndex.ServiceTypeId } );		
			_serviceType = null;
		}
		
		/// <summary> setups the sync logic for member _serviceType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncServiceType(IEntity relatedEntity)
		{
			if(_serviceType!=relatedEntity)
			{		
				DesetupSyncServiceType(true, true);
				_serviceType = (ServiceTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceType, new PropertyChangedEventHandler( OnServiceTypePropertyChanged ), "ServiceType", WorkOrderEntity.Relations.ServiceTypeEntityUsingServiceTypeId, true, ref _alreadyFetchedServiceType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnServiceTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 workOrderId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)WorkOrderFieldIndex.WorkOrderId].ForcedCurrentValueWrite(workOrderId);
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
			return DAOFactory.CreateWorkOrderDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new WorkOrderEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static WorkOrderRelations Relations
		{
			get	{ return new WorkOrderRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderEmployee
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrderEmployee")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, null, "WorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderServiceLocation
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrderServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, null, "WorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaWorkOrderServiceLocation
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrderServiceLocation_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaWorkOrderServiceLocation"), "ServiceLocationCollectionViaWorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaWorkOrderEmployee
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrderEmployee_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaWorkOrderEmployee"), "ServiceLocationCollectionViaWorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccount
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(),
					(IEntityRelation)GetRelationsForField("Account")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, null, "Account", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceType
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection(),
					(IEntityRelation)GetRelationsForField("ServiceType")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, 0, null, null, null, "ServiceType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "WorkOrderEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return WorkOrderEntity.CustomProperties;}
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
			get { return WorkOrderEntity.FieldsCustomProperties;}
		}

		/// <summary> The WorkOrderId property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."WorkOrderId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 WorkOrderId
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.WorkOrderId, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.WorkOrderId, value, true); }
		}
		/// <summary> The AccountId property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.AccountId, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.AccountId, value, true); }
		}
		/// <summary> The AppointmentDate property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."AppointmentDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime AppointmentDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderFieldIndex.AppointmentDate, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.AppointmentDate, value, true); }
		}
		/// <summary> The AppointmentTime property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."AppointmentTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> AppointmentTime
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderFieldIndex.AppointmentTime, false); }
			set	{ SetValue((int)WorkOrderFieldIndex.AppointmentTime, value, true); }
		}
		/// <summary> The ServiceTypeId property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."ServiceTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceTypeId
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.ServiceTypeId, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.ServiceTypeId, value, true); }
		}
		/// <summary> The Notes property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)WorkOrderFieldIndex.Notes, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.Notes, value, true); }
		}
		/// <summary> The IsComplete property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."IsComplete"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsComplete
		{
			get { return (System.Boolean)GetValue((int)WorkOrderFieldIndex.IsComplete, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.IsComplete, value, true); }
		}
		/// <summary> The IsActive property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsActive
		{
			get { return (Nullable<System.Boolean>)GetValue((int)WorkOrderFieldIndex.IsActive, false); }
			set	{ SetValue((int)WorkOrderFieldIndex.IsActive, value, true); }
		}
		/// <summary> The Signature property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."Signature"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Signature
		{
			get { return (System.String)GetValue((int)WorkOrderFieldIndex.Signature, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.Signature, value, true); }
		}
		/// <summary> The TechnicianId property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."TechnicianId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TechnicianId
		{
			get { return (Nullable<System.Int32>)GetValue((int)WorkOrderFieldIndex.TechnicianId, false); }
			set	{ SetValue((int)WorkOrderFieldIndex.TechnicianId, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection WorkOrderEmployee
		{
			get	{ return GetMultiWorkOrderEmployee(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderEmployee. When set to true, WorkOrderEmployee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderEmployee is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderEmployee
		{
			get	{ return _alwaysFetchWorkOrderEmployee; }
			set	{ _alwaysFetchWorkOrderEmployee = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderEmployee already has been fetched. Setting this property to false when WorkOrderEmployee has been fetched
		/// will clear the WorkOrderEmployee collection well. Setting this property to true while WorkOrderEmployee hasn't been fetched disables lazy loading for WorkOrderEmployee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderEmployee
		{
			get { return _alreadyFetchedWorkOrderEmployee;}
			set 
			{
				if(_alreadyFetchedWorkOrderEmployee && !value && (_workOrderEmployee != null))
				{
					_workOrderEmployee.Clear();
				}
				_alreadyFetchedWorkOrderEmployee = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection WorkOrderServiceLocation
		{
			get	{ return GetMultiWorkOrderServiceLocation(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderServiceLocation. When set to true, WorkOrderServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderServiceLocation
		{
			get	{ return _alwaysFetchWorkOrderServiceLocation; }
			set	{ _alwaysFetchWorkOrderServiceLocation = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderServiceLocation already has been fetched. Setting this property to false when WorkOrderServiceLocation has been fetched
		/// will clear the WorkOrderServiceLocation collection well. Setting this property to true while WorkOrderServiceLocation hasn't been fetched disables lazy loading for WorkOrderServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderServiceLocation
		{
			get { return _alreadyFetchedWorkOrderServiceLocation;}
			set 
			{
				if(_alreadyFetchedWorkOrderServiceLocation && !value && (_workOrderServiceLocation != null))
				{
					_workOrderServiceLocation.Clear();
				}
				_alreadyFetchedWorkOrderServiceLocation = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaWorkOrderServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaWorkOrderServiceLocation
		{
			get { return GetMultiServiceLocationCollectionViaWorkOrderServiceLocation(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaWorkOrderServiceLocation. When set to true, ServiceLocationCollectionViaWorkOrderServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaWorkOrderServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaWorkOrderServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaWorkOrderServiceLocation
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaWorkOrderServiceLocation; }
			set	{ _alwaysFetchServiceLocationCollectionViaWorkOrderServiceLocation = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaWorkOrderServiceLocation already has been fetched. Setting this property to false when ServiceLocationCollectionViaWorkOrderServiceLocation has been fetched
		/// will clear the ServiceLocationCollectionViaWorkOrderServiceLocation collection well. Setting this property to true while ServiceLocationCollectionViaWorkOrderServiceLocation hasn't been fetched disables lazy loading for ServiceLocationCollectionViaWorkOrderServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation
		{
			get { return _alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation && !value && (_serviceLocationCollectionViaWorkOrderServiceLocation != null))
				{
					_serviceLocationCollectionViaWorkOrderServiceLocation.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaWorkOrderServiceLocation = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaWorkOrderEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaWorkOrderEmployee
		{
			get { return GetMultiServiceLocationCollectionViaWorkOrderEmployee(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaWorkOrderEmployee. When set to true, ServiceLocationCollectionViaWorkOrderEmployee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaWorkOrderEmployee is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaWorkOrderEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaWorkOrderEmployee
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaWorkOrderEmployee; }
			set	{ _alwaysFetchServiceLocationCollectionViaWorkOrderEmployee = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaWorkOrderEmployee already has been fetched. Setting this property to false when ServiceLocationCollectionViaWorkOrderEmployee has been fetched
		/// will clear the ServiceLocationCollectionViaWorkOrderEmployee collection well. Setting this property to true while ServiceLocationCollectionViaWorkOrderEmployee hasn't been fetched disables lazy loading for ServiceLocationCollectionViaWorkOrderEmployee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaWorkOrderEmployee
		{
			get { return _alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee && !value && (_serviceLocationCollectionViaWorkOrderEmployee != null))
				{
					_serviceLocationCollectionViaWorkOrderEmployee.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaWorkOrderEmployee = value;
			}
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
							_account.UnsetRelatedEntity(this, "WorkOrder");
						}
					}
					else
					{
						if(_account!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "WorkOrder");
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
							_employee.UnsetRelatedEntity(this, "WorkOrder");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "WorkOrder");
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
		/// <summary> Gets / sets related entity of type 'ServiceTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleServiceType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ServiceTypeEntity ServiceType
		{
			get	{ return GetSingleServiceType(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncServiceType(value);
				}
				else
				{
					if(value==null)
					{
						if(_serviceType != null)
						{
							_serviceType.UnsetRelatedEntity(this, "WorkOrder");
						}
					}
					else
					{
						if(_serviceType!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "WorkOrder");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceType. When set to true, ServiceType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceType is accessed. You can always execute
		/// a forced fetch by calling GetSingleServiceType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceType
		{
			get	{ return _alwaysFetchServiceType; }
			set	{ _alwaysFetchServiceType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceType already has been fetched. Setting this property to false when ServiceType has been fetched
		/// will set ServiceType to null as well. Setting this property to true while ServiceType hasn't been fetched disables lazy loading for ServiceType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceType
		{
			get { return _alreadyFetchedServiceType;}
			set 
			{
				if(_alreadyFetchedServiceType && !value)
				{
					this.ServiceType = null;
				}
				_alreadyFetchedServiceType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ServiceType is not found
		/// in the database. When set to true, ServiceType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ServiceTypeReturnsNewIfNotFound
		{
			get	{ return _serviceTypeReturnsNewIfNotFound; }
			set { _serviceTypeReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity; }
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
