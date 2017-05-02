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
	/// Entity class which represents the entity 'AssetReclamationService'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AssetReclamationServiceEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<AssetReclamationServiceChangeLogEntity> _assetReclamationServiceChangeLog;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaAssetReclamationServiceChangeLog;
		private EntityCollection<UserEntity> _userCollectionViaAssetReclamationServiceChangeLog;
		private ServiceLocationAssetTypeEntity _serviceLocationAssetType;
		private WorkOrderEmployeeEntity _workOrderEmployee;
		private WorkOrderServiceLocationEntity _workOrderServiceLocation;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name ServiceLocationAssetType</summary>
			public static readonly string ServiceLocationAssetType = "ServiceLocationAssetType";
			/// <summary>Member name WorkOrderEmployee</summary>
			public static readonly string WorkOrderEmployee = "WorkOrderEmployee";
			/// <summary>Member name WorkOrderServiceLocation</summary>
			public static readonly string WorkOrderServiceLocation = "WorkOrderServiceLocation";
			/// <summary>Member name AssetReclamationServiceChangeLog</summary>
			public static readonly string AssetReclamationServiceChangeLog = "AssetReclamationServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaAssetReclamationServiceChangeLog</summary>
			public static readonly string EmployeeCollectionViaAssetReclamationServiceChangeLog = "EmployeeCollectionViaAssetReclamationServiceChangeLog";
			/// <summary>Member name UserCollectionViaAssetReclamationServiceChangeLog</summary>
			public static readonly string UserCollectionViaAssetReclamationServiceChangeLog = "UserCollectionViaAssetReclamationServiceChangeLog";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AssetReclamationServiceEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public AssetReclamationServiceEntity():base("AssetReclamationServiceEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AssetReclamationServiceEntity(IEntityFields2 fields):base("AssetReclamationServiceEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AssetReclamationServiceEntity</param>
		public AssetReclamationServiceEntity(IValidator validator):base("AssetReclamationServiceEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AssetReclamationServiceEntity(System.Int32 assetReclamationServiceId):base("AssetReclamationServiceEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.AssetReclamationServiceId = assetReclamationServiceId;
		}

		/// <summary> CTor</summary>
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		/// <param name="validator">The custom validator object for this AssetReclamationServiceEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AssetReclamationServiceEntity(System.Int32 assetReclamationServiceId, IValidator validator):base("AssetReclamationServiceEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.AssetReclamationServiceId = assetReclamationServiceId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AssetReclamationServiceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_assetReclamationServiceChangeLog = (EntityCollection<AssetReclamationServiceChangeLogEntity>)info.GetValue("_assetReclamationServiceChangeLog", typeof(EntityCollection<AssetReclamationServiceChangeLogEntity>));
				_employeeCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaAssetReclamationServiceChangeLog", typeof(EntityCollection<EmployeeEntity>));
				_userCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaAssetReclamationServiceChangeLog", typeof(EntityCollection<UserEntity>));
				_serviceLocationAssetType = (ServiceLocationAssetTypeEntity)info.GetValue("_serviceLocationAssetType", typeof(ServiceLocationAssetTypeEntity));
				if(_serviceLocationAssetType!=null)
				{
					_serviceLocationAssetType.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_workOrderEmployee = (WorkOrderEmployeeEntity)info.GetValue("_workOrderEmployee", typeof(WorkOrderEmployeeEntity));
				if(_workOrderEmployee!=null)
				{
					_workOrderEmployee.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_workOrderServiceLocation = (WorkOrderServiceLocationEntity)info.GetValue("_workOrderServiceLocation", typeof(WorkOrderServiceLocationEntity));
				if(_workOrderServiceLocation!=null)
				{
					_workOrderServiceLocation.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((AssetReclamationServiceFieldIndex)fieldIndex)
			{
				case AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId:
					DesetupSyncWorkOrderEmployee(true, false);
					DesetupSyncWorkOrderServiceLocation(true, false);
					break;
				case AssetReclamationServiceFieldIndex.ServiceLocationAssetTypeId:
					DesetupSyncServiceLocationAssetType(true, false);
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
				case "ServiceLocationAssetType":
					this.ServiceLocationAssetType = (ServiceLocationAssetTypeEntity)entity;
					break;
				case "WorkOrderEmployee":
					this.WorkOrderEmployee = (WorkOrderEmployeeEntity)entity;
					break;
				case "WorkOrderServiceLocation":
					this.WorkOrderServiceLocation = (WorkOrderServiceLocationEntity)entity;
					break;
				case "AssetReclamationServiceChangeLog":
					this.AssetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)entity);
					break;
				case "EmployeeCollectionViaAssetReclamationServiceChangeLog":
					this.EmployeeCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = false;
					this.EmployeeCollectionViaAssetReclamationServiceChangeLog.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = true;
					break;
				case "UserCollectionViaAssetReclamationServiceChangeLog":
					this.UserCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = false;
					this.UserCollectionViaAssetReclamationServiceChangeLog.Add((UserEntity)entity);
					this.UserCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = true;
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
			return AssetReclamationServiceEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ServiceLocationAssetType":
					toReturn.Add(AssetReclamationServiceEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId);
					break;
				case "WorkOrderEmployee":
					toReturn.Add(AssetReclamationServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);
					break;
				case "WorkOrderServiceLocation":
					toReturn.Add(AssetReclamationServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);
					break;
				case "AssetReclamationServiceChangeLog":
					toReturn.Add(AssetReclamationServiceEntity.Relations.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId);
					break;
				case "EmployeeCollectionViaAssetReclamationServiceChangeLog":
					toReturn.Add(AssetReclamationServiceEntity.Relations.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId, "AssetReclamationServiceEntity__", "AssetReclamationServiceChangeLog_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, "AssetReclamationServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaAssetReclamationServiceChangeLog":
					toReturn.Add(AssetReclamationServiceEntity.Relations.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId, "AssetReclamationServiceEntity__", "AssetReclamationServiceChangeLog_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "AssetReclamationServiceChangeLog_", string.Empty, JoinHint.None);
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
				case "ServiceLocationAssetType":
					SetupSyncServiceLocationAssetType(relatedEntity);
					break;
				case "WorkOrderEmployee":
					SetupSyncWorkOrderEmployee(relatedEntity);
					break;
				case "WorkOrderServiceLocation":
					SetupSyncWorkOrderServiceLocation(relatedEntity);
					break;
				case "AssetReclamationServiceChangeLog":
					this.AssetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)relatedEntity);
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
				case "ServiceLocationAssetType":
					DesetupSyncServiceLocationAssetType(false, true);
					break;
				case "WorkOrderEmployee":
					DesetupSyncWorkOrderEmployee(false, true);
					break;
				case "WorkOrderServiceLocation":
					DesetupSyncWorkOrderServiceLocation(false, true);
					break;
				case "AssetReclamationServiceChangeLog":
					base.PerformRelatedEntityRemoval(this.AssetReclamationServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_serviceLocationAssetType!=null)
			{
				toReturn.Add(_serviceLocationAssetType);
			}
			if(_workOrderEmployee!=null)
			{
				toReturn.Add(_workOrderEmployee);
			}
			if(_workOrderServiceLocation!=null)
			{
				toReturn.Add(_workOrderServiceLocation);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.AssetReclamationServiceChangeLog);

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
				info.AddValue("_assetReclamationServiceChangeLog", ((_assetReclamationServiceChangeLog!=null) && (_assetReclamationServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_assetReclamationServiceChangeLog:null);
				info.AddValue("_employeeCollectionViaAssetReclamationServiceChangeLog", ((_employeeCollectionViaAssetReclamationServiceChangeLog!=null) && (_employeeCollectionViaAssetReclamationServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaAssetReclamationServiceChangeLog:null);
				info.AddValue("_userCollectionViaAssetReclamationServiceChangeLog", ((_userCollectionViaAssetReclamationServiceChangeLog!=null) && (_userCollectionViaAssetReclamationServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_userCollectionViaAssetReclamationServiceChangeLog:null);
				info.AddValue("_serviceLocationAssetType", (!this.MarkedForDeletion?_serviceLocationAssetType:null));
				info.AddValue("_workOrderEmployee", (!this.MarkedForDeletion?_workOrderEmployee:null));
				info.AddValue("_workOrderServiceLocation", (!this.MarkedForDeletion?_workOrderServiceLocation:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(AssetReclamationServiceFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(AssetReclamationServiceFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new AssetReclamationServiceRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AssetReclamationServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAssetReclamationServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AssetReclamationServiceChangeLogFields.AssetReclamationServiceId, null, ComparisonOperator.Equal, this.AssetReclamationServiceId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaAssetReclamationServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaAssetReclamationServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AssetReclamationServiceFields.AssetReclamationServiceId, null, ComparisonOperator.Equal, this.AssetReclamationServiceId, "AssetReclamationServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaAssetReclamationServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaAssetReclamationServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AssetReclamationServiceFields.AssetReclamationServiceId, null, ComparisonOperator.Equal, this.AssetReclamationServiceId, "AssetReclamationServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'ServiceLocationAssetType' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationAssetType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, null, ComparisonOperator.Equal, this.ServiceLocationAssetTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'WorkOrderEmployee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderEmployeeFields.WorkOrderEmployeeId, null, ComparisonOperator.Equal, this.WorkOrderServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'WorkOrderServiceLocation' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, null, ComparisonOperator.Equal, this.WorkOrderServiceLocationId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._assetReclamationServiceChangeLog);
			collectionsQueue.Enqueue(this._employeeCollectionViaAssetReclamationServiceChangeLog);
			collectionsQueue.Enqueue(this._userCollectionViaAssetReclamationServiceChangeLog);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._assetReclamationServiceChangeLog = (EntityCollection<AssetReclamationServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._assetReclamationServiceChangeLog != null)
			{
				return true;
			}
			if (this._employeeCollectionViaAssetReclamationServiceChangeLog != null)
			{
				return true;
			}
			if (this._userCollectionViaAssetReclamationServiceChangeLog != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AssetReclamationServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ServiceLocationAssetType", _serviceLocationAssetType);
			toReturn.Add("WorkOrderEmployee", _workOrderEmployee);
			toReturn.Add("WorkOrderServiceLocation", _workOrderServiceLocation);
			toReturn.Add("AssetReclamationServiceChangeLog", _assetReclamationServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaAssetReclamationServiceChangeLog", _employeeCollectionViaAssetReclamationServiceChangeLog);
			toReturn.Add("UserCollectionViaAssetReclamationServiceChangeLog", _userCollectionViaAssetReclamationServiceChangeLog);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_assetReclamationServiceChangeLog!=null)
			{
				_assetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaAssetReclamationServiceChangeLog!=null)
			{
				_employeeCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaAssetReclamationServiceChangeLog!=null)
			{
				_userCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationAssetType!=null)
			{
				_serviceLocationAssetType.ActiveContext = base.ActiveContext;
			}
			if(_workOrderEmployee!=null)
			{
				_workOrderEmployee.ActiveContext = base.ActiveContext;
			}
			if(_workOrderServiceLocation!=null)
			{
				_workOrderServiceLocation.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_assetReclamationServiceChangeLog = null;
			_employeeCollectionViaAssetReclamationServiceChangeLog = null;
			_userCollectionViaAssetReclamationServiceChangeLog = null;
			_serviceLocationAssetType = null;
			_workOrderEmployee = null;
			_workOrderServiceLocation = null;

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

			_fieldsCustomProperties.Add("AssetReclamationServiceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("WorkOrderServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceLocationAssetTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Quantity", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _serviceLocationAssetType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocationAssetType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocationAssetType, new PropertyChangedEventHandler( OnServiceLocationAssetTypePropertyChanged ), "ServiceLocationAssetType", AssetReclamationServiceEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, true, signalRelatedEntity, "AssetReclamationService", resetFKFields, new int[] { (int)AssetReclamationServiceFieldIndex.ServiceLocationAssetTypeId } );		
			_serviceLocationAssetType = null;
		}

		/// <summary> setups the sync logic for member _serviceLocationAssetType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncServiceLocationAssetType(IEntity2 relatedEntity)
		{
			if(_serviceLocationAssetType!=relatedEntity)
			{
				DesetupSyncServiceLocationAssetType(true, true);
				_serviceLocationAssetType = (ServiceLocationAssetTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceLocationAssetType, new PropertyChangedEventHandler( OnServiceLocationAssetTypePropertyChanged ), "ServiceLocationAssetType", AssetReclamationServiceEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnServiceLocationAssetTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _workOrderEmployee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrderEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", AssetReclamationServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "AssetReclamationService", resetFKFields, new int[] { (int)AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId } );		
			_workOrderEmployee = null;
		}

		/// <summary> setups the sync logic for member _workOrderEmployee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrderEmployee(IEntity2 relatedEntity)
		{
			if(_workOrderEmployee!=relatedEntity)
			{
				DesetupSyncWorkOrderEmployee(true, true);
				_workOrderEmployee = (WorkOrderEmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", AssetReclamationServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWorkOrderEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _workOrderServiceLocation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrderServiceLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", AssetReclamationServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "AssetReclamationService", resetFKFields, new int[] { (int)AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId } );		
			_workOrderServiceLocation = null;
		}

		/// <summary> setups the sync logic for member _workOrderServiceLocation</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrderServiceLocation(IEntity2 relatedEntity)
		{
			if(_workOrderServiceLocation!=relatedEntity)
			{
				DesetupSyncWorkOrderServiceLocation(true, true);
				_workOrderServiceLocation = (WorkOrderServiceLocationEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", AssetReclamationServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWorkOrderServiceLocationPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this AssetReclamationServiceEntity</param>
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
		public  static AssetReclamationServiceRelations Relations
		{
			get	{ return new AssetReclamationServiceRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AssetReclamationServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAssetReclamationServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AssetReclamationServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("AssetReclamationServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceChangeLogEntity, 0, null, null, null, null, "AssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = AssetReclamationServiceEntity.Relations.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAssetReclamationServiceChangeLog"), null, "EmployeeCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = AssetReclamationServiceEntity.Relations.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaAssetReclamationServiceChangeLog"), null, "UserCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationAssetType
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetType")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, null, null, "ServiceLocationAssetType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderEmployee
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("WorkOrderEmployee")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, null, null, "WorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderServiceLocation
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))),
					(IEntityRelation)GetRelationsForField("WorkOrderServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, null, null, "WorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return AssetReclamationServiceEntity.CustomProperties;}
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
			get { return AssetReclamationServiceEntity.FieldsCustomProperties;}
		}

		/// <summary> The AssetReclamationServiceId property of the Entity AssetReclamationService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetReclamationService"."AssetReclamationServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AssetReclamationServiceId
		{
			get { return (System.Int32)GetValue((int)AssetReclamationServiceFieldIndex.AssetReclamationServiceId, true); }
			set	{ SetValue((int)AssetReclamationServiceFieldIndex.AssetReclamationServiceId, value); }
		}

		/// <summary> The WorkOrderServiceLocationId property of the Entity AssetReclamationService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetReclamationService"."WorkOrderServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 WorkOrderServiceLocationId
		{
			get { return (System.Int32)GetValue((int)AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId, true); }
			set	{ SetValue((int)AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId, value); }
		}

		/// <summary> The ServiceLocationAssetTypeId property of the Entity AssetReclamationService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetReclamationService"."ServiceLocationAssetTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceLocationAssetTypeId
		{
			get { return (System.Int32)GetValue((int)AssetReclamationServiceFieldIndex.ServiceLocationAssetTypeId, true); }
			set	{ SetValue((int)AssetReclamationServiceFieldIndex.ServiceLocationAssetTypeId, value); }
		}

		/// <summary> The Quantity property of the Entity AssetReclamationService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetReclamationService"."Quantity"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Quantity
		{
			get { return (System.Int32)GetValue((int)AssetReclamationServiceFieldIndex.Quantity, true); }
			set	{ SetValue((int)AssetReclamationServiceFieldIndex.Quantity, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AssetReclamationServiceChangeLogEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AssetReclamationServiceChangeLogEntity))]
		public virtual EntityCollection<AssetReclamationServiceChangeLogEntity> AssetReclamationServiceChangeLog
		{
			get
			{
				if(_assetReclamationServiceChangeLog==null)
				{
					_assetReclamationServiceChangeLog = new EntityCollection<AssetReclamationServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceChangeLogEntityFactory)));
					_assetReclamationServiceChangeLog.SetContainingEntityInfo(this, "AssetReclamationService");
				}
				return _assetReclamationServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				if(_employeeCollectionViaAssetReclamationServiceChangeLog==null)
				{
					_employeeCollectionViaAssetReclamationServiceChangeLog = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaAssetReclamationServiceChangeLog.IsReadOnly=true;
				}
				return _employeeCollectionViaAssetReclamationServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				if(_userCollectionViaAssetReclamationServiceChangeLog==null)
				{
					_userCollectionViaAssetReclamationServiceChangeLog = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaAssetReclamationServiceChangeLog.IsReadOnly=true;
				}
				return _userCollectionViaAssetReclamationServiceChangeLog;
			}
		}

		/// <summary> Gets / sets related entity of type 'ServiceLocationAssetTypeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual ServiceLocationAssetTypeEntity ServiceLocationAssetType
		{
			get
			{
				return _serviceLocationAssetType;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncServiceLocationAssetType(value);
				}
				else
				{
					if(value==null)
					{
						if(_serviceLocationAssetType != null)
						{
							_serviceLocationAssetType.UnsetRelatedEntity(this, "AssetReclamationService");
						}
					}
					else
					{
						if(_serviceLocationAssetType!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "AssetReclamationService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'WorkOrderEmployeeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual WorkOrderEmployeeEntity WorkOrderEmployee
		{
			get
			{
				return _workOrderEmployee;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncWorkOrderEmployee(value);
				}
				else
				{
					if(value==null)
					{
						if(_workOrderEmployee != null)
						{
							_workOrderEmployee.UnsetRelatedEntity(this, "AssetReclamationService");
						}
					}
					else
					{
						if(_workOrderEmployee!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "AssetReclamationService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'WorkOrderServiceLocationEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual WorkOrderServiceLocationEntity WorkOrderServiceLocation
		{
			get
			{
				return _workOrderServiceLocation;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncWorkOrderServiceLocation(value);
				}
				else
				{
					if(value==null)
					{
						if(_workOrderServiceLocation != null)
						{
							_workOrderServiceLocation.UnsetRelatedEntity(this, "AssetReclamationService");
						}
					}
					else
					{
						if(_workOrderServiceLocation!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "AssetReclamationService");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity; }
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
