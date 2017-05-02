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
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.DaoClasses;
using Reliant.RenuOil.DAL.RelationClasses;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'ChangeType'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ChangeTypeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection	_changeLog;
		private bool	_alwaysFetchChangeLog, _alreadyFetchedChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaChangeLog;
		private bool	_alwaysFetchUserCollectionViaChangeLog, _alreadyFetchedUserCollectionViaChangeLog;


		
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
			/// <summary>Member name UserCollectionViaChangeLog</summary>
			public static readonly string UserCollectionViaChangeLog = "UserCollectionViaChangeLog";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ChangeTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ChangeTypeEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="changeTypeId">PK value for ChangeType which data should be fetched into this ChangeType object</param>
		public ChangeTypeEntity(System.Int32 changeTypeId)
		{
			InitClassFetch(changeTypeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="changeTypeId">PK value for ChangeType which data should be fetched into this ChangeType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ChangeTypeEntity(System.Int32 changeTypeId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(changeTypeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="changeTypeId">PK value for ChangeType which data should be fetched into this ChangeType object</param>
		/// <param name="validator">The custom validator object for this ChangeTypeEntity</param>
		public ChangeTypeEntity(System.Int32 changeTypeId, IValidator validator)
		{
			InitClassFetch(changeTypeId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ChangeTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_changeLog = (Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection)info.GetValue("_changeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection));
			_alwaysFetchChangeLog = info.GetBoolean("_alwaysFetchChangeLog");
			_alreadyFetchedChangeLog = info.GetBoolean("_alreadyFetchedChangeLog");
			_userCollectionViaChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaChangeLog = info.GetBoolean("_alwaysFetchUserCollectionViaChangeLog");
			_alreadyFetchedUserCollectionViaChangeLog = info.GetBoolean("_alreadyFetchedUserCollectionViaChangeLog");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ChangeTypeFieldIndex)fieldIndex)
			{
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
		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedChangeLog = (_changeLog.Count > 0);
			_alreadyFetchedUserCollectionViaChangeLog = (_userCollectionViaChangeLog.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ChangeTypeEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(ChangeTypeEntity.Relations.ChangeLogEntityUsingChangeTypeId);
					break;
				case "UserCollectionViaChangeLog":
					toReturn.Add(ChangeTypeEntity.Relations.ChangeLogEntityUsingChangeTypeId, "ChangeTypeEntity__", "ChangeLog_", JoinHint.None);
					toReturn.Add(ChangeLogEntity.Relations.UserEntityUsingUserId, "ChangeLog_", string.Empty, JoinHint.None);
					break;

				default:

					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_changeLog", (!this.MarkedForDeletion?_changeLog:null));
			info.AddValue("_alwaysFetchChangeLog", _alwaysFetchChangeLog);
			info.AddValue("_alreadyFetchedChangeLog", _alreadyFetchedChangeLog);
			info.AddValue("_userCollectionViaChangeLog", (!this.MarkedForDeletion?_userCollectionViaChangeLog:null));
			info.AddValue("_alwaysFetchUserCollectionViaChangeLog", _alwaysFetchUserCollectionViaChangeLog);
			info.AddValue("_alreadyFetchedUserCollectionViaChangeLog", _alreadyFetchedUserCollectionViaChangeLog);


			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{

				case "ChangeLog":
					_alreadyFetchedChangeLog = true;
					if(entity!=null)
					{
						this.ChangeLog.Add((ChangeLogEntity)entity);
					}
					break;
				case "UserCollectionViaChangeLog":
					_alreadyFetchedUserCollectionViaChangeLog = true;
					if(entity!=null)
					{
						this.UserCollectionViaChangeLog.Add((UserEntity)entity);
					}
					break;

				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{

				case "ChangeLog":
					_changeLog.Add((ChangeLogEntity)relatedEntity);
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
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{

				case "ChangeLog":
					base.PerformRelatedEntityRemoval(_changeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_changeLog);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="changeTypeId">PK value for ChangeType which data should be fetched into this ChangeType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 changeTypeId)
		{
			return FetchUsingPK(changeTypeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="changeTypeId">PK value for ChangeType which data should be fetched into this ChangeType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 changeTypeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(changeTypeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="changeTypeId">PK value for ChangeType which data should be fetched into this ChangeType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 changeTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(changeTypeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="changeTypeId">PK value for ChangeType which data should be fetched into this ChangeType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 changeTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(changeTypeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ChangeTypeId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ChangeTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ChangeTypeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ChangeTypeRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLog(bool forceFetch)
		{
			return GetMultiChangeLog(forceFetch, _changeLog.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLog(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiChangeLog(forceFetch, _changeLog.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiChangeLog(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedChangeLog || forceFetch || _alwaysFetchChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_changeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_changeLog);
					}
				}
				_changeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_changeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_changeLog.GetMultiManyToOne(this, null, filter);
				_changeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedChangeLog = true;
			}
			return _changeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'ChangeLog'. These settings will be taken into account
		/// when the property ChangeLog is requested or GetMultiChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_changeLog.SortClauses=sortClauses;
			_changeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaChangeLog(bool forceFetch)
		{
			return GetMultiUserCollectionViaChangeLog(forceFetch, _userCollectionViaChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaChangeLog || forceFetch || _alwaysFetchUserCollectionViaChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ChangeTypeFields.ChangeTypeId, ComparisonOperator.Equal, this.ChangeTypeId, "ChangeTypeEntity__"));
				_userCollectionViaChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaChangeLog.GetMulti(filter, GetRelationsForField("UserCollectionViaChangeLog"));
				_userCollectionViaChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaChangeLog = true;
			}
			return _userCollectionViaChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaChangeLog'. These settings will be taken into account
		/// when the property UserCollectionViaChangeLog is requested or GetMultiUserCollectionViaChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaChangeLog.SortClauses=sortClauses;
			_userCollectionViaChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ChangeTypeDAO dao = (ChangeTypeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_changeLog.ActiveContext = base.ActiveContext;
			_userCollectionViaChangeLog.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ChangeTypeDAO dao = (ChangeTypeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ChangeTypeDAO dao = (ChangeTypeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity);
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();

			toReturn.Add("ChangeLog", _changeLog);
			toReturn.Add("UserCollectionViaChangeLog", _userCollectionViaChangeLog);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="changeTypeId">PK value for ChangeType which data should be fetched into this ChangeType object</param>
		/// <param name="validator">The validator object for this ChangeTypeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 changeTypeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(changeTypeId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_changeLog = new Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection(new ChangeLogEntityFactory());
			_changeLog.SetContainingEntityInfo(this, "ChangeType");
			_alwaysFetchChangeLog = false;
			_alreadyFetchedChangeLog = false;
			_userCollectionViaChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaChangeLog = false;
			_alreadyFetchedUserCollectionViaChangeLog = false;



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

			_fieldsCustomProperties.Add("ChangeTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="changeTypeId">PK value for ChangeType which data should be fetched into this ChangeType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 changeTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ChangeTypeFieldIndex.ChangeTypeId].ForcedCurrentValueWrite(changeTypeId);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (base.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateChangeTypeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ChangeTypeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ChangeTypeRelations Relations
		{
			get	{ return new ChangeTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("ChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, 0, null, null, null, "ChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ChangeTypeEntity.Relations.ChangeLogEntityUsingChangeTypeId;
				intermediateRelation.SetAliases(string.Empty, "ChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaChangeLog"), "UserCollectionViaChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ChangeTypeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ChangeTypeEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
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
			get { return ChangeTypeEntity.FieldsCustomProperties;}
		}

		/// <summary> The ChangeTypeId property of the Entity ChangeType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeType"."ChangeTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ChangeTypeId
		{
			get { return (System.Int32)GetValue((int)ChangeTypeFieldIndex.ChangeTypeId, true); }
			set	{ SetValue((int)ChangeTypeFieldIndex.ChangeTypeId, value, true); }
		}
		/// <summary> The Name property of the Entity ChangeType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ChangeTypeFieldIndex.Name, true); }
			set	{ SetValue((int)ChangeTypeFieldIndex.Name, value, true); }
		}
		/// <summary> The Description property of the Entity ChangeType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ChangeType"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)ChangeTypeFieldIndex.Description, true); }
			set	{ SetValue((int)ChangeTypeFieldIndex.Description, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection ChangeLog
		{
			get	{ return GetMultiChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ChangeLog. When set to true, ChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChangeLog
		{
			get	{ return _alwaysFetchChangeLog; }
			set	{ _alwaysFetchChangeLog = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChangeLog already has been fetched. Setting this property to false when ChangeLog has been fetched
		/// will clear the ChangeLog collection well. Setting this property to true while ChangeLog hasn't been fetched disables lazy loading for ChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChangeLog
		{
			get { return _alreadyFetchedChangeLog;}
			set 
			{
				if(_alreadyFetchedChangeLog && !value && (_changeLog != null))
				{
					_changeLog.Clear();
				}
				_alreadyFetchedChangeLog = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaChangeLog
		{
			get { return GetMultiUserCollectionViaChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaChangeLog. When set to true, UserCollectionViaChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaChangeLog
		{
			get	{ return _alwaysFetchUserCollectionViaChangeLog; }
			set	{ _alwaysFetchUserCollectionViaChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaChangeLog already has been fetched. Setting this property to false when UserCollectionViaChangeLog has been fetched
		/// will clear the UserCollectionViaChangeLog collection well. Setting this property to true while UserCollectionViaChangeLog hasn't been fetched disables lazy loading for UserCollectionViaChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaChangeLog
		{
			get { return _alreadyFetchedUserCollectionViaChangeLog;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaChangeLog && !value && (_userCollectionViaChangeLog != null))
				{
					_userCollectionViaChangeLog.Clear();
				}
				_alreadyFetchedUserCollectionViaChangeLog = value;
			}
		}




		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the Reliant.RenuOil.DAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity; }
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
