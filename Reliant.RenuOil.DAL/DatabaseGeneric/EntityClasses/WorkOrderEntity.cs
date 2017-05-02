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
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Entity class which represents the entity 'WorkOrder'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class WorkOrderEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<WorkOrderEmployeeEntity> _workOrderEmployee;
		private EntityCollection<WorkOrderServiceLocationEntity> _workOrderServiceLocation;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaWorkOrderServiceLocation;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaWorkOrderEmployee;
		private AccountEntity _account;
		private EmployeeEntity _employee;
		private ServiceTypeEntity _serviceType;

		
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
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static WorkOrderEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public WorkOrderEntity():base("WorkOrderEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public WorkOrderEntity(IEntityFields2 fields):base("WorkOrderEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this WorkOrderEntity</param>
		public WorkOrderEntity(IValidator validator):base("WorkOrderEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public WorkOrderEntity(System.Int32 workOrderId):base("WorkOrderEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.WorkOrderId = workOrderId;
		}

		/// <summary> CTor</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="validator">The custom validator object for this WorkOrderEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public WorkOrderEntity(System.Int32 workOrderId, IValidator validator):base("WorkOrderEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.WorkOrderId = workOrderId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected WorkOrderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_workOrderEmployee = (EntityCollection<WorkOrderEmployeeEntity>)info.GetValue("_workOrderEmployee", typeof(EntityCollection<WorkOrderEmployeeEntity>));
				_workOrderServiceLocation = (EntityCollection<WorkOrderServiceLocationEntity>)info.GetValue("_workOrderServiceLocation", typeof(EntityCollection<WorkOrderServiceLocationEntity>));
				_serviceLocationCollectionViaWorkOrderServiceLocation = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaWorkOrderServiceLocation", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationCollectionViaWorkOrderEmployee = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaWorkOrderEmployee", typeof(EntityCollection<ServiceLocationEntity>));
				_account = (AccountEntity)info.GetValue("_account", typeof(AccountEntity));
				if(_account!=null)
				{
					_account.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
				if(_employee!=null)
				{
					_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_serviceType = (ServiceTypeEntity)info.GetValue("_serviceType", typeof(ServiceTypeEntity));
				if(_serviceType!=null)
				{
					_serviceType.AfterSave+=new EventHandler(OnEntityAfterSave);
				}

				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
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
					break;
				case WorkOrderFieldIndex.ServiceTypeId:
					DesetupSyncServiceType(true, false);
					break;
				case WorkOrderFieldIndex.TechnicianId:
					DesetupSyncEmployee(true, false);
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
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{
				case "Account":
					this.Account = (AccountEntity)entity;
					break;
				case "Employee":
					this.Employee = (EmployeeEntity)entity;
					break;
				case "ServiceType":
					this.ServiceType = (ServiceTypeEntity)entity;
					break;
				case "WorkOrderEmployee":
					this.WorkOrderEmployee.Add((WorkOrderEmployeeEntity)entity);
					break;
				case "WorkOrderServiceLocation":
					this.WorkOrderServiceLocation.Add((WorkOrderServiceLocationEntity)entity);
					break;
				case "ServiceLocationCollectionViaWorkOrderServiceLocation":
					this.ServiceLocationCollectionViaWorkOrderServiceLocation.IsReadOnly = false;
					this.ServiceLocationCollectionViaWorkOrderServiceLocation.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaWorkOrderServiceLocation.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaWorkOrderEmployee":
					this.ServiceLocationCollectionViaWorkOrderEmployee.IsReadOnly = false;
					this.ServiceLocationCollectionViaWorkOrderEmployee.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaWorkOrderEmployee.IsReadOnly = true;
					break;

				default:
					break;
			}
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
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it
		/// will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckOneWayRelations(string propertyName)
		{
			// use template trick to calculate the # of single-sided / oneway relations
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));




				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
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
					this.WorkOrderEmployee.Add((WorkOrderEmployeeEntity)relatedEntity);
					break;
				case "WorkOrderServiceLocation":
					this.WorkOrderServiceLocation.Add((WorkOrderServiceLocationEntity)relatedEntity);
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
		public override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
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
					base.PerformRelatedEntityRemoval(this.WorkOrderEmployee, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrderServiceLocation":
					base.PerformRelatedEntityRemoval(this.WorkOrderServiceLocation, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
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
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.WorkOrderEmployee);
			toReturn.Add(this.WorkOrderServiceLocation);

			return toReturn;
		}
		


		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_workOrderEmployee", ((_workOrderEmployee!=null) && (_workOrderEmployee.Count>0) && !this.MarkedForDeletion)?_workOrderEmployee:null);
				info.AddValue("_workOrderServiceLocation", ((_workOrderServiceLocation!=null) && (_workOrderServiceLocation.Count>0) && !this.MarkedForDeletion)?_workOrderServiceLocation:null);
				info.AddValue("_serviceLocationCollectionViaWorkOrderServiceLocation", ((_serviceLocationCollectionViaWorkOrderServiceLocation!=null) && (_serviceLocationCollectionViaWorkOrderServiceLocation.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaWorkOrderServiceLocation:null);
				info.AddValue("_serviceLocationCollectionViaWorkOrderEmployee", ((_serviceLocationCollectionViaWorkOrderEmployee!=null) && (_serviceLocationCollectionViaWorkOrderEmployee.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaWorkOrderEmployee:null);
				info.AddValue("_account", (!this.MarkedForDeletion?_account:null));
				info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
				info.AddValue("_serviceType", (!this.MarkedForDeletion?_serviceType:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
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
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderEmployee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderEmployeeFields.WorkOrderId, null, ComparisonOperator.Equal, this.WorkOrderId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderServiceLocationFields.WorkOrderId, null, ComparisonOperator.Equal, this.WorkOrderId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaWorkOrderServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaWorkOrderServiceLocation"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderFields.WorkOrderId, null, ComparisonOperator.Equal, this.WorkOrderId, "WorkOrderEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaWorkOrderEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaWorkOrderEmployee"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderFields.WorkOrderId, null, ComparisonOperator.Equal, this.WorkOrderId, "WorkOrderEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Account' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccount()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.TechnicianId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'ServiceType' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceTypeFields.ServiceTypeId, null, ComparisonOperator.Equal, this.ServiceTypeId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.WorkOrderEntity);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._workOrderEmployee);
			collectionsQueue.Enqueue(this._workOrderServiceLocation);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaWorkOrderServiceLocation);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaWorkOrderEmployee);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._workOrderEmployee = (EntityCollection<WorkOrderEmployeeEntity>) collectionsQueue.Dequeue();
			this._workOrderServiceLocation = (EntityCollection<WorkOrderServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaWorkOrderServiceLocation = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaWorkOrderEmployee = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._workOrderEmployee != null)
			{
				return true;
			}
			if (this._workOrderServiceLocation != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaWorkOrderServiceLocation != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaWorkOrderEmployee != null)
			{
				return true;
			}
			return base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
		}
#endif
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
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_workOrderEmployee!=null)
			{
				_workOrderEmployee.ActiveContext = base.ActiveContext;
			}
			if(_workOrderServiceLocation!=null)
			{
				_workOrderServiceLocation.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaWorkOrderServiceLocation!=null)
			{
				_serviceLocationCollectionViaWorkOrderServiceLocation.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaWorkOrderEmployee!=null)
			{
				_serviceLocationCollectionViaWorkOrderEmployee.ActiveContext = base.ActiveContext;
			}
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

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_workOrderEmployee = null;
			_workOrderServiceLocation = null;
			_serviceLocationCollectionViaWorkOrderServiceLocation = null;
			_serviceLocationCollectionViaWorkOrderEmployee = null;
			_account = null;
			_employee = null;
			_serviceType = null;

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
		private void SetupSyncAccount(IEntity2 relatedEntity)
		{
			if(_account!=relatedEntity)
			{
				DesetupSyncAccount(true, true);
				_account = (AccountEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", WorkOrderEntity.Relations.AccountEntityUsingAccountId, true, new string[] {  } );
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
		private void SetupSyncEmployee(IEntity2 relatedEntity)
		{
			if(_employee!=relatedEntity)
			{
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", WorkOrderEntity.Relations.EmployeeEntityUsingTechnicianId, true, new string[] {  } );
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
		private void SetupSyncServiceType(IEntity2 relatedEntity)
		{
			if(_serviceType!=relatedEntity)
			{
				DesetupSyncServiceType(true, true);
				_serviceType = (ServiceTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceType, new PropertyChangedEventHandler( OnServiceTypePropertyChanged ), "ServiceType", WorkOrderEntity.Relations.ServiceTypeEntityUsingServiceTypeId, true, new string[] {  } );
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


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this WorkOrderEntity</param>
		/// <param name="fields">Fields of this entity</param>
		protected virtual void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			base.Fields = fields;
			base.IsNew=true;
			base.Validator = validator;
			InitClassMembers();

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
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

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderEmployee
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("WorkOrderEmployee")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, null, null, "WorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderServiceLocation
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))),
					(IEntityRelation)GetRelationsForField("WorkOrderServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, null, null, "WorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaWorkOrderServiceLocation
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrderServiceLocation_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaWorkOrderServiceLocation"), null, "ServiceLocationCollectionViaWorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaWorkOrderEmployee
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrderEmployee_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaWorkOrderEmployee"), null, "ServiceLocationCollectionViaWorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccount
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))),
					(IEntityRelation)GetRelationsForField("Account")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, null, null, "Account", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceType
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceType")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, 0, null, null, null, null, "ServiceType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return WorkOrderEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value
		/// pairs. </summary>
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
			set	{ SetValue((int)WorkOrderFieldIndex.WorkOrderId, value); }
		}

		/// <summary> The AccountId property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.AccountId, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.AccountId, value); }
		}

		/// <summary> The AppointmentDate property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."AppointmentDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime AppointmentDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderFieldIndex.AppointmentDate, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.AppointmentDate, value); }
		}

		/// <summary> The AppointmentTime property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."AppointmentTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> AppointmentTime
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderFieldIndex.AppointmentTime, false); }
			set	{ SetValue((int)WorkOrderFieldIndex.AppointmentTime, value); }
		}

		/// <summary> The ServiceTypeId property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."ServiceTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceTypeId
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.ServiceTypeId, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.ServiceTypeId, value); }
		}

		/// <summary> The Notes property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)WorkOrderFieldIndex.Notes, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.Notes, value); }
		}

		/// <summary> The IsComplete property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."IsComplete"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsComplete
		{
			get { return (System.Boolean)GetValue((int)WorkOrderFieldIndex.IsComplete, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.IsComplete, value); }
		}

		/// <summary> The IsActive property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsActive
		{
			get { return (Nullable<System.Boolean>)GetValue((int)WorkOrderFieldIndex.IsActive, false); }
			set	{ SetValue((int)WorkOrderFieldIndex.IsActive, value); }
		}

		/// <summary> The Signature property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."Signature"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Signature
		{
			get { return (System.String)GetValue((int)WorkOrderFieldIndex.Signature, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.Signature, value); }
		}

		/// <summary> The TechnicianId property of the Entity WorkOrder<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."TechnicianId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TechnicianId
		{
			get { return (Nullable<System.Int32>)GetValue((int)WorkOrderFieldIndex.TechnicianId, false); }
			set	{ SetValue((int)WorkOrderFieldIndex.TechnicianId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEmployeeEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderEmployeeEntity))]
		public virtual EntityCollection<WorkOrderEmployeeEntity> WorkOrderEmployee
		{
			get
			{
				if(_workOrderEmployee==null)
				{
					_workOrderEmployee = new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory)));
					_workOrderEmployee.SetContainingEntityInfo(this, "WorkOrder");
				}
				return _workOrderEmployee;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderServiceLocationEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderServiceLocationEntity))]
		public virtual EntityCollection<WorkOrderServiceLocationEntity> WorkOrderServiceLocation
		{
			get
			{
				if(_workOrderServiceLocation==null)
				{
					_workOrderServiceLocation = new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory)));
					_workOrderServiceLocation.SetContainingEntityInfo(this, "WorkOrder");
				}
				return _workOrderServiceLocation;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaWorkOrderServiceLocation
		{
			get
			{
				if(_serviceLocationCollectionViaWorkOrderServiceLocation==null)
				{
					_serviceLocationCollectionViaWorkOrderServiceLocation = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaWorkOrderServiceLocation.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaWorkOrderServiceLocation;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaWorkOrderEmployee
		{
			get
			{
				if(_serviceLocationCollectionViaWorkOrderEmployee==null)
				{
					_serviceLocationCollectionViaWorkOrderEmployee = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaWorkOrderEmployee.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaWorkOrderEmployee;
			}
		}

		/// <summary> Gets / sets related entity of type 'AccountEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual AccountEntity Account
		{
			get
			{
				return _account;
			}
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
							((IEntity2)value).SetRelatedEntity(this, "WorkOrder");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get
			{
				return _employee;
			}
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
							((IEntity2)value).SetRelatedEntity(this, "WorkOrder");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ServiceTypeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual ServiceTypeEntity ServiceType
		{
			get
			{
				return _serviceType;
			}
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
							((IEntity2)value).SetRelatedEntity(this, "WorkOrder");
						}
					}
				}
			}
		}

	
		
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
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
