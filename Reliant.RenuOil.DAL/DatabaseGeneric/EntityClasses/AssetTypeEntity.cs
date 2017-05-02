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
	/// Entity class which represents the entity 'AssetType'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AssetTypeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<ServiceLocationAssetTypeEntity> _serviceLocationAssetTypeId;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaServiceLocationAssetTypeId;
		private AssetCategoryEntity _assetCategory;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name AssetCategory</summary>
			public static readonly string AssetCategory = "AssetCategory";
			/// <summary>Member name ServiceLocationAssetTypeId</summary>
			public static readonly string ServiceLocationAssetTypeId = "ServiceLocationAssetTypeId";
			/// <summary>Member name ServiceLocationCollectionViaServiceLocationAssetTypeId</summary>
			public static readonly string ServiceLocationCollectionViaServiceLocationAssetTypeId = "ServiceLocationCollectionViaServiceLocationAssetTypeId";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AssetTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public AssetTypeEntity():base("AssetTypeEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AssetTypeEntity(IEntityFields2 fields):base("AssetTypeEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AssetTypeEntity</param>
		public AssetTypeEntity(IValidator validator):base("AssetTypeEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AssetTypeEntity(System.Int32 assetTypeId):base("AssetTypeEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.AssetTypeId = assetTypeId;
		}

		/// <summary> CTor</summary>
		/// <param name="assetTypeId">PK value for AssetType which data should be fetched into this AssetType object</param>
		/// <param name="validator">The custom validator object for this AssetTypeEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AssetTypeEntity(System.Int32 assetTypeId, IValidator validator):base("AssetTypeEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.AssetTypeId = assetTypeId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AssetTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_serviceLocationAssetTypeId = (EntityCollection<ServiceLocationAssetTypeEntity>)info.GetValue("_serviceLocationAssetTypeId", typeof(EntityCollection<ServiceLocationAssetTypeEntity>));
				_serviceLocationCollectionViaServiceLocationAssetTypeId = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaServiceLocationAssetTypeId", typeof(EntityCollection<ServiceLocationEntity>));
				_assetCategory = (AssetCategoryEntity)info.GetValue("_assetCategory", typeof(AssetCategoryEntity));
				if(_assetCategory!=null)
				{
					_assetCategory.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((AssetTypeFieldIndex)fieldIndex)
			{
				case AssetTypeFieldIndex.AssetCategoryId:
					DesetupSyncAssetCategory(true, false);
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
				case "AssetCategory":
					this.AssetCategory = (AssetCategoryEntity)entity;
					break;
				case "ServiceLocationAssetTypeId":
					this.ServiceLocationAssetTypeId.Add((ServiceLocationAssetTypeEntity)entity);
					break;
				case "ServiceLocationCollectionViaServiceLocationAssetTypeId":
					this.ServiceLocationCollectionViaServiceLocationAssetTypeId.IsReadOnly = false;
					this.ServiceLocationCollectionViaServiceLocationAssetTypeId.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaServiceLocationAssetTypeId.IsReadOnly = true;
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
			return AssetTypeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "AssetCategory":
					toReturn.Add(AssetTypeEntity.Relations.AssetCategoryEntityUsingAssetCategoryId);
					break;
				case "ServiceLocationAssetTypeId":
					toReturn.Add(AssetTypeEntity.Relations.ServiceLocationAssetTypeEntityUsingAssetTypeId);
					break;
				case "ServiceLocationCollectionViaServiceLocationAssetTypeId":
					toReturn.Add(AssetTypeEntity.Relations.ServiceLocationAssetTypeEntityUsingAssetTypeId, "AssetTypeEntity__", "ServiceLocationAssetType_", JoinHint.None);
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "ServiceLocationAssetType_", string.Empty, JoinHint.None);
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
				case "AssetCategory":
					SetupSyncAssetCategory(relatedEntity);
					break;
				case "ServiceLocationAssetTypeId":
					this.ServiceLocationAssetTypeId.Add((ServiceLocationAssetTypeEntity)relatedEntity);
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
				case "AssetCategory":
					DesetupSyncAssetCategory(false, true);
					break;
				case "ServiceLocationAssetTypeId":
					base.PerformRelatedEntityRemoval(this.ServiceLocationAssetTypeId, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_assetCategory!=null)
			{
				toReturn.Add(_assetCategory);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.ServiceLocationAssetTypeId);

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
				info.AddValue("_serviceLocationAssetTypeId", ((_serviceLocationAssetTypeId!=null) && (_serviceLocationAssetTypeId.Count>0) && !this.MarkedForDeletion)?_serviceLocationAssetTypeId:null);
				info.AddValue("_serviceLocationCollectionViaServiceLocationAssetTypeId", ((_serviceLocationCollectionViaServiceLocationAssetTypeId!=null) && (_serviceLocationCollectionViaServiceLocationAssetTypeId.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaServiceLocationAssetTypeId:null);
				info.AddValue("_assetCategory", (!this.MarkedForDeletion?_assetCategory:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(AssetTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(AssetTypeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new AssetTypeRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationAssetType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationAssetTypeId()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeFields.AssetTypeId, null, ComparisonOperator.Equal, this.AssetTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaServiceLocationAssetTypeId()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaServiceLocationAssetTypeId"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AssetTypeFields.AssetTypeId, null, ComparisonOperator.Equal, this.AssetTypeId, "AssetTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'AssetCategory' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAssetCategory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AssetCategoryFields.AssetCategoryId, null, ComparisonOperator.Equal, this.AssetCategoryId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.AssetTypeEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(AssetTypeEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._serviceLocationAssetTypeId);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaServiceLocationAssetTypeId);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._serviceLocationAssetTypeId = (EntityCollection<ServiceLocationAssetTypeEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaServiceLocationAssetTypeId = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._serviceLocationAssetTypeId != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaServiceLocationAssetTypeId != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AssetCategory", _assetCategory);
			toReturn.Add("ServiceLocationAssetTypeId", _serviceLocationAssetTypeId);
			toReturn.Add("ServiceLocationCollectionViaServiceLocationAssetTypeId", _serviceLocationCollectionViaServiceLocationAssetTypeId);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_serviceLocationAssetTypeId!=null)
			{
				_serviceLocationAssetTypeId.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaServiceLocationAssetTypeId!=null)
			{
				_serviceLocationCollectionViaServiceLocationAssetTypeId.ActiveContext = base.ActiveContext;
			}
			if(_assetCategory!=null)
			{
				_assetCategory.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_serviceLocationAssetTypeId = null;
			_serviceLocationCollectionViaServiceLocationAssetTypeId = null;
			_assetCategory = null;

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

			_fieldsCustomProperties.Add("AssetTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AssetCategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("SpanishLabel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _assetCategory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAssetCategory(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _assetCategory, new PropertyChangedEventHandler( OnAssetCategoryPropertyChanged ), "AssetCategory", AssetTypeEntity.Relations.AssetCategoryEntityUsingAssetCategoryId, true, signalRelatedEntity, "AssetType", resetFKFields, new int[] { (int)AssetTypeFieldIndex.AssetCategoryId } );		
			_assetCategory = null;
		}

		/// <summary> setups the sync logic for member _assetCategory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAssetCategory(IEntity2 relatedEntity)
		{
			if(_assetCategory!=relatedEntity)
			{
				DesetupSyncAssetCategory(true, true);
				_assetCategory = (AssetCategoryEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _assetCategory, new PropertyChangedEventHandler( OnAssetCategoryPropertyChanged ), "AssetCategory", AssetTypeEntity.Relations.AssetCategoryEntityUsingAssetCategoryId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAssetCategoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this AssetTypeEntity</param>
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
		public  static AssetTypeRelations Relations
		{
			get	{ return new AssetTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationAssetTypeId
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetTypeId")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, null, null, "ServiceLocationAssetTypeId", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaServiceLocationAssetTypeId
		{
			get
			{
				IEntityRelation intermediateRelation = AssetTypeEntity.Relations.ServiceLocationAssetTypeEntityUsingAssetTypeId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationAssetType_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationAssetTypeId"), null, "ServiceLocationCollectionViaServiceLocationAssetTypeId", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AssetCategory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAssetCategory
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AssetCategoryEntityFactory))),
					(IEntityRelation)GetRelationsForField("AssetCategory")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetCategoryEntity, 0, null, null, null, null, "AssetCategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return AssetTypeEntity.CustomProperties;}
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
			get { return AssetTypeEntity.FieldsCustomProperties;}
		}

		/// <summary> The AssetTypeId property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."AssetTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AssetTypeId
		{
			get { return (System.Int32)GetValue((int)AssetTypeFieldIndex.AssetTypeId, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.AssetTypeId, value); }
		}

		/// <summary> The AssetCategoryId property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."AssetCategoryId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AssetCategoryId
		{
			get { return (System.Int32)GetValue((int)AssetTypeFieldIndex.AssetCategoryId, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.AssetCategoryId, value); }
		}

		/// <summary> The Name property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AssetTypeFieldIndex.Name, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.Name, value); }
		}

		/// <summary> The Description property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)AssetTypeFieldIndex.Description, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.Description, value); }
		}

		/// <summary> The SpanishLabel property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."SpanishLabel"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String SpanishLabel
		{
			get { return (System.String)GetValue((int)AssetTypeFieldIndex.SpanishLabel, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.SpanishLabel, value); }
		}

		/// <summary> The IsActive property of the Entity AssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetType"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)AssetTypeFieldIndex.IsActive, true); }
			set	{ SetValue((int)AssetTypeFieldIndex.IsActive, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationAssetTypeEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationAssetTypeEntity))]
		public virtual EntityCollection<ServiceLocationAssetTypeEntity> ServiceLocationAssetTypeId
		{
			get
			{
				if(_serviceLocationAssetTypeId==null)
				{
					_serviceLocationAssetTypeId = new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory)));
					_serviceLocationAssetTypeId.SetContainingEntityInfo(this, "AssetType");
				}
				return _serviceLocationAssetTypeId;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaServiceLocationAssetTypeId
		{
			get
			{
				if(_serviceLocationCollectionViaServiceLocationAssetTypeId==null)
				{
					_serviceLocationCollectionViaServiceLocationAssetTypeId = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaServiceLocationAssetTypeId.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaServiceLocationAssetTypeId;
			}
		}

		/// <summary> Gets / sets related entity of type 'AssetCategoryEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual AssetCategoryEntity AssetCategory
		{
			get
			{
				return _assetCategory;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAssetCategory(value);
				}
				else
				{
					if(value==null)
					{
						if(_assetCategory != null)
						{
							_assetCategory.UnsetRelatedEntity(this, "AssetType");
						}
					}
					else
					{
						if(_assetCategory!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "AssetType");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity; }
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
