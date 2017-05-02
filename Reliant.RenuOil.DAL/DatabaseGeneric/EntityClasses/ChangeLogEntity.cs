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
	/// Entity class which represents the entity 'ChangeLog'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ChangeLogEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<DeepFryerChangeLogEntity> _deepFryerChangeLog;
		private EntityCollection<ServiceLocationAssetTypeChangeLogEntity> _serviceLocationAssetTypeChangeLog;
		private EntityCollection<DeepFryerEntity> _deepFryerCollectionViaDeepFryerChangeLog;
		private EntityCollection<ServiceLocationAssetTypeEntity> _serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog;
		private ChangeTypeEntity _changeType;
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
			/// <summary>Member name ChangeType</summary>
			public static readonly string ChangeType = "ChangeType";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
			/// <summary>Member name DeepFryerChangeLog</summary>
			public static readonly string DeepFryerChangeLog = "DeepFryerChangeLog";
			/// <summary>Member name ServiceLocationAssetTypeChangeLog</summary>
			public static readonly string ServiceLocationAssetTypeChangeLog = "ServiceLocationAssetTypeChangeLog";
			/// <summary>Member name DeepFryerCollectionViaDeepFryerChangeLog</summary>
			public static readonly string DeepFryerCollectionViaDeepFryerChangeLog = "DeepFryerCollectionViaDeepFryerChangeLog";
			/// <summary>Member name ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog</summary>
			public static readonly string ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = "ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ChangeLogEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public ChangeLogEntity():base("ChangeLogEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ChangeLogEntity(IEntityFields2 fields):base("ChangeLogEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ChangeLogEntity</param>
		public ChangeLogEntity(IValidator validator):base("ChangeLogEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ChangeLogEntity(System.Int32 changeLogId):base("ChangeLogEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.ChangeLogId = changeLogId;
		}

		/// <summary> CTor</summary>
		/// <param name="changeLogId">PK value for ChangeLog which data should be fetched into this ChangeLog object</param>
		/// <param name="validator">The custom validator object for this ChangeLogEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ChangeLogEntity(System.Int32 changeLogId, IValidator validator):base("ChangeLogEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.ChangeLogId = changeLogId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ChangeLogEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_deepFryerChangeLog = (EntityCollection<DeepFryerChangeLogEntity>)info.GetValue("_deepFryerChangeLog", typeof(EntityCollection<DeepFryerChangeLogEntity>));
				_serviceLocationAssetTypeChangeLog = (EntityCollection<ServiceLocationAssetTypeChangeLogEntity>)info.GetValue("_serviceLocationAssetTypeChangeLog", typeof(EntityCollection<ServiceLocationAssetTypeChangeLogEntity>));
				_deepFryerCollectionViaDeepFryerChangeLog = (EntityCollection<DeepFryerEntity>)info.GetValue("_deepFryerCollectionViaDeepFryerChangeLog", typeof(EntityCollection<DeepFryerEntity>));
				_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = (EntityCollection<ServiceLocationAssetTypeEntity>)info.GetValue("_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog", typeof(EntityCollection<ServiceLocationAssetTypeEntity>));
				_changeType = (ChangeTypeEntity)info.GetValue("_changeType", typeof(ChangeTypeEntity));
				if(_changeType!=null)
				{
					_changeType.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((ChangeLogFieldIndex)fieldIndex)
			{
				case ChangeLogFieldIndex.ChangeTypeId:
					DesetupSyncChangeType(true, false);
					break;
				case ChangeLogFieldIndex.UserId:
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
				case "ChangeType":
					this.ChangeType = (ChangeTypeEntity)entity;
					break;
				case "User":
					this.User = (UserEntity)entity;
					break;
				case "DeepFryerChangeLog":
					this.DeepFryerChangeLog.Add((DeepFryerChangeLogEntity)entity);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					this.ServiceLocationAssetTypeChangeLog.Add((ServiceLocationAssetTypeChangeLogEntity)entity);
					break;
				case "DeepFryerCollectionViaDeepFryerChangeLog":
					this.DeepFryerCollectionViaDeepFryerChangeLog.IsReadOnly = false;
					this.DeepFryerCollectionViaDeepFryerChangeLog.Add((DeepFryerEntity)entity);
					this.DeepFryerCollectionViaDeepFryerChangeLog.IsReadOnly = true;
					break;
				case "ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog":
					this.ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.IsReadOnly = false;
					this.ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.Add((ServiceLocationAssetTypeEntity)entity);
					this.ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.IsReadOnly = true;
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
			return ChangeLogEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ChangeType":
					toReturn.Add(ChangeLogEntity.Relations.ChangeTypeEntityUsingChangeTypeId);
					break;
				case "User":
					toReturn.Add(ChangeLogEntity.Relations.UserEntityUsingUserId);
					break;
				case "DeepFryerChangeLog":
					toReturn.Add(ChangeLogEntity.Relations.DeepFryerChangeLogEntityUsingChangeLogId);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					toReturn.Add(ChangeLogEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingChangeLogId);
					break;
				case "DeepFryerCollectionViaDeepFryerChangeLog":
					toReturn.Add(ChangeLogEntity.Relations.DeepFryerChangeLogEntityUsingChangeLogId, "ChangeLogEntity__", "DeepFryerChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerChangeLogEntity.Relations.DeepFryerEntityUsingDeepFryerId, "DeepFryerChangeLog_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog":
					toReturn.Add(ChangeLogEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingChangeLogId, "ChangeLogEntity__", "ServiceLocationAssetTypeChangeLog_", JoinHint.None);
					toReturn.Add(ServiceLocationAssetTypeChangeLogEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, "ServiceLocationAssetTypeChangeLog_", string.Empty, JoinHint.None);
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
				case "ChangeType":
					SetupSyncChangeType(relatedEntity);
					break;
				case "User":
					SetupSyncUser(relatedEntity);
					break;
				case "DeepFryerChangeLog":
					this.DeepFryerChangeLog.Add((DeepFryerChangeLogEntity)relatedEntity);
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
				case "ChangeType":
					DesetupSyncChangeType(false, true);
					break;
				case "User":
					DesetupSyncUser(false, true);
					break;
				case "DeepFryerChangeLog":
					base.PerformRelatedEntityRemoval(this.DeepFryerChangeLog, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_changeType!=null)
			{
				toReturn.Add(_changeType);
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
			toReturn.Add(this.DeepFryerChangeLog);
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
				info.AddValue("_deepFryerChangeLog", ((_deepFryerChangeLog!=null) && (_deepFryerChangeLog.Count>0) && !this.MarkedForDeletion)?_deepFryerChangeLog:null);
				info.AddValue("_serviceLocationAssetTypeChangeLog", ((_serviceLocationAssetTypeChangeLog!=null) && (_serviceLocationAssetTypeChangeLog.Count>0) && !this.MarkedForDeletion)?_serviceLocationAssetTypeChangeLog:null);
				info.AddValue("_deepFryerCollectionViaDeepFryerChangeLog", ((_deepFryerCollectionViaDeepFryerChangeLog!=null) && (_deepFryerCollectionViaDeepFryerChangeLog.Count>0) && !this.MarkedForDeletion)?_deepFryerCollectionViaDeepFryerChangeLog:null);
				info.AddValue("_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog", ((_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog!=null) && (_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.Count>0) && !this.MarkedForDeletion)?_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog:null);
				info.AddValue("_changeType", (!this.MarkedForDeletion?_changeType:null));
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
		public bool TestOriginalFieldValueForNull(ChangeLogFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ChangeLogFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ChangeLogRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerChangeLogFields.ChangeLogId, null, ComparisonOperator.Equal, this.ChangeLogId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationAssetTypeChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationAssetTypeChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeChangeLogFields.ChangeLogId, null, ComparisonOperator.Equal, this.ChangeLogId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryer' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerCollectionViaDeepFryerChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DeepFryerCollectionViaDeepFryerChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ChangeLogFields.ChangeLogId, null, ComparisonOperator.Equal, this.ChangeLogId, "ChangeLogEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationAssetType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ChangeLogFields.ChangeLogId, null, ComparisonOperator.Equal, this.ChangeLogId, "ChangeLogEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'ChangeType' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoChangeType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ChangeTypeFields.ChangeTypeId, null, ComparisonOperator.Equal, this.ChangeTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'User' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ChangeLogEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._deepFryerChangeLog);
			collectionsQueue.Enqueue(this._serviceLocationAssetTypeChangeLog);
			collectionsQueue.Enqueue(this._deepFryerCollectionViaDeepFryerChangeLog);
			collectionsQueue.Enqueue(this._serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._deepFryerChangeLog = (EntityCollection<DeepFryerChangeLogEntity>) collectionsQueue.Dequeue();
			this._serviceLocationAssetTypeChangeLog = (EntityCollection<ServiceLocationAssetTypeChangeLogEntity>) collectionsQueue.Dequeue();
			this._deepFryerCollectionViaDeepFryerChangeLog = (EntityCollection<DeepFryerEntity>) collectionsQueue.Dequeue();
			this._serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = (EntityCollection<ServiceLocationAssetTypeEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._deepFryerChangeLog != null)
			{
				return true;
			}
			if (this._serviceLocationAssetTypeChangeLog != null)
			{
				return true;
			}
			if (this._deepFryerCollectionViaDeepFryerChangeLog != null)
			{
				return true;
			}
			if (this._serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationAssetTypeChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))) : null);
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
			toReturn.Add("ChangeType", _changeType);
			toReturn.Add("User", _user);
			toReturn.Add("DeepFryerChangeLog", _deepFryerChangeLog);
			toReturn.Add("ServiceLocationAssetTypeChangeLog", _serviceLocationAssetTypeChangeLog);
			toReturn.Add("DeepFryerCollectionViaDeepFryerChangeLog", _deepFryerCollectionViaDeepFryerChangeLog);
			toReturn.Add("ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog", _serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_deepFryerChangeLog!=null)
			{
				_deepFryerChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationAssetTypeChangeLog!=null)
			{
				_serviceLocationAssetTypeChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerCollectionViaDeepFryerChangeLog!=null)
			{
				_deepFryerCollectionViaDeepFryerChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog!=null)
			{
				_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_changeType!=null)
			{
				_changeType.ActiveContext = base.ActiveContext;
			}
			if(_user!=null)
			{
				_user.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_deepFryerChangeLog = null;
			_serviceLocationAssetTypeChangeLog = null;
			_deepFryerCollectionViaDeepFryerChangeLog = null;
			_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = null;
			_changeType = null;
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

			_fieldsCustomProperties.Add("ChangeLogId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ChangeTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ChangeDate", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _changeType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncChangeType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _changeType, new PropertyChangedEventHandler( OnChangeTypePropertyChanged ), "ChangeType", ChangeLogEntity.Relations.ChangeTypeEntityUsingChangeTypeId, true, signalRelatedEntity, "ChangeLog", resetFKFields, new int[] { (int)ChangeLogFieldIndex.ChangeTypeId } );		
			_changeType = null;
		}

		/// <summary> setups the sync logic for member _changeType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncChangeType(IEntity2 relatedEntity)
		{
			if(_changeType!=relatedEntity)
			{
				DesetupSyncChangeType(true, true);
				_changeType = (ChangeTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _changeType, new PropertyChangedEventHandler( OnChangeTypePropertyChanged ), "ChangeType", ChangeLogEntity.Relations.ChangeTypeEntityUsingChangeTypeId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnChangeTypePropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", ChangeLogEntity.Relations.UserEntityUsingUserId, true, signalRelatedEntity, "ChangeLog", resetFKFields, new int[] { (int)ChangeLogFieldIndex.UserId } );		
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
				base.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", ChangeLogEntity.Relations.UserEntityUsingUserId, true, new string[] {  } );
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
		/// <param name="validator">The validator object for this ChangeLogEntity</param>
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
		public  static ChangeLogRelations Relations
		{
			get	{ return new ChangeLogRelations(); }
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
					(IEntityRelation)GetRelationsForField("DeepFryerChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity, 0, null, null, null, null, "DeepFryerChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetTypeChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity, 0, null, null, null, null, "ServiceLocationAssetTypeChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerCollectionViaDeepFryerChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ChangeLogEntity.Relations.DeepFryerChangeLogEntityUsingChangeLogId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, GetRelationsForField("DeepFryerCollectionViaDeepFryerChangeLog"), null, "DeepFryerCollectionViaDeepFryerChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ChangeLogEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingChangeLogId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationAssetTypeChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, GetRelationsForField("ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog"), null, "ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ChangeType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathChangeType
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ChangeTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("ChangeType")[0], (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity, 0, null, null, null, null, "ChangeType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("User")[0], (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ChangeLogEntity.CustomProperties;}
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
			get { return ChangeLogEntity.FieldsCustomProperties;}
		}

		/// <summary> The ChangeLogId property of the Entity ChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeLog"."ChangeLogId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ChangeLogId
		{
			get { return (System.Int32)GetValue((int)ChangeLogFieldIndex.ChangeLogId, true); }
			set	{ SetValue((int)ChangeLogFieldIndex.ChangeLogId, value); }
		}

		/// <summary> The ChangeTypeId property of the Entity ChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeLog"."ChangeTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ChangeTypeId
		{
			get { return (System.Int32)GetValue((int)ChangeLogFieldIndex.ChangeTypeId, true); }
			set	{ SetValue((int)ChangeLogFieldIndex.ChangeTypeId, value); }
		}

		/// <summary> The UserId property of the Entity ChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeLog"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 UserId
		{
			get { return (System.Int32)GetValue((int)ChangeLogFieldIndex.UserId, true); }
			set	{ SetValue((int)ChangeLogFieldIndex.UserId, value); }
		}

		/// <summary> The ChangeDate property of the Entity ChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeLog"."ChangeDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ChangeDate
		{
			get { return (System.DateTime)GetValue((int)ChangeLogFieldIndex.ChangeDate, true); }
			set	{ SetValue((int)ChangeLogFieldIndex.ChangeDate, value); }
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
					_deepFryerChangeLog.SetContainingEntityInfo(this, "ChangeLog");
				}
				return _deepFryerChangeLog;
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
					_serviceLocationAssetTypeChangeLog.SetContainingEntityInfo(this, "ChangeLog");
				}
				return _serviceLocationAssetTypeChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerEntity))]
		public virtual EntityCollection<DeepFryerEntity> DeepFryerCollectionViaDeepFryerChangeLog
		{
			get
			{
				if(_deepFryerCollectionViaDeepFryerChangeLog==null)
				{
					_deepFryerCollectionViaDeepFryerChangeLog = new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory)));
					_deepFryerCollectionViaDeepFryerChangeLog.IsReadOnly=true;
				}
				return _deepFryerCollectionViaDeepFryerChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationAssetTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationAssetTypeEntity))]
		public virtual EntityCollection<ServiceLocationAssetTypeEntity> ServiceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog
		{
			get
			{
				if(_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog==null)
				{
					_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog = new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory)));
					_serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog.IsReadOnly=true;
				}
				return _serviceLocationAssetTypeCollectionViaServiceLocationAssetTypeChangeLog;
			}
		}

		/// <summary> Gets / sets related entity of type 'ChangeTypeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual ChangeTypeEntity ChangeType
		{
			get
			{
				return _changeType;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncChangeType(value);
				}
				else
				{
					if(value==null)
					{
						if(_changeType != null)
						{
							_changeType.UnsetRelatedEntity(this, "ChangeLog");
						}
					}
					else
					{
						if(_changeType!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ChangeLog");
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
							_user.UnsetRelatedEntity(this, "ChangeLog");
						}
					}
					else
					{
						if(_user!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ChangeLog");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity; }
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
