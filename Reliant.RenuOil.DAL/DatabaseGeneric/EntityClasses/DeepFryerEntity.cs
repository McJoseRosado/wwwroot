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
	/// Entity class which represents the entity 'DeepFryer'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DeepFryerEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<DeepFryerChangeLogEntity> _deepFryerChangeLog;
		private EntityCollection<DeepFryerServiceEntity> _deepFryerService;
		private EntityCollection<ChangeLogEntity> _changeLogCollectionViaDeepFryerChangeLog;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaDeepFryerService;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaDeepFryerService;
		private EntityCollection<WorkOrderEmployeeEntity> _workOrderEmployeeCollectionViaDeepFryerService;
		private EntityCollection<WorkOrderServiceLocationEntity> _workOrderServiceLocationCollectionViaDeepFryerService;
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
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name DeepFryerChangeLog</summary>
			public static readonly string DeepFryerChangeLog = "DeepFryerChangeLog";
			/// <summary>Member name DeepFryerService</summary>
			public static readonly string DeepFryerService = "DeepFryerService";
			/// <summary>Member name ChangeLogCollectionViaDeepFryerChangeLog</summary>
			public static readonly string ChangeLogCollectionViaDeepFryerChangeLog = "ChangeLogCollectionViaDeepFryerChangeLog";
			/// <summary>Member name EmployeeCollectionViaDeepFryerService</summary>
			public static readonly string EmployeeCollectionViaDeepFryerService = "EmployeeCollectionViaDeepFryerService";
			/// <summary>Member name ServiceLocationCollectionViaDeepFryerService</summary>
			public static readonly string ServiceLocationCollectionViaDeepFryerService = "ServiceLocationCollectionViaDeepFryerService";
			/// <summary>Member name WorkOrderEmployeeCollectionViaDeepFryerService</summary>
			public static readonly string WorkOrderEmployeeCollectionViaDeepFryerService = "WorkOrderEmployeeCollectionViaDeepFryerService";
			/// <summary>Member name WorkOrderServiceLocationCollectionViaDeepFryerService</summary>
			public static readonly string WorkOrderServiceLocationCollectionViaDeepFryerService = "WorkOrderServiceLocationCollectionViaDeepFryerService";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DeepFryerEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DeepFryerEntity():base("DeepFryerEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DeepFryerEntity(IEntityFields2 fields):base("DeepFryerEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DeepFryerEntity</param>
		public DeepFryerEntity(IValidator validator):base("DeepFryerEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DeepFryerEntity(System.Int32 deepFryerId):base("DeepFryerEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.DeepFryerId = deepFryerId;
		}

		/// <summary> CTor</summary>
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		/// <param name="validator">The custom validator object for this DeepFryerEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DeepFryerEntity(System.Int32 deepFryerId, IValidator validator):base("DeepFryerEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.DeepFryerId = deepFryerId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DeepFryerEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_deepFryerChangeLog = (EntityCollection<DeepFryerChangeLogEntity>)info.GetValue("_deepFryerChangeLog", typeof(EntityCollection<DeepFryerChangeLogEntity>));
				_deepFryerService = (EntityCollection<DeepFryerServiceEntity>)info.GetValue("_deepFryerService", typeof(EntityCollection<DeepFryerServiceEntity>));
				_changeLogCollectionViaDeepFryerChangeLog = (EntityCollection<ChangeLogEntity>)info.GetValue("_changeLogCollectionViaDeepFryerChangeLog", typeof(EntityCollection<ChangeLogEntity>));
				_employeeCollectionViaDeepFryerService = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaDeepFryerService", typeof(EntityCollection<EmployeeEntity>));
				_serviceLocationCollectionViaDeepFryerService = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaDeepFryerService", typeof(EntityCollection<ServiceLocationEntity>));
				_workOrderEmployeeCollectionViaDeepFryerService = (EntityCollection<WorkOrderEmployeeEntity>)info.GetValue("_workOrderEmployeeCollectionViaDeepFryerService", typeof(EntityCollection<WorkOrderEmployeeEntity>));
				_workOrderServiceLocationCollectionViaDeepFryerService = (EntityCollection<WorkOrderServiceLocationEntity>)info.GetValue("_workOrderServiceLocationCollectionViaDeepFryerService", typeof(EntityCollection<WorkOrderServiceLocationEntity>));
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
			switch((DeepFryerFieldIndex)fieldIndex)
			{
				case DeepFryerFieldIndex.ServiceLocationId:
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
				case "DeepFryerChangeLog":
					this.DeepFryerChangeLog.Add((DeepFryerChangeLogEntity)entity);
					break;
				case "DeepFryerService":
					this.DeepFryerService.Add((DeepFryerServiceEntity)entity);
					break;
				case "ChangeLogCollectionViaDeepFryerChangeLog":
					this.ChangeLogCollectionViaDeepFryerChangeLog.IsReadOnly = false;
					this.ChangeLogCollectionViaDeepFryerChangeLog.Add((ChangeLogEntity)entity);
					this.ChangeLogCollectionViaDeepFryerChangeLog.IsReadOnly = true;
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
				case "WorkOrderEmployeeCollectionViaDeepFryerService":
					this.WorkOrderEmployeeCollectionViaDeepFryerService.IsReadOnly = false;
					this.WorkOrderEmployeeCollectionViaDeepFryerService.Add((WorkOrderEmployeeEntity)entity);
					this.WorkOrderEmployeeCollectionViaDeepFryerService.IsReadOnly = true;
					break;
				case "WorkOrderServiceLocationCollectionViaDeepFryerService":
					this.WorkOrderServiceLocationCollectionViaDeepFryerService.IsReadOnly = false;
					this.WorkOrderServiceLocationCollectionViaDeepFryerService.Add((WorkOrderServiceLocationEntity)entity);
					this.WorkOrderServiceLocationCollectionViaDeepFryerService.IsReadOnly = true;
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
			return DeepFryerEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(DeepFryerEntity.Relations.ServiceLocationEntityUsingServiceLocationId);
					break;
				case "DeepFryerChangeLog":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerChangeLogEntityUsingDeepFryerId);
					break;
				case "DeepFryerService":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId);
					break;
				case "ChangeLogCollectionViaDeepFryerChangeLog":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerChangeLogEntityUsingDeepFryerId, "DeepFryerEntity__", "DeepFryerChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId, "DeepFryerChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerService":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId, "DeepFryerEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaDeepFryerService":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId, "DeepFryerEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderEmployeeCollectionViaDeepFryerService":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId, "DeepFryerEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderServiceLocationCollectionViaDeepFryerService":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId, "DeepFryerEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
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
				case "DeepFryerChangeLog":
					this.DeepFryerChangeLog.Add((DeepFryerChangeLogEntity)relatedEntity);
					break;
				case "DeepFryerService":
					this.DeepFryerService.Add((DeepFryerServiceEntity)relatedEntity);
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
				case "DeepFryerChangeLog":
					base.PerformRelatedEntityRemoval(this.DeepFryerChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerService":
					base.PerformRelatedEntityRemoval(this.DeepFryerService, relatedEntity, signalRelatedEntityManyToOne);
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

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.DeepFryerChangeLog);
			toReturn.Add(this.DeepFryerService);

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
				info.AddValue("_deepFryerChangeLog", ((_deepFryerChangeLog!=null) && (_deepFryerChangeLog.Count>0) && !this.MarkedForDeletion)?_deepFryerChangeLog:null);
				info.AddValue("_deepFryerService", ((_deepFryerService!=null) && (_deepFryerService.Count>0) && !this.MarkedForDeletion)?_deepFryerService:null);
				info.AddValue("_changeLogCollectionViaDeepFryerChangeLog", ((_changeLogCollectionViaDeepFryerChangeLog!=null) && (_changeLogCollectionViaDeepFryerChangeLog.Count>0) && !this.MarkedForDeletion)?_changeLogCollectionViaDeepFryerChangeLog:null);
				info.AddValue("_employeeCollectionViaDeepFryerService", ((_employeeCollectionViaDeepFryerService!=null) && (_employeeCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaDeepFryerService:null);
				info.AddValue("_serviceLocationCollectionViaDeepFryerService", ((_serviceLocationCollectionViaDeepFryerService!=null) && (_serviceLocationCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaDeepFryerService:null);
				info.AddValue("_workOrderEmployeeCollectionViaDeepFryerService", ((_workOrderEmployeeCollectionViaDeepFryerService!=null) && (_workOrderEmployeeCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_workOrderEmployeeCollectionViaDeepFryerService:null);
				info.AddValue("_workOrderServiceLocationCollectionViaDeepFryerService", ((_workOrderServiceLocationCollectionViaDeepFryerService!=null) && (_workOrderServiceLocationCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_workOrderServiceLocationCollectionViaDeepFryerService:null);
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
		public bool TestOriginalFieldValueForNull(DeepFryerFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DeepFryerFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DeepFryerRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerChangeLogFields.DeepFryerId, null, ComparisonOperator.Equal, this.DeepFryerId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.DeepFryerId, null, ComparisonOperator.Equal, this.DeepFryerId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoChangeLogCollectionViaDeepFryerChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ChangeLogCollectionViaDeepFryerChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, null, ComparisonOperator.Equal, this.DeepFryerId, "DeepFryerEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, null, ComparisonOperator.Equal, this.DeepFryerId, "DeepFryerEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, null, ComparisonOperator.Equal, this.DeepFryerId, "DeepFryerEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderEmployee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderEmployeeCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WorkOrderEmployeeCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, null, ComparisonOperator.Equal, this.DeepFryerId, "DeepFryerEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderServiceLocationCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WorkOrderServiceLocationCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, null, ComparisonOperator.Equal, this.DeepFryerId, "DeepFryerEntity__"));
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.DeepFryerEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._deepFryerChangeLog);
			collectionsQueue.Enqueue(this._deepFryerService);
			collectionsQueue.Enqueue(this._changeLogCollectionViaDeepFryerChangeLog);
			collectionsQueue.Enqueue(this._employeeCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._workOrderEmployeeCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._workOrderServiceLocationCollectionViaDeepFryerService);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._deepFryerChangeLog = (EntityCollection<DeepFryerChangeLogEntity>) collectionsQueue.Dequeue();
			this._deepFryerService = (EntityCollection<DeepFryerServiceEntity>) collectionsQueue.Dequeue();
			this._changeLogCollectionViaDeepFryerChangeLog = (EntityCollection<ChangeLogEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaDeepFryerService = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaDeepFryerService = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._workOrderEmployeeCollectionViaDeepFryerService = (EntityCollection<WorkOrderEmployeeEntity>) collectionsQueue.Dequeue();
			this._workOrderServiceLocationCollectionViaDeepFryerService = (EntityCollection<WorkOrderServiceLocationEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._deepFryerChangeLog != null)
			{
				return true;
			}
			if (this._deepFryerService != null)
			{
				return true;
			}
			if (this._changeLogCollectionViaDeepFryerChangeLog != null)
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
			if (this._workOrderEmployeeCollectionViaDeepFryerService != null)
			{
				return true;
			}
			if (this._workOrderServiceLocationCollectionViaDeepFryerService != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
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
			toReturn.Add("ServiceLocation", _serviceLocation);
			toReturn.Add("DeepFryerChangeLog", _deepFryerChangeLog);
			toReturn.Add("DeepFryerService", _deepFryerService);
			toReturn.Add("ChangeLogCollectionViaDeepFryerChangeLog", _changeLogCollectionViaDeepFryerChangeLog);
			toReturn.Add("EmployeeCollectionViaDeepFryerService", _employeeCollectionViaDeepFryerService);
			toReturn.Add("ServiceLocationCollectionViaDeepFryerService", _serviceLocationCollectionViaDeepFryerService);
			toReturn.Add("WorkOrderEmployeeCollectionViaDeepFryerService", _workOrderEmployeeCollectionViaDeepFryerService);
			toReturn.Add("WorkOrderServiceLocationCollectionViaDeepFryerService", _workOrderServiceLocationCollectionViaDeepFryerService);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_deepFryerChangeLog!=null)
			{
				_deepFryerChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerService!=null)
			{
				_deepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_changeLogCollectionViaDeepFryerChangeLog!=null)
			{
				_changeLogCollectionViaDeepFryerChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaDeepFryerService!=null)
			{
				_employeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaDeepFryerService!=null)
			{
				_serviceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_workOrderEmployeeCollectionViaDeepFryerService!=null)
			{
				_workOrderEmployeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_workOrderServiceLocationCollectionViaDeepFryerService!=null)
			{
				_workOrderServiceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_deepFryerChangeLog = null;
			_deepFryerService = null;
			_changeLogCollectionViaDeepFryerChangeLog = null;
			_employeeCollectionViaDeepFryerService = null;
			_serviceLocationCollectionViaDeepFryerService = null;
			_workOrderEmployeeCollectionViaDeepFryerService = null;
			_workOrderServiceLocationCollectionViaDeepFryerService = null;
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

			_fieldsCustomProperties.Add("DeepFryerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("SizeInGallons", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _serviceLocation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, signalRelatedEntity, "DeepFryer", resetFKFields, new int[] { (int)DeepFryerFieldIndex.ServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, new string[] {  } );
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
		/// <param name="validator">The validator object for this DeepFryerEntity</param>
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
		public  static DeepFryerRelations Relations
		{
			get	{ return new DeepFryerRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerChangeLog
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<DeepFryerChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("DeepFryerChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity, 0, null, null, null, null, "DeepFryerChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("DeepFryerService")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, null, null, "DeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathChangeLogCollectionViaDeepFryerChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerEntity.Relations.DeepFryerChangeLogEntityUsingDeepFryerId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<ChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, 0, null, null, GetRelationsForField("ChangeLogCollectionViaDeepFryerChangeLog"), null, "ChangeLogCollectionViaDeepFryerChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerService"), null, "EmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerService"), null, "ServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, GetRelationsForField("WorkOrderEmployeeCollectionViaDeepFryerService"), null, "WorkOrderEmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, GetRelationsForField("WorkOrderServiceLocationCollectionViaDeepFryerService"), null, "WorkOrderServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DeepFryerEntity.CustomProperties;}
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
			get { return DeepFryerEntity.FieldsCustomProperties;}
		}

		/// <summary> The DeepFryerId property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."DeepFryerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DeepFryerId
		{
			get { return (System.Int32)GetValue((int)DeepFryerFieldIndex.DeepFryerId, true); }
			set	{ SetValue((int)DeepFryerFieldIndex.DeepFryerId, value); }
		}

		/// <summary> The Name property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)DeepFryerFieldIndex.Name, true); }
			set	{ SetValue((int)DeepFryerFieldIndex.Name, value); }
		}

		/// <summary> The Description property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)DeepFryerFieldIndex.Description, true); }
			set	{ SetValue((int)DeepFryerFieldIndex.Description, value); }
		}

		/// <summary> The ServiceLocationId property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."ServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceLocationId
		{
			get { return (System.Int32)GetValue((int)DeepFryerFieldIndex.ServiceLocationId, true); }
			set	{ SetValue((int)DeepFryerFieldIndex.ServiceLocationId, value); }
		}

		/// <summary> The SizeInGallons property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."SizeInGallons"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Double> SizeInGallons
		{
			get { return (Nullable<System.Double>)GetValue((int)DeepFryerFieldIndex.SizeInGallons, false); }
			set	{ SetValue((int)DeepFryerFieldIndex.SizeInGallons, value); }
		}

		/// <summary> The IsActive property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)DeepFryerFieldIndex.IsActive, true); }
			set	{ SetValue((int)DeepFryerFieldIndex.IsActive, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerChangeLogEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerChangeLogEntity))]
		public virtual EntityCollection<DeepFryerChangeLogEntity> DeepFryerChangeLog
		{
			get
			{
				if(_deepFryerChangeLog==null)
				{
					_deepFryerChangeLog = new EntityCollection<DeepFryerChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerChangeLogEntityFactory)));
					_deepFryerChangeLog.SetContainingEntityInfo(this, "DeepFryer");
				}
				return _deepFryerChangeLog;
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
					_deepFryerService.SetContainingEntityInfo(this, "DeepFryer");
				}
				return _deepFryerService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ChangeLogEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ChangeLogEntity))]
		public virtual EntityCollection<ChangeLogEntity> ChangeLogCollectionViaDeepFryerChangeLog
		{
			get
			{
				if(_changeLogCollectionViaDeepFryerChangeLog==null)
				{
					_changeLogCollectionViaDeepFryerChangeLog = new EntityCollection<ChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory)));
					_changeLogCollectionViaDeepFryerChangeLog.IsReadOnly=true;
				}
				return _changeLogCollectionViaDeepFryerChangeLog;
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

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderEmployeeEntity))]
		public virtual EntityCollection<WorkOrderEmployeeEntity> WorkOrderEmployeeCollectionViaDeepFryerService
		{
			get
			{
				if(_workOrderEmployeeCollectionViaDeepFryerService==null)
				{
					_workOrderEmployeeCollectionViaDeepFryerService = new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory)));
					_workOrderEmployeeCollectionViaDeepFryerService.IsReadOnly=true;
				}
				return _workOrderEmployeeCollectionViaDeepFryerService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderServiceLocationEntity))]
		public virtual EntityCollection<WorkOrderServiceLocationEntity> WorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				if(_workOrderServiceLocationCollectionViaDeepFryerService==null)
				{
					_workOrderServiceLocationCollectionViaDeepFryerService = new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory)));
					_workOrderServiceLocationCollectionViaDeepFryerService.IsReadOnly=true;
				}
				return _workOrderServiceLocationCollectionViaDeepFryerService;
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
							_serviceLocation.UnsetRelatedEntity(this, "DeepFryer");
						}
					}
					else
					{
						if(_serviceLocation!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "DeepFryer");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity; }
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
