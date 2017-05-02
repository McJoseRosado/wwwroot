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
	/// Entity class which represents the entity 'RecycleServiceAction'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class RecycleServiceActionEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private EmployeeEntity _employee_;
		private EmployeeEntity _employee;
		private RecycleServiceEntity _recycleService;
		private RecycleTypeEntity _recycleType;
		private UserEntity _user;
		private UserEntity _user_;

		
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
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RecycleServiceActionEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public RecycleServiceActionEntity():base("RecycleServiceActionEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RecycleServiceActionEntity(IEntityFields2 fields):base("RecycleServiceActionEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RecycleServiceActionEntity</param>
		public RecycleServiceActionEntity(IValidator validator):base("RecycleServiceActionEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RecycleServiceActionEntity(System.Int32 recycleServiceActionId):base("RecycleServiceActionEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.RecycleServiceActionId = recycleServiceActionId;
		}

		/// <summary> CTor</summary>
		/// <param name="recycleServiceActionId">PK value for RecycleServiceAction which data should be fetched into this RecycleServiceAction object</param>
		/// <param name="validator">The custom validator object for this RecycleServiceActionEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RecycleServiceActionEntity(System.Int32 recycleServiceActionId, IValidator validator):base("RecycleServiceActionEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.RecycleServiceActionId = recycleServiceActionId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected RecycleServiceActionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


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
				_recycleService = (RecycleServiceEntity)info.GetValue("_recycleService", typeof(RecycleServiceEntity));
				if(_recycleService!=null)
				{
					_recycleService.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_recycleType = (RecycleTypeEntity)info.GetValue("_recycleType", typeof(RecycleTypeEntity));
				if(_recycleType!=null)
				{
					_recycleType.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_user = (UserEntity)info.GetValue("_user", typeof(UserEntity));
				if(_user!=null)
				{
					_user.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_user_ = (UserEntity)info.GetValue("_user_", typeof(UserEntity));
				if(_user_!=null)
				{
					_user_.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((RecycleServiceActionFieldIndex)fieldIndex)
			{
				case RecycleServiceActionFieldIndex.RecycleServiceId:
					DesetupSyncRecycleService(true, false);
					break;
				case RecycleServiceActionFieldIndex.RecycleTypeId:
					DesetupSyncRecycleType(true, false);
					break;
				case RecycleServiceActionFieldIndex.ActionUserId:
					DesetupSyncUser(true, false);
					break;
				case RecycleServiceActionFieldIndex.LastChangedByUserId:
					DesetupSyncUser_(true, false);
					break;
				case RecycleServiceActionFieldIndex.ActionEmployeeId:
					DesetupSyncEmployee(true, false);
					break;
				case RecycleServiceActionFieldIndex.LastChangedByEmployeeId:
					DesetupSyncEmployee_(true, false);
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
				case "Employee_":
					this.Employee_ = (EmployeeEntity)entity;
					break;
				case "Employee":
					this.Employee = (EmployeeEntity)entity;
					break;
				case "RecycleService":
					this.RecycleService = (RecycleServiceEntity)entity;
					break;
				case "RecycleType":
					this.RecycleType = (RecycleTypeEntity)entity;
					break;
				case "User":
					this.User = (UserEntity)entity;
					break;
				case "User_":
					this.User_ = (UserEntity)entity;
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
		public override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
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


				info.AddValue("_employee_", (!this.MarkedForDeletion?_employee_:null));
				info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
				info.AddValue("_recycleService", (!this.MarkedForDeletion?_recycleService:null));
				info.AddValue("_recycleType", (!this.MarkedForDeletion?_recycleType:null));
				info.AddValue("_user", (!this.MarkedForDeletion?_user:null));
				info.AddValue("_user_", (!this.MarkedForDeletion?_user_:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
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
		



		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.LastChangedByEmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.ActionEmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'RecycleService' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, null, ComparisonOperator.Equal, this.RecycleServiceId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'RecycleType' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'User' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.ActionUserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'User' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.LastChangedByUserId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory));
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
			toReturn.Add("Employee_", _employee_);
			toReturn.Add("Employee", _employee);
			toReturn.Add("RecycleService", _recycleService);
			toReturn.Add("RecycleType", _recycleType);
			toReturn.Add("User", _user);
			toReturn.Add("User_", _user_);



			return toReturn;
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

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{



			_employee_ = null;
			_employee = null;
			_recycleService = null;
			_recycleType = null;
			_user = null;
			_user_ = null;

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
		private void SetupSyncEmployee_(IEntity2 relatedEntity)
		{
			if(_employee_!=relatedEntity)
			{
				DesetupSyncEmployee_(true, true);
				_employee_ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee_, new PropertyChangedEventHandler( OnEmployee_PropertyChanged ), "Employee_", RecycleServiceActionEntity.Relations.EmployeeEntityUsingLastChangedByEmployeeId, true, new string[] {  } );
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
		private void SetupSyncEmployee(IEntity2 relatedEntity)
		{
			if(_employee!=relatedEntity)
			{
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", RecycleServiceActionEntity.Relations.EmployeeEntityUsingActionEmployeeId, true, new string[] {  } );
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
		private void SetupSyncRecycleService(IEntity2 relatedEntity)
		{
			if(_recycleService!=relatedEntity)
			{
				DesetupSyncRecycleService(true, true);
				_recycleService = (RecycleServiceEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _recycleService, new PropertyChangedEventHandler( OnRecycleServicePropertyChanged ), "RecycleService", RecycleServiceActionEntity.Relations.RecycleServiceEntityUsingRecycleServiceId, true, new string[] {  } );
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
		private void SetupSyncRecycleType(IEntity2 relatedEntity)
		{
			if(_recycleType!=relatedEntity)
			{
				DesetupSyncRecycleType(true, true);
				_recycleType = (RecycleTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _recycleType, new PropertyChangedEventHandler( OnRecycleTypePropertyChanged ), "RecycleType", RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, true, new string[] {  } );
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
		private void SetupSyncUser(IEntity2 relatedEntity)
		{
			if(_user!=relatedEntity)
			{
				DesetupSyncUser(true, true);
				_user = (UserEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", RecycleServiceActionEntity.Relations.UserEntityUsingActionUserId, true, new string[] {  } );
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
		private void SetupSyncUser_(IEntity2 relatedEntity)
		{
			if(_user_!=relatedEntity)
			{
				DesetupSyncUser_(true, true);
				_user_ = (UserEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _user_, new PropertyChangedEventHandler( OnUser_PropertyChanged ), "User_", RecycleServiceActionEntity.Relations.UserEntityUsingLastChangedByUserId, true, new string[] {  } );
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


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this RecycleServiceActionEntity</param>
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



		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee_
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("Employee_")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleService
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleService")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, null, null, "RecycleService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleType
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleType")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, null, null, "RecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("User")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser_
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))),
					(IEntityRelation)GetRelationsForField("User_")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, null, null, "User_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return RecycleServiceActionEntity.CustomProperties;}
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
			set	{ SetValue((int)RecycleServiceActionFieldIndex.RecycleServiceActionId, value); }
		}

		/// <summary> The ActionTime property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."ActionTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ActionTime
		{
			get { return (System.DateTime)GetValue((int)RecycleServiceActionFieldIndex.ActionTime, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.ActionTime, value); }
		}

		/// <summary> The NumberOfBales property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."NumberOfBales"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> NumberOfBales
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.NumberOfBales, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.NumberOfBales, value); }
		}

		/// <summary> The NumberOfBags property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."NumberOfBags"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> NumberOfBags
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.NumberOfBags, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.NumberOfBags, value); }
		}

		/// <summary> The BalesWeight property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."BalesWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> BalesWeight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RecycleServiceActionFieldIndex.BalesWeight, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.BalesWeight, value); }
		}

		/// <summary> The BagsWeight property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."BagsWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> BagsWeight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RecycleServiceActionFieldIndex.BagsWeight, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.BagsWeight, value); }
		}

		/// <summary> The RecycleServiceId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."RecycleServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RecycleServiceId
		{
			get { return (System.Int32)GetValue((int)RecycleServiceActionFieldIndex.RecycleServiceId, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.RecycleServiceId, value); }
		}

		/// <summary> The RecycleTypeId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."RecycleTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RecycleTypeId
		{
			get { return (System.Int32)GetValue((int)RecycleServiceActionFieldIndex.RecycleTypeId, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.RecycleTypeId, value); }
		}

		/// <summary> The ActionUserId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."ActionUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ActionUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.ActionUserId, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.ActionUserId, value); }
		}

		/// <summary> The LastChangedByUserId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."LastChangedByUserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> LastChangedByUserId
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.LastChangedByUserId, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.LastChangedByUserId, value); }
		}

		/// <summary> The LastChangedDate property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."LastChangedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime LastChangedDate
		{
			get { return (System.DateTime)GetValue((int)RecycleServiceActionFieldIndex.LastChangedDate, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.LastChangedDate, value); }
		}

		/// <summary> The ActionType property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."ActionType"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ActionType
		{
			get { return (System.String)GetValue((int)RecycleServiceActionFieldIndex.ActionType, true); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.ActionType, value); }
		}

		/// <summary> The ActionEmployeeId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."ActionEmployeeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ActionEmployeeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.ActionEmployeeId, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.ActionEmployeeId, value); }
		}

		/// <summary> The LastChangedByEmployeeId property of the Entity RecycleServiceAction<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleServiceAction"."LastChangedByEmployeeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> LastChangedByEmployeeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceActionFieldIndex.LastChangedByEmployeeId, false); }
			set	{ SetValue((int)RecycleServiceActionFieldIndex.LastChangedByEmployeeId, value); }
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
							_employee_.UnsetRelatedEntity(this, "RecycleServiceAction");
						}
					}
					else
					{
						if(_employee_!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "RecycleServiceAction");
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
							_employee.UnsetRelatedEntity(this, "RecycleServiceAction_");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "RecycleServiceAction_");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'RecycleServiceEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual RecycleServiceEntity RecycleService
		{
			get
			{
				return _recycleService;
			}
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
							((IEntity2)value).SetRelatedEntity(this, "RecycleServiceAction");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'RecycleTypeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual RecycleTypeEntity RecycleType
		{
			get
			{
				return _recycleType;
			}
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
							((IEntity2)value).SetRelatedEntity(this, "RecycleServiceAction");
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
							_user.UnsetRelatedEntity(this, "RecycleServiceAction");
						}
					}
					else
					{
						if(_user!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "RecycleServiceAction");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual UserEntity User_
		{
			get
			{
				return _user_;
			}
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
							((IEntity2)value).SetRelatedEntity(this, "RecycleServiceAction_");
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
