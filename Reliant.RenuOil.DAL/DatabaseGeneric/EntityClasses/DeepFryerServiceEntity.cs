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
	/// Entity class which represents the entity 'DeepFryerService'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DeepFryerServiceEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<DeepFryerServiceChangeLogEntity> _deepFryerServiceChangeLog;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaDeepFryerServiceChangeLog_;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaDeepFryerServiceChangeLog;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaDeepFryerServiceChangeLog;
		private EntityCollection<UserEntity> _userCollectionViaDeepFryerServiceChangeLog;
		private DeepFryerEntity _deepFryer;
		private EmployeeEntity _employee;
		private ServiceLocationEntity _serviceLocation;
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
			/// <summary>Member name DeepFryer</summary>
			public static readonly string DeepFryer = "DeepFryer";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name WorkOrderEmployee</summary>
			public static readonly string WorkOrderEmployee = "WorkOrderEmployee";
			/// <summary>Member name WorkOrderServiceLocation</summary>
			public static readonly string WorkOrderServiceLocation = "WorkOrderServiceLocation";
			/// <summary>Member name DeepFryerServiceChangeLog</summary>
			public static readonly string DeepFryerServiceChangeLog = "DeepFryerServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaDeepFryerServiceChangeLog_</summary>
			public static readonly string EmployeeCollectionViaDeepFryerServiceChangeLog_ = "EmployeeCollectionViaDeepFryerServiceChangeLog_";
			/// <summary>Member name EmployeeCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string EmployeeCollectionViaDeepFryerServiceChangeLog = "EmployeeCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name ServiceLocationCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string ServiceLocationCollectionViaDeepFryerServiceChangeLog = "ServiceLocationCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name UserCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string UserCollectionViaDeepFryerServiceChangeLog = "UserCollectionViaDeepFryerServiceChangeLog";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DeepFryerServiceEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DeepFryerServiceEntity():base("DeepFryerServiceEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DeepFryerServiceEntity(IEntityFields2 fields):base("DeepFryerServiceEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DeepFryerServiceEntity</param>
		public DeepFryerServiceEntity(IValidator validator):base("DeepFryerServiceEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DeepFryerServiceEntity(System.Int32 deepFryerServiceId):base("DeepFryerServiceEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.DeepFryerServiceId = deepFryerServiceId;
		}

		/// <summary> CTor</summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		/// <param name="validator">The custom validator object for this DeepFryerServiceEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DeepFryerServiceEntity(System.Int32 deepFryerServiceId, IValidator validator):base("DeepFryerServiceEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.DeepFryerServiceId = deepFryerServiceId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DeepFryerServiceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_deepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceChangeLogEntity>)info.GetValue("_deepFryerServiceChangeLog", typeof(EntityCollection<DeepFryerServiceChangeLogEntity>));
				_employeeCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog_", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaDeepFryerServiceChangeLog = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<EmployeeEntity>));
				_serviceLocationCollectionViaDeepFryerServiceChangeLog = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<ServiceLocationEntity>));
				_userCollectionViaDeepFryerServiceChangeLog = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<UserEntity>));
				_deepFryer = (DeepFryerEntity)info.GetValue("_deepFryer", typeof(DeepFryerEntity));
				if(_deepFryer!=null)
				{
					_deepFryer.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((DeepFryerServiceFieldIndex)fieldIndex)
			{
				case DeepFryerServiceFieldIndex.DeepFryerId:
					DesetupSyncDeepFryer(true, false);
					break;
				case DeepFryerServiceFieldIndex.WorkOrderServiceLocationId:
					DesetupSyncWorkOrderEmployee(true, false);
					DesetupSyncWorkOrderServiceLocation(true, false);
					break;
				case DeepFryerServiceFieldIndex.RelocatedToServiceLocationId:
					DesetupSyncServiceLocation(true, false);
					break;
				case DeepFryerServiceFieldIndex.Servicedby:
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
				case "DeepFryer":
					this.DeepFryer = (DeepFryerEntity)entity;
					break;
				case "Employee":
					this.Employee = (EmployeeEntity)entity;
					break;
				case "ServiceLocation":
					this.ServiceLocation = (ServiceLocationEntity)entity;
					break;
				case "WorkOrderEmployee":
					this.WorkOrderEmployee = (WorkOrderEmployeeEntity)entity;
					break;
				case "WorkOrderServiceLocation":
					this.WorkOrderServiceLocation = (WorkOrderServiceLocationEntity)entity;
					break;
				case "DeepFryerServiceChangeLog":
					this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)entity);
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog_":
					this.EmployeeCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = false;
					this.EmployeeCollectionViaDeepFryerServiceChangeLog_.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog":
					this.EmployeeCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.EmployeeCollectionViaDeepFryerServiceChangeLog.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog":
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog":
					this.UserCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.UserCollectionViaDeepFryerServiceChangeLog.Add((UserEntity)entity);
					this.UserCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
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
			return DeepFryerServiceEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "DeepFryer":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId);
					break;
				case "Employee":
					toReturn.Add(DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby);
					break;
				case "ServiceLocation":
					toReturn.Add(DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId);
					break;
				case "WorkOrderEmployee":
					toReturn.Add(DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);
					break;
				case "WorkOrderServiceLocation":
					toReturn.Add(DeepFryerServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);
					break;
				case "DeepFryerServiceChangeLog":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId);
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog_":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId, "DeepFryerServiceEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingServicedBy, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId, "DeepFryerServiceEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId, "DeepFryerServiceEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId, "DeepFryerServiceEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
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
				case "DeepFryer":
					SetupSyncDeepFryer(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "ServiceLocation":
					SetupSyncServiceLocation(relatedEntity);
					break;
				case "WorkOrderEmployee":
					SetupSyncWorkOrderEmployee(relatedEntity);
					break;
				case "WorkOrderServiceLocation":
					SetupSyncWorkOrderServiceLocation(relatedEntity);
					break;
				case "DeepFryerServiceChangeLog":
					this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)relatedEntity);
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
				case "DeepFryer":
					DesetupSyncDeepFryer(false, true);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "ServiceLocation":
					DesetupSyncServiceLocation(false, true);
					break;
				case "WorkOrderEmployee":
					DesetupSyncWorkOrderEmployee(false, true);
					break;
				case "WorkOrderServiceLocation":
					DesetupSyncWorkOrderServiceLocation(false, true);
					break;
				case "DeepFryerServiceChangeLog":
					base.PerformRelatedEntityRemoval(this.DeepFryerServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_deepFryer!=null)
			{
				toReturn.Add(_deepFryer);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_serviceLocation!=null)
			{
				toReturn.Add(_serviceLocation);
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
			toReturn.Add(this.DeepFryerServiceChangeLog);

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
				info.AddValue("_deepFryerServiceChangeLog", ((_deepFryerServiceChangeLog!=null) && (_deepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_deepFryerServiceChangeLog:null);
				info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog_", ((_employeeCollectionViaDeepFryerServiceChangeLog_!=null) && (_employeeCollectionViaDeepFryerServiceChangeLog_.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaDeepFryerServiceChangeLog_:null);
				info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog", ((_employeeCollectionViaDeepFryerServiceChangeLog!=null) && (_employeeCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", ((_serviceLocationCollectionViaDeepFryerServiceChangeLog!=null) && (_serviceLocationCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_userCollectionViaDeepFryerServiceChangeLog", ((_userCollectionViaDeepFryerServiceChangeLog!=null) && (_userCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_userCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_deepFryer", (!this.MarkedForDeletion?_deepFryer:null));
				info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
				info.AddValue("_serviceLocation", (!this.MarkedForDeletion?_serviceLocation:null));
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
		public bool TestOriginalFieldValueForNull(DeepFryerServiceFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DeepFryerServiceFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DeepFryerServiceRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceChangeLogFields.DeepFryerServiceId, null, ComparisonOperator.Equal, this.DeepFryerServiceId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaDeepFryerServiceChangeLog_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaDeepFryerServiceChangeLog_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.DeepFryerServiceId, null, ComparisonOperator.Equal, this.DeepFryerServiceId, "DeepFryerServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.DeepFryerServiceId, null, ComparisonOperator.Equal, this.DeepFryerServiceId, "DeepFryerServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.DeepFryerServiceId, null, ComparisonOperator.Equal, this.DeepFryerServiceId, "DeepFryerServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.DeepFryerServiceId, null, ComparisonOperator.Equal, this.DeepFryerServiceId, "DeepFryerServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'DeepFryer' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryer()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, null, ComparisonOperator.Equal, this.DeepFryerId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Employee' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.Servicedby));
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._deepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._employeeCollectionViaDeepFryerServiceChangeLog_);
			collectionsQueue.Enqueue(this._employeeCollectionViaDeepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaDeepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._userCollectionViaDeepFryerServiceChangeLog);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._deepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaDeepFryerServiceChangeLog = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaDeepFryerServiceChangeLog = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaDeepFryerServiceChangeLog = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._deepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._employeeCollectionViaDeepFryerServiceChangeLog_ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaDeepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaDeepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._userCollectionViaDeepFryerServiceChangeLog != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
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
			toReturn.Add("DeepFryer", _deepFryer);
			toReturn.Add("Employee", _employee);
			toReturn.Add("ServiceLocation", _serviceLocation);
			toReturn.Add("WorkOrderEmployee", _workOrderEmployee);
			toReturn.Add("WorkOrderServiceLocation", _workOrderServiceLocation);
			toReturn.Add("DeepFryerServiceChangeLog", _deepFryerServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaDeepFryerServiceChangeLog_", _employeeCollectionViaDeepFryerServiceChangeLog_);
			toReturn.Add("EmployeeCollectionViaDeepFryerServiceChangeLog", _employeeCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("ServiceLocationCollectionViaDeepFryerServiceChangeLog", _serviceLocationCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("UserCollectionViaDeepFryerServiceChangeLog", _userCollectionViaDeepFryerServiceChangeLog);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_deepFryerServiceChangeLog!=null)
			{
				_deepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaDeepFryerServiceChangeLog_!=null)
			{
				_employeeCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_employeeCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_serviceLocationCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_userCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_deepFryer!=null)
			{
				_deepFryer.ActiveContext = base.ActiveContext;
			}
			if(_employee!=null)
			{
				_employee.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
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

			_deepFryerServiceChangeLog = null;
			_employeeCollectionViaDeepFryerServiceChangeLog_ = null;
			_employeeCollectionViaDeepFryerServiceChangeLog = null;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog = null;
			_userCollectionViaDeepFryerServiceChangeLog = null;
			_deepFryer = null;
			_employee = null;
			_serviceLocation = null;
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

			_fieldsCustomProperties.Add("DeepFryerServiceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DeepFryerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("WorkOrderServiceLocationId", fieldHashtable);
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

			_fieldsCustomProperties.Add("Servicedby", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NoService", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _deepFryer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDeepFryer(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _deepFryer, new PropertyChangedEventHandler( OnDeepFryerPropertyChanged ), "DeepFryer", DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId, true, signalRelatedEntity, "DeepFryerService", resetFKFields, new int[] { (int)DeepFryerServiceFieldIndex.DeepFryerId } );		
			_deepFryer = null;
		}

		/// <summary> setups the sync logic for member _deepFryer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDeepFryer(IEntity2 relatedEntity)
		{
			if(_deepFryer!=relatedEntity)
			{
				DesetupSyncDeepFryer(true, true);
				_deepFryer = (DeepFryerEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _deepFryer, new PropertyChangedEventHandler( OnDeepFryerPropertyChanged ), "DeepFryer", DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDeepFryerPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby, true, signalRelatedEntity, "DeepFryerService", resetFKFields, new int[] { (int)DeepFryerServiceFieldIndex.Servicedby } );		
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
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby, true, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, true, signalRelatedEntity, "DeepFryerService", resetFKFields, new int[] { (int)DeepFryerServiceFieldIndex.RelocatedToServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _workOrderEmployee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrderEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "DeepFryerService", resetFKFields, new int[] { (int)DeepFryerServiceFieldIndex.WorkOrderServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", DeepFryerServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "DeepFryerService", resetFKFields, new int[] { (int)DeepFryerServiceFieldIndex.WorkOrderServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", DeepFryerServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, new string[] {  } );
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
		/// <param name="validator">The validator object for this DeepFryerServiceEntity</param>
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
		public  static DeepFryerServiceRelations Relations
		{
			get	{ return new DeepFryerServiceRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("DeepFryerServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, 0, null, null, null, null, "DeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog_"), null, "EmployeeCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog"), null, "EmployeeCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog"), null, "ServiceLocationCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog"), null, "UserCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryer
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))),
					(IEntityRelation)GetRelationsForField("DeepFryer")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, null, null, "DeepFryer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("WorkOrderEmployee")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, null, null, "WorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("WorkOrderServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, null, null, "WorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DeepFryerServiceEntity.CustomProperties;}
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
			get { return DeepFryerServiceEntity.FieldsCustomProperties;}
		}

		/// <summary> The DeepFryerServiceId property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."DeepFryerServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DeepFryerServiceId
		{
			get { return (System.Int32)GetValue((int)DeepFryerServiceFieldIndex.DeepFryerServiceId, true); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.DeepFryerServiceId, value); }
		}

		/// <summary> The DeepFryerId property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."DeepFryerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DeepFryerId
		{
			get { return (System.Int32)GetValue((int)DeepFryerServiceFieldIndex.DeepFryerId, true); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.DeepFryerId, value); }
		}

		/// <summary> The WorkOrderServiceLocationId property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."WorkOrderServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 WorkOrderServiceLocationId
		{
			get { return (System.Int32)GetValue((int)DeepFryerServiceFieldIndex.WorkOrderServiceLocationId, true); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.WorkOrderServiceLocationId, value); }
		}

		/// <summary> The Filtered property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."Filtered"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Filtered
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceFieldIndex.Filtered, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.Filtered, value); }
		}

		/// <summary> The Discarded property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."Discarded"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Discarded
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceFieldIndex.Discarded, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.Discarded, value); }
		}

		/// <summary> The Relocated property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."Relocated"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Relocated
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceFieldIndex.Relocated, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.Relocated, value); }
		}

		/// <summary> The Cleaned property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."Cleaned"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Cleaned
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceFieldIndex.Cleaned, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.Cleaned, value); }
		}

		/// <summary> The RelocatedToFryerId property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."RelocatedToFryerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> RelocatedToFryerId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceFieldIndex.RelocatedToFryerId, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.RelocatedToFryerId, value); }
		}

		/// <summary> The RelocatedToServiceLocationId property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."RelocatedToServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> RelocatedToServiceLocationId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceFieldIndex.RelocatedToServiceLocationId, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.RelocatedToServiceLocationId, value); }
		}

		/// <summary> The RelocatedToOther property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."RelocatedToOther"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RelocatedToOther
		{
			get { return (System.String)GetValue((int)DeepFryerServiceFieldIndex.RelocatedToOther, true); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.RelocatedToOther, value); }
		}

		/// <summary> The AssignedTo property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."AssignedTo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> AssignedTo
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceFieldIndex.AssignedTo, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.AssignedTo, value); }
		}

		/// <summary> The Servicedby property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."Servicedby"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Servicedby
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceFieldIndex.Servicedby, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.Servicedby, value); }
		}

		/// <summary> The NoService property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."NoService"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> NoService
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceFieldIndex.NoService, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.NoService, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerServiceChangeLogEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerServiceChangeLogEntity))]
		public virtual EntityCollection<DeepFryerServiceChangeLogEntity> DeepFryerServiceChangeLog
		{
			get
			{
				if(_deepFryerServiceChangeLog==null)
				{
					_deepFryerServiceChangeLog = new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory)));
					_deepFryerServiceChangeLog.SetContainingEntityInfo(this, "DeepFryerService");
				}
				return _deepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				if(_employeeCollectionViaDeepFryerServiceChangeLog_==null)
				{
					_employeeCollectionViaDeepFryerServiceChangeLog_ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaDeepFryerServiceChangeLog_.IsReadOnly=true;
				}
				return _employeeCollectionViaDeepFryerServiceChangeLog_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				if(_employeeCollectionViaDeepFryerServiceChangeLog==null)
				{
					_employeeCollectionViaDeepFryerServiceChangeLog = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaDeepFryerServiceChangeLog.IsReadOnly=true;
				}
				return _employeeCollectionViaDeepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				if(_serviceLocationCollectionViaDeepFryerServiceChangeLog==null)
				{
					_serviceLocationCollectionViaDeepFryerServiceChangeLog = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaDeepFryerServiceChangeLog.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaDeepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				if(_userCollectionViaDeepFryerServiceChangeLog==null)
				{
					_userCollectionViaDeepFryerServiceChangeLog = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaDeepFryerServiceChangeLog.IsReadOnly=true;
				}
				return _userCollectionViaDeepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets / sets related entity of type 'DeepFryerEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual DeepFryerEntity DeepFryer
		{
			get
			{
				return _deepFryer;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncDeepFryer(value);
				}
				else
				{
					if(value==null)
					{
						if(_deepFryer != null)
						{
							_deepFryer.UnsetRelatedEntity(this, "DeepFryerService");
						}
					}
					else
					{
						if(_deepFryer!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "DeepFryerService");
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
							_employee.UnsetRelatedEntity(this, "DeepFryerService");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "DeepFryerService");
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
							_serviceLocation.UnsetRelatedEntity(this, "DeepFryerService");
						}
					}
					else
					{
						if(_serviceLocation!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "DeepFryerService");
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
							_workOrderEmployee.UnsetRelatedEntity(this, "DeepFryerService");
						}
					}
					else
					{
						if(_workOrderEmployee!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "DeepFryerService");
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
							_workOrderServiceLocation.UnsetRelatedEntity(this, "DeepFryerService");
						}
					}
					else
					{
						if(_workOrderServiceLocation!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "DeepFryerService");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity; }
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
