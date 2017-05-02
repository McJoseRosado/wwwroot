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
	/// Entity class which represents the entity 'ServiceLocationEmployeeAssignment'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ServiceLocationEmployeeAssignmentEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private EmployeeEntity _employee____;
		private EmployeeEntity _employee_____;
		private EmployeeEntity _employee______;
		private EmployeeEntity _employee___;
		private EmployeeEntity _employee;
		private EmployeeEntity _employee_;
		private EmployeeEntity _employee__;
		private ServiceLocationEntity _serviceLocation;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Employee____</summary>
			public static readonly string Employee____ = "Employee____";
			/// <summary>Member name Employee_____</summary>
			public static readonly string Employee_____ = "Employee_____";
			/// <summary>Member name Employee______</summary>
			public static readonly string Employee______ = "Employee______";
			/// <summary>Member name Employee___</summary>
			public static readonly string Employee___ = "Employee___";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name Employee_</summary>
			public static readonly string Employee_ = "Employee_";
			/// <summary>Member name Employee__</summary>
			public static readonly string Employee__ = "Employee__";
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";



		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ServiceLocationEmployeeAssignmentEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public ServiceLocationEmployeeAssignmentEntity():base("ServiceLocationEmployeeAssignmentEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ServiceLocationEmployeeAssignmentEntity(IEntityFields2 fields):base("ServiceLocationEmployeeAssignmentEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ServiceLocationEmployeeAssignmentEntity</param>
		public ServiceLocationEmployeeAssignmentEntity(IValidator validator):base("ServiceLocationEmployeeAssignmentEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="serviceLocationEmployeeAssignmentId">PK value for ServiceLocationEmployeeAssignment which data should be fetched into this ServiceLocationEmployeeAssignment object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ServiceLocationEmployeeAssignmentEntity(System.Int32 serviceLocationEmployeeAssignmentId):base("ServiceLocationEmployeeAssignmentEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.ServiceLocationEmployeeAssignmentId = serviceLocationEmployeeAssignmentId;
		}

		/// <summary> CTor</summary>
		/// <param name="serviceLocationEmployeeAssignmentId">PK value for ServiceLocationEmployeeAssignment which data should be fetched into this ServiceLocationEmployeeAssignment object</param>
		/// <param name="validator">The custom validator object for this ServiceLocationEmployeeAssignmentEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ServiceLocationEmployeeAssignmentEntity(System.Int32 serviceLocationEmployeeAssignmentId, IValidator validator):base("ServiceLocationEmployeeAssignmentEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.ServiceLocationEmployeeAssignmentId = serviceLocationEmployeeAssignmentId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ServiceLocationEmployeeAssignmentEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


				_employee____ = (EmployeeEntity)info.GetValue("_employee____", typeof(EmployeeEntity));
				if(_employee____!=null)
				{
					_employee____.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee_____ = (EmployeeEntity)info.GetValue("_employee_____", typeof(EmployeeEntity));
				if(_employee_____!=null)
				{
					_employee_____.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee______ = (EmployeeEntity)info.GetValue("_employee______", typeof(EmployeeEntity));
				if(_employee______!=null)
				{
					_employee______.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee___ = (EmployeeEntity)info.GetValue("_employee___", typeof(EmployeeEntity));
				if(_employee___!=null)
				{
					_employee___.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
				if(_employee!=null)
				{
					_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee_ = (EmployeeEntity)info.GetValue("_employee_", typeof(EmployeeEntity));
				if(_employee_!=null)
				{
					_employee_.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee__ = (EmployeeEntity)info.GetValue("_employee__", typeof(EmployeeEntity));
				if(_employee__!=null)
				{
					_employee__.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_serviceLocation = (ServiceLocationEntity)info.GetValue("_serviceLocation", typeof(ServiceLocationEntity));
				if(_serviceLocation!=null)
				{
					_serviceLocation.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((ServiceLocationEmployeeAssignmentFieldIndex)fieldIndex)
			{
				case ServiceLocationEmployeeAssignmentFieldIndex.ServiceLocationId:
					DesetupSyncServiceLocation(true, false);
					break;
				case ServiceLocationEmployeeAssignmentFieldIndex.Monday:
					DesetupSyncEmployee(true, false);
					break;
				case ServiceLocationEmployeeAssignmentFieldIndex.Tuesday:
					DesetupSyncEmployee_(true, false);
					break;
				case ServiceLocationEmployeeAssignmentFieldIndex.Wednesday:
					DesetupSyncEmployee__(true, false);
					break;
				case ServiceLocationEmployeeAssignmentFieldIndex.Thursday:
					DesetupSyncEmployee___(true, false);
					break;
				case ServiceLocationEmployeeAssignmentFieldIndex.Friday:
					DesetupSyncEmployee____(true, false);
					break;
				case ServiceLocationEmployeeAssignmentFieldIndex.Saturday:
					DesetupSyncEmployee_____(true, false);
					break;
				case ServiceLocationEmployeeAssignmentFieldIndex.Sunday:
					DesetupSyncEmployee______(true, false);
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
				case "Employee____":
					this.Employee____ = (EmployeeEntity)entity;
					break;
				case "Employee_____":
					this.Employee_____ = (EmployeeEntity)entity;
					break;
				case "Employee______":
					this.Employee______ = (EmployeeEntity)entity;
					break;
				case "Employee___":
					this.Employee___ = (EmployeeEntity)entity;
					break;
				case "Employee":
					this.Employee = (EmployeeEntity)entity;
					break;
				case "Employee_":
					this.Employee_ = (EmployeeEntity)entity;
					break;
				case "Employee__":
					this.Employee__ = (EmployeeEntity)entity;
					break;
				case "ServiceLocation":
					this.ServiceLocation = (ServiceLocationEntity)entity;
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
			return ServiceLocationEmployeeAssignmentEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Employee____":
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingFriday);
					break;
				case "Employee_____":
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSaturday);
					break;
				case "Employee______":
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSunday);
					break;
				case "Employee___":
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingThursday);
					break;
				case "Employee":
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingMonday);
					break;
				case "Employee_":
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingTuesday);
					break;
				case "Employee__":
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingWednesday);
					break;
				case "ServiceLocation":
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.ServiceLocationEntityUsingServiceLocationId);
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
				case "Employee____":
					SetupSyncEmployee____(relatedEntity);
					break;
				case "Employee_____":
					SetupSyncEmployee_____(relatedEntity);
					break;
				case "Employee______":
					SetupSyncEmployee______(relatedEntity);
					break;
				case "Employee___":
					SetupSyncEmployee___(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "Employee_":
					SetupSyncEmployee_(relatedEntity);
					break;
				case "Employee__":
					SetupSyncEmployee__(relatedEntity);
					break;
				case "ServiceLocation":
					SetupSyncServiceLocation(relatedEntity);
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
				case "Employee____":
					DesetupSyncEmployee____(false, true);
					break;
				case "Employee_____":
					DesetupSyncEmployee_____(false, true);
					break;
				case "Employee______":
					DesetupSyncEmployee______(false, true);
					break;
				case "Employee___":
					DesetupSyncEmployee___(false, true);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "Employee_":
					DesetupSyncEmployee_(false, true);
					break;
				case "Employee__":
					DesetupSyncEmployee__(false, true);
					break;
				case "ServiceLocation":
					DesetupSyncServiceLocation(false, true);
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
			if(_employee____!=null)
			{
				toReturn.Add(_employee____);
			}
			if(_employee_____!=null)
			{
				toReturn.Add(_employee_____);
			}
			if(_employee______!=null)
			{
				toReturn.Add(_employee______);
			}
			if(_employee___!=null)
			{
				toReturn.Add(_employee___);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_employee_!=null)
			{
				toReturn.Add(_employee_);
			}
			if(_employee__!=null)
			{
				toReturn.Add(_employee__);
			}
			if(_serviceLocation!=null)
			{
				toReturn.Add(_serviceLocation);
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


				info.AddValue("_employee____", (!this.MarkedForDeletion?_employee____:null));
				info.AddValue("_employee_____", (!this.MarkedForDeletion?_employee_____:null));
				info.AddValue("_employee______", (!this.MarkedForDeletion?_employee______:null));
				info.AddValue("_employee___", (!this.MarkedForDeletion?_employee___:null));
				info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
				info.AddValue("_employee_", (!this.MarkedForDeletion?_employee_:null));
				info.AddValue("_employee__", (!this.MarkedForDeletion?_employee__:null));
				info.AddValue("_serviceLocation", (!this.MarkedForDeletion?_serviceLocation:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ServiceLocationEmployeeAssignmentFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ServiceLocationEmployeeAssignmentFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ServiceLocationEmployeeAssignmentRelations().GetAllRelations();
		}
		



		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.Friday));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee_____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.Saturday));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee______()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.Sunday));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee___()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.Thursday));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.Monday));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.Tuesday));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee__()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.Wednesday));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory));
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
			toReturn.Add("Employee____", _employee____);
			toReturn.Add("Employee_____", _employee_____);
			toReturn.Add("Employee______", _employee______);
			toReturn.Add("Employee___", _employee___);
			toReturn.Add("Employee", _employee);
			toReturn.Add("Employee_", _employee_);
			toReturn.Add("Employee__", _employee__);
			toReturn.Add("ServiceLocation", _serviceLocation);



			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_employee____!=null)
			{
				_employee____.ActiveContext = base.ActiveContext;
			}
			if(_employee_____!=null)
			{
				_employee_____.ActiveContext = base.ActiveContext;
			}
			if(_employee______!=null)
			{
				_employee______.ActiveContext = base.ActiveContext;
			}
			if(_employee___!=null)
			{
				_employee___.ActiveContext = base.ActiveContext;
			}
			if(_employee!=null)
			{
				_employee.ActiveContext = base.ActiveContext;
			}
			if(_employee_!=null)
			{
				_employee_.ActiveContext = base.ActiveContext;
			}
			if(_employee__!=null)
			{
				_employee__.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{



			_employee____ = null;
			_employee_____ = null;
			_employee______ = null;
			_employee___ = null;
			_employee = null;
			_employee_ = null;
			_employee__ = null;
			_serviceLocation = null;

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

			_fieldsCustomProperties.Add("ServiceLocationEmployeeAssignmentId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Monday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tuesday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Wednesday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thursday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Friday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Saturday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sunday", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _employee____</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee____(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee____, new PropertyChangedEventHandler( OnEmployee____PropertyChanged ), "Employee____", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingFriday, true, signalRelatedEntity, "ServiceLocationEmployeeAssignment____", resetFKFields, new int[] { (int)ServiceLocationEmployeeAssignmentFieldIndex.Friday } );		
			_employee____ = null;
		}

		/// <summary> setups the sync logic for member _employee____</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee____(IEntity2 relatedEntity)
		{
			if(_employee____!=relatedEntity)
			{
				DesetupSyncEmployee____(true, true);
				_employee____ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee____, new PropertyChangedEventHandler( OnEmployee____PropertyChanged ), "Employee____", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingFriday, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee____PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee_____</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee_____(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee_____, new PropertyChangedEventHandler( OnEmployee_____PropertyChanged ), "Employee_____", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSaturday, true, signalRelatedEntity, "ServiceLocationEmployeeAssignment_____", resetFKFields, new int[] { (int)ServiceLocationEmployeeAssignmentFieldIndex.Saturday } );		
			_employee_____ = null;
		}

		/// <summary> setups the sync logic for member _employee_____</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee_____(IEntity2 relatedEntity)
		{
			if(_employee_____!=relatedEntity)
			{
				DesetupSyncEmployee_____(true, true);
				_employee_____ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee_____, new PropertyChangedEventHandler( OnEmployee_____PropertyChanged ), "Employee_____", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSaturday, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee_____PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee______</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee______(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee______, new PropertyChangedEventHandler( OnEmployee______PropertyChanged ), "Employee______", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSunday, true, signalRelatedEntity, "ServiceLocationEmployeeAssignment______", resetFKFields, new int[] { (int)ServiceLocationEmployeeAssignmentFieldIndex.Sunday } );		
			_employee______ = null;
		}

		/// <summary> setups the sync logic for member _employee______</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee______(IEntity2 relatedEntity)
		{
			if(_employee______!=relatedEntity)
			{
				DesetupSyncEmployee______(true, true);
				_employee______ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee______, new PropertyChangedEventHandler( OnEmployee______PropertyChanged ), "Employee______", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSunday, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee______PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee___</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee___(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee___, new PropertyChangedEventHandler( OnEmployee___PropertyChanged ), "Employee___", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingThursday, true, signalRelatedEntity, "ServiceLocationEmployeeAssignment___", resetFKFields, new int[] { (int)ServiceLocationEmployeeAssignmentFieldIndex.Thursday } );		
			_employee___ = null;
		}

		/// <summary> setups the sync logic for member _employee___</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee___(IEntity2 relatedEntity)
		{
			if(_employee___!=relatedEntity)
			{
				DesetupSyncEmployee___(true, true);
				_employee___ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee___, new PropertyChangedEventHandler( OnEmployee___PropertyChanged ), "Employee___", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingThursday, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee___PropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingMonday, true, signalRelatedEntity, "ServiceLocationEmployeeAssignment", resetFKFields, new int[] { (int)ServiceLocationEmployeeAssignmentFieldIndex.Monday } );		
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
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingMonday, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _employee_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee_(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee_, new PropertyChangedEventHandler( OnEmployee_PropertyChanged ), "Employee_", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingTuesday, true, signalRelatedEntity, "ServiceLocationEmployeeAssignment_", resetFKFields, new int[] { (int)ServiceLocationEmployeeAssignmentFieldIndex.Tuesday } );		
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
				base.PerformSetupSyncRelatedEntity( _employee_, new PropertyChangedEventHandler( OnEmployee_PropertyChanged ), "Employee_", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingTuesday, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _employee__</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee__(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee__, new PropertyChangedEventHandler( OnEmployee__PropertyChanged ), "Employee__", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingWednesday, true, signalRelatedEntity, "ServiceLocationEmployeeAssignment__", resetFKFields, new int[] { (int)ServiceLocationEmployeeAssignmentFieldIndex.Wednesday } );		
			_employee__ = null;
		}

		/// <summary> setups the sync logic for member _employee__</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee__(IEntity2 relatedEntity)
		{
			if(_employee__!=relatedEntity)
			{
				DesetupSyncEmployee__(true, true);
				_employee__ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee__, new PropertyChangedEventHandler( OnEmployee__PropertyChanged ), "Employee__", ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingWednesday, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee__PropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", ServiceLocationEmployeeAssignmentEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, signalRelatedEntity, "ServiceLocationEmployeeAssignment", resetFKFields, new int[] { (int)ServiceLocationEmployeeAssignmentFieldIndex.ServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", ServiceLocationEmployeeAssignmentEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, new string[] {  } );
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


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ServiceLocationEmployeeAssignmentEntity</param>
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
		public  static ServiceLocationEmployeeAssignmentRelations Relations
		{
			get	{ return new ServiceLocationEmployeeAssignmentRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}



		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee____
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("Employee____")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee_____
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("Employee_____")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee______
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("Employee______")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee___
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("Employee___")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Employee_")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee__
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("Employee__")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ServiceLocationEmployeeAssignmentEntity.CustomProperties;}
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
			get { return ServiceLocationEmployeeAssignmentEntity.FieldsCustomProperties;}
		}

		/// <summary> The ServiceLocationEmployeeAssignmentId property of the Entity ServiceLocationEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationEmployeeAssignment"."ServiceLocationEmployeeAssignmentId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ServiceLocationEmployeeAssignmentId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.ServiceLocationEmployeeAssignmentId, true); }
			set	{ SetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.ServiceLocationEmployeeAssignmentId, value); }
		}

		/// <summary> The ServiceLocationId property of the Entity ServiceLocationEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationEmployeeAssignment"."ServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceLocationId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.ServiceLocationId, true); }
			set	{ SetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.ServiceLocationId, value); }
		}

		/// <summary> The Monday property of the Entity ServiceLocationEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationEmployeeAssignment"."Monday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Monday
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Monday, false); }
			set	{ SetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Monday, value); }
		}

		/// <summary> The Tuesday property of the Entity ServiceLocationEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationEmployeeAssignment"."Tuesday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Tuesday
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Tuesday, false); }
			set	{ SetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Tuesday, value); }
		}

		/// <summary> The Wednesday property of the Entity ServiceLocationEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationEmployeeAssignment"."Wednesday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Wednesday
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Wednesday, false); }
			set	{ SetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Wednesday, value); }
		}

		/// <summary> The Thursday property of the Entity ServiceLocationEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationEmployeeAssignment"."Thursday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Thursday
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Thursday, false); }
			set	{ SetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Thursday, value); }
		}

		/// <summary> The Friday property of the Entity ServiceLocationEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationEmployeeAssignment"."Friday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Friday
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Friday, false); }
			set	{ SetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Friday, value); }
		}

		/// <summary> The Saturday property of the Entity ServiceLocationEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationEmployeeAssignment"."Saturday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Saturday
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Saturday, false); }
			set	{ SetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Saturday, value); }
		}

		/// <summary> The Sunday property of the Entity ServiceLocationEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationEmployeeAssignment"."Sunday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Sunday
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Sunday, false); }
			set	{ SetValue((int)ServiceLocationEmployeeAssignmentFieldIndex.Sunday, value); }
		}



		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee____
		{
			get
			{
				return _employee____;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee____(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee____ != null)
						{
							_employee____.UnsetRelatedEntity(this, "ServiceLocationEmployeeAssignment____");
						}
					}
					else
					{
						if(_employee____!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationEmployeeAssignment____");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee_____
		{
			get
			{
				return _employee_____;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee_____(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee_____ != null)
						{
							_employee_____.UnsetRelatedEntity(this, "ServiceLocationEmployeeAssignment_____");
						}
					}
					else
					{
						if(_employee_____!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationEmployeeAssignment_____");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee______
		{
			get
			{
				return _employee______;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee______(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee______ != null)
						{
							_employee______.UnsetRelatedEntity(this, "ServiceLocationEmployeeAssignment______");
						}
					}
					else
					{
						if(_employee______!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationEmployeeAssignment______");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee___
		{
			get
			{
				return _employee___;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee___(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee___ != null)
						{
							_employee___.UnsetRelatedEntity(this, "ServiceLocationEmployeeAssignment___");
						}
					}
					else
					{
						if(_employee___!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationEmployeeAssignment___");
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
							_employee.UnsetRelatedEntity(this, "ServiceLocationEmployeeAssignment");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationEmployeeAssignment");
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
							_employee_.UnsetRelatedEntity(this, "ServiceLocationEmployeeAssignment_");
						}
					}
					else
					{
						if(_employee_!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationEmployeeAssignment_");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee__
		{
			get
			{
				return _employee__;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee__(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee__ != null)
						{
							_employee__.UnsetRelatedEntity(this, "ServiceLocationEmployeeAssignment__");
						}
					}
					else
					{
						if(_employee__!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationEmployeeAssignment__");
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
							_serviceLocation.UnsetRelatedEntity(this, "ServiceLocationEmployeeAssignment");
						}
					}
					else
					{
						if(_serviceLocation!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationEmployeeAssignment");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity; }
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
