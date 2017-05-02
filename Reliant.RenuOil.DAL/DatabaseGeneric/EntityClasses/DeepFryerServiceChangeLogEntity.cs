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
	/// Entity class which represents the entity 'DeepFryerServiceChangeLog'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DeepFryerServiceChangeLogEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private DeepFryerServiceEntity _deepFryerService;
		private EmployeeEntity _employee_;
		private EmployeeEntity _employee;
		private ServiceLocationEntity _serviceLocation;
		private UserEntity _user;

		
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
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DeepFryerServiceChangeLogEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DeepFryerServiceChangeLogEntity():base("DeepFryerServiceChangeLogEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DeepFryerServiceChangeLogEntity(IEntityFields2 fields):base("DeepFryerServiceChangeLogEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DeepFryerServiceChangeLogEntity</param>
		public DeepFryerServiceChangeLogEntity(IValidator validator):base("DeepFryerServiceChangeLogEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DeepFryerServiceChangeLogEntity(System.Int32 deepFryerServiceChangeLogId):base("DeepFryerServiceChangeLogEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.DeepFryerServiceChangeLogId = deepFryerServiceChangeLogId;
		}

		/// <summary> CTor</summary>
		/// <param name="deepFryerServiceChangeLogId">PK value for DeepFryerServiceChangeLog which data should be fetched into this DeepFryerServiceChangeLog object</param>
		/// <param name="validator">The custom validator object for this DeepFryerServiceChangeLogEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DeepFryerServiceChangeLogEntity(System.Int32 deepFryerServiceChangeLogId, IValidator validator):base("DeepFryerServiceChangeLogEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.DeepFryerServiceChangeLogId = deepFryerServiceChangeLogId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DeepFryerServiceChangeLogEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


				_deepFryerService = (DeepFryerServiceEntity)info.GetValue("_deepFryerService", typeof(DeepFryerServiceEntity));
				if(_deepFryerService!=null)
				{
					_deepFryerService.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee_ = (EmployeeEntity)info.GetValue("_employee_", typeof(EmployeeEntity));
				if(_employee_!=null)
				{
					_employee_.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
				if(_employee!=null)
				{
					_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_serviceLocation = (ServiceLocationEntity)info.GetValue("_serviceLocation", typeof(ServiceLocationEntity));
				if(_serviceLocation!=null)
				{
					_serviceLocation.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_user = (UserEntity)info.GetValue("_user", typeof(UserEntity));
				if(_user!=null)
				{
					_user.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((DeepFryerServiceChangeLogFieldIndex)fieldIndex)
			{
				case DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceId:
					DesetupSyncDeepFryerService(true, false);
					break;
				case DeepFryerServiceChangeLogFieldIndex.RelocatedToServiceLocationId:
					DesetupSyncServiceLocation(true, false);
					break;
				case DeepFryerServiceChangeLogFieldIndex.ServicedBy:
					DesetupSyncEmployee_(true, false);
					break;
				case DeepFryerServiceChangeLogFieldIndex.EnteredByEmployeeId:
					DesetupSyncEmployee(true, false);
					break;
				case DeepFryerServiceChangeLogFieldIndex.EnteredByUserId:
					DesetupSyncUser(true, false);
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
				case "DeepFryerService":
					this.DeepFryerService = (DeepFryerServiceEntity)entity;
					break;
				case "Employee_":
					this.Employee_ = (EmployeeEntity)entity;
					break;
				case "Employee":
					this.Employee = (EmployeeEntity)entity;
					break;
				case "ServiceLocation":
					this.ServiceLocation = (ServiceLocationEntity)entity;
					break;
				case "User":
					this.User = (UserEntity)entity;
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
		public override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
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
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();


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


				info.AddValue("_deepFryerService", (!this.MarkedForDeletion?_deepFryerService:null));
				info.AddValue("_employee_", (!this.MarkedForDeletion?_employee_:null));
				info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
				info.AddValue("_serviceLocation", (!this.MarkedForDeletion?_serviceLocation:null));
				info.AddValue("_user", (!this.MarkedForDeletion?_user:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
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
		



		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'DeepFryerService' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.DeepFryerServiceId, null, ComparisonOperator.Equal, this.DeepFryerServiceId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.ServicedBy));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EnteredByEmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.RelocatedToServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'User' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.EnteredByUserId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);


		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);


		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{


			return base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);


		}
#endif
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

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{



			_deepFryerService = null;
			_employee_ = null;
			_employee = null;
			_serviceLocation = null;
			_user = null;

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
		private void SetupSyncDeepFryerService(IEntity2 relatedEntity)
		{
			if(_deepFryerService!=relatedEntity)
			{
				DesetupSyncDeepFryerService(true, true);
				_deepFryerService = (DeepFryerServiceEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _deepFryerService, new PropertyChangedEventHandler( OnDeepFryerServicePropertyChanged ), "DeepFryerService", DeepFryerServiceChangeLogEntity.Relations.DeepFryerServiceEntityUsingDeepFryerServiceId, true, new string[] {  } );
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
		private void SetupSyncEmployee_(IEntity2 relatedEntity)
		{
			if(_employee_!=relatedEntity)
			{
				DesetupSyncEmployee_(true, true);
				_employee_ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee_, new PropertyChangedEventHandler( OnEmployee_PropertyChanged ), "Employee_", DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingServicedBy, true, new string[] {  } );
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
		private void SetupSyncEmployee(IEntity2 relatedEntity)
		{
			if(_employee!=relatedEntity)
			{
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, true, new string[] {  } );
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
		private void SetupSyncServiceLocation(IEntity2 relatedEntity)
		{
			if(_serviceLocation!=relatedEntity)
			{
				DesetupSyncServiceLocation(true, true);
				_serviceLocation = (ServiceLocationEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerServiceChangeLogEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, true, new string[] {  } );
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
		private void SetupSyncUser(IEntity2 relatedEntity)
		{
			if(_user!=relatedEntity)
			{
				DesetupSyncUser(true, true);
				_user = (UserEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", DeepFryerServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, true, new string[] {  } );
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


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this DeepFryerServiceChangeLogEntity</param>
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



		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerService
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))),
					(IEntityRelation)GetRelationsForField("DeepFryerService")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, null, null, "DeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee_
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("Employee_")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocation
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))),
					(IEntityRelation)GetRelationsForField("User")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DeepFryerServiceChangeLogEntity.CustomProperties;}
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
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceChangeLogId, value); }
		}

		/// <summary> The DeepFryerServiceId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."DeepFryerServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DeepFryerServiceId
		{
			get { return (System.Int32)GetValue((int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceId, true); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceId, value); }
		}

		/// <summary> The ChangeDate property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."ChangeDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ChangeDate
		{
			get { return (System.DateTime)GetValue((int)DeepFryerServiceChangeLogFieldIndex.ChangeDate, true); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.ChangeDate, value); }
		}

		/// <summary> The Filtered property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."Filtered"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Filtered
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.Filtered, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.Filtered, value); }
		}

		/// <summary> The Discarded property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."Discarded"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Discarded
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.Discarded, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.Discarded, value); }
		}

		/// <summary> The Relocated property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."Relocated"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Relocated
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.Relocated, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.Relocated, value); }
		}

		/// <summary> The Cleaned property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."Cleaned"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Cleaned
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.Cleaned, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.Cleaned, value); }
		}

		/// <summary> The RelocatedToFryerId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."RelocatedToFryerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> RelocatedToFryerId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToFryerId, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToFryerId, value); }
		}

		/// <summary> The RelocatedToServiceLocationId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."RelocatedToServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> RelocatedToServiceLocationId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToServiceLocationId, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToServiceLocationId, value); }
		}

		/// <summary> The RelocatedToOther property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."RelocatedToOther"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RelocatedToOther
		{
			get { return (System.String)GetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToOther, true); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.RelocatedToOther, value); }
		}

		/// <summary> The AssignedTo property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."AssignedTo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> AssignedTo
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.AssignedTo, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.AssignedTo, value); }
		}

		/// <summary> The ServicedBy property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."ServicedBy"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ServicedBy
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.ServicedBy, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.ServicedBy, value); }
		}

		/// <summary> The EnteredByEmployeeId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."EnteredByEmployeeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> EnteredByEmployeeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.EnteredByEmployeeId, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.EnteredByEmployeeId, value); }
		}

		/// <summary> The EnteredByUserId property of the Entity DeepFryerServiceChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerServiceChangeLog"."EnteredByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> EnteredByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceChangeLogFieldIndex.EnteredByUserId, false); }
			set	{ SetValue((int)DeepFryerServiceChangeLogFieldIndex.EnteredByUserId, value); }
		}



		/// <summary> Gets / sets related entity of type 'DeepFryerServiceEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual DeepFryerServiceEntity DeepFryerService
		{
			get
			{
				return _deepFryerService;
			}
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
							((IEntity2)value).SetRelatedEntity(this, "DeepFryerServiceChangeLog");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee_
		{
			get
			{
				return _employee_;
			}
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
							((IEntity2)value).SetRelatedEntity(this, "DeepFryerServiceChangeLog_");
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
							_employee.UnsetRelatedEntity(this, "DeepFryerServiceChangeLog");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "DeepFryerServiceChangeLog");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ServiceLocationEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual ServiceLocationEntity ServiceLocation
		{
			get
			{
				return _serviceLocation;
			}
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
							((IEntity2)value).SetRelatedEntity(this, "DeepFryerServiceChangeLog");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual UserEntity User
		{
			get
			{
				return _user;
			}
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
							((IEntity2)value).SetRelatedEntity(this, "DeepFryerServiceChangeLog");
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
