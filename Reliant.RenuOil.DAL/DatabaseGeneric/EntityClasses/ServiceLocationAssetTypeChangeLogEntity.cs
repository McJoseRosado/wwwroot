﻿///////////////////////////////////////////////////////////////
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
	/// Entity class which represents the entity 'ServiceLocationAssetTypeChangeLog'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ServiceLocationAssetTypeChangeLogEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private ChangeLogEntity _changeLog;
		private ServiceLocationAssetTypeEntity _serviceLocationAssetType;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name ChangeLog</summary>
			public static readonly string ChangeLog = "ChangeLog";
			/// <summary>Member name ServiceLocationAssetType</summary>
			public static readonly string ServiceLocationAssetType = "ServiceLocationAssetType";



		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ServiceLocationAssetTypeChangeLogEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public ServiceLocationAssetTypeChangeLogEntity():base("ServiceLocationAssetTypeChangeLogEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ServiceLocationAssetTypeChangeLogEntity(IEntityFields2 fields):base("ServiceLocationAssetTypeChangeLogEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ServiceLocationAssetTypeChangeLogEntity</param>
		public ServiceLocationAssetTypeChangeLogEntity(IValidator validator):base("ServiceLocationAssetTypeChangeLogEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ServiceLocationAssetTypeChangeLogEntity(System.Int32 serviceLocationAssetTypeChangeLogId):base("ServiceLocationAssetTypeChangeLogEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.ServiceLocationAssetTypeChangeLogId = serviceLocationAssetTypeChangeLogId;
		}

		/// <summary> CTor</summary>
		/// <param name="serviceLocationAssetTypeChangeLogId">PK value for ServiceLocationAssetTypeChangeLog which data should be fetched into this ServiceLocationAssetTypeChangeLog object</param>
		/// <param name="validator">The custom validator object for this ServiceLocationAssetTypeChangeLogEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ServiceLocationAssetTypeChangeLogEntity(System.Int32 serviceLocationAssetTypeChangeLogId, IValidator validator):base("ServiceLocationAssetTypeChangeLogEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.ServiceLocationAssetTypeChangeLogId = serviceLocationAssetTypeChangeLogId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ServiceLocationAssetTypeChangeLogEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{


				_changeLog = (ChangeLogEntity)info.GetValue("_changeLog", typeof(ChangeLogEntity));
				if(_changeLog!=null)
				{
					_changeLog.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_serviceLocationAssetType = (ServiceLocationAssetTypeEntity)info.GetValue("_serviceLocationAssetType", typeof(ServiceLocationAssetTypeEntity));
				if(_serviceLocationAssetType!=null)
				{
					_serviceLocationAssetType.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((ServiceLocationAssetTypeChangeLogFieldIndex)fieldIndex)
			{
				case ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeId:
					DesetupSyncServiceLocationAssetType(true, false);
					break;
				case ServiceLocationAssetTypeChangeLogFieldIndex.ChangeLogId:
					DesetupSyncChangeLog(true, false);
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
				case "ChangeLog":
					this.ChangeLog = (ChangeLogEntity)entity;
					break;
				case "ServiceLocationAssetType":
					this.ServiceLocationAssetType = (ServiceLocationAssetTypeEntity)entity;
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
			return ServiceLocationAssetTypeChangeLogEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ChangeLog":
					toReturn.Add(ServiceLocationAssetTypeChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId);
					break;
				case "ServiceLocationAssetType":
					toReturn.Add(ServiceLocationAssetTypeChangeLogEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId);
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
				case "ChangeLog":
					SetupSyncChangeLog(relatedEntity);
					break;
				case "ServiceLocationAssetType":
					SetupSyncServiceLocationAssetType(relatedEntity);
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
				case "ChangeLog":
					DesetupSyncChangeLog(false, true);
					break;
				case "ServiceLocationAssetType":
					DesetupSyncServiceLocationAssetType(false, true);
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
			if(_changeLog!=null)
			{
				toReturn.Add(_changeLog);
			}
			if(_serviceLocationAssetType!=null)
			{
				toReturn.Add(_serviceLocationAssetType);
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


				info.AddValue("_changeLog", (!this.MarkedForDeletion?_changeLog:null));
				info.AddValue("_serviceLocationAssetType", (!this.MarkedForDeletion?_serviceLocationAssetType:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ServiceLocationAssetTypeChangeLogFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ServiceLocationAssetTypeChangeLogFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ServiceLocationAssetTypeChangeLogRelations().GetAllRelations();
		}
		



		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'ChangeLog' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ChangeLogFields.ChangeLogId, null, ComparisonOperator.Equal, this.ChangeLogId));
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

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeChangeLogEntityFactory));
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
			toReturn.Add("ChangeLog", _changeLog);
			toReturn.Add("ServiceLocationAssetType", _serviceLocationAssetType);



			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_changeLog!=null)
			{
				_changeLog.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationAssetType!=null)
			{
				_serviceLocationAssetType.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{



			_changeLog = null;
			_serviceLocationAssetType = null;

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

			_fieldsCustomProperties.Add("ServiceLocationAssetTypeChangeLogId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceLocationAssetTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ChangeLogId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _changeLog</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncChangeLog(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _changeLog, new PropertyChangedEventHandler( OnChangeLogPropertyChanged ), "ChangeLog", ServiceLocationAssetTypeChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId, true, signalRelatedEntity, "ServiceLocationAssetTypeChangeLog", resetFKFields, new int[] { (int)ServiceLocationAssetTypeChangeLogFieldIndex.ChangeLogId } );		
			_changeLog = null;
		}

		/// <summary> setups the sync logic for member _changeLog</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncChangeLog(IEntity2 relatedEntity)
		{
			if(_changeLog!=relatedEntity)
			{
				DesetupSyncChangeLog(true, true);
				_changeLog = (ChangeLogEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _changeLog, new PropertyChangedEventHandler( OnChangeLogPropertyChanged ), "ChangeLog", ServiceLocationAssetTypeChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnChangeLogPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _serviceLocationAssetType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocationAssetType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocationAssetType, new PropertyChangedEventHandler( OnServiceLocationAssetTypePropertyChanged ), "ServiceLocationAssetType", ServiceLocationAssetTypeChangeLogEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, true, signalRelatedEntity, "ServiceLocationAssetTypeChangeLog", resetFKFields, new int[] { (int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeId } );		
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
				base.PerformSetupSyncRelatedEntity( _serviceLocationAssetType, new PropertyChangedEventHandler( OnServiceLocationAssetTypePropertyChanged ), "ServiceLocationAssetType", ServiceLocationAssetTypeChangeLogEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, true, new string[] {  } );
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


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ServiceLocationAssetTypeChangeLogEntity</param>
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
		public  static ServiceLocationAssetTypeChangeLogRelations Relations
		{
			get	{ return new ServiceLocationAssetTypeChangeLogRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}



		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathChangeLog
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("ChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, 0, null, null, null, null, "ChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetType")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, null, null, "ServiceLocationAssetType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ServiceLocationAssetTypeChangeLogEntity.CustomProperties;}
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
			get { return ServiceLocationAssetTypeChangeLogEntity.FieldsCustomProperties;}
		}

		/// <summary> The ServiceLocationAssetTypeChangeLogId property of the Entity ServiceLocationAssetTypeChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetTypeChangeLog"."ServiceLocationAssetTypeChangeLogId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ServiceLocationAssetTypeChangeLogId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeChangeLogId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeChangeLogId, value); }
		}

		/// <summary> The ServiceLocationAssetTypeId property of the Entity ServiceLocationAssetTypeChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetTypeChangeLog"."ServiceLocationAssetTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceLocationAssetTypeId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeId, value); }
		}

		/// <summary> The ChangeLogId property of the Entity ServiceLocationAssetTypeChangeLog<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetTypeChangeLog"."ChangeLogId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ChangeLogId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ChangeLogId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeChangeLogFieldIndex.ChangeLogId, value); }
		}



		/// <summary> Gets / sets related entity of type 'ChangeLogEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual ChangeLogEntity ChangeLog
		{
			get
			{
				return _changeLog;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncChangeLog(value);
				}
				else
				{
					if(value==null)
					{
						if(_changeLog != null)
						{
							_changeLog.UnsetRelatedEntity(this, "ServiceLocationAssetTypeChangeLog");
						}
					}
					else
					{
						if(_changeLog!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationAssetTypeChangeLog");
						}
					}
				}
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
							_serviceLocationAssetType.UnsetRelatedEntity(this, "ServiceLocationAssetTypeChangeLog");
						}
					}
					else
					{
						if(_serviceLocationAssetType!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocationAssetTypeChangeLog");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity; }
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