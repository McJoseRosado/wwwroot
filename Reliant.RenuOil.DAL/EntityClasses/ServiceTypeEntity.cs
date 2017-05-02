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
	/// Entity class which represents the entity 'ServiceType'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ServiceTypeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection	_serviceLocation;
		private bool	_alwaysFetchServiceLocation, _alreadyFetchedServiceLocation;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection	_workOrder;
		private bool	_alwaysFetchWorkOrder, _alreadyFetchedWorkOrder;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaWorkOrder;
		private bool	_alwaysFetchAccountCollectionViaWorkOrder, _alreadyFetchedAccountCollectionViaWorkOrder;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaServiceLocation;
		private bool	_alwaysFetchAccountCollectionViaServiceLocation, _alreadyFetchedAccountCollectionViaServiceLocation;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaWorkOrder;
		private bool	_alwaysFetchEmployeeCollectionViaWorkOrder, _alreadyFetchedEmployeeCollectionViaWorkOrder;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name WorkOrder</summary>
			public static readonly string WorkOrder = "WorkOrder";
			/// <summary>Member name AccountCollectionViaWorkOrder</summary>
			public static readonly string AccountCollectionViaWorkOrder = "AccountCollectionViaWorkOrder";
			/// <summary>Member name AccountCollectionViaServiceLocation</summary>
			public static readonly string AccountCollectionViaServiceLocation = "AccountCollectionViaServiceLocation";
			/// <summary>Member name EmployeeCollectionViaWorkOrder</summary>
			public static readonly string EmployeeCollectionViaWorkOrder = "EmployeeCollectionViaWorkOrder";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ServiceTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ServiceTypeEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		public ServiceTypeEntity(System.Int32 serviceTypeId)
		{
			InitClassFetch(serviceTypeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ServiceTypeEntity(System.Int32 serviceTypeId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(serviceTypeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		/// <param name="validator">The custom validator object for this ServiceTypeEntity</param>
		public ServiceTypeEntity(System.Int32 serviceTypeId, IValidator validator)
		{
			InitClassFetch(serviceTypeId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ServiceTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_serviceLocation = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocation", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocation = info.GetBoolean("_alwaysFetchServiceLocation");
			_alreadyFetchedServiceLocation = info.GetBoolean("_alreadyFetchedServiceLocation");
			_workOrder = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection)info.GetValue("_workOrder", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection));
			_alwaysFetchWorkOrder = info.GetBoolean("_alwaysFetchWorkOrder");
			_alreadyFetchedWorkOrder = info.GetBoolean("_alreadyFetchedWorkOrder");
			_accountCollectionViaWorkOrder = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaWorkOrder", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaWorkOrder = info.GetBoolean("_alwaysFetchAccountCollectionViaWorkOrder");
			_alreadyFetchedAccountCollectionViaWorkOrder = info.GetBoolean("_alreadyFetchedAccountCollectionViaWorkOrder");
			_accountCollectionViaServiceLocation = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaServiceLocation", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaServiceLocation = info.GetBoolean("_alwaysFetchAccountCollectionViaServiceLocation");
			_alreadyFetchedAccountCollectionViaServiceLocation = info.GetBoolean("_alreadyFetchedAccountCollectionViaServiceLocation");
			_employeeCollectionViaWorkOrder = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaWorkOrder", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaWorkOrder = info.GetBoolean("_alwaysFetchEmployeeCollectionViaWorkOrder");
			_alreadyFetchedEmployeeCollectionViaWorkOrder = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaWorkOrder");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ServiceTypeFieldIndex)fieldIndex)
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
			_alreadyFetchedServiceLocation = (_serviceLocation.Count > 0);
			_alreadyFetchedWorkOrder = (_workOrder.Count > 0);
			_alreadyFetchedAccountCollectionViaWorkOrder = (_accountCollectionViaWorkOrder.Count > 0);
			_alreadyFetchedAccountCollectionViaServiceLocation = (_accountCollectionViaServiceLocation.Count > 0);
			_alreadyFetchedEmployeeCollectionViaWorkOrder = (_employeeCollectionViaWorkOrder.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ServiceTypeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "ServiceLocation":
					toReturn.Add(ServiceTypeEntity.Relations.ServiceLocationEntityUsingServiceTypeId);
					break;
				case "WorkOrder":
					toReturn.Add(ServiceTypeEntity.Relations.WorkOrderEntityUsingServiceTypeId);
					break;
				case "AccountCollectionViaWorkOrder":
					toReturn.Add(ServiceTypeEntity.Relations.WorkOrderEntityUsingServiceTypeId, "ServiceTypeEntity__", "WorkOrder_", JoinHint.None);
					toReturn.Add(WorkOrderEntity.Relations.AccountEntityUsingAccountId, "WorkOrder_", string.Empty, JoinHint.None);
					break;
				case "AccountCollectionViaServiceLocation":
					toReturn.Add(ServiceTypeEntity.Relations.ServiceLocationEntityUsingServiceTypeId, "ServiceTypeEntity__", "ServiceLocation_", JoinHint.None);
					toReturn.Add(ServiceLocationEntity.Relations.AccountEntityUsingAccountId, "ServiceLocation_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaWorkOrder":
					toReturn.Add(ServiceTypeEntity.Relations.WorkOrderEntityUsingServiceTypeId, "ServiceTypeEntity__", "WorkOrder_", JoinHint.None);
					toReturn.Add(WorkOrderEntity.Relations.EmployeeEntityUsingTechnicianId, "WorkOrder_", string.Empty, JoinHint.None);
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
			info.AddValue("_serviceLocation", (!this.MarkedForDeletion?_serviceLocation:null));
			info.AddValue("_alwaysFetchServiceLocation", _alwaysFetchServiceLocation);
			info.AddValue("_alreadyFetchedServiceLocation", _alreadyFetchedServiceLocation);
			info.AddValue("_workOrder", (!this.MarkedForDeletion?_workOrder:null));
			info.AddValue("_alwaysFetchWorkOrder", _alwaysFetchWorkOrder);
			info.AddValue("_alreadyFetchedWorkOrder", _alreadyFetchedWorkOrder);
			info.AddValue("_accountCollectionViaWorkOrder", (!this.MarkedForDeletion?_accountCollectionViaWorkOrder:null));
			info.AddValue("_alwaysFetchAccountCollectionViaWorkOrder", _alwaysFetchAccountCollectionViaWorkOrder);
			info.AddValue("_alreadyFetchedAccountCollectionViaWorkOrder", _alreadyFetchedAccountCollectionViaWorkOrder);
			info.AddValue("_accountCollectionViaServiceLocation", (!this.MarkedForDeletion?_accountCollectionViaServiceLocation:null));
			info.AddValue("_alwaysFetchAccountCollectionViaServiceLocation", _alwaysFetchAccountCollectionViaServiceLocation);
			info.AddValue("_alreadyFetchedAccountCollectionViaServiceLocation", _alreadyFetchedAccountCollectionViaServiceLocation);
			info.AddValue("_employeeCollectionViaWorkOrder", (!this.MarkedForDeletion?_employeeCollectionViaWorkOrder:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaWorkOrder", _alwaysFetchEmployeeCollectionViaWorkOrder);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaWorkOrder", _alreadyFetchedEmployeeCollectionViaWorkOrder);


			
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

				case "ServiceLocation":
					_alreadyFetchedServiceLocation = true;
					if(entity!=null)
					{
						this.ServiceLocation.Add((ServiceLocationEntity)entity);
					}
					break;
				case "WorkOrder":
					_alreadyFetchedWorkOrder = true;
					if(entity!=null)
					{
						this.WorkOrder.Add((WorkOrderEntity)entity);
					}
					break;
				case "AccountCollectionViaWorkOrder":
					_alreadyFetchedAccountCollectionViaWorkOrder = true;
					if(entity!=null)
					{
						this.AccountCollectionViaWorkOrder.Add((AccountEntity)entity);
					}
					break;
				case "AccountCollectionViaServiceLocation":
					_alreadyFetchedAccountCollectionViaServiceLocation = true;
					if(entity!=null)
					{
						this.AccountCollectionViaServiceLocation.Add((AccountEntity)entity);
					}
					break;
				case "EmployeeCollectionViaWorkOrder":
					_alreadyFetchedEmployeeCollectionViaWorkOrder = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaWorkOrder.Add((EmployeeEntity)entity);
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

				case "ServiceLocation":
					_serviceLocation.Add((ServiceLocationEntity)relatedEntity);
					break;
				case "WorkOrder":
					_workOrder.Add((WorkOrderEntity)relatedEntity);
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

				case "ServiceLocation":
					base.PerformRelatedEntityRemoval(_serviceLocation, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrder":
					base.PerformRelatedEntityRemoval(_workOrder, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_serviceLocation);
			toReturn.Add(_workOrder);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceTypeId)
		{
			return FetchUsingPK(serviceTypeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceTypeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(serviceTypeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(serviceTypeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(serviceTypeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ServiceTypeId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ServiceTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ServiceTypeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ServiceTypeRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocation(bool forceFetch)
		{
			return GetMultiServiceLocation(forceFetch, _serviceLocation.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocation(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocation(forceFetch, _serviceLocation.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocation(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocation || forceFetch || _alwaysFetchServiceLocation) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocation.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocation);
					}
				}
				_serviceLocation.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocation.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocation.GetMultiManyToOne(null, this, filter);
				_serviceLocation.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocation = true;
			}
			return _serviceLocation;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocation'. These settings will be taken into account
		/// when the property ServiceLocation is requested or GetMultiServiceLocation is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocation(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocation.SortClauses=sortClauses;
			_serviceLocation.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch)
		{
			return GetMultiWorkOrder(forceFetch, _workOrder.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiWorkOrder(forceFetch, _workOrder.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiWorkOrder(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrder);
					}
				}
				_workOrder.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrder.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrder.GetMultiManyToOne(null, null, this, filter);
				_workOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrder = true;
			}
			return _workOrder;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrder'. These settings will be taken into account
		/// when the property WorkOrder is requested or GetMultiWorkOrder is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrder(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrder.SortClauses=sortClauses;
			_workOrder.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaWorkOrder(bool forceFetch)
		{
			return GetMultiAccountCollectionViaWorkOrder(forceFetch, _accountCollectionViaWorkOrder.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaWorkOrder || forceFetch || _alwaysFetchAccountCollectionViaWorkOrder) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaWorkOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaWorkOrder);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceTypeFields.ServiceTypeId, ComparisonOperator.Equal, this.ServiceTypeId, "ServiceTypeEntity__"));
				_accountCollectionViaWorkOrder.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaWorkOrder.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaWorkOrder.GetMulti(filter, GetRelationsForField("AccountCollectionViaWorkOrder"));
				_accountCollectionViaWorkOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaWorkOrder = true;
			}
			return _accountCollectionViaWorkOrder;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaWorkOrder'. These settings will be taken into account
		/// when the property AccountCollectionViaWorkOrder is requested or GetMultiAccountCollectionViaWorkOrder is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaWorkOrder(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaWorkOrder.SortClauses=sortClauses;
			_accountCollectionViaWorkOrder.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaServiceLocation(bool forceFetch)
		{
			return GetMultiAccountCollectionViaServiceLocation(forceFetch, _accountCollectionViaServiceLocation.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaServiceLocation || forceFetch || _alwaysFetchAccountCollectionViaServiceLocation) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaServiceLocation.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaServiceLocation);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceTypeFields.ServiceTypeId, ComparisonOperator.Equal, this.ServiceTypeId, "ServiceTypeEntity__"));
				_accountCollectionViaServiceLocation.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaServiceLocation.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaServiceLocation.GetMulti(filter, GetRelationsForField("AccountCollectionViaServiceLocation"));
				_accountCollectionViaServiceLocation.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaServiceLocation = true;
			}
			return _accountCollectionViaServiceLocation;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaServiceLocation'. These settings will be taken into account
		/// when the property AccountCollectionViaServiceLocation is requested or GetMultiAccountCollectionViaServiceLocation is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaServiceLocation(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaServiceLocation.SortClauses=sortClauses;
			_accountCollectionViaServiceLocation.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaWorkOrder(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaWorkOrder(forceFetch, _employeeCollectionViaWorkOrder.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaWorkOrder || forceFetch || _alwaysFetchEmployeeCollectionViaWorkOrder) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaWorkOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaWorkOrder);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceTypeFields.ServiceTypeId, ComparisonOperator.Equal, this.ServiceTypeId, "ServiceTypeEntity__"));
				_employeeCollectionViaWorkOrder.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaWorkOrder.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaWorkOrder.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaWorkOrder"));
				_employeeCollectionViaWorkOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaWorkOrder = true;
			}
			return _employeeCollectionViaWorkOrder;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaWorkOrder'. These settings will be taken into account
		/// when the property EmployeeCollectionViaWorkOrder is requested or GetMultiEmployeeCollectionViaWorkOrder is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaWorkOrder(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaWorkOrder.SortClauses=sortClauses;
			_employeeCollectionViaWorkOrder.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ServiceTypeDAO dao = (ServiceTypeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_serviceLocation.ActiveContext = base.ActiveContext;
			_workOrder.ActiveContext = base.ActiveContext;
			_accountCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			_accountCollectionViaServiceLocation.ActiveContext = base.ActiveContext;
			_employeeCollectionViaWorkOrder.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ServiceTypeDAO dao = (ServiceTypeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ServiceTypeDAO dao = (ServiceTypeDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity);
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

			toReturn.Add("ServiceLocation", _serviceLocation);
			toReturn.Add("WorkOrder", _workOrder);
			toReturn.Add("AccountCollectionViaWorkOrder", _accountCollectionViaWorkOrder);
			toReturn.Add("AccountCollectionViaServiceLocation", _accountCollectionViaServiceLocation);
			toReturn.Add("EmployeeCollectionViaWorkOrder", _employeeCollectionViaWorkOrder);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		/// <param name="validator">The validator object for this ServiceTypeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 serviceTypeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(serviceTypeId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_serviceLocation = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_serviceLocation.SetContainingEntityInfo(this, "ServiceType");
			_alwaysFetchServiceLocation = false;
			_alreadyFetchedServiceLocation = false;
			_workOrder = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection(new WorkOrderEntityFactory());
			_workOrder.SetContainingEntityInfo(this, "ServiceType");
			_alwaysFetchWorkOrder = false;
			_alreadyFetchedWorkOrder = false;
			_accountCollectionViaWorkOrder = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaWorkOrder = false;
			_alreadyFetchedAccountCollectionViaWorkOrder = false;
			_accountCollectionViaServiceLocation = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaServiceLocation = false;
			_alreadyFetchedAccountCollectionViaServiceLocation = false;
			_employeeCollectionViaWorkOrder = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaWorkOrder = false;
			_alreadyFetchedEmployeeCollectionViaWorkOrder = false;



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

			_fieldsCustomProperties.Add("ServiceTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 serviceTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ServiceTypeFieldIndex.ServiceTypeId].ForcedCurrentValueWrite(serviceTypeId);
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
			return DAOFactory.CreateServiceTypeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ServiceTypeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ServiceTypeRelations Relations
		{
			get	{ return new ServiceTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocation
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrder
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceTypeEntity.Relations.WorkOrderEntityUsingServiceTypeId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaWorkOrder"), "AccountCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaServiceLocation
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceTypeEntity.Relations.ServiceLocationEntityUsingServiceTypeId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocation_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaServiceLocation"), "AccountCollectionViaServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceTypeEntity.Relations.WorkOrderEntityUsingServiceTypeId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaWorkOrder"), "EmployeeCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ServiceTypeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ServiceTypeEntity.CustomProperties;}
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
			get { return ServiceTypeEntity.FieldsCustomProperties;}
		}

		/// <summary> The ServiceTypeId property of the Entity ServiceType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceType"."ServiceTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ServiceTypeId
		{
			get { return (System.Int32)GetValue((int)ServiceTypeFieldIndex.ServiceTypeId, true); }
			set	{ SetValue((int)ServiceTypeFieldIndex.ServiceTypeId, value, true); }
		}
		/// <summary> The Name property of the Entity ServiceType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ServiceTypeFieldIndex.Name, true); }
			set	{ SetValue((int)ServiceTypeFieldIndex.Name, value, true); }
		}
		/// <summary> The Description property of the Entity ServiceType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceType"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)ServiceTypeFieldIndex.Description, true); }
			set	{ SetValue((int)ServiceTypeFieldIndex.Description, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocation
		{
			get	{ return GetMultiServiceLocation(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocation. When set to true, ServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocation
		{
			get	{ return _alwaysFetchServiceLocation; }
			set	{ _alwaysFetchServiceLocation = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocation already has been fetched. Setting this property to false when ServiceLocation has been fetched
		/// will clear the ServiceLocation collection well. Setting this property to true while ServiceLocation hasn't been fetched disables lazy loading for ServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocation
		{
			get { return _alreadyFetchedServiceLocation;}
			set 
			{
				if(_alreadyFetchedServiceLocation && !value && (_serviceLocation != null))
				{
					_serviceLocation.Clear();
				}
				_alreadyFetchedServiceLocation = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection WorkOrder
		{
			get	{ return GetMultiWorkOrder(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrder. When set to true, WorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrder
		{
			get	{ return _alwaysFetchWorkOrder; }
			set	{ _alwaysFetchWorkOrder = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrder already has been fetched. Setting this property to false when WorkOrder has been fetched
		/// will clear the WorkOrder collection well. Setting this property to true while WorkOrder hasn't been fetched disables lazy loading for WorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrder
		{
			get { return _alreadyFetchedWorkOrder;}
			set 
			{
				if(_alreadyFetchedWorkOrder && !value && (_workOrder != null))
				{
					_workOrder.Clear();
				}
				_alreadyFetchedWorkOrder = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaWorkOrder
		{
			get { return GetMultiAccountCollectionViaWorkOrder(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaWorkOrder. When set to true, AccountCollectionViaWorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaWorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaWorkOrder
		{
			get	{ return _alwaysFetchAccountCollectionViaWorkOrder; }
			set	{ _alwaysFetchAccountCollectionViaWorkOrder = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaWorkOrder already has been fetched. Setting this property to false when AccountCollectionViaWorkOrder has been fetched
		/// will clear the AccountCollectionViaWorkOrder collection well. Setting this property to true while AccountCollectionViaWorkOrder hasn't been fetched disables lazy loading for AccountCollectionViaWorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaWorkOrder
		{
			get { return _alreadyFetchedAccountCollectionViaWorkOrder;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaWorkOrder && !value && (_accountCollectionViaWorkOrder != null))
				{
					_accountCollectionViaWorkOrder.Clear();
				}
				_alreadyFetchedAccountCollectionViaWorkOrder = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaServiceLocation
		{
			get { return GetMultiAccountCollectionViaServiceLocation(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaServiceLocation. When set to true, AccountCollectionViaServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaServiceLocation
		{
			get	{ return _alwaysFetchAccountCollectionViaServiceLocation; }
			set	{ _alwaysFetchAccountCollectionViaServiceLocation = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaServiceLocation already has been fetched. Setting this property to false when AccountCollectionViaServiceLocation has been fetched
		/// will clear the AccountCollectionViaServiceLocation collection well. Setting this property to true while AccountCollectionViaServiceLocation hasn't been fetched disables lazy loading for AccountCollectionViaServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaServiceLocation
		{
			get { return _alreadyFetchedAccountCollectionViaServiceLocation;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaServiceLocation && !value && (_accountCollectionViaServiceLocation != null))
				{
					_accountCollectionViaServiceLocation.Clear();
				}
				_alreadyFetchedAccountCollectionViaServiceLocation = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaWorkOrder
		{
			get { return GetMultiEmployeeCollectionViaWorkOrder(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaWorkOrder. When set to true, EmployeeCollectionViaWorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaWorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaWorkOrder
		{
			get	{ return _alwaysFetchEmployeeCollectionViaWorkOrder; }
			set	{ _alwaysFetchEmployeeCollectionViaWorkOrder = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaWorkOrder already has been fetched. Setting this property to false when EmployeeCollectionViaWorkOrder has been fetched
		/// will clear the EmployeeCollectionViaWorkOrder collection well. Setting this property to true while EmployeeCollectionViaWorkOrder hasn't been fetched disables lazy loading for EmployeeCollectionViaWorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaWorkOrder
		{
			get { return _alreadyFetchedEmployeeCollectionViaWorkOrder;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaWorkOrder && !value && (_employeeCollectionViaWorkOrder != null))
				{
					_employeeCollectionViaWorkOrder.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaWorkOrder = value;
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity; }
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
