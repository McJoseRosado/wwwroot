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
	/// Entity class which represents the entity 'ServiceType'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ServiceTypeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<ServiceLocationEntity> _serviceLocation;
		private EntityCollection<WorkOrderEntity> _workOrder;
		private EntityCollection<AccountEntity> _accountCollectionViaWorkOrder;
		private EntityCollection<AccountEntity> _accountCollectionViaServiceLocation;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaWorkOrder;


		
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
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ServiceTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public ServiceTypeEntity():base("ServiceTypeEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ServiceTypeEntity(IEntityFields2 fields):base("ServiceTypeEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ServiceTypeEntity</param>
		public ServiceTypeEntity(IValidator validator):base("ServiceTypeEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ServiceTypeEntity(System.Int32 serviceTypeId):base("ServiceTypeEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.ServiceTypeId = serviceTypeId;
		}

		/// <summary> CTor</summary>
		/// <param name="serviceTypeId">PK value for ServiceType which data should be fetched into this ServiceType object</param>
		/// <param name="validator">The custom validator object for this ServiceTypeEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ServiceTypeEntity(System.Int32 serviceTypeId, IValidator validator):base("ServiceTypeEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.ServiceTypeId = serviceTypeId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ServiceTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_serviceLocation = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocation", typeof(EntityCollection<ServiceLocationEntity>));
				_workOrder = (EntityCollection<WorkOrderEntity>)info.GetValue("_workOrder", typeof(EntityCollection<WorkOrderEntity>));
				_accountCollectionViaWorkOrder = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaWorkOrder", typeof(EntityCollection<AccountEntity>));
				_accountCollectionViaServiceLocation = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaServiceLocation", typeof(EntityCollection<AccountEntity>));
				_employeeCollectionViaWorkOrder = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaWorkOrder", typeof(EntityCollection<EmployeeEntity>));


				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
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
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{

				case "ServiceLocation":
					this.ServiceLocation.Add((ServiceLocationEntity)entity);
					break;
				case "WorkOrder":
					this.WorkOrder.Add((WorkOrderEntity)entity);
					break;
				case "AccountCollectionViaWorkOrder":
					this.AccountCollectionViaWorkOrder.IsReadOnly = false;
					this.AccountCollectionViaWorkOrder.Add((AccountEntity)entity);
					this.AccountCollectionViaWorkOrder.IsReadOnly = true;
					break;
				case "AccountCollectionViaServiceLocation":
					this.AccountCollectionViaServiceLocation.IsReadOnly = false;
					this.AccountCollectionViaServiceLocation.Add((AccountEntity)entity);
					this.AccountCollectionViaServiceLocation.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaWorkOrder":
					this.EmployeeCollectionViaWorkOrder.IsReadOnly = false;
					this.EmployeeCollectionViaWorkOrder.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaWorkOrder.IsReadOnly = true;
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

				case "ServiceLocation":
					this.ServiceLocation.Add((ServiceLocationEntity)relatedEntity);
					break;
				case "WorkOrder":
					this.WorkOrder.Add((WorkOrderEntity)relatedEntity);
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

				case "ServiceLocation":
					base.PerformRelatedEntityRemoval(this.ServiceLocation, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrder":
					base.PerformRelatedEntityRemoval(this.WorkOrder, relatedEntity, signalRelatedEntityManyToOne);
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


			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.ServiceLocation);
			toReturn.Add(this.WorkOrder);

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
				info.AddValue("_serviceLocation", ((_serviceLocation!=null) && (_serviceLocation.Count>0) && !this.MarkedForDeletion)?_serviceLocation:null);
				info.AddValue("_workOrder", ((_workOrder!=null) && (_workOrder.Count>0) && !this.MarkedForDeletion)?_workOrder:null);
				info.AddValue("_accountCollectionViaWorkOrder", ((_accountCollectionViaWorkOrder!=null) && (_accountCollectionViaWorkOrder.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaWorkOrder:null);
				info.AddValue("_accountCollectionViaServiceLocation", ((_accountCollectionViaServiceLocation!=null) && (_accountCollectionViaServiceLocation.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaServiceLocation:null);
				info.AddValue("_employeeCollectionViaWorkOrder", ((_employeeCollectionViaWorkOrder!=null) && (_employeeCollectionViaWorkOrder.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaWorkOrder:null);


			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
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
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceTypeId, null, ComparisonOperator.Equal, this.ServiceTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrder' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderFields.ServiceTypeId, null, ComparisonOperator.Equal, this.ServiceTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaWorkOrder"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceTypeFields.ServiceTypeId, null, ComparisonOperator.Equal, this.ServiceTypeId, "ServiceTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaServiceLocation"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceTypeFields.ServiceTypeId, null, ComparisonOperator.Equal, this.ServiceTypeId, "ServiceTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaWorkOrder"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceTypeFields.ServiceTypeId, null, ComparisonOperator.Equal, this.ServiceTypeId, "ServiceTypeEntity__"));
			return bucket;
		}


	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._serviceLocation);
			collectionsQueue.Enqueue(this._workOrder);
			collectionsQueue.Enqueue(this._accountCollectionViaWorkOrder);
			collectionsQueue.Enqueue(this._accountCollectionViaServiceLocation);
			collectionsQueue.Enqueue(this._employeeCollectionViaWorkOrder);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._serviceLocation = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._workOrder = (EntityCollection<WorkOrderEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaWorkOrder = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaServiceLocation = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaWorkOrder = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._serviceLocation != null)
			{
				return true;
			}
			if (this._workOrder != null)
			{
				return true;
			}
			if (this._accountCollectionViaWorkOrder != null)
			{
				return true;
			}
			if (this._accountCollectionViaServiceLocation != null)
			{
				return true;
			}
			if (this._employeeCollectionViaWorkOrder != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
		}
#endif
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
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
			}
			if(_workOrder!=null)
			{
				_workOrder.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaWorkOrder!=null)
			{
				_accountCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaServiceLocation!=null)
			{
				_accountCollectionViaServiceLocation.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaWorkOrder!=null)
			{
				_employeeCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			}


		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_serviceLocation = null;
			_workOrder = null;
			_accountCollectionViaWorkOrder = null;
			_accountCollectionViaServiceLocation = null;
			_employeeCollectionViaWorkOrder = null;


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



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ServiceTypeEntity</param>
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

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocation
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrder
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))),
					(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceTypeEntity.Relations.WorkOrderEntityUsingServiceTypeId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaWorkOrder"), null, "AccountCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaServiceLocation
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceTypeEntity.Relations.ServiceLocationEntityUsingServiceTypeId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocation_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaServiceLocation"), null, "AccountCollectionViaServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceTypeEntity.Relations.WorkOrderEntityUsingServiceTypeId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaWorkOrder"), null, "EmployeeCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ServiceTypeEntity.CustomProperties;}
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
			set	{ SetValue((int)ServiceTypeFieldIndex.ServiceTypeId, value); }
		}

		/// <summary> The Name property of the Entity ServiceType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ServiceTypeFieldIndex.Name, true); }
			set	{ SetValue((int)ServiceTypeFieldIndex.Name, value); }
		}

		/// <summary> The Description property of the Entity ServiceType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceType"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)ServiceTypeFieldIndex.Description, true); }
			set	{ SetValue((int)ServiceTypeFieldIndex.Description, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocation
		{
			get
			{
				if(_serviceLocation==null)
				{
					_serviceLocation = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocation.SetContainingEntityInfo(this, "ServiceType");
				}
				return _serviceLocation;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderEntity))]
		public virtual EntityCollection<WorkOrderEntity> WorkOrder
		{
			get
			{
				if(_workOrder==null)
				{
					_workOrder = new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory)));
					_workOrder.SetContainingEntityInfo(this, "ServiceType");
				}
				return _workOrder;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaWorkOrder
		{
			get
			{
				if(_accountCollectionViaWorkOrder==null)
				{
					_accountCollectionViaWorkOrder = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaWorkOrder.IsReadOnly=true;
				}
				return _accountCollectionViaWorkOrder;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaServiceLocation
		{
			get
			{
				if(_accountCollectionViaServiceLocation==null)
				{
					_accountCollectionViaServiceLocation = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaServiceLocation.IsReadOnly=true;
				}
				return _accountCollectionViaServiceLocation;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaWorkOrder
		{
			get
			{
				if(_employeeCollectionViaWorkOrder==null)
				{
					_employeeCollectionViaWorkOrder = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaWorkOrder.IsReadOnly=true;
				}
				return _employeeCollectionViaWorkOrder;
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
