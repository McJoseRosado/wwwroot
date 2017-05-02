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
	/// Entity class which represents the entity 'ServiceLocationAssetType'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ServiceLocationAssetTypeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<AssetReclamationServiceEntity> _assetReclamationService;
		private EntityCollection<ServiceLocationAssetTypeChangeLogEntity> _serviceLocationAssetTypeChangeLog;
		private EntityCollection<ChangeLogEntity> _changeLogCollectionViaServiceLocationAssetTypeChangeLog;
		private EntityCollection<WorkOrderEmployeeEntity> _workOrderEmployeeCollectionViaAssetReclamationService;
		private EntityCollection<WorkOrderServiceLocationEntity> _workOrderServiceLocationCollectionViaAssetReclamationService;
		private AssetTypeEntity _assetType;
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
			/// <summary>Member name AssetType</summary>
			public static readonly string AssetType = "AssetType";
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name AssetReclamationService</summary>
			public static readonly string AssetReclamationService = "AssetReclamationService";
			/// <summary>Member name ServiceLocationAssetTypeChangeLog</summary>
			public static readonly string ServiceLocationAssetTypeChangeLog = "ServiceLocationAssetTypeChangeLog";
			/// <summary>Member name ChangeLogCollectionViaServiceLocationAssetTypeChangeLog</summary>
			public static readonly string ChangeLogCollectionViaServiceLocationAssetTypeChangeLog = "ChangeLogCollectionViaServiceLocationAssetTypeChangeLog";
			/// <summary>Member name WorkOrderEmployeeCollectionViaAssetReclamationService</summary>
			public static readonly string WorkOrderEmployeeCollectionViaAssetReclamationService = "WorkOrderEmployeeCollectionViaAssetReclamationService";
			/// <summary>Member name WorkOrderServiceLocationCollectionViaAssetReclamationService</summary>
			public static readonly string WorkOrderServiceLocationCollectionViaAssetReclamationService = "WorkOrderServiceLocationCollectionViaAssetReclamationService";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ServiceLocationAssetTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public ServiceLocationAssetTypeEntity():base("ServiceLocationAssetTypeEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ServiceLocationAssetTypeEntity(IEntityFields2 fields):base("ServiceLocationAssetTypeEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ServiceLocationAssetTypeEntity</param>
		public ServiceLocationAssetTypeEntity(IValidator validator):base("ServiceLocationAssetTypeEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ServiceLocationAssetTypeEntity(System.Int32 serviceLocationAssetTypeId):base("ServiceLocationAssetTypeEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.ServiceLocationAssetTypeId = serviceLocationAssetTypeId;
		}

		/// <summary> CTor</summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		/// <param name="validator">The custom validator object for this ServiceLocationAssetTypeEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ServiceLocationAssetTypeEntity(System.Int32 serviceLocationAssetTypeId, IValidator validator):base("ServiceLocationAssetTypeEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.ServiceLocationAssetTypeId = serviceLocationAssetTypeId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ServiceLocationAssetTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_assetReclamationService = (EntityCollection<AssetReclamationServiceEntity>)info.GetValue("_assetReclamationService", typeof(EntityCollection<AssetReclamationServiceEntity>));
				_serviceLocationAssetTypeChangeLog = (EntityCollection<ServiceLocationAssetTypeChangeLogEntity>)info.GetValue("_serviceLocationAssetTypeChangeLog", typeof(EntityCollection<ServiceLocationAssetTypeChangeLogEntity>));
				_changeLogCollectionViaServiceLocationAssetTypeChangeLog = (EntityCollection<ChangeLogEntity>)info.GetValue("_changeLogCollectionViaServiceLocationAssetTypeChangeLog", typeof(EntityCollection<ChangeLogEntity>));
				_workOrderEmployeeCollectionViaAssetReclamationService = (EntityCollection<WorkOrderEmployeeEntity>)info.GetValue("_workOrderEmployeeCollectionViaAssetReclamationService", typeof(EntityCollection<WorkOrderEmployeeEntity>));
				_workOrderServiceLocationCollectionViaAssetReclamationService = (EntityCollection<WorkOrderServiceLocationEntity>)info.GetValue("_workOrderServiceLocationCollectionViaAssetReclamationService", typeof(EntityCollection<WorkOrderServiceLocationEntity>));
				_assetType = (AssetTypeEntity)info.GetValue("_assetType", typeof(AssetTypeEntity));
				if(_assetType!=null)
				{
					_assetType.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((ServiceLocationAssetTypeFieldIndex)fieldIndex)
			{
				case ServiceLocationAssetTypeFieldIndex.ServiceLocationId:
					DesetupSyncServiceLocation(true, false);
					break;
				case ServiceLocationAssetTypeFieldIndex.AssetTypeId:
					DesetupSyncAssetType(true, false);
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
				case "AssetType":
					this.AssetType = (AssetTypeEntity)entity;
					break;
				case "ServiceLocation":
					this.ServiceLocation = (ServiceLocationEntity)entity;
					break;
				case "AssetReclamationService":
					this.AssetReclamationService.Add((AssetReclamationServiceEntity)entity);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					this.ServiceLocationAssetTypeChangeLog.Add((ServiceLocationAssetTypeChangeLogEntity)entity);
					break;
				case "ChangeLogCollectionViaServiceLocationAssetTypeChangeLog":
					this.ChangeLogCollectionViaServiceLocationAssetTypeChangeLog.IsReadOnly = false;
					this.ChangeLogCollectionViaServiceLocationAssetTypeChangeLog.Add((ChangeLogEntity)entity);
					this.ChangeLogCollectionViaServiceLocationAssetTypeChangeLog.IsReadOnly = true;
					break;
				case "WorkOrderEmployeeCollectionViaAssetReclamationService":
					this.WorkOrderEmployeeCollectionViaAssetReclamationService.IsReadOnly = false;
					this.WorkOrderEmployeeCollectionViaAssetReclamationService.Add((WorkOrderEmployeeEntity)entity);
					this.WorkOrderEmployeeCollectionViaAssetReclamationService.IsReadOnly = true;
					break;
				case "WorkOrderServiceLocationCollectionViaAssetReclamationService":
					this.WorkOrderServiceLocationCollectionViaAssetReclamationService.IsReadOnly = false;
					this.WorkOrderServiceLocationCollectionViaAssetReclamationService.Add((WorkOrderServiceLocationEntity)entity);
					this.WorkOrderServiceLocationCollectionViaAssetReclamationService.IsReadOnly = true;
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
			return ServiceLocationAssetTypeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "AssetType":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.AssetTypeEntityUsingAssetTypeId);
					break;
				case "ServiceLocation":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.ServiceLocationEntityUsingServiceLocationId);
					break;
				case "AssetReclamationService":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingServiceLocationAssetTypeId);
					break;
				case "ChangeLogCollectionViaServiceLocationAssetTypeChangeLog":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__", "ServiceLocationAssetTypeChangeLog_", JoinHint.None);
					toReturn.Add(ServiceLocationAssetTypeChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId, "ServiceLocationAssetTypeChangeLog_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderEmployeeCollectionViaAssetReclamationService":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__", "AssetReclamationService_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, "AssetReclamationService_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderServiceLocationCollectionViaAssetReclamationService":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__", "AssetReclamationService_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, "AssetReclamationService_", string.Empty, JoinHint.None);
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
				case "AssetType":
					SetupSyncAssetType(relatedEntity);
					break;
				case "ServiceLocation":
					SetupSyncServiceLocation(relatedEntity);
					break;
				case "AssetReclamationService":
					this.AssetReclamationService.Add((AssetReclamationServiceEntity)relatedEntity);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					this.ServiceLocationAssetTypeChangeLog.Add((ServiceLocationAssetTypeChangeLogEntity)relatedEntity);
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
				case "AssetType":
					DesetupSyncAssetType(false, true);
					break;
				case "ServiceLocation":
					DesetupSyncServiceLocation(false, true);
					break;
				case "AssetReclamationService":
					base.PerformRelatedEntityRemoval(this.AssetReclamationService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					base.PerformRelatedEntityRemoval(this.ServiceLocationAssetTypeChangeLog, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_assetType!=null)
			{
				toReturn.Add(_assetType);
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
			toReturn.Add(this.AssetReclamationService);
			toReturn.Add(this.ServiceLocationAssetTypeChangeLog);

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
				info.AddValue("_assetReclamationService", ((_assetReclamationService!=null) && (_assetReclamationService.Count>0) && !this.MarkedForDeletion)?_assetReclamationService:null);
				info.AddValue("_serviceLocationAssetTypeChangeLog", ((_serviceLocationAssetTypeChangeLog!=null) && (_serviceLocationAssetTypeChangeLog.Count>0) && !this.MarkedForDeletion)?_serviceLocationAssetTypeChangeLog:null);
				info.AddValue("_changeLogCollectionViaServiceLocationAssetTypeChangeLog", ((_changeLogCollectionViaServiceLocationAssetTypeChangeLog!=null) && (_changeLogCollectionViaServiceLocationAssetTypeChangeLog.Count>0) && !this.MarkedForDeletion)?_changeLogCollectionViaServiceLocationAssetTypeChangeLog:null);
				info.AddValue("_workOrderEmployeeCollectionViaAssetReclamationService", ((_workOrderEmployeeCollectionViaAssetReclamationService!=null) && (_workOrderEmployeeCollectionViaAssetReclamationService.Count>0) && !this.MarkedForDeletion)?_workOrderEmployeeCollectionViaAssetReclamationService:null);
				info.AddValue("_workOrderServiceLocationCollectionViaAssetReclamationService", ((_workOrderServiceLocationCollectionViaAssetReclamationService!=null) && (_workOrderServiceLocationCollectionViaAssetReclamationService.Count>0) && !this.MarkedForDeletion)?_workOrderServiceLocationCollectionViaAssetReclamationService:null);
				info.AddValue("_assetType", (!this.MarkedForDeletion?_assetType:null));
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
		public bool TestOriginalFieldValueForNull(ServiceLocationAssetTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ServiceLocationAssetTypeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ServiceLocationAssetTypeRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AssetReclamationService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAssetReclamationService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AssetReclamationServiceFields.ServiceLocationAssetTypeId, null, ComparisonOperator.Equal, this.ServiceLocationAssetTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationAssetTypeChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationAssetTypeChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeChangeLogFields.ServiceLocationAssetTypeId, null, ComparisonOperator.Equal, this.ServiceLocationAssetTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoChangeLogCollectionViaServiceLocationAssetTypeChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ChangeLogCollectionViaServiceLocationAssetTypeChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, null, ComparisonOperator.Equal, this.ServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderEmployee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderEmployeeCollectionViaAssetReclamationService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WorkOrderEmployeeCollectionViaAssetReclamationService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, null, ComparisonOperator.Equal, this.ServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderServiceLocationCollectionViaAssetReclamationService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WorkOrderServiceLocationCollectionViaAssetReclamationService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, null, ComparisonOperator.Equal, this.ServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'AssetType' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAssetType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AssetTypeFields.AssetTypeId, null, ComparisonOperator.Equal, this.AssetTypeId));
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._assetReclamationService);
			collectionsQueue.Enqueue(this._serviceLocationAssetTypeChangeLog);
			collectionsQueue.Enqueue(this._changeLogCollectionViaServiceLocationAssetTypeChangeLog);
			collectionsQueue.Enqueue(this._workOrderEmployeeCollectionViaAssetReclamationService);
			collectionsQueue.Enqueue(this._workOrderServiceLocationCollectionViaAssetReclamationService);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._assetReclamationService = (EntityCollection<AssetReclamationServiceEntity>) collectionsQueue.Dequeue();
			this._serviceLocationAssetTypeChangeLog = (EntityCollection<ServiceLocationAssetTypeChangeLogEntity>) collectionsQueue.Dequeue();
			this._changeLogCollectionViaServiceLocationAssetTypeChangeLog = (EntityCollection<ChangeLogEntity>) collectionsQueue.Dequeue();
			this._workOrderEmployeeCollectionViaAssetReclamationService = (EntityCollection<WorkOrderEmployeeEntity>) collectionsQueue.Dequeue();
			this._workOrderServiceLocationCollectionViaAssetReclamationService = (EntityCollection<WorkOrderServiceLocationEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._assetReclamationService != null)
			{
				return true;
			}
			if (this._serviceLocationAssetTypeChangeLog != null)
			{
				return true;
			}
			if (this._changeLogCollectionViaServiceLocationAssetTypeChangeLog != null)
			{
				return true;
			}
			if (this._workOrderEmployeeCollectionViaAssetReclamationService != null)
			{
				return true;
			}
			if (this._workOrderServiceLocationCollectionViaAssetReclamationService != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AssetReclamationServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationAssetTypeChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))) : null);
		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AssetType", _assetType);
			toReturn.Add("ServiceLocation", _serviceLocation);
			toReturn.Add("AssetReclamationService", _assetReclamationService);
			toReturn.Add("ServiceLocationAssetTypeChangeLog", _serviceLocationAssetTypeChangeLog);
			toReturn.Add("ChangeLogCollectionViaServiceLocationAssetTypeChangeLog", _changeLogCollectionViaServiceLocationAssetTypeChangeLog);
			toReturn.Add("WorkOrderEmployeeCollectionViaAssetReclamationService", _workOrderEmployeeCollectionViaAssetReclamationService);
			toReturn.Add("WorkOrderServiceLocationCollectionViaAssetReclamationService", _workOrderServiceLocationCollectionViaAssetReclamationService);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_assetReclamationService!=null)
			{
				_assetReclamationService.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationAssetTypeChangeLog!=null)
			{
				_serviceLocationAssetTypeChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_changeLogCollectionViaServiceLocationAssetTypeChangeLog!=null)
			{
				_changeLogCollectionViaServiceLocationAssetTypeChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_workOrderEmployeeCollectionViaAssetReclamationService!=null)
			{
				_workOrderEmployeeCollectionViaAssetReclamationService.ActiveContext = base.ActiveContext;
			}
			if(_workOrderServiceLocationCollectionViaAssetReclamationService!=null)
			{
				_workOrderServiceLocationCollectionViaAssetReclamationService.ActiveContext = base.ActiveContext;
			}
			if(_assetType!=null)
			{
				_assetType.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_assetReclamationService = null;
			_serviceLocationAssetTypeChangeLog = null;
			_changeLogCollectionViaServiceLocationAssetTypeChangeLog = null;
			_workOrderEmployeeCollectionViaAssetReclamationService = null;
			_workOrderServiceLocationCollectionViaAssetReclamationService = null;
			_assetType = null;
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

			_fieldsCustomProperties.Add("ServiceLocationAssetTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AssetTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("PricePerUnit", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _assetType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAssetType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _assetType, new PropertyChangedEventHandler( OnAssetTypePropertyChanged ), "AssetType", ServiceLocationAssetTypeEntity.Relations.AssetTypeEntityUsingAssetTypeId, true, signalRelatedEntity, "ServiceLocationAssetTypeId", resetFKFields, new int[] { (int)ServiceLocationAssetTypeFieldIndex.AssetTypeId } );		
			_assetType = null;
		}

		/// <summary> setups the sync logic for member _assetType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAssetType(IEntity2 relatedEntity)
		{
			if(_assetType!=relatedEntity)
			{
				DesetupSyncAssetType(true, true);
				_assetType = (AssetTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _assetType, new PropertyChangedEventHandler( OnAssetTypePropertyChanged ), "AssetType", ServiceLocationAssetTypeEntity.Relations.AssetTypeEntityUsingAssetTypeId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAssetTypePropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", ServiceLocationAssetTypeEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, signalRelatedEntity, "ServiceLocationAssetType", resetFKFields, new int[] { (int)ServiceLocationAssetTypeFieldIndex.ServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", ServiceLocationAssetTypeEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, new string[] {  } );
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
		/// <param name="validator">The validator object for this ServiceLocationAssetTypeEntity</param>
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
		public  static ServiceLocationAssetTypeRelations Relations
		{
			get	{ return new ServiceLocationAssetTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AssetReclamationService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAssetReclamationService
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AssetReclamationServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceEntityFactory))),
					(IEntityRelation)GetRelationsForField("AssetReclamationService")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, 0, null, null, null, null, "AssetReclamationService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetTypeChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationAssetTypeChangeLog
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationAssetTypeChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetTypeChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity, 0, null, null, null, null, "ServiceLocationAssetTypeChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathChangeLogCollectionViaServiceLocationAssetTypeChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationAssetTypeEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingServiceLocationAssetTypeId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationAssetTypeChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<ChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, 0, null, null, GetRelationsForField("ChangeLogCollectionViaServiceLocationAssetTypeChangeLog"), null, "ChangeLogCollectionViaServiceLocationAssetTypeChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderEmployeeCollectionViaAssetReclamationService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationAssetTypeEntity.Relations.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationService_");
				return new PrefetchPathElement2(new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, GetRelationsForField("WorkOrderEmployeeCollectionViaAssetReclamationService"), null, "WorkOrderEmployeeCollectionViaAssetReclamationService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderServiceLocationCollectionViaAssetReclamationService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationAssetTypeEntity.Relations.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationService_");
				return new PrefetchPathElement2(new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, GetRelationsForField("WorkOrderServiceLocationCollectionViaAssetReclamationService"), null, "WorkOrderServiceLocationCollectionViaAssetReclamationService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAssetType
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AssetTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("AssetType")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity, 0, null, null, null, null, "AssetType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ServiceLocationAssetTypeEntity.CustomProperties;}
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
			get { return ServiceLocationAssetTypeEntity.FieldsCustomProperties;}
		}

		/// <summary> The ServiceLocationAssetTypeId property of the Entity ServiceLocationAssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetType"."ServiceLocationAssetTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ServiceLocationAssetTypeId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeFieldIndex.ServiceLocationAssetTypeId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeFieldIndex.ServiceLocationAssetTypeId, value); }
		}

		/// <summary> The ServiceLocationId property of the Entity ServiceLocationAssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetType"."ServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceLocationId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeFieldIndex.ServiceLocationId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeFieldIndex.ServiceLocationId, value); }
		}

		/// <summary> The AssetTypeId property of the Entity ServiceLocationAssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetType"."AssetTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AssetTypeId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeFieldIndex.AssetTypeId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeFieldIndex.AssetTypeId, value); }
		}

		/// <summary> The PricePerUnit property of the Entity ServiceLocationAssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetType"."PricePerUnit"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal PricePerUnit
		{
			get { return (System.Decimal)GetValue((int)ServiceLocationAssetTypeFieldIndex.PricePerUnit, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeFieldIndex.PricePerUnit, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AssetReclamationServiceEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AssetReclamationServiceEntity))]
		public virtual EntityCollection<AssetReclamationServiceEntity> AssetReclamationService
		{
			get
			{
				if(_assetReclamationService==null)
				{
					_assetReclamationService = new EntityCollection<AssetReclamationServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceEntityFactory)));
					_assetReclamationService.SetContainingEntityInfo(this, "ServiceLocationAssetType");
				}
				return _assetReclamationService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationAssetTypeChangeLogEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationAssetTypeChangeLogEntity))]
		public virtual EntityCollection<ServiceLocationAssetTypeChangeLogEntity> ServiceLocationAssetTypeChangeLog
		{
			get
			{
				if(_serviceLocationAssetTypeChangeLog==null)
				{
					_serviceLocationAssetTypeChangeLog = new EntityCollection<ServiceLocationAssetTypeChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeChangeLogEntityFactory)));
					_serviceLocationAssetTypeChangeLog.SetContainingEntityInfo(this, "ServiceLocationAssetType");
				}
				return _serviceLocationAssetTypeChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ChangeLogEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ChangeLogEntity))]
		public virtual EntityCollection<ChangeLogEntity> ChangeLogCollectionViaServiceLocationAssetTypeChangeLog
		{
			get
			{
				if(_changeLogCollectionViaServiceLocationAssetTypeChangeLog==null)
				{
					_changeLogCollectionViaServiceLocationAssetTypeChangeLog = new EntityCollection<ChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory)));
					_changeLogCollectionViaServiceLocationAssetTypeChangeLog.IsReadOnly=true;
				}
				return _changeLogCollectionViaServiceLocationAssetTypeChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderEmployeeEntity))]
		public virtual EntityCollection<WorkOrderEmployeeEntity> WorkOrderEmployeeCollectionViaAssetReclamationService
		{
			get
			{
				if(_workOrderEmployeeCollectionViaAssetReclamationService==null)
				{
					_workOrderEmployeeCollectionViaAssetReclamationService = new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory)));
					_workOrderEmployeeCollectionViaAssetReclamationService.IsReadOnly=true;
				}
				return _workOrderEmployeeCollectionViaAssetReclamationService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderServiceLocationEntity))]
		public virtual EntityCollection<WorkOrderServiceLocationEntity> WorkOrderServiceLocationCollectionViaAssetReclamationService
		{
			get
			{
				if(_workOrderServiceLocationCollectionViaAssetReclamationService==null)
				{
					_workOrderServiceLocationCollectionViaAssetReclamationService = new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory)));
					_workOrderServiceLocationCollectionViaAssetReclamationService.IsReadOnly=true;
				}
				return _workOrderServiceLocationCollectionViaAssetReclamationService;
			}
		}

		/// <summary> Gets / sets related entity of type 'AssetTypeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual AssetTypeEntity AssetType
		{
			get
			{
				return _assetType;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAssetType(value);
				}
				else
				{
					if(value==null)
					{
						if(_assetType != null)
						{
							_assetType.UnsetRelatedEntity(this, "ServiceLocationAssetTypeId");
						}
					}
					else
					{
						if(_assetType!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationAssetTypeId");
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
							_serviceLocation.UnsetRelatedEntity(this, "ServiceLocationAssetType");
						}
					}
					else
					{
						if(_serviceLocation!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationAssetType");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity; }
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
