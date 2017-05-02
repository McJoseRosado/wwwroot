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
	/// Entity class which represents the entity 'WorkOrderServiceLocation'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class WorkOrderServiceLocationEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<AssetReclamationServiceEntity> _assetReclamationService;
		private EntityCollection<DeepFryerServiceEntity> _deepFryerService;
		private EntityCollection<RecycleServiceEntity> _recycleService;
		private EntityCollection<DeepFryerEntity> _deepFryerCollectionViaDeepFryerService;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaDeepFryerService;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaDeepFryerService;
		private EntityCollection<ServiceLocationAssetTypeEntity> _serviceLocationAssetTypeCollectionViaAssetReclamationService;
		private ServiceLocationEntity _serviceLocation;
		private WorkOrderEntity _workOrder;

		
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
			/// <summary>Member name AssetReclamationService</summary>
			public static readonly string AssetReclamationService = "AssetReclamationService";
			/// <summary>Member name DeepFryerService</summary>
			public static readonly string DeepFryerService = "DeepFryerService";
			/// <summary>Member name RecycleService</summary>
			public static readonly string RecycleService = "RecycleService";
			/// <summary>Member name DeepFryerCollectionViaDeepFryerService</summary>
			public static readonly string DeepFryerCollectionViaDeepFryerService = "DeepFryerCollectionViaDeepFryerService";
			/// <summary>Member name EmployeeCollectionViaDeepFryerService</summary>
			public static readonly string EmployeeCollectionViaDeepFryerService = "EmployeeCollectionViaDeepFryerService";
			/// <summary>Member name ServiceLocationCollectionViaDeepFryerService</summary>
			public static readonly string ServiceLocationCollectionViaDeepFryerService = "ServiceLocationCollectionViaDeepFryerService";
			/// <summary>Member name ServiceLocationAssetTypeCollectionViaAssetReclamationService</summary>
			public static readonly string ServiceLocationAssetTypeCollectionViaAssetReclamationService = "ServiceLocationAssetTypeCollectionViaAssetReclamationService";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static WorkOrderServiceLocationEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public WorkOrderServiceLocationEntity():base("WorkOrderServiceLocationEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public WorkOrderServiceLocationEntity(IEntityFields2 fields):base("WorkOrderServiceLocationEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this WorkOrderServiceLocationEntity</param>
		public WorkOrderServiceLocationEntity(IValidator validator):base("WorkOrderServiceLocationEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="workOrderServiceLocationId">PK value for WorkOrderServiceLocation which data should be fetched into this WorkOrderServiceLocation object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public WorkOrderServiceLocationEntity(System.Int32 workOrderServiceLocationId):base("WorkOrderServiceLocationEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.WorkOrderServiceLocationId = workOrderServiceLocationId;
		}

		/// <summary> CTor</summary>
		/// <param name="workOrderServiceLocationId">PK value for WorkOrderServiceLocation which data should be fetched into this WorkOrderServiceLocation object</param>
		/// <param name="validator">The custom validator object for this WorkOrderServiceLocationEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public WorkOrderServiceLocationEntity(System.Int32 workOrderServiceLocationId, IValidator validator):base("WorkOrderServiceLocationEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.WorkOrderServiceLocationId = workOrderServiceLocationId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected WorkOrderServiceLocationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_assetReclamationService = (EntityCollection<AssetReclamationServiceEntity>)info.GetValue("_assetReclamationService", typeof(EntityCollection<AssetReclamationServiceEntity>));
				_deepFryerService = (EntityCollection<DeepFryerServiceEntity>)info.GetValue("_deepFryerService", typeof(EntityCollection<DeepFryerServiceEntity>));
				_recycleService = (EntityCollection<RecycleServiceEntity>)info.GetValue("_recycleService", typeof(EntityCollection<RecycleServiceEntity>));
				_deepFryerCollectionViaDeepFryerService = (EntityCollection<DeepFryerEntity>)info.GetValue("_deepFryerCollectionViaDeepFryerService", typeof(EntityCollection<DeepFryerEntity>));
				_employeeCollectionViaDeepFryerService = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaDeepFryerService", typeof(EntityCollection<EmployeeEntity>));
				_serviceLocationCollectionViaDeepFryerService = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaDeepFryerService", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationAssetTypeCollectionViaAssetReclamationService = (EntityCollection<ServiceLocationAssetTypeEntity>)info.GetValue("_serviceLocationAssetTypeCollectionViaAssetReclamationService", typeof(EntityCollection<ServiceLocationAssetTypeEntity>));
				_serviceLocation = (ServiceLocationEntity)info.GetValue("_serviceLocation", typeof(ServiceLocationEntity));
				if(_serviceLocation!=null)
				{
					_serviceLocation.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_workOrder = (WorkOrderEntity)info.GetValue("_workOrder", typeof(WorkOrderEntity));
				if(_workOrder!=null)
				{
					_workOrder.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((WorkOrderServiceLocationFieldIndex)fieldIndex)
			{
				case WorkOrderServiceLocationFieldIndex.WorkOrderId:
					DesetupSyncWorkOrder(true, false);
					break;
				case WorkOrderServiceLocationFieldIndex.ServiceLocationId:
					DesetupSyncServiceLocation(true, false);
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
				case "ServiceLocation":
					this.ServiceLocation = (ServiceLocationEntity)entity;
					break;
				case "WorkOrder":
					this.WorkOrder = (WorkOrderEntity)entity;
					break;
				case "AssetReclamationService":
					this.AssetReclamationService.Add((AssetReclamationServiceEntity)entity);
					break;
				case "DeepFryerService":
					this.DeepFryerService.Add((DeepFryerServiceEntity)entity);
					break;
				case "RecycleService":
					this.RecycleService.Add((RecycleServiceEntity)entity);
					break;
				case "DeepFryerCollectionViaDeepFryerService":
					this.DeepFryerCollectionViaDeepFryerService.IsReadOnly = false;
					this.DeepFryerCollectionViaDeepFryerService.Add((DeepFryerEntity)entity);
					this.DeepFryerCollectionViaDeepFryerService.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaDeepFryerService":
					this.EmployeeCollectionViaDeepFryerService.IsReadOnly = false;
					this.EmployeeCollectionViaDeepFryerService.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaDeepFryerService.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaDeepFryerService":
					this.ServiceLocationCollectionViaDeepFryerService.IsReadOnly = false;
					this.ServiceLocationCollectionViaDeepFryerService.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaDeepFryerService.IsReadOnly = true;
					break;
				case "ServiceLocationAssetTypeCollectionViaAssetReclamationService":
					this.ServiceLocationAssetTypeCollectionViaAssetReclamationService.IsReadOnly = false;
					this.ServiceLocationAssetTypeCollectionViaAssetReclamationService.Add((ServiceLocationAssetTypeEntity)entity);
					this.ServiceLocationAssetTypeCollectionViaAssetReclamationService.IsReadOnly = true;
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
			return WorkOrderServiceLocationEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.ServiceLocationEntityUsingServiceLocationId);
					break;
				case "WorkOrder":
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.WorkOrderEntityUsingWorkOrderId);
					break;
				case "AssetReclamationService":
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.AssetReclamationServiceEntityUsingWorkOrderServiceLocationId);
					break;
				case "DeepFryerService":
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId);
					break;
				case "RecycleService":
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.RecycleServiceEntityUsingWorkOrderServiceLocationId);
					break;
				case "DeepFryerCollectionViaDeepFryerService":
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId, "WorkOrderServiceLocationEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerService":
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId, "WorkOrderServiceLocationEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaDeepFryerService":
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId, "WorkOrderServiceLocationEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationAssetTypeCollectionViaAssetReclamationService":
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.AssetReclamationServiceEntityUsingWorkOrderServiceLocationId, "WorkOrderServiceLocationEntity__", "AssetReclamationService_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, "AssetReclamationService_", string.Empty, JoinHint.None);
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
					SetupSyncServiceLocation(relatedEntity);
					break;
				case "WorkOrder":
					SetupSyncWorkOrder(relatedEntity);
					break;
				case "AssetReclamationService":
					this.AssetReclamationService.Add((AssetReclamationServiceEntity)relatedEntity);
					break;
				case "DeepFryerService":
					this.DeepFryerService.Add((DeepFryerServiceEntity)relatedEntity);
					break;
				case "RecycleService":
					this.RecycleService.Add((RecycleServiceEntity)relatedEntity);
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
					DesetupSyncServiceLocation(false, true);
					break;
				case "WorkOrder":
					DesetupSyncWorkOrder(false, true);
					break;
				case "AssetReclamationService":
					base.PerformRelatedEntityRemoval(this.AssetReclamationService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerService":
					base.PerformRelatedEntityRemoval(this.DeepFryerService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleService":
					base.PerformRelatedEntityRemoval(this.RecycleService, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_serviceLocation!=null)
			{
				toReturn.Add(_serviceLocation);
			}
			if(_workOrder!=null)
			{
				toReturn.Add(_workOrder);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.AssetReclamationService);
			toReturn.Add(this.DeepFryerService);
			toReturn.Add(this.RecycleService);

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
				info.AddValue("_deepFryerService", ((_deepFryerService!=null) && (_deepFryerService.Count>0) && !this.MarkedForDeletion)?_deepFryerService:null);
				info.AddValue("_recycleService", ((_recycleService!=null) && (_recycleService.Count>0) && !this.MarkedForDeletion)?_recycleService:null);
				info.AddValue("_deepFryerCollectionViaDeepFryerService", ((_deepFryerCollectionViaDeepFryerService!=null) && (_deepFryerCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_deepFryerCollectionViaDeepFryerService:null);
				info.AddValue("_employeeCollectionViaDeepFryerService", ((_employeeCollectionViaDeepFryerService!=null) && (_employeeCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaDeepFryerService:null);
				info.AddValue("_serviceLocationCollectionViaDeepFryerService", ((_serviceLocationCollectionViaDeepFryerService!=null) && (_serviceLocationCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaDeepFryerService:null);
				info.AddValue("_serviceLocationAssetTypeCollectionViaAssetReclamationService", ((_serviceLocationAssetTypeCollectionViaAssetReclamationService!=null) && (_serviceLocationAssetTypeCollectionViaAssetReclamationService.Count>0) && !this.MarkedForDeletion)?_serviceLocationAssetTypeCollectionViaAssetReclamationService:null);
				info.AddValue("_serviceLocation", (!this.MarkedForDeletion?_serviceLocation:null));
				info.AddValue("_workOrder", (!this.MarkedForDeletion?_workOrder:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(WorkOrderServiceLocationFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(WorkOrderServiceLocationFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new WorkOrderServiceLocationRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AssetReclamationService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAssetReclamationService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AssetReclamationServiceFields.WorkOrderServiceLocationId, null, ComparisonOperator.Equal, this.WorkOrderServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.WorkOrderServiceLocationId, null, ComparisonOperator.Equal, this.WorkOrderServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceFields.WorkOrderServiceLocationId, null, ComparisonOperator.Equal, this.WorkOrderServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryer' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DeepFryerCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, null, ComparisonOperator.Equal, this.WorkOrderServiceLocationId, "WorkOrderServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, null, ComparisonOperator.Equal, this.WorkOrderServiceLocationId, "WorkOrderServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, null, ComparisonOperator.Equal, this.WorkOrderServiceLocationId, "WorkOrderServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationAssetType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationAssetTypeCollectionViaAssetReclamationService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationAssetTypeCollectionViaAssetReclamationService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderServiceLocationFields.WorkOrderServiceLocationId, null, ComparisonOperator.Equal, this.WorkOrderServiceLocationId, "WorkOrderServiceLocationEntity__"));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'WorkOrder' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderFields.WorkOrderId, null, ComparisonOperator.Equal, this.WorkOrderId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._assetReclamationService);
			collectionsQueue.Enqueue(this._deepFryerService);
			collectionsQueue.Enqueue(this._recycleService);
			collectionsQueue.Enqueue(this._deepFryerCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._employeeCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._serviceLocationAssetTypeCollectionViaAssetReclamationService);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._assetReclamationService = (EntityCollection<AssetReclamationServiceEntity>) collectionsQueue.Dequeue();
			this._deepFryerService = (EntityCollection<DeepFryerServiceEntity>) collectionsQueue.Dequeue();
			this._recycleService = (EntityCollection<RecycleServiceEntity>) collectionsQueue.Dequeue();
			this._deepFryerCollectionViaDeepFryerService = (EntityCollection<DeepFryerEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaDeepFryerService = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaDeepFryerService = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationAssetTypeCollectionViaAssetReclamationService = (EntityCollection<ServiceLocationAssetTypeEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._assetReclamationService != null)
			{
				return true;
			}
			if (this._deepFryerService != null)
			{
				return true;
			}
			if (this._recycleService != null)
			{
				return true;
			}
			if (this._deepFryerCollectionViaDeepFryerService != null)
			{
				return true;
			}
			if (this._employeeCollectionViaDeepFryerService != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaDeepFryerService != null)
			{
				return true;
			}
			if (this._serviceLocationAssetTypeCollectionViaAssetReclamationService != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory))) : null);
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
			toReturn.Add("AssetReclamationService", _assetReclamationService);
			toReturn.Add("DeepFryerService", _deepFryerService);
			toReturn.Add("RecycleService", _recycleService);
			toReturn.Add("DeepFryerCollectionViaDeepFryerService", _deepFryerCollectionViaDeepFryerService);
			toReturn.Add("EmployeeCollectionViaDeepFryerService", _employeeCollectionViaDeepFryerService);
			toReturn.Add("ServiceLocationCollectionViaDeepFryerService", _serviceLocationCollectionViaDeepFryerService);
			toReturn.Add("ServiceLocationAssetTypeCollectionViaAssetReclamationService", _serviceLocationAssetTypeCollectionViaAssetReclamationService);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_assetReclamationService!=null)
			{
				_assetReclamationService.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerService!=null)
			{
				_deepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_recycleService!=null)
			{
				_recycleService.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerCollectionViaDeepFryerService!=null)
			{
				_deepFryerCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaDeepFryerService!=null)
			{
				_employeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaDeepFryerService!=null)
			{
				_serviceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationAssetTypeCollectionViaAssetReclamationService!=null)
			{
				_serviceLocationAssetTypeCollectionViaAssetReclamationService.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
			}
			if(_workOrder!=null)
			{
				_workOrder.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_assetReclamationService = null;
			_deepFryerService = null;
			_recycleService = null;
			_deepFryerCollectionViaDeepFryerService = null;
			_employeeCollectionViaDeepFryerService = null;
			_serviceLocationCollectionViaDeepFryerService = null;
			_serviceLocationAssetTypeCollectionViaAssetReclamationService = null;
			_serviceLocation = null;
			_workOrder = null;

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

			_fieldsCustomProperties.Add("WorkOrderServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("WorkOrderId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Notes", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("UncategorizedItems", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _serviceLocation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", WorkOrderServiceLocationEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, signalRelatedEntity, "WorkOrderServiceLocation", resetFKFields, new int[] { (int)WorkOrderServiceLocationFieldIndex.ServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", WorkOrderServiceLocationEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _workOrder</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrder(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", WorkOrderServiceLocationEntity.Relations.WorkOrderEntityUsingWorkOrderId, true, signalRelatedEntity, "WorkOrderServiceLocation", resetFKFields, new int[] { (int)WorkOrderServiceLocationFieldIndex.WorkOrderId } );		
			_workOrder = null;
		}

		/// <summary> setups the sync logic for member _workOrder</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrder(IEntity2 relatedEntity)
		{
			if(_workOrder!=relatedEntity)
			{
				DesetupSyncWorkOrder(true, true);
				_workOrder = (WorkOrderEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", WorkOrderServiceLocationEntity.Relations.WorkOrderEntityUsingWorkOrderId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWorkOrderPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this WorkOrderServiceLocationEntity</param>
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
		public  static WorkOrderServiceLocationRelations Relations
		{
			get	{ return new WorkOrderServiceLocationRelations(); }
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
					(IEntityRelation)GetRelationsForField("AssetReclamationService")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, 0, null, null, null, null, "AssetReclamationService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerService
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))),
					(IEntityRelation)GetRelationsForField("DeepFryerService")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, null, null, "DeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleService
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleService")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, null, null, "RecycleService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderServiceLocationEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, GetRelationsForField("DeepFryerCollectionViaDeepFryerService"), null, "DeepFryerCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderServiceLocationEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerService"), null, "EmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderServiceLocationEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerService"), null, "ServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationAssetTypeCollectionViaAssetReclamationService
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderServiceLocationEntity.Relations.AssetReclamationServiceEntityUsingWorkOrderServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationService_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, GetRelationsForField("ServiceLocationAssetTypeCollectionViaAssetReclamationService"), null, "ServiceLocationAssetTypeCollectionViaAssetReclamationService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrder
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))),
					(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return WorkOrderServiceLocationEntity.CustomProperties;}
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
			get { return WorkOrderServiceLocationEntity.FieldsCustomProperties;}
		}

		/// <summary> The WorkOrderServiceLocationId property of the Entity WorkOrderServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrderServiceLocation"."WorkOrderServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 WorkOrderServiceLocationId
		{
			get { return (System.Int32)GetValue((int)WorkOrderServiceLocationFieldIndex.WorkOrderServiceLocationId, true); }
			set	{ SetValue((int)WorkOrderServiceLocationFieldIndex.WorkOrderServiceLocationId, value); }
		}

		/// <summary> The WorkOrderId property of the Entity WorkOrderServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrderServiceLocation"."WorkOrderId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 WorkOrderId
		{
			get { return (System.Int32)GetValue((int)WorkOrderServiceLocationFieldIndex.WorkOrderId, true); }
			set	{ SetValue((int)WorkOrderServiceLocationFieldIndex.WorkOrderId, value); }
		}

		/// <summary> The ServiceLocationId property of the Entity WorkOrderServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrderServiceLocation"."ServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceLocationId
		{
			get { return (System.Int32)GetValue((int)WorkOrderServiceLocationFieldIndex.ServiceLocationId, true); }
			set	{ SetValue((int)WorkOrderServiceLocationFieldIndex.ServiceLocationId, value); }
		}

		/// <summary> The Notes property of the Entity WorkOrderServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrderServiceLocation"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)WorkOrderServiceLocationFieldIndex.Notes, true); }
			set	{ SetValue((int)WorkOrderServiceLocationFieldIndex.Notes, value); }
		}

		/// <summary> The UncategorizedItems property of the Entity WorkOrderServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrderServiceLocation"."UncategorizedItems"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String UncategorizedItems
		{
			get { return (System.String)GetValue((int)WorkOrderServiceLocationFieldIndex.UncategorizedItems, true); }
			set	{ SetValue((int)WorkOrderServiceLocationFieldIndex.UncategorizedItems, value); }
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
					_assetReclamationService.SetContainingEntityInfo(this, "WorkOrderServiceLocation");
				}
				return _assetReclamationService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerServiceEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerServiceEntity))]
		public virtual EntityCollection<DeepFryerServiceEntity> DeepFryerService
		{
			get
			{
				if(_deepFryerService==null)
				{
					_deepFryerService = new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory)));
					_deepFryerService.SetContainingEntityInfo(this, "WorkOrderServiceLocation");
				}
				return _deepFryerService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceEntity))]
		public virtual EntityCollection<RecycleServiceEntity> RecycleService
		{
			get
			{
				if(_recycleService==null)
				{
					_recycleService = new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory)));
					_recycleService.SetContainingEntityInfo(this, "WorkOrderServiceLocation");
				}
				return _recycleService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerEntity))]
		public virtual EntityCollection<DeepFryerEntity> DeepFryerCollectionViaDeepFryerService
		{
			get
			{
				if(_deepFryerCollectionViaDeepFryerService==null)
				{
					_deepFryerCollectionViaDeepFryerService = new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory)));
					_deepFryerCollectionViaDeepFryerService.IsReadOnly=true;
				}
				return _deepFryerCollectionViaDeepFryerService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaDeepFryerService
		{
			get
			{
				if(_employeeCollectionViaDeepFryerService==null)
				{
					_employeeCollectionViaDeepFryerService = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaDeepFryerService.IsReadOnly=true;
				}
				return _employeeCollectionViaDeepFryerService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				if(_serviceLocationCollectionViaDeepFryerService==null)
				{
					_serviceLocationCollectionViaDeepFryerService = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaDeepFryerService.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaDeepFryerService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationAssetTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationAssetTypeEntity))]
		public virtual EntityCollection<ServiceLocationAssetTypeEntity> ServiceLocationAssetTypeCollectionViaAssetReclamationService
		{
			get
			{
				if(_serviceLocationAssetTypeCollectionViaAssetReclamationService==null)
				{
					_serviceLocationAssetTypeCollectionViaAssetReclamationService = new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory)));
					_serviceLocationAssetTypeCollectionViaAssetReclamationService.IsReadOnly=true;
				}
				return _serviceLocationAssetTypeCollectionViaAssetReclamationService;
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
							_serviceLocation.UnsetRelatedEntity(this, "WorkOrderServiceLocation");
						}
					}
					else
					{
						if(_serviceLocation!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "WorkOrderServiceLocation");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'WorkOrderEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual WorkOrderEntity WorkOrder
		{
			get
			{
				return _workOrder;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncWorkOrder(value);
				}
				else
				{
					if(value==null)
					{
						if(_workOrder != null)
						{
							_workOrder.UnsetRelatedEntity(this, "WorkOrderServiceLocation");
						}
					}
					else
					{
						if(_workOrder!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "WorkOrderServiceLocation");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity; }
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
