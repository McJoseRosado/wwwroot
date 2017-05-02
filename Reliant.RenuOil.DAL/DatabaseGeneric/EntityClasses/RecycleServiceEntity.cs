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
	/// Entity class which represents the entity 'RecycleService'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class RecycleServiceEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<RecycleServiceActionEntity> _recycleServiceAction;
		private EntityCollection<RecycleServiceChangeLogEntity> _recycleServiceChangeLog;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaRecycleServiceChangeLog;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaRecycleServiceAction;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaRecycleServiceAction_;
		private EntityCollection<RecycleTypeEntity> _recycleTypeCollectionViaRecycleServiceAction;
		private EntityCollection<UserEntity> _userCollectionViaRecycleServiceChangeLog;
		private EntityCollection<UserEntity> _userCollectionViaRecycleServiceAction;
		private EntityCollection<UserEntity> _userCollectionViaRecycleServiceAction_;
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
			/// <summary>Member name WorkOrderEmployee</summary>
			public static readonly string WorkOrderEmployee = "WorkOrderEmployee";
			/// <summary>Member name WorkOrderServiceLocation</summary>
			public static readonly string WorkOrderServiceLocation = "WorkOrderServiceLocation";
			/// <summary>Member name RecycleServiceAction</summary>
			public static readonly string RecycleServiceAction = "RecycleServiceAction";
			/// <summary>Member name RecycleServiceChangeLog</summary>
			public static readonly string RecycleServiceChangeLog = "RecycleServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceChangeLog</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceChangeLog = "EmployeeCollectionViaRecycleServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceAction</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceAction = "EmployeeCollectionViaRecycleServiceAction";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceAction_</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceAction_ = "EmployeeCollectionViaRecycleServiceAction_";
			/// <summary>Member name RecycleTypeCollectionViaRecycleServiceAction</summary>
			public static readonly string RecycleTypeCollectionViaRecycleServiceAction = "RecycleTypeCollectionViaRecycleServiceAction";
			/// <summary>Member name UserCollectionViaRecycleServiceChangeLog</summary>
			public static readonly string UserCollectionViaRecycleServiceChangeLog = "UserCollectionViaRecycleServiceChangeLog";
			/// <summary>Member name UserCollectionViaRecycleServiceAction</summary>
			public static readonly string UserCollectionViaRecycleServiceAction = "UserCollectionViaRecycleServiceAction";
			/// <summary>Member name UserCollectionViaRecycleServiceAction_</summary>
			public static readonly string UserCollectionViaRecycleServiceAction_ = "UserCollectionViaRecycleServiceAction_";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RecycleServiceEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public RecycleServiceEntity():base("RecycleServiceEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RecycleServiceEntity(IEntityFields2 fields):base("RecycleServiceEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RecycleServiceEntity</param>
		public RecycleServiceEntity(IValidator validator):base("RecycleServiceEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RecycleServiceEntity(System.Int32 recycleServiceId):base("RecycleServiceEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.RecycleServiceId = recycleServiceId;
		}

		/// <summary> CTor</summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		/// <param name="validator">The custom validator object for this RecycleServiceEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RecycleServiceEntity(System.Int32 recycleServiceId, IValidator validator):base("RecycleServiceEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.RecycleServiceId = recycleServiceId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected RecycleServiceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_recycleServiceAction = (EntityCollection<RecycleServiceActionEntity>)info.GetValue("_recycleServiceAction", typeof(EntityCollection<RecycleServiceActionEntity>));
				_recycleServiceChangeLog = (EntityCollection<RecycleServiceChangeLogEntity>)info.GetValue("_recycleServiceChangeLog", typeof(EntityCollection<RecycleServiceChangeLogEntity>));
				_employeeCollectionViaRecycleServiceChangeLog = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaRecycleServiceChangeLog", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaRecycleServiceAction = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaRecycleServiceAction", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaRecycleServiceAction_ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaRecycleServiceAction_", typeof(EntityCollection<EmployeeEntity>));
				_recycleTypeCollectionViaRecycleServiceAction = (EntityCollection<RecycleTypeEntity>)info.GetValue("_recycleTypeCollectionViaRecycleServiceAction", typeof(EntityCollection<RecycleTypeEntity>));
				_userCollectionViaRecycleServiceChangeLog = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRecycleServiceChangeLog", typeof(EntityCollection<UserEntity>));
				_userCollectionViaRecycleServiceAction = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRecycleServiceAction", typeof(EntityCollection<UserEntity>));
				_userCollectionViaRecycleServiceAction_ = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRecycleServiceAction_", typeof(EntityCollection<UserEntity>));
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
			switch((RecycleServiceFieldIndex)fieldIndex)
			{
				case RecycleServiceFieldIndex.WorkOrderServiceLocationId:
					DesetupSyncWorkOrderEmployee(true, false);
					DesetupSyncWorkOrderServiceLocation(true, false);
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
				case "WorkOrderEmployee":
					this.WorkOrderEmployee = (WorkOrderEmployeeEntity)entity;
					break;
				case "WorkOrderServiceLocation":
					this.WorkOrderServiceLocation = (WorkOrderServiceLocationEntity)entity;
					break;
				case "RecycleServiceAction":
					this.RecycleServiceAction.Add((RecycleServiceActionEntity)entity);
					break;
				case "RecycleServiceChangeLog":
					this.RecycleServiceChangeLog.Add((RecycleServiceChangeLogEntity)entity);
					break;
				case "EmployeeCollectionViaRecycleServiceChangeLog":
					this.EmployeeCollectionViaRecycleServiceChangeLog.IsReadOnly = false;
					this.EmployeeCollectionViaRecycleServiceChangeLog.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaRecycleServiceChangeLog.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaRecycleServiceAction":
					this.EmployeeCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.EmployeeCollectionViaRecycleServiceAction.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaRecycleServiceAction.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaRecycleServiceAction_":
					this.EmployeeCollectionViaRecycleServiceAction_.IsReadOnly = false;
					this.EmployeeCollectionViaRecycleServiceAction_.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaRecycleServiceAction_.IsReadOnly = true;
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction":
					this.RecycleTypeCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.RecycleTypeCollectionViaRecycleServiceAction.Add((RecycleTypeEntity)entity);
					this.RecycleTypeCollectionViaRecycleServiceAction.IsReadOnly = true;
					break;
				case "UserCollectionViaRecycleServiceChangeLog":
					this.UserCollectionViaRecycleServiceChangeLog.IsReadOnly = false;
					this.UserCollectionViaRecycleServiceChangeLog.Add((UserEntity)entity);
					this.UserCollectionViaRecycleServiceChangeLog.IsReadOnly = true;
					break;
				case "UserCollectionViaRecycleServiceAction":
					this.UserCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.UserCollectionViaRecycleServiceAction.Add((UserEntity)entity);
					this.UserCollectionViaRecycleServiceAction.IsReadOnly = true;
					break;
				case "UserCollectionViaRecycleServiceAction_":
					this.UserCollectionViaRecycleServiceAction_.IsReadOnly = false;
					this.UserCollectionViaRecycleServiceAction_.Add((UserEntity)entity);
					this.UserCollectionViaRecycleServiceAction_.IsReadOnly = true;
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
			return RecycleServiceEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "WorkOrderEmployee":
					toReturn.Add(RecycleServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);
					break;
				case "WorkOrderServiceLocation":
					toReturn.Add(RecycleServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);
					break;
				case "RecycleServiceAction":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId);
					break;
				case "RecycleServiceChangeLog":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceChangeLogEntityUsingRecycleServiceId);
					break;
				case "EmployeeCollectionViaRecycleServiceChangeLog":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceChangeLogEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceChangeLog_", JoinHint.None);
					toReturn.Add(RecycleServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, "RecycleServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceAction":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingLastChangedByEmployeeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceAction_":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingActionEmployeeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceChangeLog":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceChangeLogEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceChangeLog_", JoinHint.None);
					toReturn.Add(RecycleServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "RecycleServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceAction":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingActionUserId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceAction_":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingLastChangedByUserId, "RecycleServiceAction_", string.Empty, JoinHint.None);
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
				case "WorkOrderEmployee":
					SetupSyncWorkOrderEmployee(relatedEntity);
					break;
				case "WorkOrderServiceLocation":
					SetupSyncWorkOrderServiceLocation(relatedEntity);
					break;
				case "RecycleServiceAction":
					this.RecycleServiceAction.Add((RecycleServiceActionEntity)relatedEntity);
					break;
				case "RecycleServiceChangeLog":
					this.RecycleServiceChangeLog.Add((RecycleServiceChangeLogEntity)relatedEntity);
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
				case "WorkOrderEmployee":
					DesetupSyncWorkOrderEmployee(false, true);
					break;
				case "WorkOrderServiceLocation":
					DesetupSyncWorkOrderServiceLocation(false, true);
					break;
				case "RecycleServiceAction":
					base.PerformRelatedEntityRemoval(this.RecycleServiceAction, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleServiceChangeLog":
					base.PerformRelatedEntityRemoval(this.RecycleServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(this.RecycleServiceAction);
			toReturn.Add(this.RecycleServiceChangeLog);

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
				info.AddValue("_recycleServiceAction", ((_recycleServiceAction!=null) && (_recycleServiceAction.Count>0) && !this.MarkedForDeletion)?_recycleServiceAction:null);
				info.AddValue("_recycleServiceChangeLog", ((_recycleServiceChangeLog!=null) && (_recycleServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_recycleServiceChangeLog:null);
				info.AddValue("_employeeCollectionViaRecycleServiceChangeLog", ((_employeeCollectionViaRecycleServiceChangeLog!=null) && (_employeeCollectionViaRecycleServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaRecycleServiceChangeLog:null);
				info.AddValue("_employeeCollectionViaRecycleServiceAction", ((_employeeCollectionViaRecycleServiceAction!=null) && (_employeeCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaRecycleServiceAction:null);
				info.AddValue("_employeeCollectionViaRecycleServiceAction_", ((_employeeCollectionViaRecycleServiceAction_!=null) && (_employeeCollectionViaRecycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaRecycleServiceAction_:null);
				info.AddValue("_recycleTypeCollectionViaRecycleServiceAction", ((_recycleTypeCollectionViaRecycleServiceAction!=null) && (_recycleTypeCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_recycleTypeCollectionViaRecycleServiceAction:null);
				info.AddValue("_userCollectionViaRecycleServiceChangeLog", ((_userCollectionViaRecycleServiceChangeLog!=null) && (_userCollectionViaRecycleServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRecycleServiceChangeLog:null);
				info.AddValue("_userCollectionViaRecycleServiceAction", ((_userCollectionViaRecycleServiceAction!=null) && (_userCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRecycleServiceAction:null);
				info.AddValue("_userCollectionViaRecycleServiceAction_", ((_userCollectionViaRecycleServiceAction_!=null) && (_userCollectionViaRecycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRecycleServiceAction_:null);
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
		public bool TestOriginalFieldValueForNull(RecycleServiceFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(RecycleServiceFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new RecycleServiceRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleServiceAction' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceActionFields.RecycleServiceId, null, ComparisonOperator.Equal, this.RecycleServiceId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceChangeLogFields.RecycleServiceId, null, ComparisonOperator.Equal, this.RecycleServiceId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaRecycleServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaRecycleServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, null, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, null, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaRecycleServiceAction_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, null, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleTypeCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleTypeCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, null, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRecycleServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRecycleServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, null, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, null, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRecycleServiceAction_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, null, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._recycleServiceAction);
			collectionsQueue.Enqueue(this._recycleServiceChangeLog);
			collectionsQueue.Enqueue(this._employeeCollectionViaRecycleServiceChangeLog);
			collectionsQueue.Enqueue(this._employeeCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._employeeCollectionViaRecycleServiceAction_);
			collectionsQueue.Enqueue(this._recycleTypeCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._userCollectionViaRecycleServiceChangeLog);
			collectionsQueue.Enqueue(this._userCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._userCollectionViaRecycleServiceAction_);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._recycleServiceAction = (EntityCollection<RecycleServiceActionEntity>) collectionsQueue.Dequeue();
			this._recycleServiceChangeLog = (EntityCollection<RecycleServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaRecycleServiceChangeLog = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaRecycleServiceAction = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaRecycleServiceAction_ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._recycleTypeCollectionViaRecycleServiceAction = (EntityCollection<RecycleTypeEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRecycleServiceChangeLog = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRecycleServiceAction = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRecycleServiceAction_ = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._recycleServiceAction != null)
			{
				return true;
			}
			if (this._recycleServiceChangeLog != null)
			{
				return true;
			}
			if (this._employeeCollectionViaRecycleServiceChangeLog != null)
			{
				return true;
			}
			if (this._employeeCollectionViaRecycleServiceAction != null)
			{
				return true;
			}
			if (this._employeeCollectionViaRecycleServiceAction_ != null)
			{
				return true;
			}
			if (this._recycleTypeCollectionViaRecycleServiceAction != null)
			{
				return true;
			}
			if (this._userCollectionViaRecycleServiceChangeLog != null)
			{
				return true;
			}
			if (this._userCollectionViaRecycleServiceAction != null)
			{
				return true;
			}
			if (this._userCollectionViaRecycleServiceAction_ != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
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
			toReturn.Add("WorkOrderEmployee", _workOrderEmployee);
			toReturn.Add("WorkOrderServiceLocation", _workOrderServiceLocation);
			toReturn.Add("RecycleServiceAction", _recycleServiceAction);
			toReturn.Add("RecycleServiceChangeLog", _recycleServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaRecycleServiceChangeLog", _employeeCollectionViaRecycleServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaRecycleServiceAction", _employeeCollectionViaRecycleServiceAction);
			toReturn.Add("EmployeeCollectionViaRecycleServiceAction_", _employeeCollectionViaRecycleServiceAction_);
			toReturn.Add("RecycleTypeCollectionViaRecycleServiceAction", _recycleTypeCollectionViaRecycleServiceAction);
			toReturn.Add("UserCollectionViaRecycleServiceChangeLog", _userCollectionViaRecycleServiceChangeLog);
			toReturn.Add("UserCollectionViaRecycleServiceAction", _userCollectionViaRecycleServiceAction);
			toReturn.Add("UserCollectionViaRecycleServiceAction_", _userCollectionViaRecycleServiceAction_);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_recycleServiceAction!=null)
			{
				_recycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceChangeLog!=null)
			{
				_recycleServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaRecycleServiceChangeLog!=null)
			{
				_employeeCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaRecycleServiceAction!=null)
			{
				_employeeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaRecycleServiceAction_!=null)
			{
				_employeeCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			}
			if(_recycleTypeCollectionViaRecycleServiceAction!=null)
			{
				_recycleTypeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRecycleServiceChangeLog!=null)
			{
				_userCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRecycleServiceAction!=null)
			{
				_userCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRecycleServiceAction_!=null)
			{
				_userCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
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

			_recycleServiceAction = null;
			_recycleServiceChangeLog = null;
			_employeeCollectionViaRecycleServiceChangeLog = null;
			_employeeCollectionViaRecycleServiceAction = null;
			_employeeCollectionViaRecycleServiceAction_ = null;
			_recycleTypeCollectionViaRecycleServiceAction = null;
			_userCollectionViaRecycleServiceChangeLog = null;
			_userCollectionViaRecycleServiceAction = null;
			_userCollectionViaRecycleServiceAction_ = null;
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

			_fieldsCustomProperties.Add("RecycleServiceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("WorkOrderServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NumberOfBales", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NumberOfBags", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("BalesWeight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("BagsWeight", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _workOrderEmployee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrderEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", RecycleServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "RecycleService", resetFKFields, new int[] { (int)RecycleServiceFieldIndex.WorkOrderServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", RecycleServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", RecycleServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "RecycleService", resetFKFields, new int[] { (int)RecycleServiceFieldIndex.WorkOrderServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", RecycleServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, new string[] {  } );
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
		/// <param name="validator">The validator object for this RecycleServiceEntity</param>
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
		public  static RecycleServiceRelations Relations
		{
			get	{ return new RecycleServiceRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleServiceAction' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceAction
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleServiceAction")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, null, "RecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RecycleServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceChangeLogEntity, 0, null, null, null, null, "RecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceChangeLogEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceChangeLog"), null, "EmployeeCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction"), null, "EmployeeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction_"), null, "EmployeeCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleTypeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction"), null, "RecycleTypeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceChangeLogEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceChangeLog"), null, "UserCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction"), null, "UserCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction_"), null, "UserCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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
					(IEntityRelation)GetRelationsForField("WorkOrderEmployee")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, null, null, "WorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("WorkOrderServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, null, null, "WorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return RecycleServiceEntity.CustomProperties;}
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
			get { return RecycleServiceEntity.FieldsCustomProperties;}
		}

		/// <summary> The RecycleServiceId property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."RecycleServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 RecycleServiceId
		{
			get { return (System.Int32)GetValue((int)RecycleServiceFieldIndex.RecycleServiceId, true); }
			set	{ SetValue((int)RecycleServiceFieldIndex.RecycleServiceId, value); }
		}

		/// <summary> The WorkOrderServiceLocationId property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."WorkOrderServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 WorkOrderServiceLocationId
		{
			get { return (System.Int32)GetValue((int)RecycleServiceFieldIndex.WorkOrderServiceLocationId, true); }
			set	{ SetValue((int)RecycleServiceFieldIndex.WorkOrderServiceLocationId, value); }
		}

		/// <summary> The NumberOfBales property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."NumberOfBales"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> NumberOfBales
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceFieldIndex.NumberOfBales, false); }
			set	{ SetValue((int)RecycleServiceFieldIndex.NumberOfBales, value); }
		}

		/// <summary> The NumberOfBags property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."NumberOfBags"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> NumberOfBags
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceFieldIndex.NumberOfBags, false); }
			set	{ SetValue((int)RecycleServiceFieldIndex.NumberOfBags, value); }
		}

		/// <summary> The BalesWeight property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."BalesWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> BalesWeight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RecycleServiceFieldIndex.BalesWeight, false); }
			set	{ SetValue((int)RecycleServiceFieldIndex.BalesWeight, value); }
		}

		/// <summary> The BagsWeight property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."BagsWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> BagsWeight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RecycleServiceFieldIndex.BagsWeight, false); }
			set	{ SetValue((int)RecycleServiceFieldIndex.BagsWeight, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceActionEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceActionEntity))]
		public virtual EntityCollection<RecycleServiceActionEntity> RecycleServiceAction
		{
			get
			{
				if(_recycleServiceAction==null)
				{
					_recycleServiceAction = new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory)));
					_recycleServiceAction.SetContainingEntityInfo(this, "RecycleService");
				}
				return _recycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceChangeLogEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceChangeLogEntity))]
		public virtual EntityCollection<RecycleServiceChangeLogEntity> RecycleServiceChangeLog
		{
			get
			{
				if(_recycleServiceChangeLog==null)
				{
					_recycleServiceChangeLog = new EntityCollection<RecycleServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceChangeLogEntityFactory)));
					_recycleServiceChangeLog.SetContainingEntityInfo(this, "RecycleService");
				}
				return _recycleServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaRecycleServiceChangeLog
		{
			get
			{
				if(_employeeCollectionViaRecycleServiceChangeLog==null)
				{
					_employeeCollectionViaRecycleServiceChangeLog = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaRecycleServiceChangeLog.IsReadOnly=true;
				}
				return _employeeCollectionViaRecycleServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaRecycleServiceAction
		{
			get
			{
				if(_employeeCollectionViaRecycleServiceAction==null)
				{
					_employeeCollectionViaRecycleServiceAction = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaRecycleServiceAction.IsReadOnly=true;
				}
				return _employeeCollectionViaRecycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaRecycleServiceAction_
		{
			get
			{
				if(_employeeCollectionViaRecycleServiceAction_==null)
				{
					_employeeCollectionViaRecycleServiceAction_ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaRecycleServiceAction_.IsReadOnly=true;
				}
				return _employeeCollectionViaRecycleServiceAction_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleTypeEntity))]
		public virtual EntityCollection<RecycleTypeEntity> RecycleTypeCollectionViaRecycleServiceAction
		{
			get
			{
				if(_recycleTypeCollectionViaRecycleServiceAction==null)
				{
					_recycleTypeCollectionViaRecycleServiceAction = new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory)));
					_recycleTypeCollectionViaRecycleServiceAction.IsReadOnly=true;
				}
				return _recycleTypeCollectionViaRecycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRecycleServiceChangeLog
		{
			get
			{
				if(_userCollectionViaRecycleServiceChangeLog==null)
				{
					_userCollectionViaRecycleServiceChangeLog = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRecycleServiceChangeLog.IsReadOnly=true;
				}
				return _userCollectionViaRecycleServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRecycleServiceAction
		{
			get
			{
				if(_userCollectionViaRecycleServiceAction==null)
				{
					_userCollectionViaRecycleServiceAction = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRecycleServiceAction.IsReadOnly=true;
				}
				return _userCollectionViaRecycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRecycleServiceAction_
		{
			get
			{
				if(_userCollectionViaRecycleServiceAction_==null)
				{
					_userCollectionViaRecycleServiceAction_ = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRecycleServiceAction_.IsReadOnly=true;
				}
				return _userCollectionViaRecycleServiceAction_;
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
							_workOrderEmployee.UnsetRelatedEntity(this, "RecycleService");
						}
					}
					else
					{
						if(_workOrderEmployee!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "RecycleService");
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
							_workOrderServiceLocation.UnsetRelatedEntity(this, "RecycleService");
						}
					}
					else
					{
						if(_workOrderServiceLocation!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "RecycleService");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity; }
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
